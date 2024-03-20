namespace HQHomebrewCards.CustomControls
{
    partial class ButtonController
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btRight = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.btUp = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btCenter = new System.Windows.Forms.Button();
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRight
            // 
            this.btRight.BackgroundImage = global::HQHomebrewCards.Properties.Resources.angulo_cuadrado_derecho;
            this.btRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRight.Location = new System.Drawing.Point(117, 3);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(32, 32);
            this.btRight.TabIndex = 7;
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btRight_MouseDown);
            this.btRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btRight_MouseUp);
            // 
            // btDown
            // 
            this.btDown.BackgroundImage = global::HQHomebrewCards.Properties.Resources.angulo_cuadrado_abajo;
            this.btDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDown.Location = new System.Drawing.Point(79, 3);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(32, 32);
            this.btDown.TabIndex = 6;
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btDown_MouseDown);
            this.btDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btDown_MouseUp);
            // 
            // btUp
            // 
            this.btUp.BackgroundImage = global::HQHomebrewCards.Properties.Resources.angulo_cuadrado_hacia_arriba;
            this.btUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btUp.Location = new System.Drawing.Point(41, 3);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(32, 32);
            this.btUp.TabIndex = 5;
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btUp_MouseDown);
            this.btUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btUp_MouseUp);
            // 
            // btLeft
            // 
            this.btLeft.BackgroundImage = global::HQHomebrewCards.Properties.Resources.angulo_cuadrado_izquierda;
            this.btLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLeft.Location = new System.Drawing.Point(3, 3);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(32, 32);
            this.btLeft.TabIndex = 4;
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btLeft_MouseDown);
            this.btLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btLeft_MouseUp);
            // 
            // flowPanel
            // 
            this.flowPanel.Controls.Add(this.btLeft);
            this.flowPanel.Controls.Add(this.btUp);
            this.flowPanel.Controls.Add(this.btDown);
            this.flowPanel.Controls.Add(this.btRight);
            this.flowPanel.Controls.Add(this.btCenter);
            this.flowPanel.Location = new System.Drawing.Point(3, 3);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(191, 39);
            this.flowPanel.TabIndex = 8;
            // 
            // btCenter
            // 
            this.btCenter.BackgroundImage = global::HQHomebrewCards.Properties.Resources.abajo_a_la_izquierda_y_arriba_a_la_derecha_al_centro;
            this.btCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCenter.Location = new System.Drawing.Point(155, 3);
            this.btCenter.Name = "btCenter";
            this.btCenter.Size = new System.Drawing.Size(32, 32);
            this.btCenter.TabIndex = 8;
            this.btCenter.UseVisualStyleBackColor = true;
            this.btCenter.Click += new System.EventHandler(this.btCenter_Click);
            // 
            // ButtonController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowPanel);
            this.Name = "ButtonController";
            this.Size = new System.Drawing.Size(227, 47);
            this.flowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Button btCenter;
    }
}
