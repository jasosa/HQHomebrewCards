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

        //Coordinates where the overlay can be drawn
        internal int overlayRectangleX; // X-coordinate of the top-left corner of the rectangle
        internal int overlayRectangleY; // Y-coordinate of the top-left corner of the rectangle
        internal int overlayRectangleWidth; // Width of the rectangle
        internal int overlayRectangleHeight; // Height of the rectangle

        //Overlay position
        internal int overlayX;
        internal int overlayY;

        //Title
        private TextElement title;
        //Text        
        private TextElement bodytext;

        //Default Values
        internal CardDefaults defaults;

        public Image OriginalCardImage => blankImage;
        public Image UdpatedCardImage => updatedCardImage;

        //Setup
        public abstract bool Setup_HasOldPaper { get; }
        public abstract bool Setup_HasScroll { get; }
        public abstract bool Setup_CanAddBorder { get; }

        //Title Properties       
        public TextElement Title { get => title;}
        public TextElement CardText { get => bodytext; }

        public abstract bool ShowOldPaper { get; set; }
        public abstract bool ShowScroll { get; set; }
        public abstract bool ShowBorder { get; set; }

        public int OverlayX { get => this.overlayX; set => this.overlayX = value; }
        public int OverlayY { get => this.overlayY; set => this.overlayY = value; }
        public  float ZoomOverlay { get => OverlayZoom.GetCurrentZoom(); set => OverlayZoom.SetZoom(value); }

        public abstract StatsType TypeOfStats { get; set; }
        public abstract CardDefaults Defaults { get; }
        public abstract int ScrollY { get; set; }
        public abstract HeroStats HeroStats { get; }

        public CardController()
        {
            title = new TextElement();
            bodytext = new TextElement();
        }

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
