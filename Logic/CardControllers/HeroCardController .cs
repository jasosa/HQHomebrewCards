using System;
using System.Collections.Generic;
using System.Drawing;
using HQHomebrewCards.Logic;

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
            backgroundImageHandler = new ImageElement(Properties.Resources.Hero_Card_Front, false);                                    
            
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

            title = new TextElement(defaults.DEFAULT_TITLE_FONT_NAME, defaults.DEFAULT_TITLE_FONT_SIZE, 0, defaults.DEFAULT_TITLE_POSITION_Y, defaults.DEFAULT_TITLE_FONT_COLOR, 0, 0, string.Empty);
            title.TextUpdated += Title_TextUpdated;
            bodytext = new TextElement(defaults.DEFAULT_TEXT_FONT_NAME, defaults.DEFAULT_TEXT_FONT_SIZE, defaults.DEFAULT_TEXT_POSITION_X, defaults.DEFAULT_TEXT_POSITION_Y, defaults.DEFAULT_TEXT_FONT_COLOR, 5, defaults.DEFAULT_TEXT_LENGHT, string.Empty);
            bodytext.TextUpdated += Title_TextUpdated;
            
            showScroll = true;
            scrollY = defaults.DEFAULT_SCROLL_Y;
            typeOfStats = StatsType.NONE;
            statsBoxY = 750;
            heroStats = new HeroStats();
            heroStats.MovementSquares.MaxTextLenght = 200;
            heroStats.MovementSquares.TextPositionX= 84;
            heroStats.MovementSquares.TextPositionY = statsBoxY + 40;
            heroStats.MovementSquares.Value = 5;
            heroStats.MovementSquares.StatValuetPositionX = 84;
            heroStats.MovementSquares.StatValuetPositionY = heroStats.MovementSquares.TextPositionY + 50;
        }

        public override bool ShowOldPaper { get => false; set { } }
        public override bool ShowScroll
        {
            get => showScroll;
            set
            {
                showScroll = value;
                OnImageUpdated(new EventArgs());
            }
        }
        public override bool ShowBorder { get => false; set { } }

        public override int ScrollY { get => scrollY; set => scrollY = value;  }
        public override StatsType TypeOfStats { get => typeOfStats; set => typeOfStats = value; }

        public override CardDefaults Defaults => defaults;

        public override HeroStats HeroStats => heroStats;

        public override void AddOverlyImage(Image image)
        {
            overlayCardHandler = new ImageElement(image, 0, 0, 742, 1045, true);
            overlayCardHandler.ImageHandlerUpdated += OverlayCardHandler_ImageHandlerUpdated;
            OnImageUpdated(new EventArgs());
        }

        public override void UpdateUI()
        {
            // Reset the current image to paint on it
            backgroundImageHandler.UpdateImage(new Bitmap(backgroundImageHandler.OriginalImage));
            using (Graphics graphics = Graphics.FromImage(backgroundImageHandler.UpdatedImage))
            {
                // Set font and brush for the card title.
                Font titleFont = new Font(Title.FontName, Title.FontSize);
                Brush titleBrush = new SolidBrush(Title.FontColor);

                // Check if an overlay image is available.
                if (OverlyImage != null)
                {
                    //Rectangle destinationRectangle = new Rectangle(OverlyImage.DrawnLimitX, OverlyImage.DrawnLimitYY, OverlyImage.DrawnLimitWidth, OverlyImage.DrawnLimitHeight);

                    // Overlay the image on the card image.
                    graphics.DrawImage(OverlyImage.UpdatedImage, new Rectangle(OverlyImage.PositionX, OverlyImage.PositionY, OverlyImage.UpdatedImage.Width, OverlyImage.UpdatedImage.Height));//, destinationRectangle, GraphicsUnit.Point);

                }

                if (ShowScroll)
                {
                    int scrollX = (backgroundImageHandler.UpdatedImage.Width - (int)Properties.Resources.Name_Scroll.Width) / 2;
                    //Draw Scroll
                    graphics.DrawImage(Properties.Resources.Name_Scroll, scrollX, ScrollY, 560, 143);
                }

                // Calculate the position for the card title to center it on the image.
                int titleX = (backgroundImageHandler.UpdatedImage.Width - (int)graphics.MeasureString(Title.Text, titleFont).Width) / 2;
                int titleY = Title.PositionY;

                // Write the card title on the image.
                graphics.DrawString(Title.Text, titleFont, titleBrush, titleX, titleY);             

                if (CardText.Text != null)
                {
                    List<FormattedSegment> segments = new List<FormattedSegment>();
                    segments = TextFormatter.Format(graphics, CardText.Text, CardText.FontName, CardText.FontSize, CardText.FontColor);
                    TextFormatter.Write(graphics, CardText.PositionX, CardText.PositionY, new SolidBrush(CardText.FontColor), segments, CardText.MaxLenghtLine, backgroundImageHandler.UpdatedImage.Width, CardText.SpaceBetweenLines);
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
                    int statsX = (backgroundImageHandler.UpdatedImage.Width - (int)statsImage.Width) / 2;
                    graphics.DrawImage(statsImage, statsX, statsBoxY, statsImage.Width, statsImage.Height);

                    List<FormattedSegment> segments = new List<FormattedSegment>();
                    segments = TextFormatter.Format(graphics, heroStats.MovementSquares.Text, CardText.FontName, 20, CardText.FontColor);
                    TextFormatter.Write(graphics, heroStats.MovementSquares.TextPositionX, heroStats.MovementSquares.TextPositionY, new SolidBrush(CardText.FontColor), segments, heroStats.MovementSquares.MaxTextLenght, backgroundImageHandler.UpdatedImage.Width, CardText.SpaceBetweenLines);
                }
            }
        }
       
    }
}


