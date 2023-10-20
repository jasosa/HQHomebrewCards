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
using System.Windows.Media.Imaging;
using System.Xml.Serialization;
using static HQHomebrewCards.CardDesignerForm;

namespace HQHomebrewCards
{
    public class GenericCardController : ICardController
    {
        //Title Text
        private string titleFontName;
        private int titleFontSize;
        private Color titleFontColor;
        private string titleText;

        //Card Text
        private string cardFontName;
        private int cardFontSize;
        private Color textFontColor;
        private string cardText;
        private Point cardTextPosition;
        private int cardTextLineSpace;
        private int cardTextX = 100;
        private int cardTextY = 600;
        private int cardTextLineSize = 600;

        //Image
        private Image blankImage; //Blank Card Image
        private Image updatedCardImage; // Store the card image
        private Image overlayImage; // Store the overlay image       
        private Image originalOverlayImage; // Store the overlay image        

        private Image oldPaperImage;


        // Max Dimensions and position where the overlay image can be drawn
        private int overlayRectangleX = 120; // X-coordinate of the top-left corner of the rectangle
        private int overlayRectangleY = 166; // Y-coordinate of the top-left corner of the rectangle
        private int overlayRectangleWidth = 499; // Width of the rectangle
        private int overlayRectangleHeight = 361; // Height of the rectangle

        //Old Paper Image Rectangle
        private int oldPaperRectangleX = 123; // X-coordinate of the top-left corner of the rectangle
        private int oldPaperRectangleY = 166; // Y-coordinate of the top-left corner of the rectangle
        private int oldPaperRectangleWidth = 496; // Width of the rectangle
        private int oldPaperRectangleHeight = 361; // Height of the rectangle


        //X and Y positions of the overlay image
        private int overlayX;
        private int overlayY;

        private bool showOldPaper;
        private int cardTitlePositionY;                

        public GenericCardController()
        {
            // Load the blank image as the template/background.
            blankImage = Properties.Resources.Card_Front___Generic;
            oldPaperImage = Properties.Resources.old_paper;
            cardTextPosition = new Point(CardTextX, CardTextY);
            cardTextLineSpace = 5;            
            ShowOldPaper = false;
        }

        public Image OriginalCardImage => blankImage;

        public Image UdpatedCardImage => updatedCardImage;

        public Image GetUpdatedOverlyImage()
        {
            return overlayImage;
        }

        public Image GetOriginalOverlyImage()
        {
            return originalOverlayImage;
        }

        public void AddOverlyImage(Image image)
        {
            originalOverlayImage = image;
            overlayImage = image;
            OverlayZoom.SetDefaultZoom();
        }

        public void RemoveOverlyImage()
        {
            originalOverlayImage = null;
            overlayImage = null;
        }

        public void UpdateOverlyImage(float amount)
        {
            if (overlayImage != null)
            {
                var width = (int)(this.originalOverlayImage.Width * amount);
                var height = (int)(this.originalOverlayImage.Height * amount);

                // Create a new Bitmap with the increased size
                Image newOverlayImage = new Bitmap(width, height);

                using (Graphics graphics = Graphics.FromImage(newOverlayImage))
                {
                    // Draw the original overlay image onto the new image with the new size. This is to avoid losing resolution.
                    graphics.DrawImage(originalOverlayImage, new Rectangle(0, 0, width, height));
                }

                // Create a new Bitmap with the increased size
                this.overlayImage = newOverlayImage;
            }
        }

        public string TitleText { get => titleText; set => titleText = value; }
        public string TitleFontName { get => titleFontName; set => titleFontName = value; }
        public int TitleFontSize { get => titleFontSize; set => titleFontSize = value; }

        [XmlIgnore]
        public Color TitleFontColor { get => titleFontColor; set => titleFontColor = value; }

        [XmlElement("TitleFontColor")]
        public string TitleFontColorString
        {
            get { return ColorTranslator.ToHtml(TitleFontColor); }
            set { TitleFontColor = ColorTranslator.FromHtml(value); }
        }
        public int TitlePositionY { get => cardTitlePositionY; set => cardTitlePositionY = value; }
        public string CardText { get => cardText; set => cardText = value; }
        public string CardFontName { get => cardFontName; set => cardFontName = value; }
        public int CardFontSize { get => cardFontSize; set => cardFontSize = value; }

        [XmlIgnore]
        public Color CardFontColor { get => textFontColor; set => textFontColor = value; }

        [XmlElement("CardFontColor")]
        public string CardFontColorString
        {
            get { return ColorTranslator.ToHtml(CardFontColor); }
            set { CardFontColor = ColorTranslator.FromHtml(value); }
        }

        public bool ShowOldPaper { get => showOldPaper; set => showOldPaper = value; }
        public int OverlayX { get => this.overlayX; set => this.overlayX = value; }
        public int OverlayY { get => this.overlayY; set => this.overlayY = value; }

        public float ZoomOverlay { get => OverlayZoom.GetCurrentZoom(); set => OverlayZoom.SetZoom(value);}
        public int CardTextX { get => cardTextX; set => cardTextX = value; }
        public int CardTextY { get => cardTextY; set => cardTextY = value; }
        public int CardTextLineSize { get => cardTextLineSize; set => cardTextLineSize = value; }

        public void UpdateUI()
        {
            // Create a copy of the blank image to overlay the card title.
            updatedCardImage = new Bitmap(blankImage);
            using (Graphics graphics = Graphics.FromImage(updatedCardImage))
            {
                // Set font and brush for the card title.
                Font titleFont = new Font(TitleFontName, TitleFontSize);
                Brush titleBrush = new SolidBrush(TitleFontColor);

                // Calculate the position for the card title to center it on the image.
                int titleX = (updatedCardImage.Width - (int)graphics.MeasureString(TitleText, titleFont).Width) / 2;
                int titleY = cardTitlePositionY;

                // Write the card title on the image.
                graphics.DrawString(TitleText, titleFont, titleBrush, titleX, titleY);


                if (cardText != null)
                {
                    List<FormattedSegment> segments = new List<FormattedSegment>();
                    segments = FormatText(graphics, cardText, CardFontName, CardFontSize, CardFontColor);
                    WriteFormattedText(graphics, new SolidBrush(CardFontColor), segments);
                }

                if (ShowOldPaper)
                {
                    Rectangle destinationRectangle = new Rectangle(oldPaperRectangleX, oldPaperRectangleY, oldPaperRectangleWidth, oldPaperRectangleHeight);
                    graphics.SetClip(destinationRectangle);
                    // Overlay the image on the card image.
                    graphics.DrawImage(oldPaperImage, oldPaperRectangleX, oldPaperRectangleY, oldPaperImage.Width, oldPaperImage.Height);
                }

                // Check if an overlay image is available.
                if (overlayImage != null)
                {
                    Rectangle destinationRectangle = new Rectangle(overlayRectangleX, overlayRectangleY, overlayRectangleWidth, overlayRectangleHeight);
                    graphics.SetClip(destinationRectangle);

                    // Overlay the image on the card image.
                    graphics.DrawImage(overlayImage, overlayX, overlayY, overlayImage.Width, overlayImage.Height);

                }
            }
        }

        private void WriteFormattedText(Graphics graphics, Brush titleBrush, List<FormattedSegment> segments)
        {
            Point initialTextPosition = new Point(CardTextX, CardTextY);
            Point currentTextPosition = initialTextPosition;
            
            foreach (FormattedSegment textSegment in segments)
            {
                int segmentTextSize = GetSegmentTextWidth(graphics, textSegment);

                if (textSegment.BreakLine)
                {
                    currentTextPosition = GoToNextLine(graphics, textSegment, currentTextPosition, initialTextPosition);
                    continue;
                }

                if (segmentTextSize + currentTextPosition.X > CardTextLineSize)
                {
                    currentTextPosition = GoToNextLine(graphics, textSegment, currentTextPosition, initialTextPosition);
                }

                if (textSegment.Centered)
                {
                    currentTextPosition.X = (updatedCardImage.Width - (int)graphics.MeasureString(textSegment.Text, textSegment.Font).Width) / 2;
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
                currentPosition.Y + TextRenderer.MeasureText(graphics, textSegment.Text, textSegment.Font, Size.Empty, TextFormatFlags.NoPadding).Height - cardTextLineSpace
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

        internal bool PositionInOverlyRectangle(PictureBox p, int x, int y)
        {

            if (overlayImage != null)
            {
                ZoomFactor zf = new ZoomFactor();
                var zoomedOverlayBoundariesRectangle = zf.TranslateSelectionToZoomedSel(new Rectangle(overlayRectangleX, overlayRectangleY, overlayRectangleWidth, overlayRectangleHeight), p.Size, updatedCardImage.Size);
                var zoomedOverlayImageRectangle = zf.TranslateSelectionToZoomedSel(new Rectangle(overlayX, overlayY, overlayImage.Width, overlayImage.Height), p.Size, updatedCardImage.Size);

                var intersectRectangle = Rectangle.Intersect(Rectangle.Round(zoomedOverlayBoundariesRectangle), Rectangle.Round(zoomedOverlayImageRectangle));

                System.Console.WriteLine(String.Format("Checking boundaries -> X:{0}, Y:{1}, OverlayX:{2}, OverlayY:{3}, MaxX:{4}, MaxY:{5}",
                    x,
                    y,
                    intersectRectangle.X,
                    intersectRectangle.Y,
                    intersectRectangle.X + intersectRectangle.Width,
                    intersectRectangle.Y + intersectRectangle.Height));

                return (x > intersectRectangle.X &&
                    x < intersectRectangle.X + intersectRectangle.Width &&
                    y > intersectRectangle.Y &&
                    y < intersectRectangle.Y + intersectRectangle.Height);
            }

            return false;
        }

        public Rectangle GetOverlayImageBoundaries()
        {
            return new Rectangle(overlayRectangleX, overlayRectangleY, overlayRectangleWidth, overlayRectangleHeight);
        }
    }
}


