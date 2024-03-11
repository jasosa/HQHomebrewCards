
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
            this.btSave = new System.Windows.Forms.Button();
            this.btLoadcard = new System.Windows.Forms.Button();
            this.saveCardDialog = new System.Windows.Forms.SaveFileDialog();
            this.btExport = new System.Windows.Forms.Button();
            this.panelCardTypes = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetTitlePosition = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.lbTitleText = new System.Windows.Forms.Label();
            this.moveImageDown = new System.Windows.Forms.Button();
            this.titleFontFamily = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fontColorButton = new System.Windows.Forms.Button();
            this.moveTitleUp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.titleFontSizeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.showScrollcb = new System.Windows.Forms.CheckBox();
            this.panelImage = new System.Windows.Forms.Panel();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.moveImageUpButton = new System.Windows.Forms.Button();
            this.moveImageDownButton = new System.Windows.Forms.Button();
            this.moveImageRightButton = new System.Windows.Forms.Button();
            this.cbShowBorder = new System.Windows.Forms.CheckBox();
            this.cbOldPaper = new System.Windows.Forms.CheckBox();
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
            this.panelStats = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.statValueYNum = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.statValueXNum = new System.Windows.Forms.NumericUpDown();
            this.individualStatsCombo = new System.Windows.Forms.ComboBox();
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbCustomCard = new System.Windows.Forms.PictureBox();
            this.pbHeroCard = new System.Windows.Forms.PictureBox();
            this.pbGenericCard = new System.Windows.Forms.PictureBox();
            this.addImageButton = new System.Windows.Forms.Button();
            this.RemoveImageButton = new System.Windows.Forms.Button();
            this.makeImageBiggerButton = new System.Windows.Forms.Button();
            this.makeImageSmallerButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCardTypes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleFontSizeNumUpDown)).BeginInit();
            this.panelImage.SuspendLayout();
            this.panelCardText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextLenghtNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextYnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextXnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFontSizeNumUpDown)).BeginInit();
            this.panelStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statValueYNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statValueXNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresMaxLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statValueNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenericCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(229, 12);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(110, 23);
            this.btSave.TabIndex = 28;
            this.btSave.Text = "Save Design";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoadcard
            // 
            this.btLoadcard.Location = new System.Drawing.Point(127, 12);
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
            this.btExport.Location = new System.Drawing.Point(345, 12);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(110, 23);
            this.btExport.TabIndex = 30;
            this.btExport.Text = "Export Image";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // panelCardTypes
            // 
            this.panelCardTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardTypes.Controls.Add(this.pbCustomCard);
            this.panelCardTypes.Controls.Add(this.label16);
            this.panelCardTypes.Controls.Add(this.pbHeroCard);
            this.panelCardTypes.Controls.Add(this.pbGenericCard);
            this.panelCardTypes.Location = new System.Drawing.Point(503, 95);
            this.panelCardTypes.Name = "panelCardTypes";
            this.panelCardTypes.Size = new System.Drawing.Size(423, 225);
            this.panelCardTypes.TabIndex = 33;
            this.panelCardTypes.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(189, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Click to select a new card background";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.resetTitlePosition);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.lbTitleText);
            this.panel1.Controls.Add(this.moveImageDown);
            this.panel1.Controls.Add(this.titleFontFamily);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fontColorButton);
            this.panel1.Controls.Add(this.moveTitleUp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.titleFontSizeNumUpDown);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 151);
            this.panel1.TabIndex = 26;
            // 
            // resetTitlePosition
            // 
            this.resetTitlePosition.Location = new System.Drawing.Point(186, 114);
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
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Color";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(38, 14);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(312, 20);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // lbTitleText
            // 
            this.lbTitleText.AutoSize = true;
            this.lbTitleText.Location = new System.Drawing.Point(6, 18);
            this.lbTitleText.Name = "lbTitleText";
            this.lbTitleText.Size = new System.Drawing.Size(28, 13);
            this.lbTitleText.TabIndex = 14;
            this.lbTitleText.Text = "Text";
            // 
            // moveImageDown
            // 
            this.moveImageDown.Location = new System.Drawing.Point(95, 114);
            this.moveImageDown.Name = "moveImageDown";
            this.moveImageDown.Size = new System.Drawing.Size(85, 22);
            this.moveImageDown.TabIndex = 22;
            this.moveImageDown.Text = "Move Down";
            this.moveImageDown.UseVisualStyleBackColor = true;
            this.moveImageDown.Click += new System.EventHandler(this.moveTitleDown_Click);
            // 
            // titleFontFamily
            // 
            this.titleFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleFontFamily.FormattingEnabled = true;
            this.titleFontFamily.Location = new System.Drawing.Point(38, 38);
            this.titleFontFamily.Name = "titleFontFamily";
            this.titleFontFamily.Size = new System.Drawing.Size(312, 21);
            this.titleFontFamily.TabIndex = 13;
            this.titleFontFamily.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Font";
            // 
            // fontColorButton
            // 
            this.fontColorButton.Location = new System.Drawing.Point(38, 87);
            this.fontColorButton.Name = "fontColorButton";
            this.fontColorButton.Size = new System.Drawing.Size(97, 23);
            this.fontColorButton.TabIndex = 19;
            this.fontColorButton.Text = "Select Color";
            this.fontColorButton.UseVisualStyleBackColor = true;
            this.fontColorButton.Click += new System.EventHandler(this.fontColorButton_Click);
            // 
            // moveTitleUp
            // 
            this.moveTitleUp.Location = new System.Drawing.Point(4, 114);
            this.moveTitleUp.Name = "moveTitleUp";
            this.moveTitleUp.Size = new System.Drawing.Size(85, 22);
            this.moveTitleUp.TabIndex = 21;
            this.moveTitleUp.Text = "Move Up";
            this.moveTitleUp.UseVisualStyleBackColor = true;
            this.moveTitleUp.Click += new System.EventHandler(this.moveTitleUp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Size";
            // 
            // titleFontSizeNumUpDown
            // 
            this.titleFontSizeNumUpDown.Location = new System.Drawing.Point(38, 63);
            this.titleFontSizeNumUpDown.Name = "titleFontSizeNumUpDown";
            this.titleFontSizeNumUpDown.Size = new System.Drawing.Size(50, 20);
            this.titleFontSizeNumUpDown.TabIndex = 16;
            // 
            // showScrollcb
            // 
            this.showScrollcb.AutoSize = true;
            this.showScrollcb.Location = new System.Drawing.Point(861, 52);
            this.showScrollcb.Name = "showScrollcb";
            this.showScrollcb.Size = new System.Drawing.Size(82, 17);
            this.showScrollcb.TabIndex = 24;
            this.showScrollcb.Text = "Show Scroll";
            this.showScrollcb.UseVisualStyleBackColor = true;
            this.showScrollcb.CheckedChanged += new System.EventHandler(this.showScrollcb_CheckedChanged);
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.SystemColors.Control;
            this.panelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImage.Controls.Add(this.moveImageRightButton);
            this.panelImage.Controls.Add(this.addImageButton);
            this.panelImage.Controls.Add(this.moveLeftButton);
            this.panelImage.Controls.Add(this.RemoveImageButton);
            this.panelImage.Controls.Add(this.cbOldPaper);
            this.panelImage.Controls.Add(this.makeImageBiggerButton);
            this.panelImage.Controls.Add(this.makeImageSmallerButton);
            this.panelImage.Controls.Add(this.moveImageUpButton);
            this.panelImage.Controls.Add(this.moveImageDownButton);
            this.panelImage.Location = new System.Drawing.Point(12, 501);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(362, 183);
            this.panelImage.TabIndex = 26;
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.BackgroundImage = global::HQHomebrewCards.Properties.Resources.angulo_cuadrado_izquierda;
            this.moveLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.moveLeftButton.Location = new System.Drawing.Point(147, 35);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(64, 64);
            this.moveLeftButton.TabIndex = 8;
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // moveImageUpButton
            // 
            this.moveImageUpButton.BackgroundImage = global::HQHomebrewCards.Properties.Resources.angulo_cuadrado_hacia_arriba;
            this.moveImageUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.moveImageUpButton.Location = new System.Drawing.Point(216, 3);
            this.moveImageUpButton.Name = "moveImageUpButton";
            this.moveImageUpButton.Size = new System.Drawing.Size(64, 64);
            this.moveImageUpButton.TabIndex = 6;
            this.moveImageUpButton.UseVisualStyleBackColor = true;
            this.moveImageUpButton.Click += new System.EventHandler(this.moveImageUpButton_Click);
            // 
            // moveImageDownButton
            // 
            this.moveImageDownButton.BackColor = System.Drawing.Color.Transparent;
            this.moveImageDownButton.BackgroundImage = global::HQHomebrewCards.Properties.Resources.angulo_cuadrado_abajo;
            this.moveImageDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.moveImageDownButton.Location = new System.Drawing.Point(216, 73);
            this.moveImageDownButton.Name = "moveImageDownButton";
            this.moveImageDownButton.Size = new System.Drawing.Size(64, 64);
            this.moveImageDownButton.TabIndex = 7;
            this.moveImageDownButton.UseVisualStyleBackColor = false;
            this.moveImageDownButton.Click += new System.EventHandler(this.moveImageDownButton_Click);
            // 
            // moveImageRightButton
            // 
            this.moveImageRightButton.BackgroundImage = global::HQHomebrewCards.Properties.Resources.angulo_cuadrado_derecho;
            this.moveImageRightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.moveImageRightButton.Location = new System.Drawing.Point(286, 35);
            this.moveImageRightButton.Name = "moveImageRightButton";
            this.moveImageRightButton.Size = new System.Drawing.Size(64, 64);
            this.moveImageRightButton.TabIndex = 9;
            this.moveImageRightButton.UseVisualStyleBackColor = true;
            this.moveImageRightButton.Click += new System.EventHandler(this.moveImageRightButton_Click);
            // 
            // cbShowBorder
            // 
            this.cbShowBorder.AutoSize = true;
            this.cbShowBorder.Location = new System.Drawing.Point(861, 75);
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
            this.cbOldPaper.Location = new System.Drawing.Point(6, 161);
            this.cbOldPaper.Name = "cbOldPaper";
            this.cbOldPaper.Size = new System.Drawing.Size(147, 17);
            this.cbOldPaper.TabIndex = 12;
            this.cbOldPaper.Text = "Mostrar Fondo Pergamino";
            this.cbOldPaper.UseVisualStyleBackColor = true;
            this.cbOldPaper.CheckStateChanged += new System.EventHandler(this.cbOldPaper_CheckedChanged);
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
            this.panelCardText.Location = new System.Drawing.Point(12, 217);
            this.panelCardText.Name = "panelCardText";
            this.panelCardText.Size = new System.Drawing.Size(362, 270);
            this.panelCardText.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(137, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Text Length";
            // 
            // cardTextLenghtNumUpDown
            // 
            this.cardTextLenghtNumUpDown.Location = new System.Drawing.Point(137, 239);
            this.cardTextLenghtNumUpDown.Name = "cardTextLenghtNumUpDown";
            this.cardTextLenghtNumUpDown.Size = new System.Drawing.Size(50, 20);
            this.cardTextLenghtNumUpDown.TabIndex = 31;
            this.cardTextLenghtNumUpDown.Click += new System.EventHandler(this.CardTextLenghtNumUpDown_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Text Y";
            // 
            // cardTextYnud
            // 
            this.cardTextYnud.Location = new System.Drawing.Point(73, 239);
            this.cardTextYnud.Name = "cardTextYnud";
            this.cardTextYnud.Size = new System.Drawing.Size(50, 20);
            this.cardTextYnud.TabIndex = 29;
            this.cardTextYnud.Click += new System.EventHandler(this.CardTextY_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Text X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Color";
            // 
            // cardTextXnud
            // 
            this.cardTextXnud.Location = new System.Drawing.Point(7, 239);
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
            this.cardFontFamily.Location = new System.Drawing.Point(38, 132);
            this.cardFontFamily.Name = "cardFontFamily";
            this.cardFontFamily.Size = new System.Drawing.Size(236, 21);
            this.cardFontFamily.TabIndex = 24;
            this.cardFontFamily.SelectedIndexChanged += new System.EventHandler(this.CardFontFamily_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Size";
            // 
            // selectCardTextolor
            // 
            this.selectCardTextolor.Location = new System.Drawing.Point(38, 187);
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
            this.label11.Location = new System.Drawing.Point(8, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Font";
            // 
            // cardTextBox
            // 
            this.cardTextBox.AcceptsTab = true;
            this.cardTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cardTextBox.Location = new System.Drawing.Point(38, 5);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(269, 121);
            this.cardTextBox.TabIndex = 28;
            this.cardTextBox.Text = "";
            this.cardTextBox.TextChanged += new System.EventHandler(this.cardTextBox_TextChanged);
            // 
            // cardFontSizeNumUpDown
            // 
            this.cardFontSizeNumUpDown.Location = new System.Drawing.Point(39, 159);
            this.cardFontSizeNumUpDown.Name = "cardFontSizeNumUpDown";
            this.cardFontSizeNumUpDown.Size = new System.Drawing.Size(50, 20);
            this.cardFontSizeNumUpDown.TabIndex = 16;
            this.cardFontSizeNumUpDown.ValueChanged += new System.EventHandler(this.CardFontSizeNumUpDown_ValueChanged);
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.label8);
            this.panelStats.Controls.Add(this.statValueYNum);
            this.panelStats.Controls.Add(this.label23);
            this.panelStats.Controls.Add(this.statValueXNum);
            this.panelStats.Controls.Add(this.individualStatsCombo);
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
            this.panelStats.Location = new System.Drawing.Point(727, 353);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(452, 272);
            this.panelStats.TabIndex = 1;
            this.panelStats.Visible = false;
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
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(3, 41);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(35, 17);
            this.lbTitle.TabIndex = 34;
            this.lbTitle.Text = "Title";
            // 
            // pbCustomCard
            // 
            this.pbCustomCard.Image = global::HQHomebrewCards.Properties.Resources.Custom;
            this.pbCustomCard.Location = new System.Drawing.Point(277, 33);
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
            this.pbHeroCard.Location = new System.Drawing.Point(140, 33);
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
            this.pbGenericCard.Location = new System.Drawing.Point(6, 33);
            this.pbGenericCard.Name = "pbGenericCard";
            this.pbGenericCard.Size = new System.Drawing.Size(129, 177);
            this.pbGenericCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGenericCard.TabIndex = 0;
            this.pbGenericCard.TabStop = false;
            this.pbGenericCard.Click += new System.EventHandler(this.pbGenericCard_Click);
            // 
            // addImageButton
            // 
            this.addImageButton.BackgroundImage = global::HQHomebrewCards.Properties.Resources.anadir_imagen;
            this.addImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addImageButton.Location = new System.Drawing.Point(7, 8);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(64, 64);
            this.addImageButton.TabIndex = 4;
            this.addImageButton.UseVisualStyleBackColor = false;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // RemoveImageButton
            // 
            this.RemoveImageButton.BackgroundImage = global::HQHomebrewCards.Properties.Resources.papelera_xmark;
            this.RemoveImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveImageButton.Location = new System.Drawing.Point(6, 77);
            this.RemoveImageButton.Name = "RemoveImageButton";
            this.RemoveImageButton.Size = new System.Drawing.Size(64, 64);
            this.RemoveImageButton.TabIndex = 5;
            this.RemoveImageButton.UseVisualStyleBackColor = true;
            this.RemoveImageButton.Click += new System.EventHandler(this.RemoveImageButton_Click);
            // 
            // makeImageBiggerButton
            // 
            this.makeImageBiggerButton.BackgroundImage = global::HQHomebrewCards.Properties.Resources.acercarse;
            this.makeImageBiggerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.makeImageBiggerButton.Location = new System.Drawing.Point(77, 8);
            this.makeImageBiggerButton.Name = "makeImageBiggerButton";
            this.makeImageBiggerButton.Size = new System.Drawing.Size(64, 64);
            this.makeImageBiggerButton.TabIndex = 10;
            this.makeImageBiggerButton.UseVisualStyleBackColor = true;
            this.makeImageBiggerButton.Click += new System.EventHandler(this.makeImageBigger_Click);
            // 
            // makeImageSmallerButton
            // 
            this.makeImageSmallerButton.BackgroundImage = global::HQHomebrewCards.Properties.Resources.buscar;
            this.makeImageSmallerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.makeImageSmallerButton.Location = new System.Drawing.Point(77, 78);
            this.makeImageSmallerButton.Name = "makeImageSmallerButton";
            this.makeImageSmallerButton.Size = new System.Drawing.Size(64, 64);
            this.makeImageSmallerButton.TabIndex = 11;
            this.makeImageSmallerButton.UseVisualStyleBackColor = true;
            this.makeImageSmallerButton.Click += new System.EventHandler(this.makeImageSmallerButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::HQHomebrewCards.Properties.Resources.old_paper;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Change Card Type";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPreview.BackColor = System.Drawing.SystemColors.Control;
            this.pbPreview.Location = new System.Drawing.Point(380, 51);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(475, 633);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 1;
            this.pbPreview.TabStop = false;
            this.pbPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pbPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pbPreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Image";
            // 
            // CardDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelCardTypes);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.cbShowBorder);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.panelCardText);
            this.Controls.Add(this.showScrollcb);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btLoadcard);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.pbPreview);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "CardDesignerForm";
            this.Text = "Card Designer";
            this.Load += new System.EventHandler(this.CardDesignerForm_Load);
            this.panelCardTypes.ResumeLayout(false);
            this.panelCardTypes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleFontSizeNumUpDown)).EndInit();
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            this.panelCardText.ResumeLayout(false);
            this.panelCardText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextLenghtNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextYnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextXnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFontSizeNumUpDown)).EndInit();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statValueYNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statValueXNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresMaxLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statValueNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenericCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoadcard;
        private System.Windows.Forms.SaveFileDialog saveCardDialog;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Panel panelCardTypes;
        private System.Windows.Forms.PictureBox pbGenericCard;
        private System.Windows.Forms.PictureBox pbHeroCard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resetTitlePosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button moveImageDown;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button moveTitleUp;
        private System.Windows.Forms.Label lbTitleText;
        private System.Windows.Forms.ComboBox titleFontFamily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fontColorButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown titleFontSizeNumUpDown;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.CheckBox cbOldPaper;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.Button RemoveImageButton;
        private System.Windows.Forms.Button makeImageBiggerButton;
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
        private System.Windows.Forms.ComboBox individualStatsCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown statValueYNum;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown statValueXNum;
        private System.Windows.Forms.PictureBox pbCustomCard;
        private System.Windows.Forms.CheckBox cbShowBorder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label2;
    }

}