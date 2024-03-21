
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardDesignerForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveCardDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelCardTypes = new System.Windows.Forms.Panel();
            this.pbCustomCard = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pbHeroCard = new System.Windows.Forms.PictureBox();
            this.pbGenericCard = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btScroll = new HQHomebrewCards.CustomControls.ButtonController();
            this.btControllerTitleText = new HQHomebrewCards.CustomControls.ButtonController();
            this.numTitleFontSize = new HQHomebrewCards.CustomNumericUpDown();
            this.btReduceTitleFontSize = new System.Windows.Forms.Button();
            this.btIncreaseTitleFontSize = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.moveImageDown = new System.Windows.Forms.Button();
            this.titleFontFamily = new System.Windows.Forms.ComboBox();
            this.fontColorButton = new System.Windows.Forms.Button();
            this.showScrollcb = new System.Windows.Forms.CheckBox();
            this.moveTitleUp = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.makeImageSmallerButton = new System.Windows.Forms.Button();
            this.btControllerOverlayImage = new HQHomebrewCards.CustomControls.ButtonController();
            this.addImageButton = new System.Windows.Forms.Button();
            this.RemoveImageButton = new System.Windows.Forms.Button();
            this.cbOldPaper = new System.Windows.Forms.CheckBox();
            this.makeImageBiggerButton = new System.Windows.Forms.Button();
            this.cbShowBorder = new System.Windows.Forms.CheckBox();
            this.panelCardText = new System.Windows.Forms.Panel();
            this.btControllerCardText = new HQHomebrewCards.CustomControls.ButtonController();
            this.btDecreaseCardFontSizr = new System.Windows.Forms.Button();
            this.btIncreaseCardFontSize = new System.Windows.Forms.Button();
            this.numCardFontSize = new HQHomebrewCards.CustomNumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.cardTextLenghtNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.cardTextYnud = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.cardTextXnud = new System.Windows.Forms.NumericUpDown();
            this.cardFontFamily = new System.Windows.Forms.ComboBox();
            this.selectCardTextolor = new System.Windows.Forms.Button();
            this.cardTextBox = new System.Windows.Forms.RichTextBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btSelectCardType = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.panelCardTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenericCard)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTitleFontSize)).BeginInit();
            this.panelImage.SuspendLayout();
            this.panelCardText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCardFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextLenghtNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextYnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextXnud)).BeginInit();
            this.panelStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statValueYNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statValueXNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresMaxLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statValueNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // saveCardDialog
            // 
            this.saveCardDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveCardDialog_FileOk);
            // 
            // panelCardTypes
            // 
            this.panelCardTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardTypes.Controls.Add(this.pbCustomCard);
            this.panelCardTypes.Controls.Add(this.label16);
            this.panelCardTypes.Controls.Add(this.pbHeroCard);
            this.panelCardTypes.Controls.Add(this.pbGenericCard);
            this.panelCardTypes.Location = new System.Drawing.Point(358, 35);
            this.panelCardTypes.Name = "panelCardTypes";
            this.panelCardTypes.Size = new System.Drawing.Size(421, 230);
            this.panelCardTypes.TabIndex = 33;
            this.panelCardTypes.Visible = false;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btScroll);
            this.panel1.Controls.Add(this.btControllerTitleText);
            this.panel1.Controls.Add(this.numTitleFontSize);
            this.panel1.Controls.Add(this.btReduceTitleFontSize);
            this.panel1.Controls.Add(this.btIncreaseTitleFontSize);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.moveImageDown);
            this.panel1.Controls.Add(this.titleFontFamily);
            this.panel1.Controls.Add(this.fontColorButton);
            this.panel1.Controls.Add(this.showScrollcb);
            this.panel1.Controls.Add(this.moveTitleUp);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 209);
            this.panel1.TabIndex = 26;
            // 
            // btScroll
            // 
            this.btScroll.ButtonCenterVisible = true;
            this.btScroll.ButtonDownVisible = true;
            this.btScroll.ButtonLeftVisible = false;
            this.btScroll.ButtonRightVisible = false;
            this.btScroll.ButtonUpVisible = true;
            this.btScroll.Location = new System.Drawing.Point(3, 146);
            this.btScroll.Name = "btScroll";
            this.btScroll.Size = new System.Drawing.Size(128, 47);
            this.btScroll.TabIndex = 39;
            this.btScroll.ButtonPressed += new System.EventHandler<HQHomebrewCards.CustomControls.ButtonPressedEventArgs>(this.btScroll_ButtonPressed);
            this.btScroll.ButtonUnPressed += new System.EventHandler<HQHomebrewCards.CustomControls.ButtonUnPressedEventArgs>(this.btScroll_ButtonUnPressed);
            // 
            // btControllerTitleText
            // 
            this.btControllerTitleText.ButtonCenterVisible = true;
            this.btControllerTitleText.ButtonDownVisible = true;
            this.btControllerTitleText.ButtonLeftVisible = false;
            this.btControllerTitleText.ButtonRightVisible = false;
            this.btControllerTitleText.ButtonUpVisible = true;
            this.btControllerTitleText.Location = new System.Drawing.Point(35, 75);
            this.btControllerTitleText.Name = "btControllerTitleText";
            this.btControllerTitleText.Size = new System.Drawing.Size(128, 47);
            this.btControllerTitleText.TabIndex = 38;
            this.btControllerTitleText.ButtonPressed += new System.EventHandler<HQHomebrewCards.CustomControls.ButtonPressedEventArgs>(this.btControllerTitleText_ButtonPressed);
            this.btControllerTitleText.ButtonUnPressed += new System.EventHandler<HQHomebrewCards.CustomControls.ButtonUnPressedEventArgs>(this.btControllerTitleText_ButtonUnPressed);
            this.btControllerTitleText.ButtonCenterClick += new System.EventHandler<System.EventArgs>(this.btControllerTitleText_ButtonCenterClick);
            // 
            // numTitleFontSize
            // 
            this.numTitleFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTitleFontSize.Location = new System.Drawing.Point(190, 47);
            this.numTitleFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTitleFontSize.Name = "numTitleFontSize";
            this.numTitleFontSize.Size = new System.Drawing.Size(50, 23);
            this.numTitleFontSize.TabIndex = 27;
            this.numTitleFontSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btReduceTitleFontSize
            // 
            this.btReduceTitleFontSize.BackgroundImage = global::HQHomebrewCards.Properties.Resources.letra_reducir;
            this.btReduceTitleFontSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btReduceTitleFontSize.Location = new System.Drawing.Point(284, 41);
            this.btReduceTitleFontSize.Name = "btReduceTitleFontSize";
            this.btReduceTitleFontSize.Size = new System.Drawing.Size(32, 32);
            this.btReduceTitleFontSize.TabIndex = 25;
            this.btReduceTitleFontSize.UseVisualStyleBackColor = true;
            this.btReduceTitleFontSize.Click += new System.EventHandler(this.btReduceTitleFontSize_Click);
            // 
            // btIncreaseTitleFontSize
            // 
            this.btIncreaseTitleFontSize.BackgroundImage = global::HQHomebrewCards.Properties.Resources.letra_incrementar;
            this.btIncreaseTitleFontSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btIncreaseTitleFontSize.Location = new System.Drawing.Point(246, 41);
            this.btIncreaseTitleFontSize.Name = "btIncreaseTitleFontSize";
            this.btIncreaseTitleFontSize.Size = new System.Drawing.Size(32, 32);
            this.btIncreaseTitleFontSize.TabIndex = 24;
            this.btIncreaseTitleFontSize.UseVisualStyleBackColor = true;
            this.btIncreaseTitleFontSize.Click += new System.EventHandler(this.btIncreaseTitleFontSize_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(4, 12);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(312, 23);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // moveImageDown
            // 
            this.moveImageDown.BackgroundImage = global::HQHomebrewCards.Properties.Resources.angulo_cuadrado_abajo;
            this.moveImageDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.moveImageDown.Location = new System.Drawing.Point(80, 80);
            this.moveImageDown.Name = "moveImageDown";
            this.moveImageDown.Size = new System.Drawing.Size(32, 32);
            this.moveImageDown.TabIndex = 22;
            this.moveImageDown.UseVisualStyleBackColor = true;
            this.moveImageDown.Click += new System.EventHandler(this.moveTitleDown_Click);
            // 
            // titleFontFamily
            // 
            this.titleFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleFontFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleFontFamily.FormattingEnabled = true;
            this.titleFontFamily.Location = new System.Drawing.Point(4, 46);
            this.titleFontFamily.Name = "titleFontFamily";
            this.titleFontFamily.Size = new System.Drawing.Size(180, 24);
            this.titleFontFamily.TabIndex = 13;
            this.titleFontFamily.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
            // 
            // fontColorButton
            // 
            this.fontColorButton.BackgroundImage = global::HQHomebrewCards.Properties.Resources.paleta;
            this.fontColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fontColorButton.Location = new System.Drawing.Point(4, 80);
            this.fontColorButton.Name = "fontColorButton";
            this.fontColorButton.Size = new System.Drawing.Size(32, 32);
            this.fontColorButton.TabIndex = 19;
            this.fontColorButton.Text = "Select Color";
            this.fontColorButton.UseVisualStyleBackColor = true;
            this.fontColorButton.Click += new System.EventHandler(this.fontColorButton_Click);
            // 
            // showScrollcb
            // 
            this.showScrollcb.AutoSize = true;
            this.showScrollcb.Location = new System.Drawing.Point(4, 128);
            this.showScrollcb.Name = "showScrollcb";
            this.showScrollcb.Size = new System.Drawing.Size(82, 17);
            this.showScrollcb.TabIndex = 24;
            this.showScrollcb.Text = "Show Scroll";
            this.showScrollcb.UseVisualStyleBackColor = true;
            this.showScrollcb.CheckedChanged += new System.EventHandler(this.showScrollcb_CheckedChanged);
            // 
            // moveTitleUp
            // 
            this.moveTitleUp.BackgroundImage = global::HQHomebrewCards.Properties.Resources.angulo_cuadrado_hacia_arriba;
            this.moveTitleUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.moveTitleUp.Location = new System.Drawing.Point(42, 80);
            this.moveTitleUp.Name = "moveTitleUp";
            this.moveTitleUp.Size = new System.Drawing.Size(32, 32);
            this.moveTitleUp.TabIndex = 21;
            this.moveTitleUp.UseVisualStyleBackColor = true;
            this.moveTitleUp.Click += new System.EventHandler(this.moveTitleUp_Click);
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.SystemColors.Control;
            this.panelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImage.Controls.Add(this.makeImageSmallerButton);
            this.panelImage.Controls.Add(this.btControllerOverlayImage);
            this.panelImage.Controls.Add(this.addImageButton);
            this.panelImage.Controls.Add(this.RemoveImageButton);
            this.panelImage.Controls.Add(this.cbOldPaper);
            this.panelImage.Controls.Add(this.makeImageBiggerButton);
            this.panelImage.Location = new System.Drawing.Point(12, 303);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(347, 72);
            this.panelImage.TabIndex = 26;
            // 
            // makeImageSmallerButton
            // 
            this.makeImageSmallerButton.BackgroundImage = global::HQHomebrewCards.Properties.Resources.buscar;
            this.makeImageSmallerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.makeImageSmallerButton.Location = new System.Drawing.Point(118, 6);
            this.makeImageSmallerButton.Name = "makeImageSmallerButton";
            this.makeImageSmallerButton.Size = new System.Drawing.Size(32, 32);
            this.makeImageSmallerButton.TabIndex = 11;
            this.makeImageSmallerButton.UseVisualStyleBackColor = true;
            this.makeImageSmallerButton.Click += new System.EventHandler(this.makeImageSmallerButton_Click);
            // 
            // btControllerOverlayImage
            // 
            this.btControllerOverlayImage.ButtonCenterVisible = true;
            this.btControllerOverlayImage.ButtonDownVisible = true;
            this.btControllerOverlayImage.ButtonLeftVisible = true;
            this.btControllerOverlayImage.ButtonRightVisible = true;
            this.btControllerOverlayImage.ButtonUpVisible = true;
            this.btControllerOverlayImage.Location = new System.Drawing.Point(147, 0);
            this.btControllerOverlayImage.Name = "btControllerOverlayImage";
            this.btControllerOverlayImage.Size = new System.Drawing.Size(189, 40);
            this.btControllerOverlayImage.TabIndex = 38;
            this.btControllerOverlayImage.ButtonPressed += new System.EventHandler<HQHomebrewCards.CustomControls.ButtonPressedEventArgs>(this.btControllerOverlayImage_ButtonPressed);
            this.btControllerOverlayImage.ButtonUnPressed += new System.EventHandler<HQHomebrewCards.CustomControls.ButtonUnPressedEventArgs>(this.btControllerOverlayImage_ButtonUnPressed);
            this.btControllerOverlayImage.ButtonCenterClick += new System.EventHandler<System.EventArgs>(this.btControllerOverlayImage_ButtonCenterClick);
            // 
            // addImageButton
            // 
            this.addImageButton.BackgroundImage = global::HQHomebrewCards.Properties.Resources.anadir_imagen;
            this.addImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addImageButton.Location = new System.Drawing.Point(4, 6);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(32, 32);
            this.addImageButton.TabIndex = 4;
            this.addImageButton.UseVisualStyleBackColor = false;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // RemoveImageButton
            // 
            this.RemoveImageButton.BackgroundImage = global::HQHomebrewCards.Properties.Resources.papelera_xmark;
            this.RemoveImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveImageButton.Location = new System.Drawing.Point(42, 6);
            this.RemoveImageButton.Name = "RemoveImageButton";
            this.RemoveImageButton.Size = new System.Drawing.Size(32, 32);
            this.RemoveImageButton.TabIndex = 5;
            this.RemoveImageButton.UseVisualStyleBackColor = true;
            this.RemoveImageButton.Click += new System.EventHandler(this.RemoveImageButton_Click);
            // 
            // cbOldPaper
            // 
            this.cbOldPaper.AutoSize = true;
            this.cbOldPaper.Location = new System.Drawing.Point(7, 52);
            this.cbOldPaper.Name = "cbOldPaper";
            this.cbOldPaper.Size = new System.Drawing.Size(115, 17);
            this.cbOldPaper.TabIndex = 12;
            this.cbOldPaper.Text = "Show scroll texture";
            this.cbOldPaper.UseVisualStyleBackColor = true;
            this.cbOldPaper.CheckStateChanged += new System.EventHandler(this.cbOldPaper_CheckedChanged);
            // 
            // makeImageBiggerButton
            // 
            this.makeImageBiggerButton.BackgroundImage = global::HQHomebrewCards.Properties.Resources.acercarse;
            this.makeImageBiggerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.makeImageBiggerButton.Location = new System.Drawing.Point(80, 6);
            this.makeImageBiggerButton.Name = "makeImageBiggerButton";
            this.makeImageBiggerButton.Size = new System.Drawing.Size(32, 32);
            this.makeImageBiggerButton.TabIndex = 10;
            this.makeImageBiggerButton.UseVisualStyleBackColor = true;
            this.makeImageBiggerButton.Click += new System.EventHandler(this.makeImageBigger_Click);
            // 
            // cbShowBorder
            // 
            this.cbShowBorder.AutoSize = true;
            this.cbShowBorder.Location = new System.Drawing.Point(839, 94);
            this.cbShowBorder.Name = "cbShowBorder";
            this.cbShowBorder.Size = new System.Drawing.Size(92, 17);
            this.cbShowBorder.TabIndex = 13;
            this.cbShowBorder.Text = "Mostrar Borde";
            this.cbShowBorder.UseVisualStyleBackColor = true;
            this.cbShowBorder.CheckedChanged += new System.EventHandler(this.cbShowBorder_CheckedChanged);
            // 
            // panelCardText
            // 
            this.panelCardText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardText.Controls.Add(this.btControllerCardText);
            this.panelCardText.Controls.Add(this.btDecreaseCardFontSizr);
            this.panelCardText.Controls.Add(this.btIncreaseCardFontSize);
            this.panelCardText.Controls.Add(this.numCardFontSize);
            this.panelCardText.Controls.Add(this.label15);
            this.panelCardText.Controls.Add(this.cardTextLenghtNumUpDown);
            this.panelCardText.Controls.Add(this.label14);
            this.panelCardText.Controls.Add(this.cardTextYnud);
            this.panelCardText.Controls.Add(this.label13);
            this.panelCardText.Controls.Add(this.cardTextXnud);
            this.panelCardText.Controls.Add(this.cardFontFamily);
            this.panelCardText.Controls.Add(this.selectCardTextolor);
            this.panelCardText.Controls.Add(this.cardTextBox);
            this.panelCardText.Location = new System.Drawing.Point(12, 407);
            this.panelCardText.Name = "panelCardText";
            this.panelCardText.Size = new System.Drawing.Size(347, 279);
            this.panelCardText.TabIndex = 28;
            // 
            // btControllerCardText
            // 
            this.btControllerCardText.ButtonCenterVisible = false;
            this.btControllerCardText.ButtonDownVisible = true;
            this.btControllerCardText.ButtonLeftVisible = true;
            this.btControllerCardText.ButtonRightVisible = true;
            this.btControllerCardText.ButtonUpVisible = true;
            this.btControllerCardText.Location = new System.Drawing.Point(39, 167);
            this.btControllerCardText.Name = "btControllerCardText";
            this.btControllerCardText.Size = new System.Drawing.Size(201, 40);
            this.btControllerCardText.TabIndex = 39;
            this.btControllerCardText.ButtonPressed += new System.EventHandler<HQHomebrewCards.CustomControls.ButtonPressedEventArgs>(this.btControllerCardText_ButtonPressed);
            this.btControllerCardText.ButtonUnPressed += new System.EventHandler<HQHomebrewCards.CustomControls.ButtonUnPressedEventArgs>(this.btControllerCardText_ButtonUnPressed);
            // 
            // btDecreaseCardFontSizr
            // 
            this.btDecreaseCardFontSizr.BackgroundImage = global::HQHomebrewCards.Properties.Resources.letra_reducir;
            this.btDecreaseCardFontSizr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDecreaseCardFontSizr.Location = new System.Drawing.Point(284, 132);
            this.btDecreaseCardFontSizr.Name = "btDecreaseCardFontSizr";
            this.btDecreaseCardFontSizr.Size = new System.Drawing.Size(32, 32);
            this.btDecreaseCardFontSizr.TabIndex = 29;
            this.btDecreaseCardFontSizr.UseVisualStyleBackColor = true;
            this.btDecreaseCardFontSizr.Click += new System.EventHandler(this.btDecreaseCardFontSizr_Click);
            // 
            // btIncreaseCardFontSize
            // 
            this.btIncreaseCardFontSize.BackgroundImage = global::HQHomebrewCards.Properties.Resources.letra_incrementar;
            this.btIncreaseCardFontSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btIncreaseCardFontSize.Location = new System.Drawing.Point(246, 132);
            this.btIncreaseCardFontSize.Name = "btIncreaseCardFontSize";
            this.btIncreaseCardFontSize.Size = new System.Drawing.Size(32, 32);
            this.btIncreaseCardFontSize.TabIndex = 28;
            this.btIncreaseCardFontSize.UseVisualStyleBackColor = true;
            this.btIncreaseCardFontSize.Click += new System.EventHandler(this.btIncreaseCardFontSize_Click);
            // 
            // numCardFontSize
            // 
            this.numCardFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCardFontSize.Location = new System.Drawing.Point(190, 138);
            this.numCardFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCardFontSize.Name = "numCardFontSize";
            this.numCardFontSize.Size = new System.Drawing.Size(50, 23);
            this.numCardFontSize.TabIndex = 28;
            this.numCardFontSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.cardFontFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardFontFamily.FormattingEnabled = true;
            this.cardFontFamily.Location = new System.Drawing.Point(7, 137);
            this.cardFontFamily.Name = "cardFontFamily";
            this.cardFontFamily.Size = new System.Drawing.Size(177, 24);
            this.cardFontFamily.TabIndex = 24;
            this.cardFontFamily.SelectedIndexChanged += new System.EventHandler(this.CardFontFamily_SelectedIndexChanged);
            // 
            // selectCardTextolor
            // 
            this.selectCardTextolor.BackgroundImage = global::HQHomebrewCards.Properties.Resources.paleta;
            this.selectCardTextolor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.selectCardTextolor.Location = new System.Drawing.Point(4, 172);
            this.selectCardTextolor.Name = "selectCardTextolor";
            this.selectCardTextolor.Size = new System.Drawing.Size(32, 32);
            this.selectCardTextolor.TabIndex = 19;
            this.selectCardTextolor.Text = "Select Color";
            this.selectCardTextolor.UseVisualStyleBackColor = true;
            this.selectCardTextolor.Click += new System.EventHandler(this.selectCardTextolor_Click);
            // 
            // cardTextBox
            // 
            this.cardTextBox.AcceptsTab = true;
            this.cardTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cardTextBox.Location = new System.Drawing.Point(9, 14);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(307, 112);
            this.cardTextBox.TabIndex = 28;
            this.cardTextBox.Text = "";
            this.cardTextBox.TextChanged += new System.EventHandler(this.cardTextBox_TextChanged);
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
            this.panelStats.Location = new System.Drawing.Point(674, 412);
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
            this.lbTitle.Location = new System.Drawing.Point(12, 51);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(35, 17);
            this.lbTitle.TabIndex = 34;
            this.lbTitle.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(567, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Preview";
            // 
            // btSelectCardType
            // 
            this.btSelectCardType.BackgroundImage = global::HQHomebrewCards.Properties.Resources.elegir;
            this.btSelectCardType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSelectCardType.Location = new System.Drawing.Point(12, 12);
            this.btSelectCardType.Name = "btSelectCardType";
            this.btSelectCardType.Size = new System.Drawing.Size(32, 32);
            this.btSelectCardType.TabIndex = 3;
            this.btSelectCardType.UseVisualStyleBackColor = true;
            this.btSelectCardType.Click += new System.EventHandler(this.btSelectCardType_click);
            // 
            // btExport
            // 
            this.btExport.BackgroundImage = global::HQHomebrewCards.Properties.Resources.camara;
            this.btExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btExport.Location = new System.Drawing.Point(126, 12);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(32, 32);
            this.btExport.TabIndex = 30;
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btLoad
            // 
            this.btLoad.BackgroundImage = global::HQHomebrewCards.Properties.Resources.carga_de_carpeta;
            this.btLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLoad.Location = new System.Drawing.Point(50, 12);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(32, 32);
            this.btLoad.TabIndex = 29;
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btSave
            // 
            this.btSave.BackgroundImage = global::HQHomebrewCards.Properties.Resources.disco;
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSave.Location = new System.Drawing.Point(88, 12);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(32, 32);
            this.btSave.TabIndex = 28;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPreview.BackColor = System.Drawing.SystemColors.Control;
            this.pbPreview.Location = new System.Drawing.Point(370, 71);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(475, 613);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 1;
            this.pbPreview.TabStop = false;
            this.pbPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pbPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pbPreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // CardDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelCardTypes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.cbShowBorder);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.panelCardText);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSelectCardType);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.pbPreview);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "CardDesignerForm";
            this.Text = "Card Designer";
            this.Load += new System.EventHandler(this.CardDesignerForm_Load);
            this.panelCardTypes.ResumeLayout(false);
            this.panelCardTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenericCard)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTitleFontSize)).EndInit();
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            this.panelCardText.ResumeLayout(false);
            this.panelCardText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCardFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextLenghtNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextYnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTextXnud)).EndInit();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statValueYNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statValueXNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresMaxLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementSquaresX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statValueNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.SaveFileDialog saveCardDialog;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Panel panelCardTypes;
        private System.Windows.Forms.PictureBox pbGenericCard;
        private System.Windows.Forms.PictureBox pbHeroCard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button moveImageDown;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button moveTitleUp;
        private System.Windows.Forms.ComboBox titleFontFamily;
        private System.Windows.Forms.Button fontColorButton;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.CheckBox cbOldPaper;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.Button RemoveImageButton;
        private System.Windows.Forms.Button makeImageBiggerButton;
        private System.Windows.Forms.Button makeImageSmallerButton;
        private System.Windows.Forms.Panel panelCardText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown cardTextLenghtNumUpDown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown cardTextYnud;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown cardTextXnud;
        private System.Windows.Forms.ComboBox cardFontFamily;
        private System.Windows.Forms.Button selectCardTextolor;
        private System.Windows.Forms.RichTextBox cardTextBox;
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
        private System.Windows.Forms.Button btSelectCardType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btIncreaseTitleFontSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btReduceTitleFontSize;
        private CustomNumericUpDown numTitleFontSize;
        private System.Windows.Forms.Button btDecreaseCardFontSizr;
        private System.Windows.Forms.Button btIncreaseCardFontSize;
        private CustomNumericUpDown numCardFontSize;
        private HQHomebrewCards.CustomControls.ButtonController btControllerOverlayImage;
        private HQHomebrewCards.CustomControls.ButtonController btControllerCardText;
        private HQHomebrewCards.CustomControls.ButtonController btControllerTitleText;
        private CustomControls.ButtonController btScroll;
    }

}