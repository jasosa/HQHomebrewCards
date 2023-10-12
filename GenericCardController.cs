using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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
        //Image
        private Image blankImage; //Blank Card Image
        private Image updatedCardImage; // Store the card image
        private Image overlayImage; // Store the overlay image       
        private Image originalOverlayImage; // Store the overlay image

        // Max Dimensions and position where the overlay image can be drawn
        private int overlayRectangleX = 120; // X-coordinate of the top-left corner of the rectangle
        private int overlayRectangleY = 166; // Y-coordinate of the top-left corner of the rectangle
        private int overlayRectangleWidth = 499; // Width of the rectangle
        private int overlayRectangleHeight = 361; // Height of the rectangle

        //X and Y positions of the overlay image
        private int overlayX;
        private int overlayY;

        //Card Text 
        private string cardText;
        private Point cardTextPosition;
        
        //consts
        const int CARD_TEXT_DEFAULT_X = 120;
        const int CARD_TEXT_DEFAULT_Y = 600;

        public GenericCardController()
        {
            // Load the blank image as the template/background.
            blankImage = Properties.Resources.Card_Front___Generic; 
            cardTextPosition = new Point(CARD_TEXT_DEFAULT_X, CARD_TEXT_DEFAULT_Y);
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

        public void UpdateUI(string titleFontName, int titleFontSize, Color titlefontColor, string cardTitle, int cardTitlePositionY)
        {
            // Create a copy of the blank image to overlay the card title.
            updatedCardImage = new Bitmap(blankImage);
            using (Graphics graphics = Graphics.FromImage(updatedCardImage))
            {
                // Set font and brush for the card title.
                Font titleFont = new Font(titleFontName, titleFontSize);
                Brush titleBrush = new SolidBrush(titlefontColor);

                // Calculate the position for the card title to center it on the image.
                int titleX = (updatedCardImage.Width - (int)graphics.MeasureString(cardTitle, titleFont).Width) / 2;
                int titleY = cardTitlePositionY;

                // Overlay the card title on the image.
                graphics.DrawString(cardTitle, titleFont, titleBrush, titleX, titleY);

                // Calculate the position for the card text to center it on the image.         

                if (cardText != null)
                {
                    List<FormattedSegment> segments = new List<FormattedSegment>();
                    segments = FormatText(graphics, cardText, titleFont, titleFontSize, titlefontColor);
                    WriteFormattedText(graphics, titleBrush, segments);
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
            float x = CARD_TEXT_DEFAULT_X;
            float y = CARD_TEXT_DEFAULT_Y;
            Point currentTextPosition = cardTextPosition;
            int maxWidth = 600;
            foreach (FormattedSegment textSegment in segments)
            {
                if (TextRenderer.MeasureText(graphics, textSegment.Text, textSegment.Font, Size.Empty, TextFormatFlags.NoPadding).Width + currentTextPosition.X > maxWidth)
                {
                    currentTextPosition = GoToNextLine(graphics, textSegment, currentTextPosition, cardTextPosition);
                }

                graphics.DrawString(textSegment.Text, textSegment.Font, titleBrush, currentTextPosition.X, currentTextPosition.Y - textSegment.BaseLine);
                currentTextPosition.X += TextRenderer.MeasureText(graphics, textSegment.Text, textSegment.Font, Size.Empty, TextFormatFlags.NoPadding).Width;

                if (textSegment.BreakLine)
                {
                    currentTextPosition = GoToNextLine(graphics, textSegment, currentTextPosition, cardTextPosition);
                }
            }
        }

        private Point GoToNextLine(Graphics graphics, FormattedSegment textSegment, Point currentPosition, Point originalPosition)
        {
            Point nextLinePosition = new Point(
                originalPosition.X,
                currentPosition.Y + TextRenderer.MeasureText(graphics, textSegment.Text, textSegment.Font, Size.Empty, TextFormatFlags.NoPadding).Height
                );
            return nextLinePosition;
        }

        private List<FormattedSegment> FormatText(Graphics graphics, string cardMainText, Font font, int fontSize, Color fontColor)
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
                switch (matchText)
                {
                    case "\n":
                        addBreakLine = false; //Handled on the previous segment
                        continue; ;
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

                if (match.NextMatch() != null && match.NextMatch().Value == "\n")
                {
                    //add breakline to next segment
                    addBreakLine = true;
                }

                fonts.Add(new FormattedSegment(graphics, matchText, new FontFamily(font.Name), fontStyle, fontColor, fontSize, addBreakLine));
                Console.WriteLine(matchText);
            }

            return fonts;
        }
    }

    public class DrawFont
    {
        public Font Font { get; set; }
        public float baseLine { get; set; }
        public string Text { get; set; }
        public bool BreakLine { get; set; }

        public DrawFont(Graphics G, string text, FontFamily FF, float height, FontStyle style)
        {
            Font = new Font(FF, height, style);
            float lineSpace = FF.GetLineSpacing(Font.Style);
            float ascent = FF.GetCellAscent(Font.Style);
            baseLine = Font.GetHeight(G) * ascent / lineSpace;
            Text = text;
            BreakLine = false;
        }

        public DrawFont(Graphics G, string text, FontFamily FF, float height, FontStyle style, bool breakline)
        {
            Font = new Font(FF, height, style);
            float lineSpace = FF.GetLineSpacing(Font.Style);
            float ascent = FF.GetCellAscent(Font.Style);
            baseLine = Font.GetHeight(G) * ascent / lineSpace;
            Text = text;
            BreakLine = breakline;
        }
    }    
}


