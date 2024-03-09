
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardDesignerForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btLoadcard = new System.Windows.Forms.Button();
            this.saveCardDialog = new System.Windows.Forms.SaveFileDialog();
            this.btExport = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbCustomCard = new System.Windows.Forms.PictureBox();
            this.pbHeroCard = new System.Windows.Forms.PictureBox();
            this.pbGenericCard = new System.Windows.Forms.PictureBox();
            this.genericCardPanel = new System.Windows.Forms.Panel();
            this.ParametersTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showScrollcb = new System.Windows.Forms.CheckBox();
            this.resetTitlePosition = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.moveImageDown = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.moveTitleUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.titleFontFamily = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fontColorButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.titleFontSizeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelImage = new System.Windows.Forms.Panel();
            this.cbShowBorder = new System.Windows.Forms.CheckBox();
            this.cbOldPaper = new System.Windows.Forms.CheckBox();
            this.addImageButton = new System.Windows.Forms.Button();
            this.RemoveImageButton = new System.Windows.Forms.Button();
            this.biggerImageButton = new System.Windows.Forms.Button();
            this.makeImageSmallerButton = new System.Windows.Forms.Button();
            this.moveImageRightButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.moveImageDownButton = new System.Windows.Forms.Button();
            this.moveImageUpButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelCardText = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.cardTextLenghtNumUpDown = new System.Windows.Forms.NumericUpDown();
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panelStats = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.statValueYNum = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.statValueXNum = new System.Windows.Forms.NumericUpDown();
            this.individualStatsCombo = new System.Windows.Forms.ComboBox();
            this.movementSquaresRtb = new System.Windows.Forms.RichTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.movementSquaresMaxLenght = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.movementSquaresY = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.movementSquaresX = new System.Windows.Forms.NumericUpDown();
            this.statValueNum = new System.Windows.Forms.NumericUpDown();
            this.movementSquarestextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStats = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenericCard)).BeginInit();
            this.genericCardPanel.SuspendLayout();
            this.ParametersTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleFontSizeNumUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelImage.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelCardText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextLenghtNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextYnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextXnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFontSizeNumUpDown)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panelStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statValueYNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statValueXNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresMaxLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statValueNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(703, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Card Preview";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(113, 12);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(110, 23);
            this.btSave.TabIndex = 28;
            this.btSave.Text = "Save Design";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoadcard
            // 
            this.btLoadcard.Location = new System.Drawing.Point(11, 12);
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
            this.btExport.Location = new System.Drawing.Point(229, 12);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(110, 23);
            this.btExport.TabIndex = 30;
            this.btExport.Text = "Export Image";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "Card Type";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pbCustomCard);
            this.panel4.Controls.Add(this.pbHeroCard);
            this.panel4.Controls.Add(this.pbGenericCard);
            this.panel4.Location = new System.Drawing.Point(11, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 642);
            this.panel4.TabIndex = 33;
            // 
            // pbCustomCard
            // 
            this.pbCustomCard.Image = global::HQHomebrewCards.Properties.Resources.Custom;
            this.pbCustomCard.Location = new System.Drawing.Point(31, 390);
            this.pbCustomCard.Name = "pbCustomCard";
            this.pbCustomCard.Size = new System.Drawing.Size(129, 177);
            this.pbCustomCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCustomCard.TabIndex = 2;
            this.pbCustomCard.TabStop = false;
            this.pbCustomCard.Click += new System.EventHandler(this.pbCustomCard_Click);
            // 
            // pbHeroCard
            // 
            this.pbHeroCard.Image = ((System.Drawing.Image)(resources.GetObject("pbHeroCard.Image")));
            this.pbHeroCard.Location = new System.Drawing.Point(31, 207);
            this.pbHeroCard.Name = "pbHeroCard";
            this.pbHeroCard.Size = new System.Drawing.Size(129, 177);
            this.pbHeroCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeroCard.TabIndex = 1;
            this.pbHeroCard.TabStop = false;
            this.pbHeroCard.Click += new System.EventHandler(this.pbHeroCard_Click);
            // 
            // pbGenericCard
            // 
            this.pbGenericCard.Image = global::HQHomebrewCards.Properties.Resources.Card_Front___Generic;
            this.pbGenericCard.Location = new System.Drawing.Point(31, 24);
            this.pbGenericCard.Name = "pbGenericCard";
            this.pbGenericCard.Size = new System.Drawing.Size(129, 177);
            this.pbGenericCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGenericCard.TabIndex = 0;
            this.pbGenericCard.TabStop = false;
            this.pbGenericCard.Click += new System.EventHandler(this.pbGenericCard_Click);
            // 
            // genericCardPanel
            // 
            this.genericCardPanel.AutoScroll = true;
            this.genericCardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genericCardPanel.Controls.Add(this.ParametersTabControl);
            this.genericCardPanel.Location = new System.Drawing.Point(216, 75);
            this.genericCardPanel.Name = "genericCardPanel";
            this.genericCardPanel.Size = new System.Drawing.Size(485, 642);
            this.genericCardPanel.TabIndex = 34;
            // 
            // ParametersTabControl
            // 
            this.ParametersTabControl.Controls.Add(this.tabPage1);
            this.ParametersTabControl.Controls.Add(this.tabPage2);
            this.ParametersTabControl.Controls.Add(this.tabPage3);
            this.ParametersTabControl.Controls.Add(this.tabPage4);
            this.ParametersTabControl.Location = new System.Drawing.Point(3, 6);
            this.ParametersTabControl.Name = "ParametersTabControl";
            this.ParametersTabControl.SelectedIndex = 0;
            this.ParametersTabControl.Size = new System.Drawing.Size(477, 631);
            this.ParametersTabControl.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(469, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Card Title";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.showScrollcb);
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
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 180);
            this.panel1.TabIndex = 26;
            // 
            // showScrollcb
            // 
            this.showScrollcb.AutoSize = true;
            this.showScrollcb.Location = new System.Drawing.Point(6, 110);
            this.showScrollcb.Name = "showScrollcb";
            this.showScrollcb.Size = new System.Drawing.Size(82, 17);
            this.showScrollcb.TabIndex = 24;
            this.showScrollcb.Text = "Show Scroll";
            this.showScrollcb.UseVisualStyleBackColor = true;
            this.showScrollcb.CheckedChanged += new System.EventHandler(this.showScrollcb_CheckedChanged);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Font Color";
            // 
            // moveImageDown
            // 
            this.moveImageDown.Location = new System.Drawing.Point(313, 70);
            this.moveImageDown.Name = "moveImageDown";
            this.moveImageDown.Size = new System.Drawing.Size(80, 22);
            this.moveImageDown.TabIndex = 22;
            this.moveImageDown.Text = "Move Down";
            this.moveImageDown.UseVisualStyleBackColor = true;
            this.moveImageDown.Click += new System.EventHandler(this.moveTitleDown_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(3, 23);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(223, 20);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // moveTitleUp
            // 
            this.moveTitleUp.Location = new System.Drawing.Point(227, 70);
            this.moveTitleUp.Name = "moveTitleUp";
            this.moveTitleUp.Size = new System.Drawing.Size(80, 22);
            this.moveTitleUp.TabIndex = 21;
            this.moveTitleUp.Text = "Move Up";
            this.moveTitleUp.UseVisualStyleBackColor = true;
            this.moveTitleUp.Click += new System.EventHandler(this.moveTitleUp_Click);
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
            // titleFontFamily
            // 
            this.titleFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleFontFamily.FormattingEnabled = true;
            this.titleFontFamily.Location = new System.Drawing.Point(232, 23);
            this.titleFontFamily.Name = "titleFontFamily";
            this.titleFontFamily.Size = new System.Drawing.Size(223, 21);
            this.titleFontFamily.TabIndex = 13;
            this.titleFontFamily.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Font Size";
            // 
            // titleFontSizeNumUpDown
            // 
            this.titleFontSizeNumUpDown.Location = new System.Drawing.Point(6, 73);
            this.titleFontSizeNumUpDown.Name = "titleFontSizeNumUpDown";
            this.titleFontSizeNumUpDown.Size = new System.Drawing.Size(50, 20);
            this.titleFontSizeNumUpDown.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelImage);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(469, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Card Image";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelImage
            // 
            this.panelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImage.Controls.Add(this.cbShowBorder);
            this.panelImage.Controls.Add(this.cbOldPaper);
            this.panelImage.Controls.Add(this.addImageButton);
            this.panelImage.Controls.Add(this.RemoveImageButton);
            this.panelImage.Controls.Add(this.biggerImageButton);
            this.panelImage.Controls.Add(this.makeImageSmallerButton);
            this.panelImage.Controls.Add(this.moveImageRightButton);
            this.panelImage.Controls.Add(this.moveLeftButton);
            this.panelImage.Controls.Add(this.moveImageDownButton);
            this.panelImage.Controls.Add(this.moveImageUpButton);
            this.panelImage.Location = new System.Drawing.Point(3, 22);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(468, 129);
            this.panelImage.TabIndex = 26;
            // 
            // cbShowBorder
            // 
            this.cbShowBorder.AutoSize = true;
            this.cbShowBorder.Location = new System.Drawing.Point(159, 105);
            this.cbShowBorder.Name = "cbShowBorder";
            this.cbShowBorder.Size = new System.Drawing.Size(92, 17);
            this.cbShowBorder.TabIndex = 13;
            this.cbShowBorder.Text = "Mostrar Borde";
            this.cbShowBorder.UseVisualStyleBackColor = true;
            this.cbShowBorder.CheckedChanged += new System.EventHandler(this.cbShowBorder_CheckedChanged);
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
            this.cbOldPaper.CheckStateChanged += new System.EventHandler(this.cbOldPaper_CheckedChanged);
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
            // biggerImageButton
            // 
            this.biggerImageButton.Location = new System.Drawing.Point(241, 15);
            this.biggerImageButton.Name = "biggerImageButton";
            this.biggerImageButton.Size = new System.Drawing.Size(96, 22);
            this.biggerImageButton.TabIndex = 10;
            this.biggerImageButton.Text = "Bigger";
            this.biggerImageButton.UseVisualStyleBackColor = true;
            this.biggerImageButton.Click += new System.EventHandler(this.makeImageBigger_Click);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelCardText);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(469, 605);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Card Text";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelCardText
            // 
            this.panelCardText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardText.Controls.Add(this.label15);
            this.panelCardText.Controls.Add(this.cardTextLenghtNumUpDown);
            this.panelCardText.Controls.Add(this.label14);
            this.panelCardText.Controls.Add(this.cardTextYnud);
            this.panelCardText.Controls.Add(this.label13);
            this.panelCardText.Controls.Add(this.label9);
            this.panelCardText.Controls.Add(this.cardTextXnud);
            this.panelCardText.Controls.Add(this.cardFontFamily);
            this.panelCardText.Controls.Add(this.label12);
            this.panelCardText.Controls.Add(this.selectCardTextolor);
            this.panelCardText.Controls.Add(this.label10);
            this.panelCardText.Controls.Add(this.label11);
            this.panelCardText.Controls.Add(this.cardTextBox);
            this.panelCardText.Controls.Add(this.cardFontSizeNumUpDown);
            this.panelCardText.Location = new System.Drawing.Point(0, 161);
            this.panelCardText.Name = "panelCardText";
            this.panelCardText.Size = new System.Drawing.Size(468, 282);
            this.panelCardText.TabIndex = 28;
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
            // cardTextLenghtNumUpDown
            // 
            this.cardTextLenghtNumUpDown.Location = new System.Drawing.Point(137, 209);
            this.cardTextLenghtNumUpDown.Name = "cardTextLenghtNumUpDown";
            this.cardTextLenghtNumUpDown.Size = new System.Drawing.Size(50, 20);
            this.cardTextLenghtNumUpDown.TabIndex = 31;
            this.cardTextLenghtNumUpDown.Click += new System.EventHandler(this.CardTextLenghtNumUpDown_ValueChanged);
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
            this.cardTextYnud.Click += new System.EventHandler(this.CardTextY_ValueChanged);
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
            this.cardTextXnud.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.cardTextXnud.Name = "cardTextXnud";
            this.cardTextXnud.Size = new System.Drawing.Size(50, 20);
            this.cardTextXnud.TabIndex = 24;
            this.cardTextXnud.Click += new System.EventHandler(this.CardTextX_ValueChanged);
            // 
            // cardFontFamily
            // 
            this.cardFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cardFontFamily.FormattingEnabled = true;
            this.cardFontFamily.Location = new System.Drawing.Point(4, 161);
            this.cardFontFamily.Name = "cardFontFamily";
            this.cardFontFamily.Size = new System.Drawing.Size(223, 21);
            this.cardFontFamily.TabIndex = 24;
            this.cardFontFamily.SelectedIndexChanged += new System.EventHandler(this.CardFontFamily_SelectedIndexChanged);
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
            this.cardFontSizeNumUpDown.ValueChanged += new System.EventHandler(this.FontSize_ValueChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panelStats);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(469, 605);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Stats";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.label8);
            this.panelStats.Controls.Add(this.statValueYNum);
            this.panelStats.Controls.Add(this.label23);
            this.panelStats.Controls.Add(this.statValueXNum);
            this.panelStats.Controls.Add(this.individualStatsCombo);
            this.panelStats.Controls.Add(this.movementSquaresRtb);
            this.panelStats.Controls.Add(this.label22);
            this.panelStats.Controls.Add(this.label19);
            this.panelStats.Controls.Add(this.movementSquaresMaxLenght);
            this.panelStats.Controls.Add(this.label20);
            this.panelStats.Controls.Add(this.movementSquaresY);
            this.panelStats.Controls.Add(this.label21);
            this.panelStats.Controls.Add(this.movementSquaresX);
            this.panelStats.Controls.Add(this.statValueNum);
            this.panelStats.Controls.Add(this.movementSquarestextBox);
            this.panelStats.Controls.Add(this.label18);
            this.panelStats.Controls.Add(this.label5);
            this.panelStats.Controls.Add(this.cbStats);
            this.panelStats.Controls.Add(this.label1);
            this.panelStats.Location = new System.Drawing.Point(0, 20);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(452, 537);
            this.panelStats.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = " Y";
            // 
            // statValueYNum
            // 
            this.statValueYNum.Location = new System.Drawing.Point(82, 240);
            this.statValueYNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.statValueYNum.Name = "statValueYNum";
            this.statValueYNum.Size = new System.Drawing.Size(50, 20);
            this.statValueYNum.TabIndex = 45;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(62, 221);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 44;
            this.label23.Text = "X";
            // 
            // statValueXNum
            // 
            this.statValueXNum.Location = new System.Drawing.Point(82, 214);
            this.statValueXNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.statValueXNum.Name = "statValueXNum";
            this.statValueXNum.Size = new System.Drawing.Size(50, 20);
            this.statValueXNum.TabIndex = 43;
            // 
            // individualStatsCombo
            // 
            this.individualStatsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.individualStatsCombo.FormattingEnabled = true;
            this.individualStatsCombo.Location = new System.Drawing.Point(82, 45);
            this.individualStatsCombo.Name = "individualStatsCombo";
            this.individualStatsCombo.Size = new System.Drawing.Size(212, 21);
            this.individualStatsCombo.TabIndex = 42;
            // 
            // movementSquaresRtb
            // 
            this.movementSquaresRtb.AcceptsTab = true;
            this.movementSquaresRtb.ImeMode = System.Windows.Forms.ImeMode.On;
            this.movementSquaresRtb.Location = new System.Drawing.Point(203, 376);
            this.movementSquaresRtb.Name = "movementSquaresRtb";
            this.movementSquaresRtb.Size = new System.Drawing.Size(111, 43);
            this.movementSquaresRtb.TabIndex = 41;
            this.movementSquaresRtb.Text = "";
            this.movementSquaresRtb.TextChanged += new System.EventHandler(this.movementSquaresRtb_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(48, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 13);
            this.label22.TabIndex = 40;
            this.label22.Text = "Text";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 158);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Max.Length";
            // 
            // movementSquaresMaxLenght
            // 
            this.movementSquaresMaxLenght.Location = new System.Drawing.Point(82, 154);
            this.movementSquaresMaxLenght.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.movementSquaresMaxLenght.Name = "movementSquaresMaxLenght";
            this.movementSquaresMaxLenght.Size = new System.Drawing.Size(50, 20);
            this.movementSquaresMaxLenght.TabIndex = 37;
            this.movementSquaresMaxLenght.ValueChanged += new System.EventHandler(this.movementSquaresMaxLenght_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(59, 136);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 13);
            this.label20.TabIndex = 36;
            this.label20.Text = " Y";
            // 
            // movementSquaresY
            // 
            this.movementSquaresY.Location = new System.Drawing.Point(82, 129);
            this.movementSquaresY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.movementSquaresY.Name = "movementSquaresY";
            this.movementSquaresY.Size = new System.Drawing.Size(50, 20);
            this.movementSquaresY.TabIndex = 35;
            this.movementSquaresY.ValueChanged += new System.EventHandler(this.movementSquaresY_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(62, 110);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 34;
            this.label21.Text = "X";
            // 
            // movementSquaresX
            // 
            this.movementSquaresX.Location = new System.Drawing.Point(82, 103);
            this.movementSquaresX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.movementSquaresX.Name = "movementSquaresX";
            this.movementSquaresX.Size = new System.Drawing.Size(50, 20);
            this.movementSquaresX.TabIndex = 33;
            this.movementSquaresX.ValueChanged += new System.EventHandler(this.movementSquaresX_ValueChanged);
            // 
            // statValueNum
            // 
            this.statValueNum.Location = new System.Drawing.Point(82, 188);
            this.statValueNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.statValueNum.Name = "statValueNum";
            this.statValueNum.Size = new System.Drawing.Size(50, 20);
            this.statValueNum.TabIndex = 32;
            // 
            // movementSquarestextBox
            // 
            this.movementSquarestextBox.Location = new System.Drawing.Point(82, 77);
            this.movementSquarestextBox.Name = "movementSquarestextBox";
            this.movementSquarestextBox.Size = new System.Drawing.Size(192, 20);
            this.movementSquarestextBox.TabIndex = 20;
            this.movementSquarestextBox.TextChanged += new System.EventHandler(this.movementSquarestextBox_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(42, 190);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Edit Stats";
            // 
            // cbStats
            // 
            this.cbStats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStats.FormattingEnabled = true;
            this.cbStats.Items.AddRange(new object[] {
            "None",
            "Hero Stats",
            "Monster Stats"});
            this.cbStats.Location = new System.Drawing.Point(82, 14);
            this.cbStats.Name = "cbStats";
            this.cbStats.Size = new System.Drawing.Size(212, 21);
            this.cbStats.TabIndex = 16;
            this.cbStats.SelectedIndexChanged += new System.EventHandler(this.cbStats_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Stats Box";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(224, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 20);
            this.label17.TabIndex = 35;
            this.label17.Text = "Card Parameters";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(707, 75);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(475, 642);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // CardDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 729);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btLoadcard);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.genericCardPanel);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "CardDesignerForm";
            this.Text = "Card Designer";
            this.Load += new System.EventHandler(this.CardDesignerForm_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenericCard)).EndInit();
            this.genericCardPanel.ResumeLayout(false);
            this.ParametersTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleFontSizeNumUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panelCardText.ResumeLayout(false);
            this.panelCardText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextLenghtNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextYnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextXnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFontSizeNumUpDown)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statValueYNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statValueXNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresMaxLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statValueNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoadcard;
        private System.Windows.Forms.SaveFileDialog saveCardDialog;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbGenericCard;
        private System.Windows.Forms.PictureBox pbHeroCard;
        private System.Windows.Forms.Panel genericCardPanel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabControl ParametersTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resetTitlePosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button moveImageDown;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button moveTitleUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox titleFontFamily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fontColorButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown titleFontSizeNumUpDown;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.CheckBox cbOldPaper;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.Button RemoveImageButton;
        private System.Windows.Forms.Button biggerImageButton;
        private System.Windows.Forms.Button makeImageSmallerButton;
        private System.Windows.Forms.Button moveImageRightButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button moveImageDownButton;
        private System.Windows.Forms.Button moveImageUpButton;
        private System.Windows.Forms.Panel panelCardText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown cardTextLenghtNumUpDown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown cardTextYnud;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown cardTextXnud;
        private System.Windows.Forms.ComboBox cardFontFamily;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button selectCardTextolor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox cardTextBox;
        private System.Windows.Forms.NumericUpDown cardFontSizeNumUpDown;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.ComboBox cbStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showScrollcb;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown movementSquaresMaxLenght;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown movementSquaresY;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown movementSquaresX;
        private System.Windows.Forms.NumericUpDown statValueNum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox movementSquarestextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RichTextBox movementSquaresRtb;
        private System.Windows.Forms.ComboBox individualStatsCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown statValueYNum;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown statValueXNum;
        private System.Windows.Forms.PictureBox pbCustomCard;
        private System.Windows.Forms.CheckBox cbShowBorder;
    }

}