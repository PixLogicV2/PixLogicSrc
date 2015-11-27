namespace PixLogic
{
    partial class WindowReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowReservation));
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.panTableUsers = new System.Windows.Forms.Panel();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridUsersReservation = new System.Windows.Forms.DataGridView();
            this.IdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NickNameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonValid = new System.Windows.Forms.Button();
            this.labelAjoutDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridReservAvenir = new System.Windows.Forms.DataGridView();
            this.dateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPresent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.labelInfos = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.valType = new System.Windows.Forms.Label();
            this.valNomReservable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelListUsers = new System.Windows.Forms.Label();
            this.labelIdReservable = new System.Windows.Forms.Label();
            this.valIdReservable = new System.Windows.Forms.Label();
            this.panelGeneral.SuspendLayout();
            this.panTableUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsersReservation)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservAvenir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.labelListUsers);
            this.panelGeneral.Controls.Add(this.labelAjoutDate);
            this.panelGeneral.Controls.Add(this.panel2);
            this.panelGeneral.Controls.Add(this.dataGridReservAvenir);
            this.panelGeneral.Controls.Add(this.labelPresent);
            this.panelGeneral.Controls.Add(this.panel1);
            this.panelGeneral.Controls.Add(this.pictureBoxItem);
            this.panelGeneral.Controls.Add(this.labelInfos);
            this.panelGeneral.Controls.Add(this.panelInfo);
            this.panelGeneral.Controls.Add(this.panTableUsers);
            this.panelGeneral.Controls.Add(this.buttonCancel);
            this.panelGeneral.Controls.Add(this.buttonValid);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(590, 418);
            this.panelGeneral.TabIndex = 2;
            // 
            // panTableUsers
            // 
            this.panTableUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTableUsers.Controls.Add(this.buttonCancelSearch);
            this.panTableUsers.Controls.Add(this.textBoxSearch);
            this.panTableUsers.Controls.Add(this.labelSearch);
            this.panTableUsers.Controls.Add(this.dataGridUsersReservation);
            this.panTableUsers.Location = new System.Drawing.Point(3, 6);
            this.panTableUsers.Name = "panTableUsers";
            this.panTableUsers.Size = new System.Drawing.Size(196, 397);
            this.panTableUsers.TabIndex = 23;
            // 
            // buttonCancelSearch
            // 
            this.buttonCancelSearch.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancelSearch.Location = new System.Drawing.Point(165, 16);
            this.buttonCancelSearch.Name = "buttonCancelSearch";
            this.buttonCancelSearch.Size = new System.Drawing.Size(27, 23);
            this.buttonCancelSearch.TabIndex = 3;
            this.buttonCancelSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(65, 17);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(96, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(0, 19);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(66, 13);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Recherche :";
            // 
            // dataGridUsersReservation
            // 
            this.dataGridUsersReservation.AllowUserToAddRows = false;
            this.dataGridUsersReservation.AllowUserToDeleteRows = false;
            this.dataGridUsersReservation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridUsersReservation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridUsersReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsersReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridUsersReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUser,
            this.NameUser,
            this.NickNameUser});
            this.dataGridUsersReservation.Location = new System.Drawing.Point(0, 47);
            this.dataGridUsersReservation.Name = "dataGridUsersReservation";
            this.dataGridUsersReservation.ReadOnly = true;
            this.dataGridUsersReservation.RowHeadersVisible = false;
            this.dataGridUsersReservation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridUsersReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsersReservation.Size = new System.Drawing.Size(194, 349);
            this.dataGridUsersReservation.TabIndex = 0;
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
            this.NameUser.Width = 77;
            // 
            // NickNameUser
            // 
            this.NickNameUser.HeaderText = "Prenom";
            this.NickNameUser.Name = "NickNameUser";
            this.NickNameUser.ReadOnly = true;
            this.NickNameUser.Width = 60;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(393, 376);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 27);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonValid
            // 
            this.buttonValid.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValid.Image = global::PixLogic.Properties.Resources.valider_icon;
            this.buttonValid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValid.Location = new System.Drawing.Point(299, 376);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(84, 27);
            this.buttonValid.TabIndex = 10;
            this.buttonValid.Text = "Valider";
            this.buttonValid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // labelAjoutDate
            // 
            this.labelAjoutDate.AutoSize = true;
            this.labelAjoutDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAjoutDate.Location = new System.Drawing.Point(221, 259);
            this.labelAjoutDate.Name = "labelAjoutDate";
            this.labelAjoutDate.Size = new System.Drawing.Size(130, 13);
            this.labelAjoutDate.TabIndex = 31;
            this.labelAjoutDate.Text = "Ajouter une réservation";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateTimeEnd);
            this.panel2.Controls.Add(this.dateTimeBegin);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(205, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 92);
            this.panel2.TabIndex = 30;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(92, 57);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(179, 20);
            this.dateTimeEnd.TabIndex = 56;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Location = new System.Drawing.Point(92, 21);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(179, 20);
            this.dateTimeBegin.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Date de fin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Date début :";
            // 
            // dataGridReservAvenir
            // 
            this.dataGridReservAvenir.AllowUserToAddRows = false;
            this.dataGridReservAvenir.AllowUserToDeleteRows = false;
            this.dataGridReservAvenir.AllowUserToResizeRows = false;
            this.dataGridReservAvenir.BackgroundColor = System.Drawing.Color.White;
            this.dataGridReservAvenir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservAvenir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDebut,
            this.dateFin});
            this.dataGridReservAvenir.Location = new System.Drawing.Point(205, 134);
            this.dataGridReservAvenir.MultiSelect = false;
            this.dataGridReservAvenir.Name = "dataGridReservAvenir";
            this.dataGridReservAvenir.ReadOnly = true;
            this.dataGridReservAvenir.RowHeadersVisible = false;
            this.dataGridReservAvenir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridReservAvenir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReservAvenir.Size = new System.Drawing.Size(379, 116);
            this.dataGridReservAvenir.TabIndex = 24;
            // 
            // dateDebut
            // 
            this.dateDebut.HeaderText = "Date debut";
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.ReadOnly = true;
            this.dateDebut.Width = 188;
            // 
            // dateFin
            // 
            this.dateFin.HeaderText = "Date fin";
            this.dateFin.Name = "dateFin";
            this.dateFin.ReadOnly = true;
            this.dateFin.Width = 188;
            // 
            // labelPresent
            // 
            this.labelPresent.AutoSize = true;
            this.labelPresent.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresent.Location = new System.Drawing.Point(220, 110);
            this.labelPresent.Name = "labelPresent";
            this.labelPresent.Size = new System.Drawing.Size(126, 13);
            this.labelPresent.TabIndex = 29;
            this.labelPresent.Text = "Réservations présentes";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(205, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 136);
            this.panel1.TabIndex = 28;
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxItem.Location = new System.Drawing.Point(450, 6);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(135, 98);
            this.pictureBoxItem.TabIndex = 27;
            this.pictureBoxItem.TabStop = false;
            // 
            // labelInfos
            // 
            this.labelInfos.AutoSize = true;
            this.labelInfos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfos.Location = new System.Drawing.Point(221, 2);
            this.labelInfos.Name = "labelInfos";
            this.labelInfos.Size = new System.Drawing.Size(33, 13);
            this.labelInfos.TabIndex = 26;
            this.labelInfos.Text = "Infos";
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.valIdReservable);
            this.panelInfo.Controls.Add(this.labelIdReservable);
            this.panelInfo.Controls.Add(this.valType);
            this.panelInfo.Controls.Add(this.valNomReservable);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.labelType);
            this.panelInfo.Location = new System.Drawing.Point(205, 6);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(248, 98);
            this.panelInfo.TabIndex = 25;
            // 
            // valType
            // 
            this.valType.AutoSize = true;
            this.valType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valType.Location = new System.Drawing.Point(81, 67);
            this.valType.Name = "valType";
            this.valType.Size = new System.Drawing.Size(12, 15);
            this.valType.TabIndex = 49;
            this.valType.Text = "-";
            this.valType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valNomReservable
            // 
            this.valNomReservable.AutoSize = true;
            this.valNomReservable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNomReservable.Location = new System.Drawing.Point(81, 41);
            this.valNomReservable.Name = "valNomReservable";
            this.valNomReservable.Size = new System.Drawing.Size(12, 15);
            this.valNomReservable.TabIndex = 48;
            this.valNomReservable.Text = "-";
            this.valNomReservable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nom :";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(3, 67);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(35, 13);
            this.labelType.TabIndex = 46;
            this.labelType.Text = "Type :";
            // 
            // labelListUsers
            // 
            this.labelListUsers.AutoSize = true;
            this.labelListUsers.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListUsers.Location = new System.Drawing.Point(18, 2);
            this.labelListUsers.Name = "labelListUsers";
            this.labelListUsers.Size = new System.Drawing.Size(112, 13);
            this.labelListUsers.TabIndex = 32;
            this.labelListUsers.Text = "Liste des utilisateurs";
            // 
            // labelIdReservable
            // 
            this.labelIdReservable.AutoSize = true;
            this.labelIdReservable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdReservable.Location = new System.Drawing.Point(3, 15);
            this.labelIdReservable.Name = "labelIdReservable";
            this.labelIdReservable.Size = new System.Drawing.Size(67, 13);
            this.labelIdReservable.TabIndex = 50;
            this.labelIdReservable.Text = "Id élément :";
            // 
            // valIdReservable
            // 
            this.valIdReservable.AutoSize = true;
            this.valIdReservable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valIdReservable.Location = new System.Drawing.Point(81, 15);
            this.valIdReservable.Name = "valIdReservable";
            this.valIdReservable.Size = new System.Drawing.Size(12, 15);
            this.valIdReservable.TabIndex = 51;
            this.valIdReservable.Text = "-";
            this.valIdReservable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WindowReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 418);
            this.Controls.Add(this.panelGeneral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvelle réservation";
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.panTableUsers.ResumeLayout(false);
            this.panTableUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsersReservation)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservAvenir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonValid;
        private System.Windows.Forms.Panel panTableUsers;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridUsersReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NickNameUser;
        private System.Windows.Forms.Label labelListUsers;
        private System.Windows.Forms.Label labelAjoutDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridReservAvenir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFin;
        private System.Windows.Forms.Label labelPresent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxItem;
        private System.Windows.Forms.Label labelInfos;
        private System.Windows.Forms.Panel panelInfo;
        public System.Windows.Forms.Label valIdReservable;
        private System.Windows.Forms.Label labelIdReservable;
        public System.Windows.Forms.Label valType;
        public System.Windows.Forms.Label valNomReservable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelType;
    }
}