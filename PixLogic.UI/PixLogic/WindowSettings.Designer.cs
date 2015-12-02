namespace PixLogic
{
    partial class WindowSettings
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
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelConfiguration = new System.Windows.Forms.Label();
            this.labelServer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valServeur = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.valPassword = new System.Windows.Forms.TextBox();
            this.valEmailAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.valInfo = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControlSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPage1);
            this.tabControlSettings.Controls.Add(this.tabPage2);
            this.tabControlSettings.Location = new System.Drawing.Point(12, 12);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(574, 351);
            this.tabControlSettings.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.labelInfo);
            this.tabPage1.Controls.Add(this.valInfo);
            this.tabPage1.Controls.Add(this.labelIdentifiant);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.labelConfiguration);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(566, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Envoi e-mail";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.valServeur);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelServer);
            this.panel1.Location = new System.Drawing.Point(6, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 102);
            this.panel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(566, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelConfiguration
            // 
            this.labelConfiguration.AutoSize = true;
            this.labelConfiguration.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfiguration.Location = new System.Drawing.Point(24, 10);
            this.labelConfiguration.Name = "labelConfiguration";
            this.labelConfiguration.Size = new System.Drawing.Size(121, 13);
            this.labelConfiguration.TabIndex = 1;
            this.labelConfiguration.Text = "Configuration serveur";
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServer.Location = new System.Drawing.Point(17, 25);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(82, 13);
            this.labelServer.TabIndex = 0;
            this.labelServer.Text = "Serveur SMTP :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port :";
            // 
            // valServeur
            // 
            this.valServeur.Location = new System.Drawing.Point(105, 21);
            this.valServeur.Name = "valServeur";
            this.valServeur.Size = new System.Drawing.Size(215, 22);
            this.valServeur.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 3;
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentifiant.Location = new System.Drawing.Point(24, 131);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(140, 13);
            this.labelIdentifiant.TabIndex = 3;
            this.labelIdentifiant.Text = "Identifiants de connexion";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.valPassword);
            this.panel2.Controls.Add(this.valEmailAdress);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelEmail);
            this.panel2.Location = new System.Drawing.Point(6, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 102);
            this.panel2.TabIndex = 2;
            // 
            // valPassword
            // 
            this.valPassword.Location = new System.Drawing.Point(105, 55);
            this.valPassword.Name = "valPassword";
            this.valPassword.Size = new System.Drawing.Size(215, 22);
            this.valPassword.TabIndex = 3;
            this.valPassword.UseSystemPasswordChar = true;
            // 
            // valEmailAdress
            // 
            this.valEmailAdress.Location = new System.Drawing.Point(105, 21);
            this.valEmailAdress.Name = "valEmailAdress";
            this.valEmailAdress.Size = new System.Drawing.Size(215, 22);
            this.valEmailAdress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mot de passe :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(17, 25);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(84, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Adresse email :";
            // 
            // valInfo
            // 
            this.valInfo.AutoSize = true;
            this.valInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.valInfo.Location = new System.Drawing.Point(44, 251);
            this.valInfo.Name = "valInfo";
            this.valInfo.Size = new System.Drawing.Size(396, 13);
            this.valInfo.TabIndex = 4;
            this.valInfo.Text = "Pensez à activer le protocole POP et/ou le service IMAP de votre messagerie. ";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelInfo.Location = new System.Drawing.Point(7, 250);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(36, 15);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "Info :";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Image = global::PixLogic.Properties.Resources.valider_icon;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(222, 292);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 27);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Enregistrer";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // WindowSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 375);
            this.Controls.Add(this.tabControlSettings);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paramètres de configuration";
            this.tabControlSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelConfiguration;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox valPassword;
        private System.Windows.Forms.TextBox valEmailAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox valServeur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label valInfo;
        private System.Windows.Forms.Button buttonSave;
    }
}