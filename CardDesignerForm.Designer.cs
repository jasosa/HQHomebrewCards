
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
            this.titleFontFamily = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleFontSizeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.addImageButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontColorButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.moveTitleUp = new System.Windows.Forms.Button();
            this.moveImageDown = new System.Windows.Forms.Button();
            this.resetTitlePosition = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbOldPaper = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cardTextYnud = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cardTextXnud = new System.Windows.Forms.NumericUpDown();
            this.cardFontFamily = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.selectCardTextolor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cardTextBox = new System.Windows.Forms.RichTextBox();
            this.cardFontSizeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.btSave = new System.Windows.Forms.Button();
            this.btLoadcard = new System.Windows.Forms.Button();
            this.saveCardDialog = new System.Windows.Forms.SaveFileDialog();
            this.btExport = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cardTextLenghtNumUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleFontSizeNumUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextYnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextXnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFontSizeNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextLenghtNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(503, 75);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(497, 590);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(3, 23);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(223, 20);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // RemoveImageButton
            // 
            this.RemoveImageButton.Location = new System.Drawing.Point(139, 14);
            this.RemoveImageButton.Name = "RemoveImageButton";
            this.RemoveImageButton.Size = new System.Drawing.Size(96, 23);
            this.RemoveImageButton.TabIndex = 5;
            this.RemoveImageButton.Text = "Remove Image";
            this.RemoveImageButton.UseVisualStyleBackColor = true;
            this.RemoveImageButton.Click += new System.EventHandler(this.RemoveImageButton_Click);
            // 
            // moveImageUpButton
            // 
            this.moveImageUpButton.Location = new System.Drawing.Point(170, 43);
            this.moveImageUpButton.Name = "moveImageUpButton";
            this.moveImageUpButton.Size = new System.Drawing.Size(53, 47);
            this.moveImageUpButton.TabIndex = 6;
            this.moveImageUpButton.Text = "Move Up";
            this.moveImageUpButton.UseVisualStyleBackColor = true;
            this.moveImageUpButton.Click += new System.EventHandler(this.moveImageUpButton_Click);
            // 
            // moveImageDownButton
            // 
            this.moveImageDownButton.Location = new System.Drawing.Point(242, 43);
            this.moveImageDownButton.Name = "moveImageDownButton";
            this.moveImageDownButton.Size = new System.Drawing.Size(53, 47);
            this.moveImageDownButton.TabIndex = 7;
            this.moveImageDownButton.Text = "Move Down";
            this.moveImageDownButton.UseVisualStyleBackColor = true;
            this.moveImageDownButton.Click += new System.EventHandler(this.moveImageDownButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(98, 43);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(53, 47);
            this.moveLeftButton.TabIndex = 8;
            this.moveLeftButton.Text = "Move Left";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // moveImageRightButton
            // 
            this.moveImageRightButton.Location = new System.Drawing.Point(314, 43);
            this.moveImageRightButton.Name = "moveImageRightButton";
            this.moveImageRightButton.Size = new System.Drawing.Size(53, 47);
            this.moveImageRightButton.TabIndex = 9;
            this.moveImageRightButton.Text = "Move Right";
            this.moveImageRightButton.UseVisualStyleBackColor = true;
            this.moveImageRightButton.Click += new System.EventHandler(this.moveImageRightButton_Click);
            // 
            // biggerImageButton
            // 
            this.biggerImageButton.Location = new System.Drawing.Point(241, 15);
            this.biggerImageButton.Name = "biggerImageButton";
            this.biggerImageButton.Size = new System.Drawing.Size(96, 22);
            this.biggerImageButton.TabIndex = 10;
            this.biggerImageButton.Text = "Bigger";
            this.biggerImageButton.UseVisualStyleBackColor = true;
            this.biggerImageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // makeImageSmallerButton
            // 
            this.makeImageSmallerButton.Location = new System.Drawing.Point(343, 15);
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
            this.label1.Location = new System.Drawing.Point(13, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Image";
            // 
            // titleFontFamily
            // 
            this.titleFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleFontFamily.FormattingEnabled = true;
            this.titleFontFamily.Location = new System.Drawing.Point(232, 23);
            this.titleFontFamily.Name = "titleFontFamily";
            this.titleFontFamily.Size = new System.Drawing.Size(223, 21);
            this.titleFontFamily.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Font Family";
            // 
            // titleFontSizeNumUpDown
            // 
            this.titleFontSizeNumUpDown.Location = new System.Drawing.Point(6, 73);
            this.titleFontSizeNumUpDown.Name = "titleFontSizeNumUpDown";
            this.titleFontSizeNumUpDown.Size = new System.Drawing.Size(50, 20);
            this.titleFontSizeNumUpDown.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Font Size";
            // 
            // addImageButton
            // 
            this.addImageButton.Location = new System.Drawing.Point(37, 14);
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
            this.label5.Location = new System.Drawing.Point(13, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Card Title";
            // 
            // fontColorButton
            // 
            this.fontColorButton.Location = new System.Drawing.Point(62, 70);
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
            this.label6.Location = new System.Drawing.Point(716, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Preview";
            // 
            // moveTitleUp
            // 
            this.moveTitleUp.Location = new System.Drawing.Point(227, 70);
            this.moveTitleUp.Name = "moveTitleUp";
            this.moveTitleUp.Size = new System.Drawing.Size(80, 22);
            this.moveTitleUp.TabIndex = 21;
            this.moveTitleUp.Text = "Move Up";
            this.moveTitleUp.UseVisualStyleBackColor = true;
            this.moveTitleUp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // moveImageDown
            // 
            this.moveImageDown.Location = new System.Drawing.Point(313, 70);
            this.moveImageDown.Name = "moveImageDown";
            this.moveImageDown.Size = new System.Drawing.Size(80, 22);
            this.moveImageDown.TabIndex = 22;
            this.moveImageDown.Text = "Move Down";
            this.moveImageDown.UseVisualStyleBackColor = true;
            this.moveImageDown.Click += new System.EventHandler(this.moveImageDown_Click);
            // 
            // resetTitlePosition
            // 
            this.resetTitlePosition.Location = new System.Drawing.Point(399, 70);
            this.resetTitlePosition.Name = "resetTitlePosition";
            this.resetTitlePosition.Size = new System.Drawing.Size(56, 22);
            this.resetTitlePosition.TabIndex = 23;
            this.resetTitlePosition.Text = "Reset";
            this.resetTitlePosition.UseVisualStyleBackColor = true;
            this.resetTitlePosition.Click += new System.EventHandler(this.resetTitlePosition_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.resetTitlePosition);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.moveImageDown);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.moveTitleUp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.titleFontFamily);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fontColorButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.titleFontSizeNumUpDown);
            this.panel1.Location = new System.Drawing.Point(13, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 108);
            this.panel1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Font Color";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbOldPaper);
            this.panel2.Controls.Add(this.addImageButton);
            this.panel2.Controls.Add(this.RemoveImageButton);
            this.panel2.Controls.Add(this.biggerImageButton);
            this.panel2.Controls.Add(this.makeImageSmallerButton);
            this.panel2.Controls.Add(this.moveImageRightButton);
            this.panel2.Controls.Add(this.moveLeftButton);
            this.panel2.Controls.Add(this.moveImageDownButton);
            this.panel2.Controls.Add(this.moveImageUpButton);
            this.panel2.Location = new System.Drawing.Point(13, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 127);
            this.panel2.TabIndex = 25;
            // 
            // cbOldPaper
            // 
            this.cbOldPaper.AutoSize = true;
            this.cbOldPaper.Location = new System.Drawing.Point(6, 105);
            this.cbOldPaper.Name = "cbOldPaper";
            this.cbOldPaper.Size = new System.Drawing.Size(147, 17);
            this.cbOldPaper.TabIndex = 12;
            this.cbOldPaper.Text = "Mostrar Fondo Pergamino";
            this.cbOldPaper.UseVisualStyleBackColor = true;
            this.cbOldPaper.CheckedChanged += new System.EventHandler(this.cbOldPaper_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Card Text";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.cardTextLenghtNumUpDown);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.cardTextYnud);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cardTextXnud);
            this.panel3.Controls.Add(this.cardFontFamily);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.selectCardTextolor);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cardTextBox);
            this.panel3.Controls.Add(this.cardFontSizeNumUpDown);
            this.panel3.Location = new System.Drawing.Point(12, 383);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 282);
            this.panel3.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Text Y";
            // 
            // cardTextYnud
            // 
            this.cardTextYnud.Location = new System.Drawing.Point(73, 209);
            this.cardTextYnud.Name = "cardTextYnud";
            this.cardTextYnud.Size = new System.Drawing.Size(50, 20);
            this.cardTextYnud.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Text X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Font Color";
            // 
            // cardTextXnud
            // 
            this.cardTextXnud.Location = new System.Drawing.Point(7, 209);
            this.cardTextXnud.Name = "cardTextXnud";
            this.cardTextXnud.Size = new System.Drawing.Size(50, 20);
            this.cardTextXnud.TabIndex = 24;
            // 
            // cardFontFamily
            // 
            this.cardFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cardFontFamily.FormattingEnabled = true;
            this.cardFontFamily.Location = new System.Drawing.Point(4, 161);
            this.cardFontFamily.Name = "cardFontFamily";
            this.cardFontFamily.Size = new System.Drawing.Size(223, 21);
            this.cardFontFamily.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Font Size";
            // 
            // selectCardTextolor
            // 
            this.selectCardTextolor.Location = new System.Drawing.Point(313, 161);
            this.selectCardTextolor.Name = "selectCardTextolor";
            this.selectCardTextolor.Size = new System.Drawing.Size(97, 23);
            this.selectCardTextolor.TabIndex = 19;
            this.selectCardTextolor.Text = "Select Color";
            this.selectCardTextolor.UseVisualStyleBackColor = true;
            this.selectCardTextolor.Click += new System.EventHandler(this.selectCardTextolor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Text";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Font Family";
            // 
            // cardTextBox
            // 
            this.cardTextBox.AcceptsTab = true;
            this.cardTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cardTextBox.Location = new System.Drawing.Point(6, 21);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(449, 121);
            this.cardTextBox.TabIndex = 28;
            this.cardTextBox.Text = "";
            this.cardTextBox.TextChanged += new System.EventHandler(this.cardTextBox_TextChanged);
            // 
            // cardFontSizeNumUpDown
            // 
            this.cardFontSizeNumUpDown.Location = new System.Drawing.Point(245, 162);
            this.cardFontSizeNumUpDown.Name = "cardFontSizeNumUpDown";
            this.cardFontSizeNumUpDown.Size = new System.Drawing.Size(50, 20);
            this.cardFontSizeNumUpDown.TabIndex = 16;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(115, 12);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(110, 23);
            this.btSave.TabIndex = 28;
            this.btSave.Text = "Save Design";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoadcard
            // 
            this.btLoadcard.Location = new System.Drawing.Point(13, 12);
            this.btLoadcard.Name = "btLoadcard";
            this.btLoadcard.Size = new System.Drawing.Size(96, 23);
            this.btLoadcard.TabIndex = 29;
            this.btLoadcard.Text = "Load Design";
            this.btLoadcard.UseVisualStyleBackColor = true;
            this.btLoadcard.Click += new System.EventHandler(this.btLoadcard_Click);
            // 
            // saveCardDialog
            // 
            this.saveCardDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveCardDialog_FileOk);
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(231, 12);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(110, 23);
            this.btExport.TabIndex = 30;
            this.btExport.Text = "Export Image";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(137, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Text Length";
            // 
            // cardTextLenghtNumUpDown1
            // 
            this.cardTextLenghtNumUpDown.Location = new System.Drawing.Point(137, 209);
            this.cardTextLenghtNumUpDown.Name = "cardTextLenghtNumUpDown1";
            this.cardTextLenghtNumUpDown.Size = new System.Drawing.Size(50, 20);
            this.cardTextLenghtNumUpDown.TabIndex = 31;
            // 
            // CardDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btLoadcard);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "CardDesignerForm";
            this.Text = "Card Designer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleFontSizeNumUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextYnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextXnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFontSizeNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextLenghtNumUpDown)).EndInit();
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
        private System.Windows.Forms.ComboBox titleFontFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown titleFontSizeNumUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button fontColorButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button moveTitleUp;
        private System.Windows.Forms.Button moveImageDown;
        private System.Windows.Forms.Button resetTitlePosition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button selectCardTextolor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown cardFontSizeNumUpDown;
        private System.Windows.Forms.RichTextBox cardTextBox;
        private System.Windows.Forms.ComboBox cardFontFamily;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbOldPaper;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoadcard;
        private System.Windows.Forms.SaveFileDialog saveCardDialog;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown cardTextYnud;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown cardTextXnud;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown cardTextLenghtNumUpDown;
    }

}