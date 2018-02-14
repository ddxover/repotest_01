namespace testgithub
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
            this.btn_magic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_magic
            // 
            this.btn_magic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_magic.Location = new System.Drawing.Point(12, 12);
            this.btn_magic.Name = "btn_magic";
            this.btn_magic.Size = new System.Drawing.Size(274, 135);
            this.btn_magic.TabIndex = 0;
            this.btn_magic.Text = "Magic";
            this.btn_magic.UseVisualStyleBackColor = true;
            this.btn_magic.Click += new System.EventHandler(this.btn_magic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 159);
            this.Controls.Add(this.btn_magic);
            this.Name = "Form1";
            this.Text = "super form";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_magic;
    }
}

