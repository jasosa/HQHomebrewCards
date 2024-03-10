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
        //Image Handlers
        internal ImageCardHandler overlayCardHandler;
        internal ImageCardHandler backgroundImageHandler;

        //Text Elements
        internal TextElement title;
        internal TextElement bodytext;

        //Default Values
        internal CardDefaults defaults;


        // ICardController Properties
        public ImageCardHandler BackgroundImage => backgroundImageHandler;
        public ImageCardHandler OverlyImage => overlayCardHandler;
        public TextElement Title { get => title; }
        public TextElement CardText { get => bodytext; }


        //Setup
        public abstract bool Setup_HasOldPaper { get; }
        public abstract bool Setup_HasScroll { get; }
        public abstract bool Setup_CanAddBorder { get; }
        public abstract bool ShowOldPaper { get; set; }
        public abstract bool ShowScroll { get; set; }
        public abstract bool ShowBorder { get; set; }
        public abstract StatsType TypeOfStats { get; set; }
        public abstract CardDefaults Defaults { get; }
        public abstract int ScrollY { get; set; }        
        public abstract HeroStats HeroStats { get; }
        public float ZoomOverlay { get => OverlayZoom.GetCurrentZoom(); set => OverlayZoom.SetZoom(value); }

        
        
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
            return OverlyImage.GetImageBoundaries();
        }

        public abstract void UpdateUI();
    }
}
