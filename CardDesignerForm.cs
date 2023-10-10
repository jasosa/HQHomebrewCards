﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQHomebrewCards
{
    using System;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Windows.Forms;

    public partial class CardDesignerForm : Form
    {
        //private Image blankImage; //Blank Card Image
        //private Image updatedCardImage; // Store the card image
        //private Image overlayImage; // Store the overlay image       
        //private Image originalOverlayImage; // Store the overlay image

        //private int overlayX;
        //private int overlayY;

        //// Define the dimensions and position of the overlay rectangle
        //private int overlayRectangleX = 120; // X-coordinate of the top-left corner of the rectangle
        //private int overlayRectangleY = 166; // Y-coordinate of the top-left corner of the rectangle
        //private int overlayRectangleWidth = 499; // Width of the rectangle
        //private int overlayRectangleHeight = 361; // Height of the rectangle

        private Generic_Card_Controller cardController;

        private string cardTitle = "";
        private int cardTitleY;
        private const int defaultCardTitleY = 80;

        private string selectedFontName = "Arial"; // Default font
        private int selectedFontSize = 32; // Default font size
        private Color selectedFontColor = Color.Black; // Default font color

        public CardDesignerForm()
        {
            InitializeComponent();
            cardController = new Generic_Card_Controller();
        }

        private void LoadCardDesignerForm(object sender, EventArgs e)
        {
            // Set the initial image to the blank image.
            pictureBox.Image = cardController.GetOriginalCardImage(); ;           

            // Attach an event handler to the titleTextBox to update the card title.
            titleTextBox.TextChanged += TitleTextBox_TextChanged;            

            LoadInstalledFonts();
            LoadFontSize();

            cardTitleY = defaultCardTitleY;

            // Initialize the OpenFileDialog control.
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
            openFileDialog.Title = "Select an Image";
        }

 

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            // Update the card title with the text entered in the titleTextBox.
            cardTitle = titleTextBox.Text;
            UpdateCardUI();
        }

        private void UpdateCardUI()
        {
            cardController.UpdateUI(this.selectedFontName, this.selectedFontSize, this.selectedFontColor, this.cardTitle, this.cardTitleY);
            pictureBox.Image = cardController.GetUdpatedCardImage();
        }

    
        private void MoveOverlayImage(int deltaX, int deltaY)
        {
            if (cardController.GetUpdatedOverlyImage() != null)
            {
                using (Graphics graphics = Graphics.FromImage(cardController.GetUdpatedCardImage()))
                {
                    // Calculate the new position for the overlay image
                    int newOverlayX = cardController.GetOverlayX() + deltaX;
                    int newOverlayY = cardController.GetOverlayY() + deltaY;
                    CalculateOverlayPosition(cardController.GetUpdatedOverlyImage(), newOverlayX, newOverlayY);
                }
            }
        }

        private void CalculateOverlayPosition(Image overlay, int newOverlayX, int newOverlayY)
        {
            // Calculate the position to center the overlay image on the card image.
            if (newOverlayX != -1)
            {
                cardController.SetOverlayX(newOverlayX);
            }
            else
            {
                cardController.SetOverlayX((cardController.GetOriginalCardImage().Width - overlay.Width) / 2);

            }


            if (newOverlayY != -1)
            {
                cardController.SetOverlayY(newOverlayY);
            }
            else
            {
                cardController.SetOverlayY((cardController.GetOriginalCardImage().Width - overlay.Width) / 2);
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
                fontComboBox.Items.Add(fontFamily.Name);
            }

            // Set the default selected font in the ComboBox
            fontComboBox.SelectedItem = selectedFontName;

            // Add an event handler for the SelectedIndexChanged event
            fontComboBox.SelectedIndexChanged += FontComboBox_SelectedIndexChanged;
        }

        private void LoadFontSize() {
            fontSize.Value = selectedFontSize;
            fontSize.ValueChanged += FontSize_ValueChanged;
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
            // Update the selectedFontName when the user selects a different font
            selectedFontName = fontComboBox.SelectedItem.ToString();

            // Call UpdateCardUI to update the card image with the new font
            UpdateCardUI();
        }

        private void FontSize_ValueChanged(object sender, EventArgs e)
        {
            this.selectedFontSize = (int)fontSize.Value;
            UpdateCardUI();
        }

        private void fontColorButton_Click(object sender, EventArgs e)
        {
            // Create a ColorDialog to allow the user to select a font color
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = selectedFontColor; // Set the initial color

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Update the selectedFontColor with the user-selected color
                selectedFontColor = colorDialog.Color;

                // Call UpdateCardUI to update the card image with the new font color
                UpdateCardUI();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cardTitleY -= 5;
            UpdateCardUI();
        }

        private void moveImageDown_Click(object sender, EventArgs e)
        {
            cardTitleY += 5;
            UpdateCardUI();
        }

        private void resetTitlePosition_Click(object sender, EventArgs e)
        {
            cardTitleY = defaultCardTitleY;
            UpdateCardUI();
        }

        private void setBoldButton_Click(object sender, EventArgs e)
        {
            //int selstart = cardTextBox.SelectionStart;
            //int sellength = cardTextBox.SelectionLength;

            //// Set font of selected text
            //// You can use FontStyle.Bold | FontStyle.Italic to apply more than one style
            //if (cardTextBox.SelectionFont.Bold)
            //{
            //    cardTextBox.SelectionFont = new Font(cardTextBox.Font, FontStyle.Regular);
            //}
            //else
            //{
            //    cardTextBox.SelectionFont = new Font(cardTextBox.Font, FontStyle.Bold);
            //}

            //// Set cursor after selected text
            //cardTextBox.SelectionStart = cardTextBox.SelectionStart + cardTextBox.SelectionLength;
            //cardTextBox.SelectionLength = 0;
            //// Set font immediately after selection
            //cardTextBox.SelectionFont = cardTextBox.Font;

            //// Reselect previous text
            //cardTextBox.Select(selstart, sellength);            

            // Check if there is selected text
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

        private void cardTextBox_TextChanged(object sender, EventArgs e)
        {
            // Iterate through the lines of text in the RichTextBox
            int yOffset = 0; // Y-coordinate for each line
            foreach (string line in cardTextBox.Lines)
            {
                // Apply formatting here based on the formatting in the RichTextBox
                Font font = cardTextBox.SelectionFont ?? cardTextBox.Font; // Use selected font or default font
                Brush brush = new SolidBrush(cardTextBox.SelectionColor); // Use selected color or default color

                cardController.SetCardText(line, font, brush, yOffset);               

            }

            
            UpdateCardUI();

        }

        private void setItalicButton_Click(object sender, EventArgs e)
        {
            // Check if there is selected text
            if (cardTextBox.SelectionLength > 0)
            {
                // Toggle the italic formatting for the selected text
                bool isItalic = cardTextBox.SelectionFont.Italic;
                cardTextBox.SelectionFont = new Font(
                    cardTextBox.SelectionFont,
                    isItalic ? cardTextBox.SelectionFont.Style & ~FontStyle.Italic : cardTextBox.SelectionFont.Style | FontStyle.Italic
                );
            }
        }
    }

}
