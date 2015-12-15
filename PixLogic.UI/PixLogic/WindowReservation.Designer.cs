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
            this.labelListUsers = new System.Windows.Forms.Label();
            this.labelAjoutDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPresent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxPrevious = new System.Windows.Forms.PictureBox();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.labelLegendEm = new System.Windows.Forms.Label();
            this.labelReserve = new System.Windows.Forms.Label();
            this.panelLegendEm = new System.Windows.Forms.Panel();
            this.panelLegendRe = new System.Windows.Forms.Panel();
            this.monCalendar = new System.Windows.Forms.DataGridView();
            this.monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOk = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.labelInfos = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.valIdReservable = new System.Windows.Forms.Label();
            this.labelIdReservable = new System.Windows.Forms.Label();
            this.valType = new System.Windows.Forms.Label();
            this.valNomReservable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
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
            this.panelGeneral.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monCalendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panTableUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsersReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.labelListUsers);
            this.panelGeneral.Controls.Add(this.labelAjoutDate);
            this.panelGeneral.Controls.Add(this.panel2);
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
            this.panelGeneral.Size = new System.Drawing.Size(590, 448);
            this.panelGeneral.TabIndex = 2;
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
            // labelAjoutDate
            // 
            this.labelAjoutDate.AutoSize = true;
            this.labelAjoutDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAjoutDate.Location = new System.Drawing.Point(221, 298);
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
            this.panel2.Location = new System.Drawing.Point(205, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 92);
            this.panel2.TabIndex = 30;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(92, 57);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(179, 20);
            this.dateTimeEnd.TabIndex = 3;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Location = new System.Drawing.Point(92, 21);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(179, 20);
            this.dateTimeBegin.TabIndex = 2;
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
            // labelPresent
            // 
            this.labelPresent.AutoSize = true;
            this.labelPresent.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresent.Location = new System.Drawing.Point(220, 110);
            this.labelPresent.Name = "labelPresent";
            this.labelPresent.Size = new System.Drawing.Size(181, 13);
            this.labelPresent.TabIndex = 29;
            this.labelPresent.Text = "Réservations / Emprunts présents";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBoxPrevious);
            this.panel1.Controls.Add(this.pictureBoxNext);
            this.panel1.Controls.Add(this.labelLegendEm);
            this.panel1.Controls.Add(this.labelReserve);
            this.panel1.Controls.Add(this.panelLegendEm);
            this.panel1.Controls.Add(this.panelLegendRe);
            this.panel1.Controls.Add(this.monCalendar);
            this.panel1.Controls.Add(this.buttonOk);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Location = new System.Drawing.Point(205, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 179);
            this.panel1.TabIndex = 28;
            // 
            // pictureBoxPrevious
            // 
            this.pictureBoxPrevious.Image = global::PixLogic.Properties.Resources.previous;
            this.pictureBoxPrevious.Location = new System.Drawing.Point(38, 21);
            this.pictureBoxPrevious.Name = "pictureBoxPrevious";
            this.pictureBoxPrevious.Size = new System.Drawing.Size(18, 17);
            this.pictureBoxPrevious.TabIndex = 8;
            this.pictureBoxPrevious.TabStop = false;
            this.pictureBoxPrevious.Click += new System.EventHandler(this.pictureBoxPrevious_Click);
            this.pictureBoxPrevious.MouseEnter += new System.EventHandler(this.pictureBoxPrevious_MouseEnter);
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.Image = global::PixLogic.Properties.Resources.next;
            this.pictureBoxNext.Location = new System.Drawing.Point(187, 21);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(18, 17);
            this.pictureBoxNext.TabIndex = 7;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            this.pictureBoxNext.MouseEnter += new System.EventHandler(this.pictureBoxNext_MouseEnter);
            // 
            // labelLegendEm
            // 
            this.labelLegendEm.AutoSize = true;
            this.labelLegendEm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegendEm.Location = new System.Drawing.Point(309, 66);
            this.labelLegendEm.Name = "labelLegendEm";
            this.labelLegendEm.Size = new System.Drawing.Size(60, 13);
            this.labelLegendEm.TabIndex = 6;
            this.labelLegendEm.Text = "Emprunté.";
            // 
            // labelReserve
            // 
            this.labelReserve.AutoSize = true;
            this.labelReserve.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReserve.Location = new System.Drawing.Point(309, 46);
            this.labelReserve.Name = "labelReserve";
            this.labelReserve.Size = new System.Drawing.Size(49, 13);
            this.labelReserve.TabIndex = 5;
            this.labelReserve.Text = "Réservé.";
            // 
            // panelLegendEm
            // 
            this.panelLegendEm.BackColor = System.Drawing.Color.Red;
            this.panelLegendEm.Location = new System.Drawing.Point(288, 67);
            this.panelLegendEm.Name = "panelLegendEm";
            this.panelLegendEm.Size = new System.Drawing.Size(15, 14);
            this.panelLegendEm.TabIndex = 4;
            // 
            // panelLegendRe
            // 
            this.panelLegendRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelLegendRe.Location = new System.Drawing.Point(288, 47);
            this.panelLegendRe.Name = "panelLegendRe";
            this.panelLegendRe.Size = new System.Drawing.Size(15, 14);
            this.panelLegendRe.TabIndex = 3;
            // 
            // monCalendar
            // 
            this.monCalendar.AllowUserToAddRows = false;
            this.monCalendar.AllowUserToDeleteRows = false;
            this.monCalendar.AllowUserToResizeColumns = false;
            this.monCalendar.AllowUserToResizeRows = false;
            this.monCalendar.BackgroundColor = System.Drawing.Color.White;
            this.monCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monday,
            this.tuesday,
            this.wednesday,
            this.thursday,
            this.friday,
            this.saturday,
            this.sunday});
            this.monCalendar.Location = new System.Drawing.Point(-1, 45);
            this.monCalendar.MultiSelect = false;
            this.monCalendar.Name = "monCalendar";
            this.monCalendar.ReadOnly = true;
            this.monCalendar.RowHeadersVisible = false;
            this.monCalendar.Size = new System.Drawing.Size(283, 133);
            this.monCalendar.StandardTab = true;
            this.monCalendar.TabIndex = 2;
            // 
            // monday
            // 
            this.monday.HeaderText = "Lun.";
            this.monday.Name = "monday";
            this.monday.ReadOnly = true;
            this.monday.Width = 40;
            // 
            // tuesday
            // 
            this.tuesday.HeaderText = "Mar.";
            this.tuesday.Name = "tuesday";
            this.tuesday.ReadOnly = true;
            this.tuesday.Width = 40;
            // 
            // wednesday
            // 
            this.wednesday.HeaderText = "Mer.";
            this.wednesday.Name = "wednesday";
            this.wednesday.ReadOnly = true;
            this.wednesday.Width = 40;
            // 
            // thursday
            // 
            this.thursday.HeaderText = "Jeu.";
            this.thursday.Name = "thursday";
            this.thursday.ReadOnly = true;
            this.thursday.Width = 40;
            // 
            // friday
            // 
            this.friday.HeaderText = "Ven.";
            this.friday.Name = "friday";
            this.friday.ReadOnly = true;
            this.friday.Width = 40;
            // 
            // saturday
            // 
            this.saturday.HeaderText = "Sam.";
            this.saturday.Name = "saturday";
            this.saturday.ReadOnly = true;
            this.saturday.Width = 40;
            // 
            // sunday
            // 
            this.sunday.HeaderText = "Dim.";
            this.sunday.Name = "sunday";
            this.sunday.ReadOnly = true;
            this.sunday.Width = 40;
            // 
            // buttonOk
            // 
            this.buttonOk.Image = global::PixLogic.Properties.Resources.valider_iconPetit;
            this.buttonOk.Location = new System.Drawing.Point(257, 20);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(25, 20);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(62, 18);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker.TabIndex = 0;
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
            // panTableUsers
            // 
            this.panTableUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTableUsers.Controls.Add(this.buttonCancelSearch);
            this.panTableUsers.Controls.Add(this.textBoxSearch);
            this.panTableUsers.Controls.Add(this.labelSearch);
            this.panTableUsers.Controls.Add(this.dataGridUsersReservation);
            this.panTableUsers.Location = new System.Drawing.Point(3, 6);
            this.panTableUsers.Name = "panTableUsers";
            this.panTableUsers.Size = new System.Drawing.Size(196, 423);
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
            this.buttonCancelSearch.Click += new System.EventHandler(this.buttonCancelSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(65, 17);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(96, 20);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyUp);
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
            this.dataGridUsersReservation.Size = new System.Drawing.Size(194, 375);
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
            this.buttonCancel.Location = new System.Drawing.Point(393, 412);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 27);
            this.buttonCancel.TabIndex = 5;
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
            this.buttonValid.Location = new System.Drawing.Point(299, 412);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(84, 27);
            this.buttonValid.TabIndex = 4;
            this.buttonValid.Text = "Valider";
            this.buttonValid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // WindowReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 448);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panTableUsers.ResumeLayout(false);
            this.panTableUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsersReservation)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.DataGridView monCalendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn sunday;
        private System.Windows.Forms.Label labelLegendEm;
        private System.Windows.Forms.Label labelReserve;
        private System.Windows.Forms.Panel panelLegendEm;
        private System.Windows.Forms.Panel panelLegendRe;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.PictureBox pictureBoxPrevious;
    }
}