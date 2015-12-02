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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelListCategory = new System.Windows.Forms.Label();
            this.panelListCategory = new System.Windows.Forms.Panel();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.valInfo = new System.Windows.Forms.Label();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.valPassword = new System.Windows.Forms.TextBox();
            this.valEmailAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelConfiguration = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.valServeur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelServer = new System.Windows.Forms.Label();
            this.labelNews = new System.Windows.Forms.Label();
            this.panNews = new System.Windows.Forms.Panel();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.valLibelle = new System.Windows.Forms.Label();
            this.labelDescrip = new System.Windows.Forms.Label();
            this.valDescription = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlSettings.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelListCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panNews.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPage2);
            this.tabControlSettings.Controls.Add(this.tabPage1);
            this.tabControlSettings.Location = new System.Drawing.Point(12, 12);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(574, 351);
            this.tabControlSettings.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.buttonDelete);
            this.tabPage2.Controls.Add(this.buttonModify);
            this.tabPage2.Controls.Add(this.buttonAdd);
            this.tabPage2.Controls.Add(this.labelNews);
            this.tabPage2.Controls.Add(this.panNews);
            this.tabPage2.Controls.Add(this.labelListCategory);
            this.tabPage2.Controls.Add(this.panelListCategory);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(566, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Catégorie";
            // 
            // labelListCategory
            // 
            this.labelListCategory.AutoSize = true;
            this.labelListCategory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListCategory.Location = new System.Drawing.Point(24, 9);
            this.labelListCategory.Name = "labelListCategory";
            this.labelListCategory.Size = new System.Drawing.Size(108, 13);
            this.labelListCategory.TabIndex = 2;
            this.labelListCategory.Text = "Liste des catégories";
            // 
            // panelListCategory
            // 
            this.panelListCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelListCategory.Controls.Add(this.buttonCancelSearch);
            this.panelListCategory.Controls.Add(this.textBoxSearch);
            this.panelListCategory.Controls.Add(this.labelSearch);
            this.panelListCategory.Controls.Add(this.dataGridView1);
            this.panelListCategory.Location = new System.Drawing.Point(6, 14);
            this.panelListCategory.Name = "panelListCategory";
            this.panelListCategory.Size = new System.Drawing.Size(228, 305);
            this.panelListCategory.TabIndex = 0;
            // 
            // buttonCancelSearch
            // 
            this.buttonCancelSearch.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancelSearch.Location = new System.Drawing.Point(177, 16);
            this.buttonCancelSearch.Name = "buttonCancelSearch";
            this.buttonCancelSearch.Size = new System.Drawing.Size(27, 23);
            this.buttonCancelSearch.TabIndex = 6;
            this.buttonCancelSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(77, 17);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(96, 22);
            this.textBoxSearch.TabIndex = 5;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(12, 19);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(66, 13);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Recherche :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.libelleCol,
            this.descriptCol});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(228, 251);
            this.dataGridView1.TabIndex = 0;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 3;
            // 
            // valServeur
            // 
            this.valServeur.Location = new System.Drawing.Point(105, 21);
            this.valServeur.Name = "valServeur";
            this.valServeur.Size = new System.Drawing.Size(215, 22);
            this.valServeur.TabIndex = 2;
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
            // labelNews
            // 
            this.labelNews.AutoSize = true;
            this.labelNews.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNews.Location = new System.Drawing.Point(262, 10);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(33, 13);
            this.labelNews.TabIndex = 43;
            this.labelNews.Text = "Infos";
            // 
            // panNews
            // 
            this.panNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panNews.Controls.Add(this.valDescription);
            this.panNews.Controls.Add(this.labelDescrip);
            this.panNews.Controls.Add(this.labelLibelle);
            this.panNews.Controls.Add(this.valLibelle);
            this.panNews.Location = new System.Drawing.Point(240, 14);
            this.panNews.Name = "panNews";
            this.panNews.Size = new System.Drawing.Size(320, 193);
            this.panNews.TabIndex = 42;
            // 
            // labelLibelle
            // 
            this.labelLibelle.AutoSize = true;
            this.labelLibelle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibelle.Location = new System.Drawing.Point(6, 19);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(46, 13);
            this.labelLibelle.TabIndex = 6;
            this.labelLibelle.Text = "Libellé :";
            // 
            // valLibelle
            // 
            this.valLibelle.AutoSize = true;
            this.valLibelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valLibelle.Location = new System.Drawing.Point(78, 17);
            this.valLibelle.Name = "valLibelle";
            this.valLibelle.Size = new System.Drawing.Size(13, 17);
            this.valLibelle.TabIndex = 39;
            this.valLibelle.Text = "-";
            this.valLibelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDescrip
            // 
            this.labelDescrip.AutoSize = true;
            this.labelDescrip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescrip.Location = new System.Drawing.Point(6, 49);
            this.labelDescrip.Name = "labelDescrip";
            this.labelDescrip.Size = new System.Drawing.Size(72, 13);
            this.labelDescrip.TabIndex = 40;
            this.labelDescrip.Text = "Description :";
            // 
            // valDescription
            // 
            this.valDescription.Location = new System.Drawing.Point(84, 57);
            this.valDescription.Multiline = true;
            this.valDescription.Name = "valDescription";
            this.valDescription.ReadOnly = true;
            this.valDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.valDescription.Size = new System.Drawing.Size(231, 131);
            this.valDescription.TabIndex = 41;
            this.valDescription.WordWrap = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Image = global::PixLogic.Properties.Resources.supprimer_icon;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(444, 290);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(93, 29);
            this.buttonDelete.TabIndex = 46;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.Image = global::PixLogic.Properties.Resources.modifier_icon;
            this.buttonModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModify.Location = new System.Drawing.Point(358, 290);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(78, 29);
            this.buttonModify.TabIndex = 45;
            this.buttonModify.Text = "Modifier";
            this.buttonModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Image = global::PixLogic.Properties.Resources.ajouter_icon;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(274, 290);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 29);
            this.buttonAdd.TabIndex = 44;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "Id";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Width = 40;
            // 
            // libelleCol
            // 
            this.libelleCol.HeaderText = "Libellé";
            this.libelleCol.Name = "libelleCol";
            this.libelleCol.ReadOnly = true;
            this.libelleCol.Width = 95;
            // 
            // descriptCol
            // 
            this.descriptCol.HeaderText = "Description";
            this.descriptCol.Name = "descriptCol";
            this.descriptCol.ReadOnly = true;
            this.descriptCol.Width = 90;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelListCategory.ResumeLayout(false);
            this.panelListCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panNews.ResumeLayout(false);
            this.panNews.PerformLayout();
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
        private System.Windows.Forms.Label labelListCategory;
        private System.Windows.Forms.Panel panelListCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelNews;
        private System.Windows.Forms.Panel panNews;
        private System.Windows.Forms.TextBox valDescription;
        private System.Windows.Forms.Label labelDescrip;
        private System.Windows.Forms.Label labelLibelle;
        public System.Windows.Forms.Label valLibelle;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptCol;
    }
}