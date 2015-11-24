namespace PixLogic
{
    partial class panReservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panTableUsers = new System.Windows.Forms.Panel();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridReservations = new System.Windows.Forms.DataGridView();
            this.IdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUserReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameReservable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debutResersation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panNews = new System.Windows.Forms.Panel();
            this.valType = new System.Windows.Forms.Label();
            this.valNomReservable = new System.Windows.Forms.Label();
            this.valNomUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.valDateDebut = new System.Windows.Forms.Label();
            this.valDateFin = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.labelListReservation = new System.Windows.Forms.Label();
            this.labelNews = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.checkBoxPack = new System.Windows.Forms.CheckBox();
            this.labelTypeElementFiltre = new System.Windows.Forms.Label();
            this.checkBoxItem = new System.Windows.Forms.CheckBox();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.radioBetween = new System.Windows.Forms.RadioButton();
            this.radioOfPastSevenDays = new System.Windows.Forms.RadioButton();
            this.labelListeFiltre = new System.Windows.Forms.Label();
            this.radioToday = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.labelFiltres = new System.Windows.Forms.Label();
            this.buttonCancelReserv = new System.Windows.Forms.Button();
            this.buttonModif = new System.Windows.Forms.Button();
            this.buttonEmprunt = new System.Windows.Forms.Button();
            this.panTableUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservations)).BeginInit();
            this.panNews.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTableUsers
            // 
            this.panTableUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTableUsers.Controls.Add(this.buttonCancelSearch);
            this.panTableUsers.Controls.Add(this.textBoxSearch);
            this.panTableUsers.Controls.Add(this.labelSearch);
            this.panTableUsers.Controls.Add(this.dataGridReservations);
            this.panTableUsers.Location = new System.Drawing.Point(9, 3);
            this.panTableUsers.Name = "panTableUsers";
            this.panTableUsers.Size = new System.Drawing.Size(412, 285);
            this.panTableUsers.TabIndex = 23;
            // 
            // buttonCancelSearch
            // 
            this.buttonCancelSearch.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancelSearch.Location = new System.Drawing.Point(174, 15);
            this.buttonCancelSearch.Name = "buttonCancelSearch";
            this.buttonCancelSearch.Size = new System.Drawing.Size(27, 23);
            this.buttonCancelSearch.TabIndex = 3;
            this.buttonCancelSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(74, 16);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(96, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(9, 18);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(66, 13);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Recherche :";
            // 
            // dataGridReservations
            // 
            this.dataGridReservations.AllowUserToAddRows = false;
            this.dataGridReservations.AllowUserToDeleteRows = false;
            this.dataGridReservations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridReservations.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridReservations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUser,
            this.NameUserReservation,
            this.NameReservable,
            this.debutResersation,
            this.finReservation});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridReservations.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridReservations.Location = new System.Drawing.Point(-1, 47);
            this.dataGridReservations.Name = "dataGridReservations";
            this.dataGridReservations.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReservations.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridReservations.RowHeadersVisible = false;
            this.dataGridReservations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReservations.Size = new System.Drawing.Size(412, 234);
            this.dataGridReservations.TabIndex = 0;
            this.dataGridReservations.Click += new System.EventHandler(this.dataGridReservations_Click);
            this.dataGridReservations.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridReservations_KeyUp);
            // 
            // IdUser
            // 
            this.IdUser.HeaderText = "Id";
            this.IdUser.Name = "IdUser";
            this.IdUser.ReadOnly = true;
            this.IdUser.Width = 60;
            // 
            // NameUserReservation
            // 
            this.NameUserReservation.HeaderText = "Utilisateur";
            this.NameUserReservation.Name = "NameUserReservation";
            this.NameUserReservation.ReadOnly = true;
            this.NameUserReservation.Width = 82;
            // 
            // NameReservable
            // 
            this.NameReservable.HeaderText = "Reservable";
            this.NameReservable.Name = "NameReservable";
            this.NameReservable.ReadOnly = true;
            this.NameReservable.Width = 90;
            // 
            // debutResersation
            // 
            this.debutResersation.HeaderText = "Début Réservation";
            this.debutResersation.Name = "debutResersation";
            this.debutResersation.ReadOnly = true;
            this.debutResersation.Width = 90;
            // 
            // finReservation
            // 
            this.finReservation.HeaderText = "Fin Reservation";
            this.finReservation.Name = "finReservation";
            this.finReservation.ReadOnly = true;
            this.finReservation.Width = 90;
            // 
            // panNews
            // 
            this.panNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panNews.Controls.Add(this.valType);
            this.panNews.Controls.Add(this.valNomReservable);
            this.panNews.Controls.Add(this.valNomUser);
            this.panNews.Controls.Add(this.label1);
            this.panNews.Controls.Add(this.labelType);
            this.panNews.Controls.Add(this.labelNameUser);
            this.panNews.Controls.Add(this.labelDateDebut);
            this.panNews.Controls.Add(this.valDateDebut);
            this.panNews.Controls.Add(this.valDateFin);
            this.panNews.Controls.Add(this.labelTel);
            this.panNews.Controls.Add(this.labelDateFin);
            this.panNews.Location = new System.Drawing.Point(9, 298);
            this.panNews.Name = "panNews";
            this.panNews.Size = new System.Drawing.Size(674, 96);
            this.panNews.TabIndex = 28;
            // 
            // valType
            // 
            this.valType.AutoSize = true;
            this.valType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valType.Location = new System.Drawing.Point(142, 65);
            this.valType.Name = "valType";
            this.valType.Size = new System.Drawing.Size(13, 17);
            this.valType.TabIndex = 45;
            this.valType.Text = "-";
            this.valType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valNomReservable
            // 
            this.valNomReservable.AutoSize = true;
            this.valNomReservable.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNomReservable.Location = new System.Drawing.Point(142, 39);
            this.valNomReservable.Name = "valNomReservable";
            this.valNomReservable.Size = new System.Drawing.Size(13, 17);
            this.valNomReservable.TabIndex = 44;
            this.valNomReservable.Text = "-";
            this.valNomReservable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valNomUser
            // 
            this.valNomUser.AutoSize = true;
            this.valNomUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNomUser.Location = new System.Drawing.Point(142, 13);
            this.valNomUser.Name = "valNomUser";
            this.valNomUser.Size = new System.Drawing.Size(13, 17);
            this.valNomUser.TabIndex = 43;
            this.valNomUser.Text = "-";
            this.valNomUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nom du reservable :";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(3, 68);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(35, 13);
            this.labelType.TabIndex = 41;
            this.labelType.Text = "Type :";
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameUser.Location = new System.Drawing.Point(3, 16);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(92, 13);
            this.labelNameUser.TabIndex = 40;
            this.labelNameUser.Text = "Nom utilisateur :";
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDebut.Location = new System.Drawing.Point(365, 16);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(71, 13);
            this.labelDateDebut.TabIndex = 6;
            this.labelDateDebut.Text = "Date début :";
            // 
            // valDateDebut
            // 
            this.valDateDebut.AutoSize = true;
            this.valDateDebut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDateDebut.Location = new System.Drawing.Point(455, 12);
            this.valDateDebut.Name = "valDateDebut";
            this.valDateDebut.Size = new System.Drawing.Size(13, 17);
            this.valDateDebut.TabIndex = 39;
            this.valDateDebut.Text = "-";
            this.valDateDebut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valDateFin
            // 
            this.valDateFin.AutoSize = true;
            this.valDateFin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDateFin.Location = new System.Drawing.Point(455, 41);
            this.valDateFin.Name = "valDateFin";
            this.valDateFin.Size = new System.Drawing.Size(13, 17);
            this.valDateFin.TabIndex = 3;
            this.valDateFin.Text = "-";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.Location = new System.Drawing.Point(0, 68);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(0, 13);
            this.labelTel.TabIndex = 1;
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFin.Location = new System.Drawing.Point(365, 42);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(70, 13);
            this.labelDateFin.TabIndex = 0;
            this.labelDateFin.Text = "Date de fin :";
            // 
            // labelListReservation
            // 
            this.labelListReservation.AutoSize = true;
            this.labelListReservation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListReservation.Location = new System.Drawing.Point(30, -1);
            this.labelListReservation.Name = "labelListReservation";
            this.labelListReservation.Size = new System.Drawing.Size(118, 13);
            this.labelListReservation.TabIndex = 41;
            this.labelListReservation.Text = "Liste des reservations";
            // 
            // labelNews
            // 
            this.labelNews.AutoSize = true;
            this.labelNews.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNews.Location = new System.Drawing.Point(31, 293);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(33, 13);
            this.labelNews.TabIndex = 43;
            this.labelNews.Text = "Infos";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonFilter);
            this.panel1.Controls.Add(this.checkBoxPack);
            this.panel1.Controls.Add(this.labelTypeElementFiltre);
            this.panel1.Controls.Add(this.checkBoxItem);
            this.panel1.Controls.Add(this.radioAll);
            this.panel1.Controls.Add(this.dateTimeEnd);
            this.panel1.Controls.Add(this.dateTimeBegin);
            this.panel1.Controls.Add(this.radioBetween);
            this.panel1.Controls.Add(this.radioOfPastSevenDays);
            this.panel1.Controls.Add(this.labelListeFiltre);
            this.panel1.Controls.Add(this.radioToday);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(427, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 285);
            this.panel1.TabIndex = 43;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilter.Image = global::PixLogic.Properties.Resources.filter;
            this.buttonFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFilter.Location = new System.Drawing.Point(90, 254);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(67, 26);
            this.buttonFilter.TabIndex = 47;
            this.buttonFilter.Text = "Filtrer";
            this.buttonFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // checkBoxPack
            // 
            this.checkBoxPack.AutoSize = true;
            this.checkBoxPack.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPack.Location = new System.Drawing.Point(188, 204);
            this.checkBoxPack.Name = "checkBoxPack";
            this.checkBoxPack.Size = new System.Drawing.Size(54, 17);
            this.checkBoxPack.TabIndex = 11;
            this.checkBoxPack.Text = "Packs";
            this.checkBoxPack.UseVisualStyleBackColor = true;
            // 
            // labelTypeElementFiltre
            // 
            this.labelTypeElementFiltre.AutoSize = true;
            this.labelTypeElementFiltre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeElementFiltre.Location = new System.Drawing.Point(3, 204);
            this.labelTypeElementFiltre.Name = "labelTypeElementFiltre";
            this.labelTypeElementFiltre.Size = new System.Drawing.Size(100, 15);
            this.labelTypeElementFiltre.TabIndex = 10;
            this.labelTypeElementFiltre.Text = "Type d\'élément :";
            // 
            // checkBoxItem
            // 
            this.checkBoxItem.AutoSize = true;
            this.checkBoxItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxItem.Location = new System.Drawing.Point(109, 204);
            this.checkBoxItem.Name = "checkBoxItem";
            this.checkBoxItem.Size = new System.Drawing.Size(73, 17);
            this.checkBoxItem.TabIndex = 10;
            this.checkBoxItem.Text = "Matériels";
            this.checkBoxItem.UseVisualStyleBackColor = true;
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAll.Location = new System.Drawing.Point(21, 37);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(48, 17);
            this.radioAll.TabIndex = 8;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "Tous";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(51, 162);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimeEnd.TabIndex = 7;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Location = new System.Drawing.Point(51, 131);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(200, 20);
            this.dateTimeBegin.TabIndex = 6;
            // 
            // radioBetween
            // 
            this.radioBetween.AutoSize = true;
            this.radioBetween.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBetween.Location = new System.Drawing.Point(21, 106);
            this.radioBetween.Name = "radioBetween";
            this.radioBetween.Size = new System.Drawing.Size(57, 17);
            this.radioBetween.TabIndex = 5;
            this.radioBetween.TabStop = true;
            this.radioBetween.Text = "Entre :";
            this.radioBetween.UseVisualStyleBackColor = true;
            // 
            // radioOfPastSevenDays
            // 
            this.radioOfPastSevenDays.AutoSize = true;
            this.radioOfPastSevenDays.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOfPastSevenDays.Location = new System.Drawing.Point(21, 83);
            this.radioOfPastSevenDays.Name = "radioOfPastSevenDays";
            this.radioOfPastSevenDays.Size = new System.Drawing.Size(103, 17);
            this.radioOfPastSevenDays.TabIndex = 4;
            this.radioOfPastSevenDays.TabStop = true;
            this.radioOfPastSevenDays.Text = "Depuis 07 jours";
            this.radioOfPastSevenDays.UseVisualStyleBackColor = true;
            // 
            // labelListeFiltre
            // 
            this.labelListeFiltre.AutoSize = true;
            this.labelListeFiltre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListeFiltre.Location = new System.Drawing.Point(3, 19);
            this.labelListeFiltre.Name = "labelListeFiltre";
            this.labelListeFiltre.Size = new System.Drawing.Size(133, 15);
            this.labelListeFiltre.TabIndex = 3;
            this.labelListeFiltre.Text = "Liste des réservations :";
            // 
            // radioToday
            // 
            this.radioToday.AutoSize = true;
            this.radioToday.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioToday.Location = new System.Drawing.Point(21, 60);
            this.radioToday.Name = "radioToday";
            this.radioToday.Size = new System.Drawing.Size(90, 17);
            this.radioToday.TabIndex = 2;
            this.radioToday.TabStop = true;
            this.radioToday.Text = "D\'aujourdhui";
            this.radioToday.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 1;
            // 
            // labelFiltres
            // 
            this.labelFiltres.AutoSize = true;
            this.labelFiltres.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltres.Location = new System.Drawing.Point(446, -1);
            this.labelFiltres.Name = "labelFiltres";
            this.labelFiltres.Size = new System.Drawing.Size(38, 13);
            this.labelFiltres.TabIndex = 46;
            this.labelFiltres.Text = "Filtres";
            // 
            // buttonCancelReserv
            // 
            this.buttonCancelReserv.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelReserv.Image = global::PixLogic.Properties.Resources.supprimer_icon;
            this.buttonCancelReserv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelReserv.Location = new System.Drawing.Point(414, 405);
            this.buttonCancelReserv.Name = "buttonCancelReserv";
            this.buttonCancelReserv.Size = new System.Drawing.Size(95, 32);
            this.buttonCancelReserv.TabIndex = 45;
            this.buttonCancelReserv.Text = "Annuler";
            this.buttonCancelReserv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelReserv.UseVisualStyleBackColor = true;
            // 
            // buttonModif
            // 
            this.buttonModif.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModif.Image = global::PixLogic.Properties.Resources.modifier_icon;
            this.buttonModif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModif.Location = new System.Drawing.Point(284, 405);
            this.buttonModif.Name = "buttonModif";
            this.buttonModif.Size = new System.Drawing.Size(95, 32);
            this.buttonModif.TabIndex = 44;
            this.buttonModif.Text = "Modifier";
            this.buttonModif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonModif.UseVisualStyleBackColor = true;
            // 
            // buttonEmprunt
            // 
            this.buttonEmprunt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmprunt.Image = global::PixLogic.Properties.Resources.reserver;
            this.buttonEmprunt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmprunt.Location = new System.Drawing.Point(154, 405);
            this.buttonEmprunt.Name = "buttonEmprunt";
            this.buttonEmprunt.Size = new System.Drawing.Size(95, 32);
            this.buttonEmprunt.TabIndex = 42;
            this.buttonEmprunt.Text = "Emprunter";
            this.buttonEmprunt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEmprunt.UseVisualStyleBackColor = true;
            this.buttonEmprunt.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelFiltres);
            this.Controls.Add(this.buttonCancelReserv);
            this.Controls.Add(this.buttonModif);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelNews);
            this.Controls.Add(this.buttonEmprunt);
            this.Controls.Add(this.labelListReservation);
            this.Controls.Add(this.panNews);
            this.Controls.Add(this.panTableUsers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "panReservation";
            this.Size = new System.Drawing.Size(686, 450);
            this.panTableUsers.ResumeLayout(false);
            this.panTableUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservations)).EndInit();
            this.panNews.ResumeLayout(false);
            this.panNews.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTableUsers;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridReservations;
        private System.Windows.Forms.Panel panNews;
        private System.Windows.Forms.Label labelDateDebut;
        public System.Windows.Forms.Label valDateDebut;
        private System.Windows.Forms.Label valDateFin;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Label labelListReservation;
        private System.Windows.Forms.Button buttonEmprunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUserReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameReservable;
        private System.Windows.Forms.DataGridViewTextBoxColumn debutResersation;
        private System.Windows.Forms.DataGridViewTextBoxColumn finReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.Label labelNews;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonModif;
        private System.Windows.Forms.Button buttonCancelReserv;
        private System.Windows.Forms.Label labelFiltres;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.RadioButton radioBetween;
        private System.Windows.Forms.RadioButton radioOfPastSevenDays;
        private System.Windows.Forms.Label labelListeFiltre;
        private System.Windows.Forms.RadioButton radioToday;
        private System.Windows.Forms.CheckBox checkBoxPack;
        private System.Windows.Forms.CheckBox checkBoxItem;
        public System.Windows.Forms.Label valType;
        public System.Windows.Forms.Label valNomReservable;
        public System.Windows.Forms.Label valNomUser;
        private System.Windows.Forms.Label labelTypeElementFiltre;
        private System.Windows.Forms.Button buttonFilter;
    }
}
