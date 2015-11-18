namespace PixLogic
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
            this.panTableUsers = new System.Windows.Forms.Panel();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NickNameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valUserName = new System.Windows.Forms.Label();
            this.panNews = new System.Windows.Forms.Panel();
            this.valClass = new System.Windows.Forms.Label();
            this.valTel = new System.Windows.Forms.Label();
            this.valMail = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.valUserNickName = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.valUserId = new System.Windows.Forms.Label();
            this.panTableUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.panNews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panTableUsers
            // 
            this.panTableUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTableUsers.Controls.Add(this.buttonCancelSearch);
            this.panTableUsers.Controls.Add(this.textBoxSearch);
            this.panTableUsers.Controls.Add(this.labelSearch);
            this.panTableUsers.Controls.Add(this.dataGridUsers);
            this.panTableUsers.Location = new System.Drawing.Point(7, 4);
            this.panTableUsers.Margin = new System.Windows.Forms.Padding(4);
            this.panTableUsers.Name = "panTableUsers";
            this.panTableUsers.Size = new System.Drawing.Size(266, 505);
            this.panTableUsers.TabIndex = 22;
            // 
            // buttonCancelSearch
            // 
            this.buttonCancelSearch.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancelSearch.Location = new System.Drawing.Point(223, 20);
            this.buttonCancelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelSearch.Name = "buttonCancelSearch";
            this.buttonCancelSearch.Size = new System.Drawing.Size(36, 28);
            this.buttonCancelSearch.TabIndex = 3;
            this.buttonCancelSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(89, 21);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(127, 22);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(3, 23);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(78, 19);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Recherche :";
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameUser,
            this.NickNameUser,
            this.ClassUser});
            this.dataGridUsers.Location = new System.Drawing.Point(0, 58);
            this.dataGridUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowHeadersVisible = false;
            this.dataGridUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(259, 447);
            this.dataGridUsers.TabIndex = 0;
            this.dataGridUsers.Click += new System.EventHandler(this.dataGridUsers_Click);
            // 
            // NameUser
            // 
            this.NameUser.HeaderText = "Nom";
            this.NameUser.Name = "NameUser";
            this.NameUser.ReadOnly = true;
            this.NameUser.Width = 77;
            // 
            // NickNameUser
            // 
            this.NickNameUser.HeaderText = "Prenom";
            this.NickNameUser.Name = "NickNameUser";
            this.NickNameUser.ReadOnly = true;
            this.NickNameUser.Width = 60;
            // 
            // ClassUser
            // 
            this.ClassUser.HeaderText = "Classe";
            this.ClassUser.Name = "ClassUser";
            this.ClassUser.ReadOnly = true;
            this.ClassUser.Width = 60;
            // 
            // valUserName
            // 
            this.valUserName.AutoSize = true;
            this.valUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valUserName.Location = new System.Drawing.Point(276, 1);
            this.valUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valUserName.Name = "valUserName";
            this.valUserName.Size = new System.Drawing.Size(192, 28);
            this.valUserName.TabIndex = 24;
            this.valUserName.Text = "Nom de l\'utilisateur";
            this.valUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panNews
            // 
            this.panNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panNews.Controls.Add(this.valClass);
            this.panNews.Controls.Add(this.valTel);
            this.panNews.Controls.Add(this.valMail);
            this.panNews.Controls.Add(this.labelClass);
            this.panNews.Controls.Add(this.labelTel);
            this.panNews.Controls.Add(this.labelMail);
            this.panNews.Location = new System.Drawing.Point(447, 242);
            this.panNews.Margin = new System.Windows.Forms.Padding(4);
            this.panNews.Name = "panNews";
            this.panNews.Size = new System.Drawing.Size(186, 118);
            this.panNews.TabIndex = 27;
            // 
            // valClass
            // 
            this.valClass.AutoSize = true;
            this.valClass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valClass.Location = new System.Drawing.Point(107, 81);
            this.valClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valClass.Name = "valClass";
            this.valClass.Size = new System.Drawing.Size(17, 23);
            this.valClass.TabIndex = 5;
            this.valClass.Text = "-";
            // 
            // valTel
            // 
            this.valTel.AutoSize = true;
            this.valTel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTel.Location = new System.Drawing.Point(107, 50);
            this.valTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valTel.Name = "valTel";
            this.valTel.Size = new System.Drawing.Size(17, 23);
            this.valTel.TabIndex = 4;
            this.valTel.Text = "-";
            // 
            // valMail
            // 
            this.valMail.AutoSize = true;
            this.valMail.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valMail.Location = new System.Drawing.Point(107, 20);
            this.valMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valMail.Name = "valMail";
            this.valMail.Size = new System.Drawing.Size(15, 19);
            this.valMail.TabIndex = 3;
            this.valMail.Text = "-";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(0, 85);
            this.labelClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(54, 19);
            this.labelClass.TabIndex = 2;
            this.labelClass.Text = "Classe :";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.Location = new System.Drawing.Point(0, 52);
            this.labelTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(31, 19);
            this.labelTel.TabIndex = 1;
            this.labelTel.Text = "tel :";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(0, 20);
            this.labelMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(42, 19);
            this.labelMail.TabIndex = 0;
            this.labelMail.Text = "Mail :";
            // 
            // valUserNickName
            // 
            this.valUserNickName.AutoSize = true;
            this.valUserNickName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valUserNickName.Location = new System.Drawing.Point(476, 4);
            this.valUserNickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valUserNickName.Name = "valUserNickName";
            this.valUserNickName.Size = new System.Drawing.Size(219, 28);
            this.valUserNickName.TabIndex = 28;
            this.valUserNickName.Text = "Prenom de l\'utilisateur";
            this.valUserNickName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Image = global::PixLogic.Properties.Resources.ajouter_icon;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(283, 474);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 36);
            this.buttonAdd.TabIndex = 29;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.Image = global::PixLogic.Properties.Resources.modifier_icon;
            this.buttonModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModify.Location = new System.Drawing.Point(395, 473);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(104, 36);
            this.buttonModify.TabIndex = 30;
            this.buttonModify.Text = "Modifier";
            this.buttonModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUser.Image = global::PixLogic.Properties.Resources.camera_photo;
            this.pictureBoxUser.InitialImage = null;
            this.pictureBoxUser.Location = new System.Drawing.Point(283, 33);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(351, 204);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 37;
            this.pictureBoxUser.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Image = global::PixLogic.Properties.Resources.supprimer_icon;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(510, 473);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(124, 36);
            this.buttonDelete.TabIndex = 38;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // valUserId
            // 
            this.valUserId.AutoSize = true;
            this.valUserId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valUserId.Location = new System.Drawing.Point(703, 4);
            this.valUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valUserId.Name = "valUserId";
            this.valUserId.Size = new System.Drawing.Size(128, 28);
            this.valUserId.TabIndex = 39;
            this.valUserId.Text = "ID utilisateur";
            this.valUserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.valUserId);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.valUserNickName);
            this.Controls.Add(this.panNews);
            this.Controls.Add(this.valUserName);
            this.Controls.Add(this.panTableUsers);
            this.Name = "panUsers";
            this.Size = new System.Drawing.Size(918, 519);
            this.panTableUsers.ResumeLayout(false);
            this.panTableUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.panNews.ResumeLayout(false);
            this.panNews.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTableUsers;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NickNameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassUser;
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
    }
}
