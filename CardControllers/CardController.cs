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
        internal Image backgroundImage; //Blank Card Image                                   
        internal Image updatedCardImage; // Store the card image
        //internal Image overlayImage; // Store the overlay image       
        //internal Image originalOverlayImage; // Store the overlay image

        internal HQHomebrewCards.ImageCardHandler overlayCardHandler;

        //Coordinates where the overlay can be drawn
        //internal int overlayRectangleX; // X-coordinate of the top-left corner of the rectangle
        //internal int overlayRectangleY; // Y-coordinate of the top-left corner of the rectangle
        //internal int overlayRectangleWidth; // Width of the rectangle
        //internal int overlayRectangleHeight; // Height of the rectangle

        //Overlay position
        //internal int overlayX;
        //internal int overlayY;

        //Title
        private TextElement title;
        //Text        
        private TextElement bodytext;

        //Default Values
        internal CardDefaults defaults;

        public Image OriginalCardImage => backgroundImage;
        public Image UdpatedCardImage => updatedCardImage;
        public ImageCardHandler OverlyImage => overlayCardHandler;

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

        public abstract void AddOverlyImage(Image image);

        public void RemoveOverlyImage()
        {
            overlayCardHandler = null;
        }

        public Image GetOriginalOverlyImage()
        {
            return overlayCardHandler.OriginalImage;
        }

        public Image GetUpdatedOverlyImage()
        {
            return overlayCardHandler.UpdatedImage; ;
        }       

        public void UpdateOverlyImage(float amount)
        {
            if (overlayCardHandler.UpdatedImage != null)
            {
                var width = (int)(this.overlayCardHandler.OriginalImage.Width * amount);
                var height = (int)(this.overlayCardHandler.OriginalImage.Height * amount);

                // Create a new Bitmap with the increased size
                Image newOverlayImage = new Bitmap(width, height);

                using (Graphics graphics = Graphics.FromImage(newOverlayImage))
                {
                    // Draw the original overlay image onto the new image with the new size. This is to avoid losing resolution.
                    graphics.DrawImage(overlayCardHandler.OriginalImage, new Rectangle(0, 0, width, height));
                }

                // Create a new Bitmap with the increased size
                overlayCardHandler.UpdateImage(newOverlayImage);
            }
        }

        public Rectangle GetOverlayImageBoundaries()
        {
            return new Rectangle(OverlyImage.DrawnLimitX, OverlyImage.DrawnLimitYY, OverlyImage.DrawnLimitWidth, OverlyImage.DrawnLimitHeight);
        }

        public abstract void UpdateUI();
    }
}
