using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQHomebrewCards
{
    public class ImageCardHandler
    {
        Image originalImage;
        Image updatedImage;
        int positionX;
        int positionY;
        int drawnLimitX; // X-coordinate of the top-left corner of the rectangle
        int drawnLimitYY; // Y-coordinate of the top-left corner of the rectangle
        int drawnLimitWidth; // Width of the rectangle
        int drawnLimitHeight; // Height of the rectangle

        public ImageCardHandler(Image image)
        {
            originalImage = image;
            updatedImage = image;
        }

        public ImageCardHandler(Image image, int boundariesX, int boundariesY, int boundarieswidth, int boundariesHeight)
        {
            originalImage = image;
            updatedImage = image;
            drawnLimitX = boundariesX;
            drawnLimitYY = boundariesY;
            drawnLimitWidth = boundarieswidth;
            drawnLimitHeight = boundariesHeight;
        }

        public Image UpdatedImage { get => updatedImage;}
        public Image OriginalImage { get => originalImage; }
        public int PositionX { get => positionX; set => positionX = value; }
        public int PositionY { get => positionY; set => positionY = value; }
        //public int DrawnLimitX { get => drawnLimitX; set => drawnLimitX = value; }
        //public int DrawnLimitYY { get => drawnLimitYY; set => drawnLimitYY = value; }
        //public int DrawnLimitWidth { get => drawnLimitWidth; set => drawnLimitWidth = value; }
        //public int DrawnLimitHeight { get => drawnLimitHeight; set => drawnLimitHeight = value; }

        internal void UpdateImage(Image image)
        {   
            updatedImage = image;
        }

        public Rectangle GetImageBoundaries()
        {
            return new Rectangle(drawnLimitX, drawnLimitYY, drawnLimitWidth, drawnLimitHeight);
        }
    }
}
