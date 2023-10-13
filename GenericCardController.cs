using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HQHomebrewCards.CardDesignerForm;

namespace HQHomebrewCards
{
    public class GenericCardController
    {
        //Title Text
        private string titleFontName;
        private int titleFontSize;
        private Color titleFontColor;

        //Card Text
        private string cardFontName;
        private int cardFontSize;
        private Color textFontColor;

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

        //Card Text 
        private string cardText;
        private Point cardTextPosition;
        private int cardTextLineSpace;

        private bool showOldPaper;

        //consts
        const int CARD_TEXT_DEFAULT_X = 120;
        const int CARD_TEXT_DEFAULT_Y = 600;       

        public GenericCardController()
        {
            // Load the blank image as the template/background.
            blankImage = Properties.Resources.Card_Front___Generic;
            oldPaperImage = Properties.Resources.old_paper;            
            cardTextPosition = new Point(CARD_TEXT_DEFAULT_X, CARD_TEXT_DEFAULT_Y);
            cardTextLineSpace = 5;
            ShowOldPaper = false;
        }

        public Image GetOriginalCardImage()
        {
            return blankImage;
        }

        public Image GetUdpatedCardImage()
        {
            return updatedCardImage;
        }

        public Image GetUpdatedOverlyImage()
        {
            return overlayImage;
        }

        public Image GetOriginalOverlyImage()
        {
            return originalOverlayImage;
        }

        public void SetOverlayX(int X)
        {
            this.overlayX = X;
        }

        public void SetOverlayY(int Y)
        {
            this.overlayY = Y;
        }

        public int GetOverlayX()
        {
            return this.overlayX;
        }

        public int GetOverlayY()
        {
            return this.overlayY;
        }

        internal void AddOverlyImage(Image image)
        {
            originalOverlayImage = image;
            overlayImage = image;
        }

        internal void RemoveOverlyImage()
        {
            originalOverlayImage = null;
            overlayImage = null;
        }

        internal void UpdateOverly(Image image)
        {
            overlayImage = image;
        }

        internal void SetCardText(string text)
        {
            this.cardText = text;
        }

        public string TitleFontName { get => titleFontName; set => titleFontName = value; }
        public string CardFontName { get => cardFontName; set => cardFontName = value; }
        public int TitleFontSize { get => titleFontSize; set => titleFontSize = value; }
        public int CardFontSize { get => cardFontSize; set => cardFontSize = value; }
        public Color TitleFontColor { get => titleFontColor; set => titleFontColor = value; }
        public Color TextFontColor { get => textFontColor; set => textFontColor = value; }
        public bool ShowOldPaper { get => showOldPaper; set => showOldPaper = value; }        

        public void UpdateUI(string cardTitle, int cardTitlePositionY)
        {
            // Create a copy of the blank image to overlay the card title.
            updatedCardImage = new Bitmap(blankImage);
            using (Graphics graphics = Graphics.FromImage(updatedCardImage))
            {
                // Set font and brush for the card title.
                Font titleFont = new Font(TitleFontName, TitleFontSize);
                Brush titleBrush = new SolidBrush(TitleFontColor);

                // Calculate the position for the card title to center it on the image.
                int titleX = (updatedCardImage.Width - (int)graphics.MeasureString(cardTitle, titleFont).Width) / 2;
                int titleY = cardTitlePositionY;

                // Write the card title on the image.
                graphics.DrawString(cardTitle, titleFont, titleBrush, titleX, titleY);
                

                if (cardText != null)
                {
                    List<FormattedSegment> segments = new List<FormattedSegment>();
                    segments = FormatText(graphics, cardText, CardFontName, CardFontSize, TextFontColor);
                    WriteFormattedText(graphics, new SolidBrush(TextFontColor), segments);
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
            Point currentTextPosition = cardTextPosition;
            int maxWidth = 600;
            foreach (FormattedSegment textSegment in segments)
            {
                int segmentTextSize = GetSegmentTextWidth(graphics, textSegment);

                if (textSegment.BreakLine)
                {
                    currentTextPosition = GoToNextLine(graphics, textSegment, currentTextPosition, cardTextPosition);
                    continue;
                }

                if (segmentTextSize + currentTextPosition.X > maxWidth)
                {
                    currentTextPosition = GoToNextLine(graphics, textSegment, currentTextPosition, cardTextPosition);
                }

                graphics.DrawString(textSegment.Text, textSegment.Font, titleBrush, currentTextPosition.X, currentTextPosition.Y - textSegment.BaseLine);
                currentTextPosition.X += segmentTextSize; 
                
            }
        }

        private static int GetSegmentTextWidth(Graphics graphics, FormattedSegment textSegment)
        {
            return TextRenderer.MeasureText(graphics, textSegment.Text, textSegment.Font,Size.Empty, TextFormatFlags.NoPadding).Width;
        }

        private Point GoToNextLine(Graphics graphics, FormattedSegment textSegment, Point currentPosition, Point originalPosition)
        {
            Point nextLinePosition = new Point(
                originalPosition.X,
                currentPosition.Y + TextRenderer.MeasureText(graphics, textSegment.Text, textSegment.Font, Size.Empty, TextFormatFlags.NoPadding).Height - cardTextLineSpace
                ) ;
            return nextLinePosition;
        }

        private List<FormattedSegment> FormatText(Graphics graphics, string cardMainText, string fontName, int fontSize, Color fontColor)
        {
            List<FormattedSegment> fonts = new List<FormattedSegment>();
            string pattern = @"<[b, i, \/b, \/i]+>|\w+|\s+|\p{P}";

            // Match text using the pattern
            MatchCollection matches = Regex.Matches(cardMainText, pattern);
            FontStyle fontStyle = FontStyle.Regular;

            bool addBreakLine = false;            
            foreach (Match match in matches)
            {
                string matchText = match.Value;
                if (matchText.Contains("\n"))
                {
                    addBreakLine = true;
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
                        case "</b>":
                            fontStyle &= ~FontStyle.Bold;
                            continue;
                        case "</i>":
                            fontStyle &= ~FontStyle.Italic;
                            continue;
                    }
                }

                if (addBreakLine)
                {
                    for (int i = 0; i < match.Length; i++)
                    {
                        if (matchText[i] == '\n'){
                            fonts.Add(new BreaklineSegment(graphics, "breakline", new FontFamily(fontName), fontStyle, fontColor, fontSize));
                        }
                    }

                    addBreakLine = false;
                }
                else { 
                    fonts.Add(new FormattedSegment(graphics, matchText, new FontFamily(fontName), fontStyle, fontColor, fontSize));                
                }

                Console.WriteLine(matchText);
            }

            return fonts;
        }

        internal void SaveImage(string v)
        {
            Bitmap bmp = new Bitmap(updatedCardImage);
            bmp.SetResolution(300, 300);
            bmp.Save(v);
        }
    }   
}


