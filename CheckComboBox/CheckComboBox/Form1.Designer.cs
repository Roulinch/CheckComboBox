namespace CheckComboBox
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkComboBox1 = new CheckComboBox();
            this.checkComboBox2 = new CheckComboBox();
            this.SuspendLayout();
            // 
            // checkComboBox1
            // 
            this.checkComboBox1.Location = new System.Drawing.Point(48, 67);
            this.checkComboBox1.Name = "checkComboBox1";
            this.checkComboBox1.PlaceholderText = "A placeholder text";
            this.checkComboBox1.Size = new System.Drawing.Size(265, 19);
            this.checkComboBox1.TabIndex = 0;
            this.checkComboBox1.TextMode = CheckComboBoxTextMode.Items;
            // 
            // checkComboBox2
            // 
            this.checkComboBox2.Location = new System.Drawing.Point(483, 66);
            this.checkComboBox2.Name = "checkComboBox2";
            this.checkComboBox2.PlaceholderText = "A placeholder text 2";
            this.checkComboBox2.Size = new System.Drawing.Size(141, 19);
            this.checkComboBox2.TabIndex = 1;
            this.checkComboBox2.TextMode = CheckComboBoxTextMode.Items;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkComboBox2);
            this.Controls.Add(this.checkComboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CheckComboBox checkComboBox1;
        private CheckComboBox checkComboBox2;
    }
}

