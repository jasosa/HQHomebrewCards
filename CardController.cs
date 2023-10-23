using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HQHomebrewCards
{
    public abstract class CardController : ICardController
    {
        //Image
        internal Image blankImage; //Blank Card Image                                   
        internal Image updatedCardImage; // Store the card image
        internal Image overlayImage; // Store the overlay image       
        internal Image originalOverlayImage; // Store the overlay image      
        internal Image scrollImage;

        public abstract bool Setup_HasOldPaper { get; }

        [XmlIgnore]
        public abstract Color CardFontColor { get; set; }
        
        [XmlElement("CardFontColor")]
        public abstract string CardFontColorString { get; set; }
        public abstract string CardFontName { get; set; }
        public abstract int CardFontSize { get; set; }
        public abstract string CardText { get; set; }
        public abstract int OverlayX { get; set; }
        public abstract int OverlayY { get; set; }
        public abstract bool ShowOldPaper { get; set; }
        [XmlIgnore]
        public abstract Color TitleFontColor { get; set; }
        [XmlElement("TitleFontColor")]
        public abstract string TitleFontColorString { get; set; }
        public abstract string TitleFontName { get; set; }
        public abstract int TitleFontSize { get; set; }
        public abstract int TitlePositionY { get; set; }
        public abstract string TitleText { get; set; }
        public Image OriginalCardImage => blankImage;
        public Image UdpatedCardImage => updatedCardImage;
        public abstract float ZoomOverlay { get; set; }
        public abstract int CardTextX { get; set; }
        public abstract int CardTextY { get; set; }
        public abstract int CardTextLineSize { get; set; }        
 
        public void AddOverlyImage(Image image)
        {
            originalOverlayImage = image;
            overlayImage = image;
        }

        public void RemoveOverlyImage()
        {
            originalOverlayImage = null;
            overlayImage = null;
        }

        public Image GetOriginalOverlyImage()
        {
            return originalOverlayImage;
        }

        public Image GetUpdatedOverlyImage()
        {
            return overlayImage;
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

        public abstract Rectangle GetOverlayImageBoundaries();

        public abstract void UpdateUI();
    }
}
