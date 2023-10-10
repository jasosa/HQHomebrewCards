using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQHomebrewCards
{
    public class Generic_Card_Controller
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

        private int textX;
        private int textY;
        private string text;

        public Generic_Card_Controller()
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

        public void  UpdateUI(string titleFontName, int titleFontSize, Color titlefontColor, string cardTitle, int cardTitlePositionY )
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
                int textX = (updatedCardImage.Width - (int)graphics.MeasureString(text, titleFont).Width) / 2;
                int textY = 600;
                graphics.DrawString(this.text, titleFont, titleBrush, textX, textY);

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
            this.text = text;
        }

        internal void SetCardText(string line, Font font, Brush brush, int yOffset)
        {
           
        }
    }
}

public class FormattedSegment
{
    public string Text { get; }
    public bool IsBold { get; }
    public Color Color { get; }

    public FormattedSegment(string text, bool isBold, Color color)
    {
        Text = text;
        IsBold = isBold;
        Color = color;
    }
}
