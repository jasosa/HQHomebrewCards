using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;
using static HQHomebrewCards.CardDesignerForm;

namespace HQHomebrewCards
{
    public class HeroCardController : CardController
    {
        //Title Text
        private bool showScroll;
        private int scrollY;


        //Stats
        private StatsType typeOfStats;
        private int statsBoxY;
        public HeroStats heroStats;


        public override bool Setup_CanAddBorder => false;
        public override bool Setup_HasOldPaper { get => false; }
        public override bool Setup_HasScroll { get => true; }

        public HeroCardController()
        {
            // Load the blank image as the template/background.
            base.blankImage = Properties.Resources.Hero_Card_Front;
            CardText.SpaceBetweenLines = 5;
            showScroll = true;
            typeOfStats = StatsType.NONE;

            overlayRectangleX = 0;
            overlayRectangleY = 0;
            overlayRectangleWidth = 742;
            overlayRectangleHeight = 1045;

            statsBoxY = 750;
            defaults = new CardDefaults()
            {
                DEFAULT_TEXT_FONT_SIZE = 24,
                DEFAULT_TEXT_FONT_NAME = "CarterSansW01-Regular",
                DEFAULT_TEXT_FONT_COLOR = Color.Black,
                DEFAULT_TEXT_LENGHT = 660,
                DEFAULT_TEXT_POSITION_X = 100,
                DEFAULT_TEXT_POSITION_Y = 950,
                DEFAULT_TITLE_FONT_COLOR = Color.Black,
                DEFAULT_TITLE_FONT_NAME = "CarterSansW01-SmBd",
                DEFAULT_TITLE_FONT_SIZE = 40,
                DEFAULT_TITLE_POSITION_Y = 80,
                DEFAULT_SHOW_OLD_PAPER = false,
                DEFAULT_SHOW_STATS = StatsType.MONSTER,
                DEFAULT_SCROLL_Y = 80,
            };

            heroStats = new HeroStats();
            heroStats.MovementSquares.MaxTextLenght = 200;
            heroStats.MovementSquares.TextPositionX= 84;
            heroStats.MovementSquares.TextPositionY = statsBoxY + 40;
            heroStats.MovementSquares.Value = 5;
            heroStats.MovementSquares.StatValuetPositionX = 84;
            heroStats.MovementSquares.StatValuetPositionY = heroStats.MovementSquares.TextPositionY + 50;
        }

        public override bool ShowOldPaper { get => false; set { } }
        public override bool ShowScroll { get => showScroll; set => showScroll = value; }
        public override bool ShowBorder { get => false; set { } }

        public override int ScrollY { get => scrollY; set => scrollY = value;  }
        public override StatsType TypeOfStats { get => typeOfStats; set => typeOfStats = value; }

        public override CardDefaults Defaults => defaults;

        public override HeroStats HeroStats => heroStats;

        public override void UpdateUI()
        {

            // Create a copy of the blank image to overlay the card title.
            updatedCardImage = new Bitmap(base.blankImage);
            using (Graphics graphics = Graphics.FromImage(updatedCardImage))
            {
                // Set font and brush for the card title.
                Font titleFont = new Font(Title.FontName, Title.FontSize);
                Brush titleBrush = new SolidBrush(Title.FontColor);

                if (ShowScroll)
                {
                    int scrollX = (updatedCardImage.Width - (int)Properties.Resources.Name_Scroll.Width) / 2;
                    //Draw Scroll
                    graphics.DrawImage(Properties.Resources.Name_Scroll, scrollX, ScrollY, 560, 143);
                }

                // Calculate the position for the card title to center it on the image.
                int titleX = (updatedCardImage.Width - (int)graphics.MeasureString(Title.Text, titleFont).Width) / 2;
                int titleY = Title.PositionY;

                // Write the card title on the image.
                graphics.DrawString(Title.Text, titleFont, titleBrush, titleX, titleY);

                // Check if an overlay image is available.
                if (overlayImage != null)
                {
                    Rectangle destinationRectangle = new Rectangle(overlayRectangleX, overlayRectangleY, overlayRectangleWidth, overlayRectangleHeight);
                    //graphics.SetClip(destinationRectangle);

                    // Overlay the image on the card image.
                    graphics.DrawImage(overlayImage, new Rectangle(overlayX, overlayY, overlayImage.Width, overlayImage.Height), destinationRectangle, GraphicsUnit.Point);

                }

                if (CardText.Text != null)
                {
                    List<FormattedSegment> segments = new List<FormattedSegment>();
                    segments = TextFormatter.Format(graphics, CardText.Text, CardText.FontName, CardText.FontSize, CardText.FontColor);
                    TextFormatter.Write(graphics, CardText.PositionX, CardText.PositionY, new SolidBrush(CardText.FontColor), segments, CardText.MaxLenghtLine, updatedCardImage.Width, CardText.SpaceBetweenLines);
                }


                Image statsImage = null;
                switch (TypeOfStats)
                {
                    case StatsType.MONSTER:
                        //Draw Scroll
                        statsImage = Properties.Resources.Monster_Stat_Box;
                        break;
                    case StatsType.HERO:
                        statsImage = Properties.Resources.Hero_Stat_Box;
                        break;
                }

                if (statsImage != null)
                {
                    int statsX = (updatedCardImage.Width - (int)statsImage.Width) / 2;
                    graphics.DrawImage(statsImage, statsX, statsBoxY, statsImage.Width, statsImage.Height);

                    List<FormattedSegment> segments = new List<FormattedSegment>();
                    segments = TextFormatter.Format(graphics, heroStats.MovementSquares.Text, CardText.FontName, 20, CardText.FontColor);
                    TextFormatter.Write(graphics, heroStats.MovementSquares.TextPositionX, heroStats.MovementSquares.TextPositionY, new SolidBrush(CardText.FontColor), segments, heroStats.MovementSquares.MaxTextLenght, updatedCardImage.Width, CardText.SpaceBetweenLines);
                }
            }
        }

        internal bool PositionInOverlyRectangle(PictureBox p, int x, int y)
        {

            if (overlayImage != null)
            {
                ZoomFactor zf = new ZoomFactor();
                var zoomedOverlayBoundariesRectangle = zf.TranslateSelectionToZoomedSel(new Rectangle(overlayRectangleX, overlayRectangleY, overlayRectangleWidth, overlayRectangleHeight), p.Size, updatedCardImage.Size);
                var zoomedOverlayImageRectangle = zf.TranslateSelectionToZoomedSel(new Rectangle(overlayX, overlayY, overlayImage.Width, overlayImage.Height), p.Size, updatedCardImage.Size);

                var intersectRectangle = Rectangle.Intersect(Rectangle.Round(zoomedOverlayBoundariesRectangle), Rectangle.Round(zoomedOverlayImageRectangle));

                System.Console.WriteLine(String.Format("Checking boundaries -> X:{0}, Y:{1}, OverlayX:{2}, OverlayY:{3}, MaxX:{4}, MaxY:{5}",
                    x,
                    y,
                    intersectRectangle.X,
                    intersectRectangle.Y,
                    intersectRectangle.X + intersectRectangle.Width,
                    intersectRectangle.Y + intersectRectangle.Height));

                return (x > intersectRectangle.X &&
                    x < intersectRectangle.X + intersectRectangle.Width &&
                    y > intersectRectangle.Y &&
                    y < intersectRectangle.Y + intersectRectangle.Height);
            }

            return false;
        }

        public override Rectangle GetOverlayImageBoundaries()
        {
            return new Rectangle(overlayRectangleX, overlayRectangleY, overlayRectangleWidth, overlayRectangleHeight);
        }
    }
}


