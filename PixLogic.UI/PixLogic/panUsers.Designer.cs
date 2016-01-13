﻿namespace PixLogic
{
    partial class panUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panUsers));
            this.panTableUsers = new System.Windows.Forms.Panel();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.IdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NickNameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valUserName = new System.Windows.Forms.Label();
            this.panNews = new System.Windows.Forms.Panel();
            this.valUserCredits = new System.Windows.Forms.Label();
            this.labelCredits = new System.Windows.Forms.Label();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.valClass = new System.Windows.Forms.Label();
            this.valUserId = new System.Windows.Forms.Label();
            this.valTel = new System.Windows.Forms.Label();
            this.valMail = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.valUserNickName = new System.Windows.Forms.Label();
            this.labelListUser = new System.Windows.Forms.Label();
            this.labelNews = new System.Windows.Forms.Label();
            this.buttonAjoutCredit = new System.Windows.Forms.Button();
            this.buttonReinitCredit = new System.Windows.Forms.Button();
            this.buttonMailSent = new System.Windows.Forms.Button();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureReserver = new System.Windows.Forms.PictureBox();
            this.panTableUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.panNews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReserver)).BeginInit();
            this.SuspendLayout();
            // 
            // panTableUsers
            // 
            this.panTableUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panTableUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTableUsers.Controls.Add(this.buttonCancelSearch);
            this.panTableUsers.Controls.Add(this.textBoxSearch);
            this.panTableUsers.Controls.Add(this.labelSearch);
            this.panTableUsers.Controls.Add(this.dataGridUsers);
            this.panTableUsers.Location = new System.Drawing.Point(5, 3);
            this.panTableUsers.Name = "panTableUsers";
            this.panTableUsers.Size = new System.Drawing.Size(212, 428);
            this.panTableUsers.TabIndex = 22;
            // 
            // buttonCancelSearch
            // 
            this.buttonCancelSearch.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancelSearch.Location = new System.Drawing.Point(167, 16);
            this.buttonCancelSearch.Name = "buttonCancelSearch";
            this.buttonCancelSearch.Size = new System.Drawing.Size(27, 23);
            this.buttonCancelSearch.TabIndex = 3;
            this.buttonCancelSearch.UseVisualStyleBackColor = true;
            this.buttonCancelSearch.Click += new System.EventHandler(this.buttonCancelSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(67, 17);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(96, 20);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyUp);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(2, 19);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(66, 13);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Recherche :";
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(231)))));
            this.dataGridUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUser,
            this.NameUser,
            this.NickNameUser,
            this.email,
            this.tel,
            this.classe,
            this.credits});
            this.dataGridUsers.Location = new System.Drawing.Point(0, 47);
            this.dataGridUsers.MultiSelect = false;
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowHeadersVisible = false;
            this.dataGridUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(211, 379);
            this.dataGridUsers.TabIndex = 0;
            this.dataGridUsers.Click += new System.EventHandler(this.dataGridUsers_Click);
            this.dataGridUsers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridUsers_KeyUp);
            // 
            // IdUser
            // 
            this.IdUser.HeaderText = "Id";
            this.IdUser.Name = "IdUser";
            this.IdUser.ReadOnly = true;
            this.IdUser.Width = 60;
            // 
            // NameUser
            // 
            this.NameUser.HeaderText = "Nom";
            this.NameUser.Name = "NameUser";
            this.NameUser.ReadOnly = true;
            this.NameUser.Width = 75;
            // 
            // NickNameUser
            // 
            this.NickNameUser.HeaderText = "Prenom";
            this.NickNameUser.Name = "NickNameUser";
            this.NickNameUser.ReadOnly = true;
            this.NickNameUser.Width = 75;
            // 
            // email
            // 
            this.email.HeaderText = "E-Mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 160;
            // 
            // tel
            // 
            this.tel.HeaderText = "Tel";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            this.tel.Width = 80;
            // 
            // classe
            // 
            this.classe.HeaderText = "Classe";
            this.classe.Name = "classe";
            this.classe.ReadOnly = true;
            this.classe.Width = 80;
            // 
            // credits
            // 
            this.credits.HeaderText = "Crédits";
            this.credits.Name = "credits";
            this.credits.ReadOnly = true;
            this.credits.Width = 75;
            // 
            // valUserName
            // 
            this.valUserName.AutoSize = true;
            this.valUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valUserName.Location = new System.Drawing.Point(223, 1);
            this.valUserName.Name = "valUserName";
            this.valUserName.Size = new System.Drawing.Size(46, 21);
            this.valUserName.TabIndex = 24;
            this.valUserName.Text = "Nom";
            this.valUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panNews
            // 
            this.panNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panNews.Controls.Add(this.valUserCredits);
            this.panNews.Controls.Add(this.labelCredits);
            this.panNews.Controls.Add(this.labelIdentifiant);
            this.panNews.Controls.Add(this.valClass);
            this.panNews.Controls.Add(this.valUserId);
            this.panNews.Controls.Add(this.valTel);
            this.panNews.Controls.Add(this.valMail);
            this.panNews.Controls.Add(this.labelClass);
            this.panNews.Controls.Add(this.labelTel);
            this.panNews.Controls.Add(this.labelMail);
            this.panNews.Location = new System.Drawing.Point(227, 197);
            this.panNews.Name = "panNews";
            this.panNews.Size = new System.Drawing.Size(264, 113);
            this.panNews.TabIndex = 27;
            // 
            // valUserCredits
            // 
            this.valUserCredits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valUserCredits.AutoSize = true;
            this.valUserCredits.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valUserCredits.Location = new System.Drawing.Point(198, 17);
            this.valUserCredits.Name = "valUserCredits";
            this.valUserCredits.Size = new System.Drawing.Size(11, 13);
            this.valUserCredits.TabIndex = 41;
            this.valUserCredits.Text = "-";
            this.valUserCredits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCredits
            // 
            this.labelCredits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCredits.AutoSize = true;
            this.labelCredits.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredits.Location = new System.Drawing.Point(146, 17);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(49, 13);
            this.labelCredits.TabIndex = 40;
            this.labelCredits.Text = "Credits :";
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentifiant.Location = new System.Drawing.Point(0, 16);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(23, 13);
            this.labelIdentifiant.TabIndex = 6;
            this.labelIdentifiant.Text = "Id :";
            // 
            // valClass
            // 
            this.valClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valClass.AutoSize = true;
            this.valClass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valClass.Location = new System.Drawing.Point(49, 92);
            this.valClass.Name = "valClass";
            this.valClass.Size = new System.Drawing.Size(13, 17);
            this.valClass.TabIndex = 5;
            this.valClass.Text = "-";
            // 
            // valUserId
            // 
            this.valUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valUserId.AutoSize = true;
            this.valUserId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valUserId.Location = new System.Drawing.Point(49, 14);
            this.valUserId.Name = "valUserId";
            this.valUserId.Size = new System.Drawing.Size(13, 17);
            this.valUserId.TabIndex = 39;
            this.valUserId.Text = "-";
            this.valUserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valTel
            // 
            this.valTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valTel.AutoSize = true;
            this.valTel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTel.Location = new System.Drawing.Point(49, 66);
            this.valTel.Name = "valTel";
            this.valTel.Size = new System.Drawing.Size(13, 17);
            this.valTel.TabIndex = 4;
            this.valTel.Text = "-";
            // 
            // valMail
            // 
            this.valMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valMail.AutoSize = true;
            this.valMail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valMail.Location = new System.Drawing.Point(49, 40);
            this.valMail.Name = "valMail";
            this.valMail.Size = new System.Drawing.Size(13, 17);
            this.valMail.TabIndex = 3;
            this.valMail.Text = "-";
            // 
            // labelClass
            // 
            this.labelClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(0, 95);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(45, 13);
            this.labelClass.TabIndex = 2;
            this.labelClass.Text = "Classe :";
            // 
            // labelTel
            // 
            this.labelTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.Location = new System.Drawing.Point(0, 68);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(26, 13);
            this.labelTel.TabIndex = 1;
            this.labelTel.Text = "tel :";
            // 
            // labelMail
            // 
            this.labelMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(0, 42);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(35, 13);
            this.labelMail.TabIndex = 0;
            this.labelMail.Text = "Mail :";
            // 
            // valUserNickName
            // 
            this.valUserNickName.AutoSize = true;
            this.valUserNickName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valUserNickName.Location = new System.Drawing.Point(373, 1);
            this.valUserNickName.Name = "valUserNickName";
            this.valUserNickName.Size = new System.Drawing.Size(67, 21);
            this.valUserNickName.TabIndex = 28;
            this.valUserNickName.Text = "Prénom";
            this.valUserNickName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelListUser
            // 
            this.labelListUser.AutoSize = true;
            this.labelListUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListUser.Location = new System.Drawing.Point(23, -2);
            this.labelListUser.Name = "labelListUser";
            this.labelListUser.Size = new System.Drawing.Size(112, 13);
            this.labelListUser.TabIndex = 40;
            this.labelListUser.Text = "Liste des utilisateurs";
            // 
            // labelNews
            // 
            this.labelNews.AutoSize = true;
            this.labelNews.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNews.Location = new System.Drawing.Point(249, 193);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(33, 13);
            this.labelNews.TabIndex = 41;
            this.labelNews.Text = "Infos";
            // 
            // buttonAjoutCredit
            // 
            this.buttonAjoutCredit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAjoutCredit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjoutCredit.Image = global::PixLogic.Properties.Resources.add_credit;
            this.buttonAjoutCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjoutCredit.Location = new System.Drawing.Point(511, 252);
            this.buttonAjoutCredit.Name = "buttonAjoutCredit";
            this.buttonAjoutCredit.Size = new System.Drawing.Size(162, 43);
            this.buttonAjoutCredit.TabIndex = 57;
            this.buttonAjoutCredit.Text = "Ajouter crédit utilisateur";
            this.buttonAjoutCredit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAjoutCredit.UseVisualStyleBackColor = true;
            this.buttonAjoutCredit.Click += new System.EventHandler(this.buttonAjoutCredit_Click);
            // 
            // buttonReinitCredit
            // 
            this.buttonReinitCredit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonReinitCredit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReinitCredit.Image = global::PixLogic.Properties.Resources.rebase;
            this.buttonReinitCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReinitCredit.Location = new System.Drawing.Point(511, 197);
            this.buttonReinitCredit.Name = "buttonReinitCredit";
            this.buttonReinitCredit.Size = new System.Drawing.Size(162, 43);
            this.buttonReinitCredit.TabIndex = 56;
            this.buttonReinitCredit.Text = "Réinitialiser les crédits";
            this.buttonReinitCredit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReinitCredit.UseVisualStyleBackColor = true;
            this.buttonReinitCredit.Click += new System.EventHandler(this.buttonReinitCredit_Click);
            this.buttonReinitCredit.MouseEnter += new System.EventHandler(this.buttonReinitCredit_MouseEnter);
            // 
            // buttonMailSent
            // 
            this.buttonMailSent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonMailSent.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMailSent.Image = global::PixLogic.Properties.Resources.envoyer_color_success;
            this.buttonMailSent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMailSent.Location = new System.Drawing.Point(511, 78);
            this.buttonMailSent.Name = "buttonMailSent";
            this.buttonMailSent.Size = new System.Drawing.Size(162, 43);
            this.buttonMailSent.TabIndex = 55;
            this.buttonMailSent.Text = "Liste mails envoyés";
            this.buttonMailSent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMailSent.UseVisualStyleBackColor = true;
            this.buttonMailSent.Click += new System.EventHandler(this.buttonMailSent_Click);
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSendMail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendMail.Image = global::PixLogic.Properties.Resources.envoyer_color;
            this.buttonSendMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSendMail.Location = new System.Drawing.Point(511, 25);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(162, 43);
            this.buttonSendMail.TabIndex = 54;
            this.buttonSendMail.Text = "Envoyer un message";
            this.buttonSendMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSendMail.UseVisualStyleBackColor = true;
            this.buttonSendMail.Click += new System.EventHandler(this.buttonSendMail_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Image = global::PixLogic.Properties.Resources.supprimer_icon;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(398, 403);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(93, 29);
            this.buttonDelete.TabIndex = 38;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.InitialImage = null;
            this.pictureBoxUser.Location = new System.Drawing.Point(227, 25);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(264, 166);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 37;
            this.pictureBoxUser.TabStop = false;
            // 
            // buttonModify
            // 
            this.buttonModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonModify.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.Image = global::PixLogic.Properties.Resources.modifier_icon;
            this.buttonModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModify.Location = new System.Drawing.Point(312, 403);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(78, 29);
            this.buttonModify.TabIndex = 30;
            this.buttonModify.Text = "Modifier";
            this.buttonModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Image = global::PixLogic.Properties.Resources.ajouter_icon;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(228, 403);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 29);
            this.buttonAdd.TabIndex = 29;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureReserver
            // 
            this.pictureReserver.BackColor = System.Drawing.Color.Transparent;
            this.pictureReserver.Image = ((System.Drawing.Image)(resources.GetObject("pictureReserver.Image")));
            this.pictureReserver.Location = new System.Drawing.Point(468, 307);
            this.pictureReserver.Name = "pictureReserver";
            this.pictureReserver.Size = new System.Drawing.Size(23, 23);
            this.pictureReserver.TabIndex = 53;
            this.pictureReserver.TabStop = false;
            this.pictureReserver.Click += new System.EventHandler(this.pictureReserver_Click);
            this.pictureReserver.MouseEnter += new System.EventHandler(this.pictureReserver_MouseEnter);
            // 
            // panUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonAjoutCredit);
            this.Controls.Add(this.buttonReinitCredit);
            this.Controls.Add(this.buttonMailSent);
            this.Controls.Add(this.buttonSendMail);
            this.Controls.Add(this.labelNews);
            this.Controls.Add(this.labelListUser);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.valUserNickName);
            this.Controls.Add(this.panNews);
            this.Controls.Add(this.valUserName);
            this.Controls.Add(this.panTableUsers);
            this.Controls.Add(this.pictureReserver);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "panUsers";
            this.Size = new System.Drawing.Size(688, 452);
            this.panTableUsers.ResumeLayout(false);
            this.panTableUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.panNews.ResumeLayout(false);
            this.panNews.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReserver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTableUsers;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridUsers;
        public System.Windows.Forms.Label valUserName;
        private System.Windows.Forms.Panel panNews;
        private System.Windows.Forms.Label valClass;
        private System.Windows.Forms.Label valTel;
        private System.Windows.Forms.Label valMail;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelMail;
        public System.Windows.Forms.Label valUserNickName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.Label valUserId;
        private System.Windows.Forms.Label labelListUser;
        private System.Windows.Forms.Label labelNews;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.PictureBox pictureReserver;
        public System.Windows.Forms.Label valUserCredits;
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NickNameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn credits;
        private System.Windows.Forms.Button buttonSendMail;
        private System.Windows.Forms.Button buttonMailSent;
        private System.Windows.Forms.Button buttonReinitCredit;
        private System.Windows.Forms.Button buttonAjoutCredit;
    }
}
