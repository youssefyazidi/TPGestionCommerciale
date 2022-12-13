namespace TPGestionCommerciale
{
    partial class FormCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNCommande = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.comboBoxCodeClient = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateCommande = new System.Windows.Forms.DateTimePicker();
            this.comboBoxArticle = new System.Windows.Forms.ComboBox();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAjouterLigne = new System.Windows.Forms.Button();
            this.GrilleLignesCommande = new System.Windows.Forms.DataGridView();
            this.buttonSupprimerLigne = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonEnregistrerCommande = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrilleLignesCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisir une commande";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "N Commande :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date commande :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Code Client :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ville :";
            // 
            // textBoxNCommande
            // 
            this.textBoxNCommande.Enabled = false;
            this.textBoxNCommande.Location = new System.Drawing.Point(178, 75);
            this.textBoxNCommande.Name = "textBoxNCommande";
            this.textBoxNCommande.Size = new System.Drawing.Size(100, 20);
            this.textBoxNCommande.TabIndex = 6;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Enabled = false;
            this.textBoxNom.Location = new System.Drawing.Point(476, 99);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(121, 20);
            this.textBoxNom.TabIndex = 7;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Enabled = false;
            this.textBoxVille.Location = new System.Drawing.Point(476, 134);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(121, 20);
            this.textBoxVille.TabIndex = 8;
            // 
            // comboBoxCodeClient
            // 
            this.comboBoxCodeClient.FormattingEnabled = true;
            this.comboBoxCodeClient.Location = new System.Drawing.Point(476, 72);
            this.comboBoxCodeClient.Name = "comboBoxCodeClient";
            this.comboBoxCodeClient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodeClient.TabIndex = 9;
            this.comboBoxCodeClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodeClient_SelectedIndexChanged);
            // 
            // dateTimePickerDateCommande
            // 
            this.dateTimePickerDateCommande.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateCommande.Location = new System.Drawing.Point(178, 99);
            this.dateTimePickerDateCommande.Name = "dateTimePickerDateCommande";
            this.dateTimePickerDateCommande.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDateCommande.TabIndex = 10;
            // 
            // comboBoxArticle
            // 
            this.comboBoxArticle.FormattingEnabled = true;
            this.comboBoxArticle.Location = new System.Drawing.Point(18, 193);
            this.comboBoxArticle.Name = "comboBoxArticle";
            this.comboBoxArticle.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArticle.TabIndex = 11;
            this.comboBoxArticle.SelectedIndexChanged += new System.EventHandler(this.comboBoxArticle_SelectedIndexChanged);
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Enabled = false;
            this.textBoxDesignation.Location = new System.Drawing.Point(146, 193);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(121, 20);
            this.textBoxDesignation.TabIndex = 12;
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Enabled = false;
            this.textBoxPrix.Location = new System.Drawing.Point(273, 193);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrix.TabIndex = 13;
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Location = new System.Drawing.Point(400, 193);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(121, 20);
            this.textBoxQuantite.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Message";
            // 
            // buttonAjouterLigne
            // 
            this.buttonAjouterLigne.Location = new System.Drawing.Point(592, 191);
            this.buttonAjouterLigne.Name = "buttonAjouterLigne";
            this.buttonAjouterLigne.Size = new System.Drawing.Size(101, 23);
            this.buttonAjouterLigne.TabIndex = 16;
            this.buttonAjouterLigne.Text = "Ajouter ligne";
            this.buttonAjouterLigne.UseVisualStyleBackColor = true;
            this.buttonAjouterLigne.Click += new System.EventHandler(this.buttonAjouterLigne_Click);
            // 
            // GrilleLignesCommande
            // 
            this.GrilleLignesCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrilleLignesCommande.Location = new System.Drawing.Point(18, 220);
            this.GrilleLignesCommande.Name = "GrilleLignesCommande";
            this.GrilleLignesCommande.Size = new System.Drawing.Size(548, 113);
            this.GrilleLignesCommande.TabIndex = 17;
            // 
            // buttonSupprimerLigne
            // 
            this.buttonSupprimerLigne.Location = new System.Drawing.Point(592, 286);
            this.buttonSupprimerLigne.Name = "buttonSupprimerLigne";
            this.buttonSupprimerLigne.Size = new System.Drawing.Size(101, 23);
            this.buttonSupprimerLigne.TabIndex = 18;
            this.buttonSupprimerLigne.Text = "Supprimer ligne";
            this.buttonSupprimerLigne.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(400, 339);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 20;
            // 
            // buttonEnregistrerCommande
            // 
            this.buttonEnregistrerCommande.Location = new System.Drawing.Point(50, 364);
            this.buttonEnregistrerCommande.Name = "buttonEnregistrerCommande";
            this.buttonEnregistrerCommande.Size = new System.Drawing.Size(203, 23);
            this.buttonEnregistrerCommande.TabIndex = 21;
            this.buttonEnregistrerCommande.Text = "Enregistrer la commande";
            this.buttonEnregistrerCommande.UseVisualStyleBackColor = true;
            this.buttonEnregistrerCommande.Click += new System.EventHandler(this.buttonEnregistrerCommande_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(592, 364);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(101, 23);
            this.buttonQuitter.TabIndex = 22;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            // 
            // FormCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 424);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonEnregistrerCommande);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSupprimerLigne);
            this.Controls.Add(this.GrilleLignesCommande);
            this.Controls.Add(this.buttonAjouterLigne);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxQuantite);
            this.Controls.Add(this.textBoxPrix);
            this.Controls.Add(this.textBoxDesignation);
            this.Controls.Add(this.comboBoxArticle);
            this.Controls.Add(this.dateTimePickerDateCommande);
            this.Controls.Add(this.comboBoxCodeClient);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxNCommande);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCommande";
            this.Text = "FormCommande";
            this.Load += new System.EventHandler(this.FormCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrilleLignesCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNCommande;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.ComboBox comboBoxCodeClient;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateCommande;
        private System.Windows.Forms.ComboBox comboBoxArticle;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAjouterLigne;
        private System.Windows.Forms.DataGridView GrilleLignesCommande;
        private System.Windows.Forms.Button buttonSupprimerLigne;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonEnregistrerCommande;
        private System.Windows.Forms.Button buttonQuitter;
    }
}