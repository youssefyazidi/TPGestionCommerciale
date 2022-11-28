namespace TPGestionCommerciale
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
            this.listBoxNomsClients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxNomsClients
            // 
            this.listBoxNomsClients.FormattingEnabled = true;
            this.listBoxNomsClients.Location = new System.Drawing.Point(97, 37);
            this.listBoxNomsClients.Name = "listBoxNomsClients";
            this.listBoxNomsClients.Size = new System.Drawing.Size(301, 225);
            this.listBoxNomsClients.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 317);
            this.Controls.Add(this.listBoxNomsClients);
            this.Name = "Form1";
            this.Text = "Liste des noms des clients :";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNomsClients;
    }
}

