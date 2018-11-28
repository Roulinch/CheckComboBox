namespace CheckComboBox
{
    partial class CheckComboBox
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ttbMain = new System.Windows.Forms.TextBox();
            this.btnDropDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ttbMain
            // 
            this.ttbMain.Location = new System.Drawing.Point(0, 0);
            this.ttbMain.Name = "ttbMain";
            this.ttbMain.ReadOnly = true;
            this.ttbMain.Size = new System.Drawing.Size(241, 20);
            this.ttbMain.TabIndex = 0;
            this.ttbMain.Click += new System.EventHandler(this.ttbMain_Click);
            // 
            // btnDropDown
            // 
            this.btnDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDropDown.Location = new System.Drawing.Point(241, 0);
            this.btnDropDown.Name = "btnDropDown";
            this.btnDropDown.Size = new System.Drawing.Size(24, 20);
            this.btnDropDown.TabIndex = 1;
            this.btnDropDown.Text = "▼";
            this.btnDropDown.UseVisualStyleBackColor = true;
            this.btnDropDown.Click += new System.EventHandler(this.btnDropDown_Click);
            // 
            // CheckComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDropDown);
            this.Controls.Add(this.ttbMain);
            this.Name = "CheckComboBox";
            this.Size = new System.Drawing.Size(265, 19);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ttbMain;
        private System.Windows.Forms.Button btnDropDown;
    }
}
