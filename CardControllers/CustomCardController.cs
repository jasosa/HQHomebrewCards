﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HQHomebrewCards
{
    public class CustomCardController : CardController
    {
        private bool showScroll;
        private bool showBorder;
        private StatsType typeOfStats;
        private int scrollY;
       
 
        public override bool Setup_CanAddBorder => true;
        
        public override bool Setup_HasOldPaper { get => false; }

        public override bool Setup_HasScroll { get => true; }

        public CustomCardController() {

            backgroundImageHandler = new ImageCardHandler(Properties.Resources.Custom);
            CardText.SpaceBetweenLines = 5;
            showScroll = true;
            showBorder = false;

            typeOfStats = StatsType.NONE;
            
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
                DEFAULT_SHOW_STATS = StatsType.NONE,
                DEFAULT_SCROLL_Y = 840,
            };
        }


        public override bool ShowOldPaper { get => false; set { } }

        public override bool ShowScroll { get => showScroll; set => showScroll = value; }
        public override bool ShowBorder { get => showBorder; set => showBorder = value; }

        public override StatsType TypeOfStats { get => typeOfStats; set => typeOfStats = value; }

        public override CardDefaults Defaults => defaults;

        public override HeroStats HeroStats => new HeroStats();

        public override int ScrollY { get => scrollY; set => scrollY = value; }

        public override void AddOverlyImage(Image image)
        {
            overlayCardHandler = new ImageCardHandler(image, 0, 0, 742, 1045);
            //overlayCardHandler.DrawnLimitX = 0;
            //overlayCardHandler.DrawnLimitYY = 0;
            //overlayCardHandler.DrawnLimitWidth = 742;
            //overlayCardHandler.DrawnLimitHeight = 1045;
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
                if (OverlyImage!= null)
                {
                    // Overlay the image on the card image.
                    graphics.DrawImage(OverlyImage.UpdatedImage, new Rectangle(OverlyImage.PositionX, OverlyImage.PositionY, OverlyImage.UpdatedImage.Width, OverlyImage.UpdatedImage.Height));
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

                if (showBorder){
                    graphics.DrawImage(Properties.Resources.backborderbig2, 0, 0, backgroundImageHandler.UpdatedImage.Width, backgroundImageHandler.UpdatedImage.Height);
                }
            }
        }
    }
}
