
using System;

namespace HQHomebrewCards
{
    partial class CardDesignerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RemoveImageButton = new System.Windows.Forms.Button();
            this.moveImageUpButton = new System.Windows.Forms.Button();
            this.moveImageDownButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.moveImageRightButton = new System.Windows.Forms.Button();
            this.biggerImageButton = new System.Windows.Forms.Button();
            this.makeImageSmallerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fontComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.addImageButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontColorButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox.Location = new System.Drawing.Point(252, 63);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(497, 517);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(12, 80);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(223, 20);
            this.titleTextBox.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // RemoveImageButton
            // 
            this.RemoveImageButton.Location = new System.Drawing.Point(122, 249);
            this.RemoveImageButton.Name = "RemoveImageButton";
            this.RemoveImageButton.Size = new System.Drawing.Size(96, 23);
            this.RemoveImageButton.TabIndex = 5;
            this.RemoveImageButton.Text = "Remove Image";
            this.RemoveImageButton.UseVisualStyleBackColor = true;
            this.RemoveImageButton.Click += new System.EventHandler(this.RemoveImageButton_Click);
            // 
            // moveImageUpButton
            // 
            this.moveImageUpButton.Location = new System.Drawing.Point(89, 278);
            this.moveImageUpButton.Name = "moveImageUpButton";
            this.moveImageUpButton.Size = new System.Drawing.Size(70, 49);
            this.moveImageUpButton.TabIndex = 6;
            this.moveImageUpButton.Text = "Move Up";
            this.moveImageUpButton.UseVisualStyleBackColor = true;
            this.moveImageUpButton.Click += new System.EventHandler(this.moveImageUpButton_Click);
            // 
            // moveImageDownButton
            // 
            this.moveImageDownButton.Location = new System.Drawing.Point(89, 333);
            this.moveImageDownButton.Name = "moveImageDownButton";
            this.moveImageDownButton.Size = new System.Drawing.Size(70, 47);
            this.moveImageDownButton.TabIndex = 7;
            this.moveImageDownButton.Text = "Move Down";
            this.moveImageDownButton.UseVisualStyleBackColor = true;
            this.moveImageDownButton.Click += new System.EventHandler(this.moveImageDownButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(30, 306);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(53, 46);
            this.moveLeftButton.TabIndex = 8;
            this.moveLeftButton.Text = "Move Left";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // moveImageRightButton
            // 
            this.moveImageRightButton.Location = new System.Drawing.Point(165, 306);
            this.moveImageRightButton.Name = "moveImageRightButton";
            this.moveImageRightButton.Size = new System.Drawing.Size(53, 47);
            this.moveImageRightButton.TabIndex = 9;
            this.moveImageRightButton.Text = "Move Right";
            this.moveImageRightButton.UseVisualStyleBackColor = true;
            this.moveImageRightButton.Click += new System.EventHandler(this.moveImageRightButton_Click);
            // 
            // biggerImageButton
            // 
            this.biggerImageButton.Location = new System.Drawing.Point(20, 386);
            this.biggerImageButton.Name = "biggerImageButton";
            this.biggerImageButton.Size = new System.Drawing.Size(96, 22);
            this.biggerImageButton.TabIndex = 10;
            this.biggerImageButton.Text = "Bigger";
            this.biggerImageButton.UseVisualStyleBackColor = true;
            this.biggerImageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // makeImageSmallerButton
            // 
            this.makeImageSmallerButton.Location = new System.Drawing.Point(122, 386);
            this.makeImageSmallerButton.Name = "makeImageSmallerButton";
            this.makeImageSmallerButton.Size = new System.Drawing.Size(96, 22);
            this.makeImageSmallerButton.TabIndex = 11;
            this.makeImageSmallerButton.Text = "Smaller";
            this.makeImageSmallerButton.UseVisualStyleBackColor = true;
            this.makeImageSmallerButton.Click += new System.EventHandler(this.makeImageSmallerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Image";
            // 
            // fontComboBox
            // 
            this.fontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontComboBox.FormattingEnabled = true;
            this.fontComboBox.Location = new System.Drawing.Point(12, 127);
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(223, 21);
            this.fontComboBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Font";
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(12, 181);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(120, 20);
            this.fontSize.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Font Size";
            // 
            // addImageButton
            // 
            this.addImageButton.Location = new System.Drawing.Point(20, 249);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(96, 23);
            this.addImageButton.TabIndex = 4;
            this.addImageButton.Text = "Add Image";
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Card Title";
            // 
            // fontColorButton
            // 
            this.fontColorButton.Location = new System.Drawing.Point(138, 178);
            this.fontColorButton.Name = "fontColorButton";
            this.fontColorButton.Size = new System.Drawing.Size(97, 23);
            this.fontColorButton.TabIndex = 19;
            this.fontColorButton.Text = "Select Color";
            this.fontColorButton.UseVisualStyleBackColor = true;
            this.fontColorButton.Click += new System.EventHandler(this.fontColorButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(466, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Preview";
            // 
            // CardDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 621);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fontColorButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fontSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fontComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makeImageSmallerButton);
            this.Controls.Add(this.biggerImageButton);
            this.Controls.Add(this.moveImageRightButton);
            this.Controls.Add(this.moveLeftButton);
            this.Controls.Add(this.moveImageDownButton);
            this.Controls.Add(this.moveImageUpButton);
            this.Controls.Add(this.RemoveImageButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.pictureBox);
            this.MaximizeBox = false;
            this.Name = "CardDesignerForm";
            this.Text = "Card Designer";
            this.Load += new System.EventHandler(this.LoadCardDesignerForm);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button RemoveImageButton;
        private System.Windows.Forms.Button moveImageUpButton;
        private System.Windows.Forms.Button moveImageDownButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button moveImageRightButton;
        private System.Windows.Forms.Button biggerImageButton;
        private System.Windows.Forms.Button makeImageSmallerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fontComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button fontColorButton;
        private System.Windows.Forms.Label label6;
    }

}