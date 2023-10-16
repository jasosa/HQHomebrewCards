namespace HQHomebrewCards
{
    using System;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class CardDesignerForm : Form
    {
        private GenericCardController cardController;

        private string cardTitle = "";
        private int cardTitleY;
        

        private const string DEFAULT_TITLE_FONT_NAME = "CarterSansW01-SmBd"; // Default font
        private const int DEFAULT_TITLE_FONT_SIZE = 40; // Default font size
        private Color DEAFULT_TITLE_FONT_COLOR = Color.Black; // Default title color
        private const int DEFAULT_TITLE_POSITION_Y = 80;
        

        private const string DEFAULT_CARD_TEXT_FONT_NAME = "CarterSansW01-Regular"; // Default font        
        private const int DEFAULT_CARD_FONT_SIZE = 28; // Default font size        
        private Color DEFAULT_TEXT_FONT_COLOR = Color.Black; // Default text color

        private RichTextBox tempRichTextBox;

        public CardDesignerForm()
        {
            InitializeComponent();
            cardController = new GenericCardController();
            cardController.TitleFontSize = DEFAULT_TITLE_FONT_SIZE;
            cardController.TitleFontName = DEFAULT_TITLE_FONT_NAME;
            cardController.TitleFontColor = DEAFULT_TITLE_FONT_COLOR;
            cardController.TitlePositionY = DEFAULT_TITLE_POSITION_Y;

            cardController.CardFontSize= DEFAULT_CARD_FONT_SIZE;
            cardController.CardFontName = DEFAULT_CARD_TEXT_FONT_NAME;
            cardController.CardFontColor = DEFAULT_TEXT_FONT_COLOR;            

            tempRichTextBox = new RichTextBox();
        }

        private void LoadCardDesignerForm(object sender, EventArgs e)
        {
            // Set the initial image to the blank image.
            pictureBox.Image = cardController.OriginalCardImage; ;            

            LoadInstalledFonts();
            LoadFontSizes();
                        

            // Initialize the OpenFileDialog control.
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
            openFileDialog.Title = "Select an Image";
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
                cardController.OverlayY = ((cardController.OriginalCardImage.Width - overlay.Width) / 2);
            }
        }

        private void ModifyOverlayImageSize(float amount)
        {
            if (cardController.GetUpdatedOverlyImage() != null)
            {
                var overlyImage = cardController.GetUpdatedOverlyImage();
                var W = (int)(overlyImage.Width * amount);
                var H = (int)(overlyImage.Height * amount);

                // Create a new Bitmap with the increased size
                Image newOverlayImage = new Bitmap(W, H);

                using (Graphics graphics = Graphics.FromImage(newOverlayImage))
                {
                    // Draw the original overlay image onto the new image with the new size. This is to avoid losing resolution.
                    graphics.DrawImage(cardController.GetOriginalOverlyImage(), new Rectangle(0, 0, W, H));
                }

                // Update the overlayImage with the new larger image
                //overlayImage = newOverlayImage;
                cardController.UpdateOverly(newOverlayImage);
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

      

        private void LoadFontSizes()
        {
            titleFontSizeNumUpDown.ValueChanged += FontSize_ValueChanged;
            titleFontSizeNumUpDown.Value = DEFAULT_TITLE_FONT_SIZE;

            cardFontSizeNumUpDown.ValueChanged += CardFontSizeNumUpDown_ValueChanged;
            cardFontSizeNumUpDown.Value = DEFAULT_CARD_FONT_SIZE;
        }

       

        private void addImageButton_Click(object sender, EventArgs e)
        {
            // Show the OpenFileDialog to select an image to overlay on the card.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cardController.AddOverlyImage(Image.FromFile(openFileDialog.FileName));
                //// Load the selected image as the overlay image.
                //overlayImage = Image.FromFile(openFileDialog.FileName);
                //originalOverlayImage = overlayImage;

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
            ModifyOverlayImageSize(1.1f);
            UpdateCardUI();
        }

        private void makeImageSmallerButton_Click(object sender, EventArgs e)
        {
            ModifyOverlayImageSize(0.9f);
            UpdateCardUI();
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
            //cardController.SaveImage(String.Format(@"C:\Users\juanan\Desktop\HQCardCreator\{0}.png", titleTextBox.Text));
            //cardController.Serialize();
            saveCardDialog.Title = "Save the card image";
            saveCardDialog.DefaultExt = "png";
            saveCardDialog.Filter = "Image files(*.png)| *.png";
            saveCardDialog.FilterIndex = 1;
            saveCardDialog.ShowDialog();
        }

        private void btLoadcard_Click(object sender, EventArgs e)
        {
            LoadCardDesign(String.Format(@"C:\Users\juanan\Desktop\HQCardCreator\{0}.xml", titleTextBox.Text));
        }

        private void LoadCardDesign(string path)
        {
            CardSerializer s = new CardSerializer();
            cardController = s.Deserialize(path, typeof(GenericCardController));
            UpdateCardUI();
        }

        private void saveCardDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {       
            if (saveCardDialog.FileName != string.Empty)
            {
                System.IO.FileStream fs =(System.IO.FileStream)saveCardDialog.OpenFile();
                cardController.SaveImage(fs.Name + ".png");
                CardSerializer s = new CardSerializer();
                s.Serialize(cardController, fs.Name + ".xml");
            }
        }
    }

}
