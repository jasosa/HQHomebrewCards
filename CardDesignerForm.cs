using System;
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
        private Image blankImage; //Blank Card Image
        private Image updatedCardImage; // Store the card image
        private Image overlayImage; // Store the overlay image       
        private Image originalOverlayImage; // Store the overlay image
        
        private int overlayX;
        private int overlayY;

        // Define the dimensions and position of the overlay rectangle
        private int overlayRectangleX = 120; // X-coordinate of the top-left corner of the rectangle
        private int overlayRectangleY = 166; // Y-coordinate of the top-left corner of the rectangle
        private int overlayRectangleWidth = 499; // Width of the rectangle
        private int overlayRectangleHeight = 361; // Height of the rectangle

        private string cardTitle = "";
        private string selectedFontName = "Arial"; // Default font
        private int selectedFontSize = 32; // Default font size
        private Color selectedFontColor = Color.Black; // Default font color

        public CardDesignerForm()
        {
            InitializeComponent();
        }

        private void LoadCardDesignerForm(object sender, EventArgs e)
        {
            // Load the blank image as the template/background.
            blankImage = Properties.Resources.Card_Front___Generic; // Assuming you have an image resource named 'blank_image'.                       

            // Set the initial image to the blank image.
           pictureBox.Image = blankImage;           

            // Attach an event handler to the titleTextBox to update the card title.
            titleTextBox.TextChanged += TitleTextBox_TextChanged;

            LoadInstalledFonts();
            LoadFontSize();

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
            // Create a copy of the blank image to overlay the card title.
            updatedCardImage = new Bitmap(blankImage);
            using (Graphics graphics = Graphics.FromImage(updatedCardImage))
            {
                // Set font and brush for the card title.
                Font titleFont = new Font(this.selectedFontName, this.selectedFontSize);
                Brush titleBrush = new SolidBrush(selectedFontColor);

                // Calculate the position for the card title to center it on the image.
                int titleX = (updatedCardImage.Width - (int)graphics.MeasureString(cardTitle, titleFont).Width) / 2;
                int titleY = 80;

                // Overlay the card title on the image.
                graphics.DrawString(cardTitle, titleFont, titleBrush, titleX, titleY);

                // Check if an overlay image is available.
                if (overlayImage != null)
                {
                    Rectangle destinationRectangle = new Rectangle(overlayRectangleX, overlayRectangleY, overlayRectangleWidth, overlayRectangleHeight);

                    graphics.SetClip(destinationRectangle);

                    // Overlay the image on the card image.
                    graphics.DrawImage(overlayImage, overlayX, overlayY, overlayImage.Width, overlayImage.Height);
                    
                }

                // Update the PictureBox with the card image.
                pictureBox.Image = updatedCardImage;
            }            
        }

        private void CalculateOverlayPosition(Image overlay, int newOverlayX, int newOverlayY)
        {
            // Calculate the position to center the overlay image on the card image.
            if (newOverlayX != -1)
            {
                overlayX = newOverlayX;
            }
            else
            {
                overlayX = (blankImage.Width - overlay.Width) / 2;
            }


            if (newOverlayY != -1)
            {
                overlayY = newOverlayY;
            }
            else
            {
                overlayY = (blankImage.Width - overlay.Width) / 2;
            }
        }

        private void MoveOverlayImage(int deltaX, int deltaY)
        {
            if (overlayImage != null)
            {
                using (Graphics graphics = Graphics.FromImage(updatedCardImage))
                {
                    // Calculate the new position for the overlay image
                    int newOverlayX = overlayX + deltaX;
                    int newOverlayY = overlayY + deltaY;
                    CalculateOverlayPosition(overlayImage, newOverlayX, newOverlayY);
                }
            }
        }

        private void ModifyOverlayImageSize(float amount)
        {
            if (overlayImage != null)
            {
                var W = (int)(overlayImage.Width * amount); 
                var H = (int)(overlayImage.Height * amount);
    
                // Create a new Bitmap with the increased size
                Image newOverlayImage = new Bitmap(W, H);
  
                using (Graphics graphics = Graphics.FromImage(newOverlayImage))
                {
                    // Draw the original overlay image onto the new image with the new size. This is to avoid losing resolution.
                    graphics.DrawImage(originalOverlayImage, new Rectangle(0, 0, W, H));
                }

                // Update the overlayImage with the new larger image
                overlayImage = newOverlayImage;
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
                // Load the selected image as the overlay image.
                overlayImage = Image.FromFile(openFileDialog.FileName);
                originalOverlayImage = overlayImage;

                CalculateOverlayPosition(overlayImage, -1, -1);
                // Update the card image with the new overlay image.
                UpdateCardUI();
            }
        }

        private void RemoveImageButton_Click(object sender, EventArgs e)
        {
            // Remove the overlay image.
            overlayImage = null;

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
    }

}
