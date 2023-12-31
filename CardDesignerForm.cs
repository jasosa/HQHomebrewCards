﻿namespace HQHomebrewCards
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
        

        private const string DEFAULT_TITLE_FONT_NAME = "CarterSansW01-SmBd"; // Default font
        private const int DEFAULT_TITLE_FONT_SIZE = 40; // Default font size
        private Color DEAFULT_TITLE_FONT_COLOR = Color.Black; // Default title color
        private const int DEFAULT_TITLE_POSITION_Y = 80;
        

        private const string DEFAULT_CARD_TEXT_FONT_NAME = "CarterSansW01-Regular"; // Default font        
        private const int DEFAULT_CARD_FONT_SIZE = 28; // Default font size        
        private Color DEFAULT_TEXT_FONT_COLOR = Color.Black; // Default text color
        private int DEFAULT_TEXT_POSITION_X = 80;
        private int DEFAULT_TEXT_POSITION_Y = 600;
        private int DEFAULT_TEXT_LENGHT = 600;
        private bool dragging;
        private int mousePosX;
        private int mousePosY;        

        internal enum CardControllerType
        {
            GENERIC,
            HERO
        }

        public CardDesignerForm()
        {            
            InitializeComponent();
            InitializeCardController(CardControllerType.GENERIC);
            InitializeEventHandlers();
            LoadDefaultValues();
            LoadInstalledFonts();            
            RefreshUIInfo();
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
            cardController.TitleFontSize = DEFAULT_TITLE_FONT_SIZE;
            cardController.TitleFontName = DEFAULT_TITLE_FONT_NAME;
            cardController.TitleFontColor = DEAFULT_TITLE_FONT_COLOR;
            cardController.TitlePositionY = DEFAULT_TITLE_POSITION_Y;
            cardController.TitleText = "";

            cardController.CardFontSize = DEFAULT_CARD_FONT_SIZE;
            cardController.CardFontName = DEFAULT_CARD_TEXT_FONT_NAME;
            cardController.CardFontColor = DEFAULT_TEXT_FONT_COLOR;
            cardController.CardTextX = DEFAULT_TEXT_POSITION_X;
            cardController.CardTextY = DEFAULT_TEXT_POSITION_Y;
            cardController.CardTextLineSize = DEFAULT_TEXT_LENGHT;
            cardController.CardText = "";
            cardController.ShowOldPaper = false;            
            
        }

        private void InitializeCardController(CardControllerType type)
        {   
            if (type == CardControllerType.GENERIC)
            {
                cardController = new GenericCardController();                
            }
            else
            {
                cardController = new HeroCardController();                
            }

          
        }

        private void RefreshUIInfo()
        {
            titleTextBox.Text = cardController.TitleText;
            titleFontFamily.SelectedItem = cardController.TitleFontName;
            titleFontSizeNumUpDown.Value = cardController.TitleFontSize;            

            cardTextBox.Text = cardController.CardText;            
            cardFontFamily.SelectedItem = cardController.CardFontName;
            cardTextXnud.Value = cardController.CardTextX;
            cardTextYnud.Value = cardController.CardTextY;
            cardTextLenghtNumUpDown.Value = cardController.CardTextLineSize;            
            cardFontSizeNumUpDown.Value = cardController.CardFontSize;
            cbOldPaper.Checked = cardController.ShowOldPaper;
        }

        private void UpdateCardUI()
        {
            cardController.UpdateUI();
            pictureBox.Image = cardController.UdpatedCardImage;
        }


        private void MoveOverlayImage(int deltaX, int deltaY)
        {
            if (cardController.GetUpdatedOverlyImage() != null)
            {
                using (Graphics graphics = Graphics.FromImage(cardController.UdpatedCardImage))
                {
                    // Calculate the new position for the overlay image
                    int newOverlayX = cardController.OverlayX + deltaX;
                    int newOverlayY = cardController.OverlayY + deltaY;
                    CalculateOverlayPosition(cardController.GetUpdatedOverlyImage(), newOverlayX, newOverlayY);
                }
            }
        }

        private void CalculateOverlayPosition(Image overlay, int newOverlayX, int newOverlayY)
        {
            // Calculate the position to center the overlay image on the card image.
            if (newOverlayX != -1)
            {
                cardController.OverlayX = newOverlayX;
            }
            else
            {
                cardController.OverlayX = ((cardController.OriginalCardImage.Width - overlay.Width) / 2);

            }


            if (newOverlayY != -1)
            {
                cardController.OverlayY = newOverlayY;
            }
            else
            {
                cardController.OverlayY = ((cardController.OriginalCardImage.Height - overlay.Height) / 2);
            }
        }        

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
            titleFontFamily.SelectedItem = DEFAULT_TITLE_FONT_NAME;
            cardFontFamily.SelectedItem = DEFAULT_CARD_TEXT_FONT_NAME;
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
                    tmpCardController.UpdateOverlyImage(tmpCardController.ZoomOverlay);
                }
                
                cardController = tmpCardController;
                RefreshUIInfo();                
                UpdateCardUI();
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
            if (cardController.GetOriginalOverlyImage() != null)
            {   
                if (File.Exists(path + ".overlay"))
                {
                    File.Delete(path + ".overlay");
                }
                cardController.GetOriginalOverlyImage().Save(path + ".overlay");                
            }
        }

        private void SaveImage(string path)
        {
            Bitmap bmp = new Bitmap(pictureBox.Image);
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
                OverlayZoom.SetDefaultZoom();            

                CalculateOverlayPosition(cardController.GetOriginalOverlyImage(), -1, -1);
                // Update the card image with the new overlay image.
                UpdateCardUI();
            }
        }

        private void RemoveImageButton_Click(object sender, EventArgs e)
        {
            // Remove the overlay image.
            cardController.RemoveOverlyImage();

            // Update the card image without the overlay image.
            UpdateCardUI();
        }

        private void moveImageUpButton_Click(object sender, EventArgs e)
        {
            MoveOverlayImage(0, -10); // Move the image upward by 10 pixels (adjust as needed)
            UpdateCardUI();
        }

        private void moveImageDownButton_Click(object sender, EventArgs e)
        {
            MoveOverlayImage(0, 10); // Move the image downard by 10 pixels (adjust as needed)
            UpdateCardUI();
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            MoveOverlayImage(-10, 0);
            UpdateCardUI();
        }

        private void moveImageRightButton_Click(object sender, EventArgs e)
        {

            MoveOverlayImage(10, 0);
            UpdateCardUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cardController.UpdateOverlyImage(OverlayZoom.GoToNextZoom());
            CenterImage();
            UpdateCardUI();
        }

        private void makeImageSmallerButton_Click(object sender, EventArgs e)
        {
            cardController.UpdateOverlyImage(OverlayZoom.GoToPreviousZoom());
            CenterImage();
            UpdateCardUI();
        }

        private void CenterImage()
        {
            cardController.OverlayX = ((cardController.OriginalCardImage.Width - cardController.GetUpdatedOverlyImage().Width) / 2);
            cardController.OverlayY = ((cardController.OriginalCardImage.Height - cardController.GetUpdatedOverlyImage().Height) / 2);
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardController.TitleFontName = titleFontFamily.SelectedItem.ToString();

            // Call UpdateCardUI to update the card image with the new font
            UpdateCardUI();
        }

        private void CardFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the selectedCardFontName when the user selects a different font
            cardController.CardFontName = cardFontFamily.SelectedItem.ToString();

            // Call UpdateCardUI to update the card image with the new font
            UpdateCardUI();
        }

        private void FontSize_ValueChanged(object sender, EventArgs e)
        {
            cardController.TitleFontSize = (int)titleFontSizeNumUpDown.Value;
            UpdateCardUI();
        }

        private void CardFontSizeNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            cardController.CardFontSize = (int)cardFontSizeNumUpDown.Value;
            UpdateCardUI();
        }

        private void CardTextY_ValueChanged(object sender, EventArgs e)
        {
            cardController.CardTextY = (int)cardTextYnud.Value;
            UpdateCardUI();
        }

        private void CardTextX_ValueChanged(object sender, EventArgs e)
        {
            cardController.CardTextX = (int)cardTextXnud.Value;
            UpdateCardUI();
        }

        private void CardTextLenghtNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            cardController.CardTextLineSize = (int)cardTextLenghtNumUpDown.Value;
            UpdateCardUI();
        }

        private void fontColorButton_Click(object sender, EventArgs e)
        {
            // Create a ColorDialog to allow the user to select a font color
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = cardController.TitleFontColor; // Set the current color

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Update the selectedFontColor with the user-selected color
                cardController.TitleFontColor = colorDialog.Color;

                // Call UpdateCardUI to update the card image with the new font color
                UpdateCardUI();
            }
        }


        private void selectCardTextolor_Click(object sender, EventArgs e)
        {
            // Create a ColorDialog to allow the user to select a font color
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = cardController.CardFontColor; // Set the current color

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Update the selectedFontColor with the user-selected color
                cardController.CardFontColor = colorDialog.Color;

                // Call UpdateCardUI to update the card image with the new font color
                UpdateCardUI();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cardController.TitlePositionY -= 5;
            UpdateCardUI();
        }

        private void moveImageDown_Click(object sender, EventArgs e)
        {
            cardController.TitlePositionY += 5;
            UpdateCardUI();
        }

        private void resetTitlePosition_Click(object sender, EventArgs e)
        {
            cardController.TitlePositionY = DEFAULT_TITLE_POSITION_Y;
            UpdateCardUI();
        }

        private void setBoldButton_Click(object sender, EventArgs e)
        {

            if (cardTextBox.SelectionLength > 0)
            {
                // Toggle the bold formatting for the selected text
                bool isBold = cardTextBox.SelectionFont.Bold;
                cardTextBox.SelectionFont = new Font(
                    cardTextBox.SelectionFont,
                    isBold ? cardTextBox.SelectionFont.Style & ~FontStyle.Bold : cardTextBox.SelectionFont.Style | FontStyle.Bold
                );
            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            // Update the card title with the text entered in the titleTextBox.
            cardController.TitleText = titleTextBox.Text;
            UpdateCardUI();
        }

        private void cardTextBox_TextChanged(object sender, EventArgs e)
        {
            cardController.CardText = cardTextBox.Text;
            UpdateCardUI();
        }

        private void cbOldPaper_CheckedChanged(object sender, EventArgs e)
        {
            cardController.ShowOldPaper = cbOldPaper.Checked;
            UpdateCardUI();
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
                ZoomFactor zf = new ZoomFactor();
                var zoomedBoundariesRectangle = zf.TranslateSelectionToZoomedSel(cardController.GetOverlayImageBoundaries(), pictureBox.Size, cardController.UdpatedCardImage.Size);
                var zoomedOverlayRectangle = zf.TranslateSelectionToZoomedSel(
                    new RectangleF(cardController.OverlayX, cardController.OverlayY,
                    cardController.GetUpdatedOverlyImage().Width,
                    cardController.GetUpdatedOverlyImage().Height), pictureBox.Size, cardController.UdpatedCardImage.Size);

                var intersectRectangle = Rectangle.Intersect(Rectangle.Round(zoomedBoundariesRectangle), Rectangle.Round(zoomedOverlayRectangle));

                if (intersectRectangle.Contains(new Point(e.X, e.Y)))
                {                    
                    System.Console.WriteLine(String.Format("Overly movement -> X:{0} Y:{1}", e.X - mousePosX, e.Y - mousePosY));
                    cardController.OverlayX += (e.X - mousePosX);
                    cardController.OverlayY += (e.Y - mousePosY);
                    mousePosX = e.X;
                    mousePosY = e.Y;
                    UpdateCardUI();
                }              
              
            }
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
                UpdateCardUI();
            }
        }

        private void pbGenericCard_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to change the card type? The progress with the current design will be lost", "Change card type", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                InitializeCardController(CardControllerType.GENERIC);
                LoadDefaultValues();
                RefreshUIInfo();
                UpdateCardUI();
            }
        }
    }

}
