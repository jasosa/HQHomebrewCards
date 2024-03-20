using System;
using System.Drawing;

namespace HQHomebrewCards.Logic
{
    public class ImageElement : IMovableElement
    {
        public event EventHandler ImageHandlerUpdated;
        public event EventHandler PositionChanged;
        Image originalImage;
        Image updatedImage;
        int positionX;
        int positionY;
        int drawnLimitX; // X-coordinate of the top-left corner of the rectangle
        int drawnLimitYY; // Y-coordinate of the top-left corner of the rectangle
        int drawnLimitWidth; // Width of the rectangle
        int drawnLimitHeight; // Height of the rectangle
        bool canZoom;
        ImageZoomHandler zoomHandler;
        Guid id;

        public ImageElement(Image image, bool canZoom)
        {
            originalImage = image;
            updatedImage = image;
            zoomHandler = new ImageZoomHandler();
            this.canZoom = canZoom;
        }

        public ImageElement(Image image, int boundariesX, int boundariesY, int boundarieswidth, int boundariesHeight, bool canZoom)
        {
            originalImage = image;
            updatedImage = image;
            drawnLimitX = boundariesX;
            drawnLimitYY = boundariesY;
            drawnLimitWidth = boundarieswidth;
            drawnLimitHeight = boundariesHeight;
            zoomHandler = new ImageZoomHandler();
            this.canZoom = canZoom;
            id = Guid.NewGuid();
        }        

        public Image UpdatedImage { get => updatedImage;}
        public Image OriginalImage { get => originalImage; }
        public int PositionX { get => positionX; set { positionX = value; OnImageMoved(); } }
        public int PositionY { get => positionY; set { positionY = value; OnImageMoved(); } }

        public Guid ID => id;

        internal void UpdateImage(Image image)
        {   
            updatedImage = image;
        }

        public Rectangle GetImageBoundaries()
        {
            return new Rectangle(drawnLimitX, drawnLimitYY, drawnLimitWidth, drawnLimitHeight);
        }

        internal float ZoomIn()
        {
           if (this.canZoom)
            {
                zoomHandler.ZoomIn();
                UpdateImage();
            }

            return zoomHandler.GetCurrentZoomLevel();
        }

        internal float ZoomOut()
        {
            if (this.canZoom)
            {
                zoomHandler.ZoomOut();
                UpdateImage();
            }

            return zoomHandler.GetCurrentZoomLevel();
        }

        internal float ZoomLevel()
        {
            return zoomHandler.GetCurrentZoomLevel();
        }

        private void UpdateImage()
        {
            if (updatedImage!= null)
            {
                var width = (int)(originalImage.Width * zoomHandler.GetCurrentZoomLevel());
                var height = (int)(originalImage.Height * zoomHandler.GetCurrentZoomLevel());

                // Create a new Bitmap with the increased size
                Image newOverlayImage = new Bitmap(width, height);

                using (Graphics graphics = Graphics.FromImage(newOverlayImage))
                {
                    // Draw the original overlay image onto the new image with the new size. This is to avoid losing resolution.
                    graphics.DrawImage(originalImage, new Rectangle(0, 0, width, height));
                }

                // Create a new Bitmap with the increased size
                updatedImage = newOverlayImage;

                OnImageHandlerUpdated(new EventArgs());
            }
        }

        internal virtual void OnImageHandlerUpdated(EventArgs e)
        {
            ImageHandlerUpdated?.Invoke(this, e);
        }

        internal virtual void OnImageMoved()
        {
            PositionChanged?.Invoke(this, new EventArgs());
        }
    }
}
