namespace HQHomebrewCards
{
    using System;
    using System.Drawing;
    using System.Drawing.Text;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class CardDesignerForm : Form
    {
        private ICardController cardController;
        

        
        private const int DEFAULT_TITLE_POSITION_Y = 80;
        
        // Stats
        private bool dragging;
        private int mousePosX;
        private int mousePosY;        

        internal enum CardControllerType
        {
            GENERIC,
            HERO,
            CUSTOM
        }

        public CardDesignerForm()
        {            
            InitializeComponent();            
            InitializeCardController(CardControllerType.GENERIC);            
            InitializeEventHandlers();
            LoadDefaultValues();
            LoadInstalledFonts();
            SetupControls();
            //RefreshUIInfo();
        }

        private void SetupControls()
        {
        }

        private void InitializeEventHandlers()
        {
            cardTextXnud.ValueChanged += CardTextX_ValueChanged;
            cardTextYnud.Maximum = 2000;
            cardTextYnud.ValueChanged += CardTextY_ValueChanged;
            cardTextYnud.Maximum = 2000;

            cardTextLenghtNumUpDown.ValueChanged += CardTextLenghtNumUpDown_ValueChanged;
            cardTextLenghtNumUpDown.Maximum = 2000;

            titleFontSizeNumUpDown.ValueChanged += FontSize_ValueChanged;
            cardFontSizeNumUpDown.ValueChanged += CardFontSizeNumUpDown_ValueChanged;
        }

        private void LoadDefaultValues()
        {
            //cardController.Title.FontSize = cardController.Defaults.DEFAULT_TITLE_FONT_SIZE;
            //cardController.Title.FontName = cardController.Defaults.DEFAULT_TITLE_FONT_NAME;
            //cardController.Title.FontColor = cardController.Defaults.DEFAULT_TITLE_FONT_COLOR;
            //cardController.Title.PositionY = cardController.Defaults.DEFAULT_TITLE_POSITION_Y;
            //cardController.Title.Text = "";
            //cardController.CardText.FontSize = cardController.Defaults.DEFAULT_TEXT_FONT_SIZE;
            //cardController.CardText.FontName = cardController.Defaults.DEFAULT_TEXT_FONT_NAME;
            //cardController.CardText.FontColor = cardController.Defaults.DEFAULT_TEXT_FONT_COLOR;
            //cardController.CardText.PositionX = cardController.Defaults.DEFAULT_TEXT_POSITION_X;
            //cardController.CardText.PositionY = cardController.Defaults.DEFAULT_TEXT_POSITION_Y;
            //cardController.CardText.MaxLenghtLine = cardController.Defaults.DEFAULT_TEXT_LENGHT;
            //cardController.CardText.Text = "";
            //cardController.ShowOldPaper = cardController.Defaults.DEFAULT_SHOW_OLD_PAPER;
            //cardController.TypeOfStats = cardController.Defaults.DEFAULT_SHOW_STATS;
            //cardController.ScrollY = cardController.Defaults.DEFAULT_SCROLL_Y;
        }

        private void InitializeCardController(CardControllerType type)
        {
         
            if (type == CardControllerType.GENERIC)
            {
                cardController = new GenericCardController();
            }
            else if (type == CardControllerType.HERO)
            {
                cardController = new HeroCardController();                
            }
            else
            {
                cardController = new CustomCardController();
            }

            cardController.ImageUpdated += CardController_ImageUpdated;
        }

        private void CardController_ImageUpdated(object sender, EventArgs e)
        {
            RefreshUIInfo();
            UpdatePreview();
        }

        private void RefreshUIInfo()
        {
            //titleTextBox.Text = cardController.Title.Text;
            //titleFontFamily.SelectedItem = cardController.Title.FontName;
            //titleFontSizeNumUpDown.Value = cardController.Title.FontSize;            

            //cardTextBox.Text = cardController.CardText.Text;            
            //cardFontFamily.SelectedItem = cardController.CardText.FontName;
            //cardTextXnud.Value = cardController.CardText.PositionX;
            //cardTextYnud.Value = cardController.CardText.PositionY;
            //cardTextLenghtNumUpDown.Value = cardController.CardText.MaxLenghtLine;            
            //cardFontSizeNumUpDown.Value = cardController.CardText.FontSize;

            cbShowBorder.Enabled = cardController.Setup_CanAddBorder;
            cbOldPaper.Enabled = cardController.Setup_HasOldPaper;
            showScrollcb.Enabled = cardController.Setup_HasScroll;

            cbOldPaper.Checked = cardController.ShowOldPaper;
            showScrollcb.Checked = cardController.ShowScroll;
            cbShowBorder.Checked = cardController.ShowBorder;

            //cbStats.SelectedItem = cardController.TypeOfStats.ToString();
            //movementSquarestextBox.Text = cardController.HeroStats.MovementSquares.Text;
            //statValueNum.Value = cardController.HeroStats.MovementSquares.Value;
            //movementSquaresX.Value = cardController.HeroStats.MovementSquares.TextPositionX;
            //movementSquaresY.Value = cardController.HeroStats.MovementSquares.TextPositionY;
            //movementSquaresMaxLenght.Value = cardController.HeroStats.MovementSquares.MaxTextLenght;

            //individualStatsCombo.Items.Clear();
            //individualStatsCombo.Items.Add(cardController.HeroStats.MovementSquares.Text);
            //individualStatsCombo.Items.Add(cardController.HeroStats.AttackDice.Text);
            //individualStatsCombo.Items.Add(cardController.HeroStats.DefendDice.Text);
            //individualStatsCombo.Items.Add(cardController.HeroStats.BodyPoints.Text);
            //individualStatsCombo.Items.Add(cardController.HeroStats.MindPoints.Text);

            moveImageDownButton.Enabled = cardController.OverlyImage != null && cardController.OverlyImage.OriginalImage != null;
            moveImageRightButton.Enabled = cardController.OverlyImage != null && cardController.OverlyImage.OriginalImage != null;
            moveLeftButton.Enabled = cardController.OverlyImage != null && cardController.OverlyImage.OriginalImage != null;
            moveImageUpButton.Enabled = cardController.OverlyImage != null && cardController.OverlyImage.OriginalImage != null;
            RemoveImageButton.Enabled = cardController.OverlyImage != null &&  cardController.OverlyImage.OriginalImage != null;
            makeImageSmallerButton.Enabled = cardController.OverlyImage != null && cardController.OverlyImage.OriginalImage != null;
            makeImageBiggerButton.Enabled = cardController.OverlyImage != null && cardController.OverlyImage.OriginalImage != null;

        }

        private void UpdatePreview()
        {
            //cardController.UpdateUI();
            pbPreview.Image = cardController.BackgroundImage.UpdatedImage;
        }


        private void MoveOverlayImage(int deltaX, int deltaY)
        {
            if (cardController.OverlyImage.UpdatedImage != null)
            {
                using (Graphics graphics = Graphics.FromImage(cardController.BackgroundImage.UpdatedImage))
                {
                    // Calculate the new position for the overlay image
                    int x = cardController.OverlyImage.PositionX + deltaX;
                    int y = cardController.OverlyImage.PositionY + deltaY;
                    cardController.MoveOverlyImage(x, y);                    
                }
            }
        }

        //private void CalculateOverlayPosition(Image overlay, int newOverlayX, int newOverlayY)
        //{   
        //    int x = newOverlayX != -1 ? newOverlayX : ((cardController.BackgroundImage.OriginalImage.Width - overlay.Width) / 2);
        //    int y = newOverlayY != -1 ? newOverlayY : ((cardController.BackgroundImage.OriginalImage.Height - overlay.Height) / 2);
        //    cardController.MoveOverlyImage(x, y);
        //}        

        private void LoadInstalledFonts()
        {
            InstalledFontCollection installedFonts = new InstalledFontCollection();
            foreach (FontFamily fontFamily in installedFonts.Families)
            {
                titleFontFamily.Items.Add(fontFamily.Name);
                cardFontFamily.Items.Add(fontFamily.Name);
            }

            // Add an event handler for the SelectedIndexChanged event
            titleFontFamily.SelectedIndexChanged += FontComboBox_SelectedIndexChanged;
            cardFontFamily.SelectedIndexChanged += CardFontFamily_SelectedIndexChanged;

            // Set the default selected font in the ComboBox
            titleFontFamily.SelectedItem = cardController.Defaults.DEFAULT_TITLE_FONT_NAME;
            cardFontFamily.SelectedItem = cardController.Defaults.DEFAULT_TEXT_FONT_NAME;

            cbStats.Items.Clear();
            cbStats.Items.Add(StatsType.NONE.ToString());
            cbStats.Items.Add(StatsType.HERO.ToString());
            cbStats.Items.Add(StatsType.MONSTER.ToString());
        }      


      private void LoadCardDesign(string path)
        {
            CardSerializer s = new CardSerializer();
            try
            {
                var tmpCardController = s.Deserialize(path, cardController.GetType());


                Image overlyImage;
                if (File.Exists(path + ".overlay"))
                {
                    using (var bmpTemp = new Bitmap(path + ".overlay"))
                    {
                        overlyImage = new Bitmap(bmpTemp);
                    }

                    tmpCardController.AddOverlyImage(overlyImage);                    
                }
                
                cardController = tmpCardController;
                //RefreshUIInfo();                
                //UpdatePreview();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }       

        private void SaveCardDesign(string path)
        {
            CardSerializer s = new CardSerializer();
            s.Serialize(cardController, path);
            if (cardController.OverlyImage.OriginalImage != null)
            {   
                if (File.Exists(path + ".overlay"))
                {
                    File.Delete(path + ".overlay");
                }
                cardController.OverlyImage.OriginalImage.Save(path + ".overlay");                
            }
        }

        private void SaveImage(string path)
        {
            Bitmap bmp = new Bitmap(pbPreview.Image);
            bmp.SetResolution(300, 300);
            bmp.Save(path);
        }


        #region Event Handlers

        private void saveCardDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (saveCardDialog.FileName != string.Empty)
            {
                if (saveCardDialog.Title == "Save card design")
                {
                    SaveCardDesign(saveCardDialog.FileName);
                }
                else
                {
                    SaveImage(saveCardDialog.FileName);
                }

            }
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            // Initialize the OpenFileDialog control.
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
            openFileDialog.Title = "Select an Image";

            // Show the OpenFileDialog to select an image to overlay on the card.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cardController.AddOverlyImage(Image.FromFile(openFileDialog.FileName));
                CenterOverlymage();
                // Update the card image with the new overlay image.
                //UpdateCardUI();
            }
        }

        private void RemoveImageButton_Click(object sender, EventArgs e)
        {
            // Remove the overlay image.
            cardController.RemoveOverlyImage();
        }

        private void moveImageUpButton_Click(object sender, EventArgs e)
        {
            MoveOverlayImage(0, -10); // Move the image upward by 10 pixels (adjust as needed)
        }

        private void moveImageDownButton_Click(object sender, EventArgs e)
        {
            MoveOverlayImage(0, 10); // Move the image downard by 10 pixels (adjust as needed)            
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            MoveOverlayImage(-10, 0);            
        }

        private void moveImageRightButton_Click(object sender, EventArgs e)
        {
            MoveOverlayImage(10, 0);            
        }

        private void makeImageBigger_Click(object sender, EventArgs e)
        {
            cardController.OverlyImage.ZoomIn();
        }

        private void makeImageSmallerButton_Click(object sender, EventArgs e)
        {
            cardController.OverlyImage.ZoomOut();                                   
        }

        private void CenterOverlymage()
        {
            int x = ((cardController.BackgroundImage.OriginalImage.Width - cardController.OverlyImage.UpdatedImage.Width) / 2);
            int y = ((cardController.BackgroundImage.OriginalImage.Height - cardController.OverlyImage.UpdatedImage.Height) / 2);
            cardController.MoveOverlyImage(x, y);
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardController.Title.FontName = titleFontFamily.SelectedItem.ToString();

            // Call UpdateCardUI to update the card image with the new font
            UpdatePreview();
        }

        private void CardFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the selectedCardFontName when the user selects a different font
            cardController.CardText.FontName = cardFontFamily.SelectedItem.ToString();

            // Call UpdateCardUI to update the card image with the new font
            UpdatePreview();
        }

        private void FontSize_ValueChanged(object sender, EventArgs e)
        {
            cardController.Title.FontSize = (int)titleFontSizeNumUpDown.Value;            
        }

        private void CardFontSizeNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            cardController.CardText.FontSize = (int)cardFontSizeNumUpDown.Value;            
        }

        private void CardTextY_ValueChanged(object sender, EventArgs e)
        {
            cardController.CardText.PositionY = (int)cardTextYnud.Value;
            UpdatePreview();
        }

        private void CardTextX_ValueChanged(object sender, EventArgs e)
        {
            cardController.CardText.PositionX = (int)cardTextXnud.Value;
            UpdatePreview();
        }

        private void CardTextLenghtNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            cardController.CardText.MaxLenghtLine = (int)cardTextLenghtNumUpDown.Value;
            UpdatePreview();
        }

        private void fontColorButton_Click(object sender, EventArgs e)
        {
            // Create a ColorDialog to allow the user to select a font color
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = cardController.Title.FontColor; // Set the current color

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Update the selectedFontColor with the user-selected color
                cardController.Title.FontColor = colorDialog.Color;

                // Call UpdateCardUI to update the card image with the new font color
                UpdatePreview();
            }
        }


        private void selectCardTextolor_Click(object sender, EventArgs e)
        {
            // Create a ColorDialog to allow the user to select a font color
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = cardController.CardText.FontColor; // Set the current color

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Update the selectedFontColor with the user-selected color
                cardController.CardText.FontColor = colorDialog.Color;

                // Call UpdateCardUI to update the card image with the new font color
                UpdatePreview();
            }
        }

        private void moveTitleUp_Click(object sender, EventArgs e)
        {
            cardController.Title.PositionY -= 5;
            UpdatePreview();
        }

        private void moveTitleDown_Click(object sender, EventArgs e)
        {
            cardController.Title.PositionY += 5;
            UpdatePreview();
        }

        private void resetTitlePosition_Click(object sender, EventArgs e)
        {
            cardController.Title.PositionY = DEFAULT_TITLE_POSITION_Y;
            UpdatePreview();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            // Update the card title with the text entered in the titleTextBox.
            cardController.Title.Text = titleTextBox.Text;
            UpdatePreview();
        }

        private void cardTextBox_TextChanged(object sender, EventArgs e)
        {
            cardController.CardText.Text = cardTextBox.Text;            
        }

        private void cbOldPaper_CheckedChanged(object sender, EventArgs e)
        {
            cardController.ShowOldPaper = cbOldPaper.Checked;            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            saveCardDialog.Title = "Save card design";
            saveCardDialog.Filter = "XML card files(*.xml)| *.xml";
            saveCardDialog.FileName = titleTextBox.Text;
            saveCardDialog.FilterIndex = 1;
            saveCardDialog.ShowDialog();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            saveCardDialog.Title = "Export image";
            saveCardDialog.Filter = "Image files(*.png)| *.png";
            saveCardDialog.FilterIndex = 1;
            saveCardDialog.ShowDialog();
        }

        private void btLoadcard_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Load card design";
            openFileDialog.Filter = "XML Card files(*.xml)| *.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName != string.Empty)
            {
                LoadCardDesign(String.Format(openFileDialog.FileName));
            }
        }

        #endregion

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {                
                dragging = true;
                mousePosX = e.X;
                mousePosY = e.Y;
                Console.WriteLine(String.Format("Start Dragging. X:{0} Y:{1}", e.X, e.Y));
                Console.WriteLine(String.Format("Start Dragging. MouseX:{0} MouseY:{1}", mousePosX, mousePosY));
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {            
            Control c = sender as Control;            
            if (dragging && c != null)
            {
                if (clickOnvalidRegion(e.X, e.Y))
                {
                    System.Console.WriteLine(String.Format("Overly movement -> X:{0} Y:{1}", e.X - mousePosX, e.Y - mousePosY));
                    cardController.OverlyImage.PositionX += (e.X - mousePosX);
                    cardController.OverlyImage.PositionY += (e.Y - mousePosY);
                    mousePosX = e.X;
                    mousePosY = e.Y;
                    UpdatePreview();
                }
               

            }
        }

        //Check if the click in on the intersection of the overly image boundaries and the image itself
        private bool clickOnvalidRegion(int x, int y)
        {
            ZoomFactor zf = new ZoomFactor();
            var zoomedBoundariesRectangle = zf.TranslateSelectionToZoomedSel(cardController.OverlyImage.GetImageBoundaries(), pbPreview.Size, cardController.BackgroundImage.UpdatedImage.Size);
            var zoomedOverlayRectangle = zf.TranslateSelectionToZoomedSel(
                new RectangleF(cardController.OverlyImage.PositionX, cardController.OverlyImage.PositionY,
                cardController.OverlyImage.UpdatedImage.Width,
                cardController.OverlyImage.UpdatedImage.Height), pbPreview.Size, cardController.BackgroundImage.OriginalImage.Size);

            var intersectRectangle = Rectangle.Intersect(Rectangle.Round(zoomedBoundariesRectangle), Rectangle.Round(zoomedOverlayRectangle));

            return intersectRectangle.Contains(new Point(x, y));
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine(String.Format("Stop Dragging. X:{0}, MouseX:{1}, DeltaX:{2}, Y:{3}, MouseY:{4}, DeltaY:{5}", e.X, mousePosX, e.X - mousePosX, e.Y, mousePosY,  e.Y - mousePosY));
            dragging = false;
        }

        private void pbHeroCard_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to change the card type? The progress with the current design will be lost", "Change card type", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                InitializeCardController(CardControllerType.HERO);
                LoadDefaultValues();
                RefreshUIInfo();
                UpdatePreview();
                panelCardTypes.Visible = false;
            }
        }

        private void pbGenericCard_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to change the card type? The progress with the current design will be lost", "Change card type", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                InitializeCardController(CardControllerType.GENERIC);
                LoadDefaultValues();
                RefreshUIInfo();
                UpdatePreview();
                panelCardTypes.Visible = false;
            }
        }

        private void pbCustomCard_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to change the card type The progress with the current design will be lost", "Change card type", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                InitializeCardController(CardControllerType.CUSTOM);
                LoadDefaultValues();
                RefreshUIInfo();
                UpdatePreview();
                panelCardTypes.Visible = false;
            }
        }

        private void CardDesignerForm_Load(object sender, EventArgs e)
        {

        }

        private void cbStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStats.SelectedItem.ToString() == StatsType.HERO.ToString())
            {
                //Add Hero Stats                
                cardController.TypeOfStats = StatsType.HERO; ;
            }
            else if (cbStats.SelectedItem.ToString() == StatsType.MONSTER.ToString())
            {
                // Add Monster Stats                
                cardController.TypeOfStats = StatsType.MONSTER;
            }
            else if (cbStats.SelectedItem.ToString() == StatsType.NONE.ToString())
            {
                //Remove Stats                
                cardController.TypeOfStats = StatsType.NONE;
            }

            UpdatePreview();
        }

        private void showScrollcb_CheckedChanged(object sender, EventArgs e)
        {
            cardController.ShowScroll = showScrollcb.Checked;
            UpdatePreview();
        }

        private void movementSquarestextBox_TextChanged(object sender, EventArgs e)
        {
            cardController.HeroStats.MovementSquares.Text = movementSquarestextBox.Text;
            UpdatePreview();
        }

        private void movementSquaresX_ValueChanged(object sender, EventArgs e)
        {
            cardController.HeroStats.MovementSquares.TextPositionX = (int) movementSquaresX.Value;
            UpdatePreview();
        }

        private void movementSquaresY_ValueChanged(object sender, EventArgs e)
        {
            cardController.HeroStats.MovementSquares.TextPositionY = (int)movementSquaresY.Value;
            UpdatePreview();
        }

        private void movementSquaresRtb_TextChanged(object sender, EventArgs e)
        {
            cardController.HeroStats.MovementSquares.Text = movementSquarestextBox.Text;
            UpdatePreview();
        }

        private void movementSquaresMaxLenght_ValueChanged(object sender, EventArgs e)
        {
            cardController.HeroStats.MovementSquares.MaxTextLenght = (int)movementSquaresMaxLenght.Value;
            UpdatePreview();
        }

        private void cbShowBorder_CheckedChanged(object sender, EventArgs e)
        {
            cardController.ShowBorder = cbShowBorder.Checked;
            UpdatePreview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCardTypes.Visible = !panelCardTypes.Visible;            
        }
    }

}
