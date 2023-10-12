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
        private Image blankImage; //Blank Card Image
        private Image updatedCardImage; // Store the card image
        private Image overlayImage; // Store the overlay image       
        private Image originalOverlayImage; // Store the overlay image

        // Define the dimensions and position of the overlay rectangle
        private int overlayRectangleX = 120; // X-coordinate of the top-left corner of the rectangle
        private int overlayRectangleY = 166; // Y-coordinate of the top-left corner of the rectangle
        private int overlayRectangleWidth = 499; // Width of the rectangle
        private int overlayRectangleHeight = 361; // Height of the rectangle

        private int overlayX;
        private int overlayY;

        private string cardMainText;
        private int cardTextRectangleX = 120;
        private int cardTextRectangleY = 600;
        private int cardTextRectangleWidth = 500;

        public GenericCardController()
        {
            // Load the blank image as the template/background.
            blankImage = Properties.Resources.Card_Front___Generic; // Assuming you have an image resource named 'blank_image'. 

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

                if (cardMainText != null)
                {
                    List<DrawFont> fonts = new List<DrawFont>();
                    string pattern = @"<[b, i, \/b, \/i]+>|\w+|\s+|\p{P}";//@"<[^>]+>|\w+|\s+|"; //@"<[^>]+>|\s+|[^\w\s]";

                    // Match text using the pattern
                    MatchCollection matches = Regex.Matches(cardMainText, pattern);                    
                    FontStyle fontStyle = FontStyle.Regular;

                    bool addBreakLine = false;
                    foreach (Match match in matches)
                    {                        
                        string matchText = match.Value;
                        if (matchText == "\n")
                        {
                            addBreakLine = false;
                            continue;

                        }
                        if (matchText == "<b>")
                        {
                            fontStyle = fontStyle | FontStyle.Bold;                            
                            continue;
                        }
                        if (matchText == "<i>")
                        {
                            fontStyle = fontStyle | FontStyle.Italic;                            
                            continue;
                        }
                        if (matchText == "</b>")
                        {
                            fontStyle = fontStyle & ~FontStyle.Bold;                            
                            continue;
                        }
                        if (matchText == "</i>")
                        {
                            fontStyle = fontStyle & ~FontStyle.Italic;                            
                            continue;
                        }

                        if (match.NextMatch() != null && match.NextMatch().Value == "\n")
                        {
                            //addbreakline 
                            addBreakLine = true;
                        }
                        
                        fonts.Add(new DrawFont(graphics, matchText, new FontFamily(titleFont.Name), titleFontSize, fontStyle, addBreakLine));
                        Console.WriteLine(matchText);
                    }

                    float x = cardTextRectangleX;
                    float y = cardTextRectangleY;
                    int maxWidth = 600;
                    foreach (DrawFont font in fonts)
                    {
                        if (TextRenderer.MeasureText(graphics, font.Text, font.Font, Size.Empty, TextFormatFlags.NoPadding).Width + x > maxWidth)
                        {
                            y += TextRenderer.MeasureText(graphics, font.Text, font.Font, Size.Empty, TextFormatFlags.NoPadding).Height;
                            x = cardTextRectangleX;
                        }

                        graphics.DrawString(font.Text, font.Font, titleBrush, x, y - font.baseLine);
                        x += TextRenderer.MeasureText(graphics, font.Text, font.Font, Size.Empty, TextFormatFlags.NoPadding).Width;

                        if (font.BreakLine)
                        {
                            y += TextRenderer.MeasureText(graphics, font.Text, font.Font, Size.Empty, TextFormatFlags.NoPadding).Height;
                            x = cardTextRectangleX;
                        }
                    }                    
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
            this.cardMainText = text;
        }

        private string ApplyFormattingAndDrawText(Graphics graphics, string text, Font defaultFont, Brush defaultBrush, List<FormattedSegment> formattedSegments)
        {
            // Define regular expressions for bold, italic, and font size formatting
            string boldPattern = @"\*\*(.*?)\*\*";
            string italicPattern = @"__(.*?)__";
            string sizePattern = @"<(\d+)>(.*?)<\d+>";

            // Apply bold formatting
            text = ApplyFormatting(graphics, text, boldPattern, FontStyle.Bold, defaultFont, defaultBrush, formattedSegments);

            // Apply italic formatting
            text = ApplyFormatting(graphics, text, italicPattern, FontStyle.Italic, defaultFont, defaultBrush, formattedSegments);

            // Apply font size formatting
            text = ApplyFormatting(graphics, text, sizePattern, FontStyle.Regular, defaultFont, defaultBrush, formattedSegments);

            // Return the text with formatting removed
            return text;
        }

        private string ApplyFormatting(Graphics graphics, string text, string pattern, FontStyle fontStyle, Font defaultFont, Brush defaultBrush, List<FormattedSegment> formattedSegments)
        {
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                string formattedText = match.Groups[1].Value;

                // Apply formatting for matched text
                Font formattedFont = new Font(defaultFont, fontStyle);

                // Create a FormattedSegment to store formatting instructions
                formattedSegments.Add(new FormattedSegment
                {
                    Text = formattedText,
                    Font = formattedFont,
                    Brush = defaultBrush
                });

                // Replace the matched text with a placeholder
                text = text.Replace(match.Value, $"@#{formattedSegments.Count - 1}#");
            }

            return text;
        }

        private void DrawFormattedText(Graphics graphics, string text, Font defaultFont, Brush defaultBrush, List<FormattedSegment> formattedSegments)
        {
            int maxWidth = 600; // Maximum width of the text block
            int imageWidth = 800; // Width of the image

            // Calculate the total width of the text
            int totalTextWidth = 0;

            // Initialize a TextFormatFlags object for word wrap and alignment
            TextFormatFlags formatFlags = TextFormatFlags.WordBreak | TextFormatFlags.NoPadding;

            // Loop through words in the text to calculate the total width
            foreach (string word in text.Split(' '))
            {
                if (word.StartsWith("@#") && word.EndsWith("#"))
                {
                    // This is a formatted segment
                    int segmentIndex = int.Parse(word.Substring(2, word.Length - 3));

                    if (segmentIndex >= 0 && segmentIndex < formattedSegments.Count)
                    {
                        FormattedSegment segment = formattedSegments[segmentIndex];

                        // Measure the width of the formatted segment
                        Size textSize = TextRenderer.MeasureText(segment.Text, segment.Font, new Size(maxWidth, 0), formatFlags);
                        totalTextWidth += textSize.Width;
                    }
                }
                else
                {
                    // This is a regular word without formatting
                    Size textSize = TextRenderer.MeasureText(word, defaultFont, new Size(maxWidth, 0), formatFlags);
                    totalTextWidth += textSize.Width;
                }

                // Add spacing between words
                totalTextWidth += 5;                
            }

            // Calculate the starting X-coordinate to center the text
            int x = (imageWidth - totalTextWidth) / 2;
            int y = 600; // Initial Y-coordinate

            // Loop through words in the text to actually draw the text
            foreach (string word in text.Split(' '))
            {
                if (word.StartsWith("@#") && word.EndsWith("#"))
                {
                    // This is a formatted segment
                    int segmentIndex = int.Parse(word.Substring(2, word.Length - 3));

                    if (segmentIndex >= 0 && segmentIndex < formattedSegments.Count)
                    {
                        FormattedSegment segment = formattedSegments[segmentIndex];

                        // Draw the formatted segment
                        TextRenderer.DrawText(graphics, segment.Text, segment.Font, new Point(x, y), Color.Black, formatFlags);

                        // Update the position based on the size of the drawn text
                        Size textSize = TextRenderer.MeasureText(segment.Text, segment.Font, new Size(maxWidth, 0), formatFlags);
                        x += textSize.Width;
                    }
                }
                else
                {
                    // This is a regular word without formatting
                    TextRenderer.DrawText(graphics, word, defaultFont, new Point(x, y), Color.Black, formatFlags);

                    // Update the position based on the size of the drawn text
                    Size textSize = TextRenderer.MeasureText(word, defaultFont, new Size(maxWidth, 0), formatFlags);
                    x += textSize.Width;
                }

                // Add spacing between words
                x += 5;

                // Check if the text exceeds the maximum width and wrap to the next line
                if (x + totalTextWidth > maxWidth)
                {
                    // Reset X to the starting position on a new line
                    x = (imageWidth - totalTextWidth) / 2;                   
                }
            }
        }
    }

        internal class FormattedSegment
    {
        public string Text { get; set; }
        public Font Font { get; set; }
        public Brush Brush { get; set; }
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


