namespace PixLogic
{
    partial class panLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelFiltres = new System.Windows.Forms.Label();
            this.panFiltres = new System.Windows.Forms.Panel();
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
            this.labelNews = new System.Windows.Forms.Label();
            this.panNews = new System.Windows.Forms.Panel();
            this.valManager = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDebutEmprunt = new System.Windows.Forms.Label();
            this.valDebutEmprunt = new System.Windows.Forms.Label();
            this.valFinEmprunt = new System.Windows.Forms.Label();
            this.labelFinEmprunt = new System.Windows.Forms.Label();
            this.valType = new System.Windows.Forms.Label();
            this.valNomReservable = new System.Windows.Forms.Label();
            this.valNomUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.panTableLogs = new System.Windows.Forms.Panel();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridLogs = new System.Windows.Forms.DataGridView();
            this.IdReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUserReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameReservable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeReservable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEmprunt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRetour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelListEmprunt = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panFiltres.SuspendLayout();
            this.panNews.SuspendLayout();
            this.panTableLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFiltres
            // 
            this.labelFiltres.AutoSize = true;
            this.labelFiltres.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltres.Location = new System.Drawing.Point(29, 3);
            this.labelFiltres.Name = "labelFiltres";
            this.labelFiltres.Size = new System.Drawing.Size(38, 13);
            this.labelFiltres.TabIndex = 62;
            this.labelFiltres.Text = "Filtres";
            // 
            // panFiltres
            // 
            this.panFiltres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFiltres.Controls.Add(this.buttonFilter);
            this.panFiltres.Controls.Add(this.checkBoxPack);
            this.panFiltres.Controls.Add(this.labelTypeElementFiltre);
            this.panFiltres.Controls.Add(this.checkBoxItem);
            this.panFiltres.Controls.Add(this.radioAll);
            this.panFiltres.Controls.Add(this.dateTimeEnd);
            this.panFiltres.Controls.Add(this.dateTimeBegin);
            this.panFiltres.Controls.Add(this.radioBetween);
            this.panFiltres.Controls.Add(this.radioOfPastSevenDays);
            this.panFiltres.Controls.Add(this.labelListeFiltre);
            this.panFiltres.Controls.Add(this.radioToday);
            this.panFiltres.Controls.Add(this.label8);
            this.panFiltres.Location = new System.Drawing.Point(3, 8);
            this.panFiltres.Name = "panFiltres";
            this.panFiltres.Size = new System.Drawing.Size(674, 90);
            this.panFiltres.TabIndex = 60;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilter.Image = global::PixLogic.Properties.Resources.filter;
            this.buttonFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFilter.Location = new System.Drawing.Point(481, 58);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(67, 26);
            this.buttonFilter.TabIndex = 47;
            this.buttonFilter.Text = "Filtrer";
            this.buttonFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // checkBoxPack
            // 
            this.checkBoxPack.AutoSize = true;
            this.checkBoxPack.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPack.Location = new System.Drawing.Point(534, 23);
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
            this.labelTypeElementFiltre.Location = new System.Drawing.Point(408, 4);
            this.labelTypeElementFiltre.Name = "labelTypeElementFiltre";
            this.labelTypeElementFiltre.Size = new System.Drawing.Size(100, 15);
            this.labelTypeElementFiltre.TabIndex = 10;
            this.labelTypeElementFiltre.Text = "Type d\'élément :";
            // 
            // checkBoxItem
            // 
            this.checkBoxItem.AutoSize = true;
            this.checkBoxItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxItem.Location = new System.Drawing.Point(455, 23);
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
            this.radioAll.Location = new System.Drawing.Point(31, 21);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(48, 17);
            this.radioAll.TabIndex = 8;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "Tous";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(194, 52);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimeEnd.TabIndex = 7;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Location = new System.Drawing.Point(194, 21);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(200, 20);
            this.dateTimeBegin.TabIndex = 6;
            // 
            // radioBetween
            // 
            this.radioBetween.AutoSize = true;
            this.radioBetween.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBetween.Location = new System.Drawing.Point(135, 21);
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
            this.radioOfPastSevenDays.Location = new System.Drawing.Point(31, 67);
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
            this.labelListeFiltre.Location = new System.Drawing.Point(59, 3);
            this.labelListeFiltre.Name = "labelListeFiltre";
            this.labelListeFiltre.Size = new System.Drawing.Size(71, 15);
            this.labelListeFiltre.TabIndex = 3;
            this.labelListeFiltre.Text = "Historique :";
            // 
            // radioToday
            // 
            this.radioToday.AutoSize = true;
            this.radioToday.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioToday.Location = new System.Drawing.Point(31, 44);
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
            // labelNews
            // 
            this.labelNews.AutoSize = true;
            this.labelNews.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNews.Location = new System.Drawing.Point(32, 338);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(33, 13);
            this.labelNews.TabIndex = 61;
            this.labelNews.Text = "Infos";
            // 
            // panNews
            // 
            this.panNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panNews.Controls.Add(this.valManager);
            this.panNews.Controls.Add(this.label2);
            this.panNews.Controls.Add(this.labelDebutEmprunt);
            this.panNews.Controls.Add(this.valDebutEmprunt);
            this.panNews.Controls.Add(this.valFinEmprunt);
            this.panNews.Controls.Add(this.labelFinEmprunt);
            this.panNews.Controls.Add(this.valType);
            this.panNews.Controls.Add(this.valNomReservable);
            this.panNews.Controls.Add(this.valNomUser);
            this.panNews.Controls.Add(this.label1);
            this.panNews.Controls.Add(this.labelType);
            this.panNews.Controls.Add(this.labelNameUser);
            this.panNews.Controls.Add(this.labelTel);
            this.panNews.Location = new System.Drawing.Point(3, 343);
            this.panNews.Name = "panNews";
            this.panNews.Size = new System.Drawing.Size(674, 104);
            this.panNews.TabIndex = 57;
            // 
            // valManager
            // 
            this.valManager.AutoSize = true;
            this.valManager.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valManager.Location = new System.Drawing.Point(488, 68);
            this.valManager.Name = "valManager";
            this.valManager.Size = new System.Drawing.Size(11, 13);
            this.valManager.TabIndex = 51;
            this.valManager.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Manager :";
            // 
            // labelDebutEmprunt
            // 
            this.labelDebutEmprunt.AutoSize = true;
            this.labelDebutEmprunt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebutEmprunt.Location = new System.Drawing.Point(381, 17);
            this.labelDebutEmprunt.Name = "labelDebutEmprunt";
            this.labelDebutEmprunt.Size = new System.Drawing.Size(92, 13);
            this.labelDebutEmprunt.TabIndex = 48;
            this.labelDebutEmprunt.Text = "Début emprunt :";
            // 
            // valDebutEmprunt
            // 
            this.valDebutEmprunt.AutoSize = true;
            this.valDebutEmprunt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDebutEmprunt.Location = new System.Drawing.Point(488, 15);
            this.valDebutEmprunt.Name = "valDebutEmprunt";
            this.valDebutEmprunt.Size = new System.Drawing.Size(11, 13);
            this.valDebutEmprunt.TabIndex = 49;
            this.valDebutEmprunt.Text = "-";
            this.valDebutEmprunt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valFinEmprunt
            // 
            this.valFinEmprunt.AutoSize = true;
            this.valFinEmprunt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valFinEmprunt.Location = new System.Drawing.Point(488, 42);
            this.valFinEmprunt.Name = "valFinEmprunt";
            this.valFinEmprunt.Size = new System.Drawing.Size(11, 13);
            this.valFinEmprunt.TabIndex = 47;
            this.valFinEmprunt.Text = "-";
            // 
            // labelFinEmprunt
            // 
            this.labelFinEmprunt.AutoSize = true;
            this.labelFinEmprunt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinEmprunt.Location = new System.Drawing.Point(381, 43);
            this.labelFinEmprunt.Name = "labelFinEmprunt";
            this.labelFinEmprunt.Size = new System.Drawing.Size(76, 13);
            this.labelFinEmprunt.TabIndex = 46;
            this.labelFinEmprunt.Text = "Fin emprunt :";
            // 
            // valType
            // 
            this.valType.AutoSize = true;
            this.valType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valType.Location = new System.Drawing.Point(125, 65);
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
            this.valNomReservable.Location = new System.Drawing.Point(125, 39);
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
            this.valNomUser.Location = new System.Drawing.Point(125, 13);
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
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.Location = new System.Drawing.Point(0, 68);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(0, 13);
            this.labelTel.TabIndex = 1;
            // 
            // panTableLogs
            // 
            this.panTableLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTableLogs.Controls.Add(this.buttonDelete);
            this.panTableLogs.Controls.Add(this.buttonCancelSearch);
            this.panTableLogs.Controls.Add(this.textBoxSearch);
            this.panTableLogs.Controls.Add(this.labelSearch);
            this.panTableLogs.Controls.Add(this.dataGridLogs);
            this.panTableLogs.Location = new System.Drawing.Point(3, 104);
            this.panTableLogs.Name = "panTableLogs";
            this.panTableLogs.Size = new System.Drawing.Size(674, 229);
            this.panTableLogs.TabIndex = 56;
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
            this.textBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyUp);
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
            // dataGridLogs
            // 
            this.dataGridLogs.AllowUserToAddRows = false;
            this.dataGridLogs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridLogs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReservation,
            this.NameUserReservation,
            this.NameReservable,
            this.typeReservable,
            this.dateEmprunt,
            this.dateRetour,
            this.manager});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridLogs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridLogs.Location = new System.Drawing.Point(-1, 44);
            this.dataGridLogs.MultiSelect = false;
            this.dataGridLogs.Name = "dataGridLogs";
            this.dataGridLogs.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridLogs.RowHeadersVisible = false;
            this.dataGridLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLogs.Size = new System.Drawing.Size(674, 184);
            this.dataGridLogs.TabIndex = 0;
            this.dataGridLogs.Click += new System.EventHandler(this.dataGridLogs_Click);
            this.dataGridLogs.DoubleClick += new System.EventHandler(this.dataGridLogs_DoubleClick);
            this.dataGridLogs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridLogs_KeyUp);
            // 
            // IdReservation
            // 
            this.IdReservation.HeaderText = "Id";
            this.IdReservation.Name = "IdReservation";
            this.IdReservation.ReadOnly = true;
            this.IdReservation.Width = 50;
            // 
            // NameUserReservation
            // 
            this.NameUserReservation.HeaderText = "Utilisateur";
            this.NameUserReservation.Name = "NameUserReservation";
            this.NameUserReservation.ReadOnly = true;
            // 
            // NameReservable
            // 
            this.NameReservable.HeaderText = "Réservable";
            this.NameReservable.Name = "NameReservable";
            this.NameReservable.ReadOnly = true;
            this.NameReservable.Width = 105;
            // 
            // typeReservable
            // 
            this.typeReservable.HeaderText = "Type";
            this.typeReservable.Name = "typeReservable";
            this.typeReservable.ReadOnly = true;
            // 
            // dateEmprunt
            // 
            this.dateEmprunt.HeaderText = "Date Emprunt";
            this.dateEmprunt.Name = "dateEmprunt";
            this.dateEmprunt.ReadOnly = true;
            this.dateEmprunt.Width = 110;
            // 
            // dateRetour
            // 
            this.dateRetour.HeaderText = "Date Retour";
            this.dateRetour.Name = "dateRetour";
            this.dateRetour.ReadOnly = true;
            this.dateRetour.Width = 110;
            // 
            // manager
            // 
            this.manager.HeaderText = "Manager";
            this.manager.Name = "manager";
            this.manager.ReadOnly = true;
            // 
            // labelListEmprunt
            // 
            this.labelListEmprunt.AutoSize = true;
            this.labelListEmprunt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListEmprunt.Location = new System.Drawing.Point(27, 100);
            this.labelListEmprunt.Name = "labelListEmprunt";
            this.labelListEmprunt.Size = new System.Drawing.Size(61, 13);
            this.labelListEmprunt.TabIndex = 63;
            this.labelListEmprunt.Text = "Historique";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Image = global::PixLogic.Properties.Resources.supprimer_icon;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(466, 11);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 48;
            this.buttonDelete.Text = "Supprimer...";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelListEmprunt);
            this.Controls.Add(this.labelFiltres);
            this.Controls.Add(this.panFiltres);
            this.Controls.Add(this.labelNews);
            this.Controls.Add(this.panNews);
            this.Controls.Add(this.panTableLogs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "panLog";
            this.Size = new System.Drawing.Size(686, 450);
            this.panFiltres.ResumeLayout(false);
            this.panFiltres.PerformLayout();
            this.panNews.ResumeLayout(false);
            this.panNews.PerformLayout();
            this.panTableLogs.ResumeLayout(false);
            this.panTableLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFiltres;
        private System.Windows.Forms.Panel panFiltres;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.CheckBox checkBoxPack;
        private System.Windows.Forms.Label labelTypeElementFiltre;
        private System.Windows.Forms.CheckBox checkBoxItem;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.RadioButton radioBetween;
        private System.Windows.Forms.RadioButton radioOfPastSevenDays;
        private System.Windows.Forms.Label labelListeFiltre;
        private System.Windows.Forms.RadioButton radioToday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelNews;
        private System.Windows.Forms.Panel panNews;
        public System.Windows.Forms.Label valType;
        public System.Windows.Forms.Label valNomReservable;
        public System.Windows.Forms.Label valNomUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Panel panTableLogs;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridLogs;
        private System.Windows.Forms.Label labelListEmprunt;
        private System.Windows.Forms.Label labelDebutEmprunt;
        public System.Windows.Forms.Label valDebutEmprunt;
        private System.Windows.Forms.Label valFinEmprunt;
        private System.Windows.Forms.Label labelFinEmprunt;
        private System.Windows.Forms.Label valManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUserReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameReservable;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeReservable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmprunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRetour;
        private System.Windows.Forms.DataGridViewTextBoxColumn manager;
        private System.Windows.Forms.Button buttonDelete;
    }
}
