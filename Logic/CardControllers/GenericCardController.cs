using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQHomebrewCards.Logic;

namespace HQHomebrewCards
{
    public class GenericCardController : CardController
    {
        private Image oldPaperImage;

        //Old Paper Image Rectangle
        private int oldPaperRectangleX = 123; // X-coordinate of the top-left corner of the rectangle
        private int oldPaperRectangleY = 166; // Y-coordinate of the top-left corner of the rectangle
        private int oldPaperRectangleWidth = 496; // Width of the rectangle
        private int oldPaperRectangleHeight = 361; // Height of the rectangle

        private bool showOldPaper;

        public override bool Setup_HasOldPaper { get => true; }

        public override bool Setup_HasScroll => false;

        public override bool Setup_CanAddBorder => false;

        public GenericCardController():base()
        {
            // Load the blank image as the template/background.
            backgroundImageHandler = new ImageElement(Properties.Resources.Generic_Card_Front, false);            
            oldPaperImage = Properties.Resources.old_paper;                       
            
            defaults = new CardDefaults()
            {
                DEFAULT_TEXT_FONT_SIZE = 24,
                DEFAULT_TEXT_FONT_NAME = "CarterSansW01-Regular",
                DEFAULT_TEXT_FONT_COLOR = Color.FromArgb(33, 0, 0),
                DEFAULT_TEXT_LENGHT = 660,
                DEFAULT_TEXT_POSITION_X = 100,
                DEFAULT_TEXT_POSITION_Y = 600,
                DEFAULT_TITLE_FONT_COLOR = Color.FromArgb(33, 0, 0),
                DEFAULT_TITLE_FONT_NAME = "CarterSansW01-SmBd",
                DEFAULT_TITLE_FONT_SIZE = 40,
                DEFAULT_TITLE_POSITION_Y = 80,
                DEFAULT_SHOW_OLD_PAPER = true,
                DEFAULT_SHOW_STATS = StatsType.NONE,
                DEFAULT_SCROLL_Y = -1,
            };

            title = new TextElement(defaults.DEFAULT_TITLE_FONT_NAME, defaults.DEFAULT_TITLE_FONT_SIZE, 0, defaults.DEFAULT_TITLE_POSITION_Y, defaults.DEFAULT_TITLE_FONT_COLOR, 0, 0, string.Empty);
            title.TextUpdated += Title_TextUpdated;
            bodytext = new TextElement(defaults.DEFAULT_TEXT_FONT_NAME, defaults.DEFAULT_TEXT_FONT_SIZE, defaults.DEFAULT_TEXT_POSITION_X, defaults.DEFAULT_TEXT_POSITION_Y, defaults.DEFAULT_TEXT_FONT_COLOR, 5, defaults.DEFAULT_TEXT_LENGHT, string.Empty);
            bodytext.TextUpdated += Title_TextUpdated;
            showOldPaper = false;
        }



        public override void AddOverlyImage(Image image)
        {
            overlayCardHandler = new ImageElement(image, 120, 164, 501, 364, true);
            overlayCardHandler.ImageHandlerUpdated += OverlayCardHandler_ImageHandlerUpdated;
            OnImageUpdated(new EventArgs());
        }

        public override bool ShowOldPaper { 
            get => showOldPaper;
            set { 
                showOldPaper = value;
                OnImageUpdated(new EventArgs());                
            } 
        }

        public override bool ShowScroll { get => false; set { } }

        public override bool ShowBorder { get => false; set { } }

        public override StatsType TypeOfStats { get => StatsType.NONE; set { } }

        public override CardDefaults Defaults => defaults;

        public override int ScrollY { get => -1 ; set { } }

        public override HeroStats HeroStats => new HeroStats();

        public override void UpdateUI()
        {
            // Reset the current image to paint on it
            backgroundImageHandler.UpdateImage(new Bitmap(backgroundImageHandler.OriginalImage));            
            using (Graphics graphics = Graphics.FromImage(backgroundImageHandler.UpdatedImage))
            {
                // Set font and brush for the card title.
                Font titleFont = new Font(Title.FontName, Title.FontSize);
                Brush titleBrush = new SolidBrush(Title.FontColor);

                // Calculate the position for the card title to center it on the image.
                int titleX = (backgroundImageHandler.UpdatedImage.Width - (int)graphics.MeasureString(Title.Text, titleFont).Width) / 2;
                int titleY = Title.PositionY;

                // Write the card title on the image.
                graphics.DrawString(Title.Text, titleFont, titleBrush, titleX, titleY);

                if (CardText.Text != null)
                {
                    List<FormattedSegment> segments = new List<FormattedSegment>();
                    segments = FormatText(graphics, CardText.Text, CardText.FontName, CardText.FontSize, CardText.FontColor);
                    WriteFormattedText(graphics, new SolidBrush(CardText.FontColor), segments);
                }

                if (ShowOldPaper)
                {
                    Rectangle destinationRectangle = new Rectangle(oldPaperRectangleX, oldPaperRectangleY, oldPaperRectangleWidth, oldPaperRectangleHeight);
                    graphics.SetClip(destinationRectangle);
                    // Overlay the image on the card image.
                    graphics.DrawImage(oldPaperImage, oldPaperRectangleX, oldPaperRectangleY, oldPaperImage.Width, oldPaperImage.Height);
                }

                // Check if an overlay image is available.
                if (OverlyImage != null)
                {                    
                    graphics.SetClip(OverlyImage.GetImageBoundaries());

                    // Overlay the image on the card image.
                    graphics.DrawImage(OverlyImage.UpdatedImage, new Rectangle(OverlyImage.PositionX, OverlyImage.PositionY, OverlyImage.UpdatedImage.Width, OverlyImage.UpdatedImage.Height));
                }
            }
        }

        private void WriteFormattedText(Graphics graphics, Brush titleBrush, List<FormattedSegment> segments)
        {
            Point initialTextPosition = new Point(CardText.PositionX, CardText.PositionY);
            Point currentTextPosition = initialTextPosition;
            
            foreach (FormattedSegment textSegment in segments)
            {
                int segmentTextSize = GetSegmentTextWidth(graphics, textSegment);

                if (textSegment.BreakLine)
                {
                    currentTextPosition = GoToNextLine(graphics, textSegment, currentTextPosition, initialTextPosition);
                    continue;
                }

                if (segmentTextSize + currentTextPosition.X > CardText.MaxLenghtLine)
                {
                    currentTextPosition = GoToNextLine(graphics, textSegment, currentTextPosition, initialTextPosition);
                }

                if (textSegment.Centered)
                {
                    currentTextPosition.X = (backgroundImageHandler.UpdatedImage.Width - (int)graphics.MeasureString(textSegment.Text, textSegment.Font).Width) / 2;
                }

                graphics.DrawString(textSegment.Text, textSegment.Font, titleBrush, currentTextPosition.X, currentTextPosition.Y - textSegment.BaseLine);
                currentTextPosition.X += segmentTextSize;
            }

        }

        private static int GetSegmentTextWidth(Graphics graphics, FormattedSegment textSegment)
        {
            return TextRenderer.MeasureText(graphics, textSegment.Text, textSegment.Font, Size.Empty, TextFormatFlags.NoPadding).Width;
        }

        private Point GoToNextLine(Graphics graphics, FormattedSegment textSegment, Point currentPosition, Point originalPosition)
        {
            Point nextLinePosition = new Point(
                originalPosition.X,
                currentPosition.Y + TextRenderer.MeasureText(graphics, textSegment.Text, textSegment.Font, Size.Empty, TextFormatFlags.NoPadding).Height - CardText.SpaceBetweenLines
                );
            return nextLinePosition;
        }

        private List<FormattedSegment> FormatText(Graphics graphics, string cardMainText, string fontName, int fontSize, Color fontColor)
        {
            List<FormattedSegment> fonts = new List<FormattedSegment>();
            string pattern = @"<[s\d+, b, i, \/b, \/i, c, \/c]+>|\w+|\s|\p{P}|\D";

            // Match text using the pattern
            MatchCollection matches = Regex.Matches(cardMainText, pattern);
            FontStyle fontStyle = FontStyle.Regular;
            int currentFontSize = fontSize; 
            bool startCenteredSegment = false;
            bool continueCenteredSegment = false;

            bool addBreakLine = false;
            foreach (Match match in matches)
            {
                string matchText = match.Value;
                if (matchText.Contains("\n"))
                {
                    addBreakLine = true;
                }
                else if (matchText.StartsWith("<s") && matchText.Length == 5)
                {
                    int.TryParse(matchText.Substring(2, 2), out currentFontSize);
                    continue;
                }
                else
                {
                    switch (matchText)
                    {
                        case "<b>":
                            fontStyle |= FontStyle.Bold;
                            continue;
                        case "<i>":
                            fontStyle |= FontStyle.Italic;
                            continue;
                        case "<c>":
                            startCenteredSegment = true;
                            break;
                        case "</b>":
                            fontStyle &= ~FontStyle.Bold;
                            continue;
                        case "</i>":
                            fontStyle &= ~FontStyle.Italic;
                            continue;
                        case "</c>":
                            continueCenteredSegment = false;
                            continue;
                        case "</s>":
                            currentFontSize = fontSize;
                            continue;
                    }
                }

                if (addBreakLine)
                {
                    for (int i = 0; i < match.Length; i++)
                    {
                        if (matchText[i] == '\n')
                        {
                            fonts.Add(new BreaklineSegment(graphics, "breakline", new FontFamily(fontName), fontStyle, fontColor, currentFontSize));
                        }
                    }

                    addBreakLine = false;
                }
                else if (startCenteredSegment)
                {
                    startCenteredSegment = false;
                    fonts.Add(new FormattedSegment(graphics, string.Empty, new FontFamily(fontName), fontStyle, fontColor, currentFontSize, true));
                    continueCenteredSegment = true;
                }
                else if (continueCenteredSegment)
                {
                    fonts.Last().Text += matchText;
                }
                else
                {
                    fonts.Add(new FormattedSegment(graphics, matchText, new FontFamily(fontName), fontStyle, fontColor, currentFontSize, false));
                }

                Console.WriteLine(matchText);
            }

            return fonts;
        }

        //internal bool PositionInOverlyRectangle(PictureBox p, int x, int y)
        //{
        //    if (OverlyImage.UpdatedImage!= null)
        //    {
        //        ZoomFactor zf = new ZoomFactor();
        //        var zoomedOverlayBoundariesRectangle = zf.TranslateSelectionToZoomedSel(OverlyImage.GetImageBoundaries(), p.Size, backgroundImageHandler.UpdatedImage.Size);
        //        var zoomedOverlayImageRectangle = zf.TranslateSelectionToZoomedSel(new Rectangle(OverlyImage.PositionX, OverlyImage.PositionY, OverlyImage.UpdatedImage.Width, OverlyImage.UpdatedImage.Height), p.Size, backgroundImageHandler.UpdatedImage.Size);

        //        var intersectRectangle = Rectangle.Intersect(Rectangle.Round(zoomedOverlayBoundariesRectangle), Rectangle.Round(zoomedOverlayImageRectangle));

        //        System.Console.WriteLine(String.Format("Checking boundaries -> X:{0}, Y:{1}, OverlayX:{2}, OverlayY:{3}, MaxX:{4}, MaxY:{5}",
        //            x,
        //            y,
        //            intersectRectangle.X,
        //            intersectRectangle.Y,
        //            intersectRectangle.X + intersectRectangle.Width,
        //            intersectRectangle.Y + intersectRectangle.Height));

        //        return (x > intersectRectangle.X &&
        //            x < intersectRectangle.X + intersectRectangle.Width &&
        //            y > intersectRectangle.Y &&
        //            y < intersectRectangle.Y + intersectRectangle.Height);
        //    }

        //    return false;
        //}

       
    }
}


