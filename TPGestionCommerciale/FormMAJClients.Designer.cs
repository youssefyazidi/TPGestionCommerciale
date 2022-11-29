namespace TPGestionCommerciale
{
    partial class FormMAJClients
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
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonRechrcher = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCodeRecherche = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPremier = new System.Windows.Forms.Button();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonDernier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mise à jour Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code Client :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ville :";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(160, 78);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(154, 26);
            this.textBoxCode.TabIndex = 4;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(160, 131);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(154, 26);
            this.textBoxNom.TabIndex = 5;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(160, 192);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(154, 26);
            this.textBoxVille.TabIndex = 6;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.Location = new System.Drawing.Point(407, 76);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(215, 30);
            this.buttonAjouter.TabIndex = 7;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Enabled = false;
            this.buttonModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.Location = new System.Drawing.Point(407, 130);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(215, 30);
            this.buttonModifier.TabIndex = 8;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Enabled = false;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.Location = new System.Drawing.Point(407, 181);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(215, 30);
            this.buttonSupprimer.TabIndex = 9;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(407, 352);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(215, 30);
            this.buttonQuitter.TabIndex = 10;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonRechrcher
            // 
            this.buttonRechrcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRechrcher.Location = new System.Drawing.Point(132, 22);
            this.buttonRechrcher.Name = "buttonRechrcher";
            this.buttonRechrcher.Size = new System.Drawing.Size(136, 30);
            this.buttonRechrcher.TabIndex = 11;
            this.buttonRechrcher.Text = "Rechercher";
            this.buttonRechrcher.UseVisualStyleBackColor = true;
            this.buttonRechrcher.Click += new System.EventHandler(this.buttonRechrcher_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCodeRecherche);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonRechrcher);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(348, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // textBoxCodeRecherche
            // 
            this.textBoxCodeRecherche.Location = new System.Drawing.Point(132, 61);
            this.textBoxCodeRecherche.Name = "textBoxCodeRecherche";
            this.textBoxCodeRecherche.Size = new System.Drawing.Size(136, 22);
            this.textBoxCodeRecherche.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Code Client :";
            // 
            // buttonPremier
            // 
            this.buttonPremier.Location = new System.Drawing.Point(42, 271);
            this.buttonPremier.Name = "buttonPremier";
            this.buttonPremier.Size = new System.Drawing.Size(45, 33);
            this.buttonPremier.TabIndex = 13;
            this.buttonPremier.Text = "<";
            this.buttonPremier.UseVisualStyleBackColor = true;
            this.buttonPremier.Click += new System.EventHandler(this.buttonPremier_Click);
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Location = new System.Drawing.Point(103, 271);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(45, 33);
            this.buttonPrecedent.TabIndex = 14;
            this.buttonPrecedent.Text = "<<";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Location = new System.Drawing.Point(170, 271);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(45, 33);
            this.buttonSuivant.TabIndex = 15;
            this.buttonSuivant.Text = ">>";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // buttonDernier
            // 
            this.buttonDernier.Location = new System.Drawing.Point(245, 271);
            this.buttonDernier.Name = "buttonDernier";
            this.buttonDernier.Size = new System.Drawing.Size(45, 33);
            this.buttonDernier.TabIndex = 16;
            this.buttonDernier.Text = ">";
            this.buttonDernier.UseVisualStyleBackColor = true;
            this.buttonDernier.Click += new System.EventHandler(this.buttonDernier_Click);
            // 
            // FormMAJClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 413);
            this.Controls.Add(this.buttonDernier);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.buttonPremier);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMAJClients";
            this.Text = "FormMAJClients";
            this.Load += new System.EventHandler(this.FormMAJClients_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonRechrcher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCodeRecherche;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPremier;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonDernier;
    }
}