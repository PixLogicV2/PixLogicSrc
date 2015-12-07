namespace PixLogic
{
    partial class panEmprunt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panEmprunt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelFiltres = new System.Windows.Forms.Label();
            this.panFiltres = new System.Windows.Forms.Panel();
            this.pictureReinit = new System.Windows.Forms.PictureBox();
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
            this.buttonRendre = new System.Windows.Forms.Button();
            this.labelListEmprunt = new System.Windows.Forms.Label();
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
            this.labelDateRetour = new System.Windows.Forms.Label();
            this.panTableUsers = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridEmprunts = new System.Windows.Forms.DataGridView();
            this.IdReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUserReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameReservable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEmprunt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRetour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panFiltres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReinit)).BeginInit();
            this.panNews.SuspendLayout();
            this.panTableUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmprunts)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFiltres
            // 
            this.labelFiltres.AutoSize = true;
            this.labelFiltres.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltres.Location = new System.Drawing.Point(596, 0);
            this.labelFiltres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiltres.Name = "labelFiltres";
            this.labelFiltres.Size = new System.Drawing.Size(49, 19);
            this.labelFiltres.TabIndex = 55;
            this.labelFiltres.Text = "Filtres";
            // 
            // panFiltres
            // 
            this.panFiltres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFiltres.Controls.Add(this.pictureReinit);
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
            this.panFiltres.Location = new System.Drawing.Point(571, 5);
            this.panFiltres.Margin = new System.Windows.Forms.Padding(4);
            this.panFiltres.Name = "panFiltres";
            this.panFiltres.Size = new System.Drawing.Size(341, 350);
            this.panFiltres.TabIndex = 51;
            // 
            // pictureReinit
            // 
            this.pictureReinit.Image = global::PixLogic.Properties.Resources.reinit_icon;
            this.pictureReinit.Location = new System.Drawing.Point(295, 7);
            this.pictureReinit.Margin = new System.Windows.Forms.Padding(4);
            this.pictureReinit.Name = "pictureReinit";
            this.pictureReinit.Size = new System.Drawing.Size(33, 26);
            this.pictureReinit.TabIndex = 48;
            this.pictureReinit.TabStop = false;
            this.pictureReinit.Click += new System.EventHandler(this.pictureReinit_Click);
            this.pictureReinit.MouseEnter += new System.EventHandler(this.pictureReinit_MouseEnter);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilter.Image = global::PixLogic.Properties.Resources.filter;
            this.buttonFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFilter.Location = new System.Drawing.Point(115, 310);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(89, 32);
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
            this.checkBoxPack.Location = new System.Drawing.Point(251, 251);
            this.checkBoxPack.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxPack.Name = "checkBoxPack";
            this.checkBoxPack.Size = new System.Drawing.Size(66, 23);
            this.checkBoxPack.TabIndex = 11;
            this.checkBoxPack.Text = "Packs";
            this.checkBoxPack.UseVisualStyleBackColor = true;
            // 
            // labelTypeElementFiltre
            // 
            this.labelTypeElementFiltre.AutoSize = true;
            this.labelTypeElementFiltre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeElementFiltre.Location = new System.Drawing.Point(4, 251);
            this.labelTypeElementFiltre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypeElementFiltre.Name = "labelTypeElementFiltre";
            this.labelTypeElementFiltre.Size = new System.Drawing.Size(124, 20);
            this.labelTypeElementFiltre.TabIndex = 10;
            this.labelTypeElementFiltre.Text = "Type d\'élément :";
            // 
            // checkBoxItem
            // 
            this.checkBoxItem.AutoSize = true;
            this.checkBoxItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxItem.Location = new System.Drawing.Point(145, 251);
            this.checkBoxItem.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxItem.Name = "checkBoxItem";
            this.checkBoxItem.Size = new System.Drawing.Size(89, 23);
            this.checkBoxItem.TabIndex = 10;
            this.checkBoxItem.Text = "Matériels";
            this.checkBoxItem.UseVisualStyleBackColor = true;
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAll.Location = new System.Drawing.Point(28, 46);
            this.radioAll.Margin = new System.Windows.Forms.Padding(4);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(59, 23);
            this.radioAll.TabIndex = 8;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "Tous";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(68, 199);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(265, 22);
            this.dateTimeEnd.TabIndex = 7;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Location = new System.Drawing.Point(68, 161);
            this.dateTimeBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(265, 22);
            this.dateTimeBegin.TabIndex = 6;
            // 
            // radioBetween
            // 
            this.radioBetween.AutoSize = true;
            this.radioBetween.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBetween.Location = new System.Drawing.Point(28, 130);
            this.radioBetween.Margin = new System.Windows.Forms.Padding(4);
            this.radioBetween.Name = "radioBetween";
            this.radioBetween.Size = new System.Drawing.Size(69, 23);
            this.radioBetween.TabIndex = 5;
            this.radioBetween.TabStop = true;
            this.radioBetween.Text = "Entre :";
            this.radioBetween.UseVisualStyleBackColor = true;
            // 
            // radioOfPastSevenDays
            // 
            this.radioOfPastSevenDays.AutoSize = true;
            this.radioOfPastSevenDays.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOfPastSevenDays.Location = new System.Drawing.Point(28, 102);
            this.radioOfPastSevenDays.Margin = new System.Windows.Forms.Padding(4);
            this.radioOfPastSevenDays.Name = "radioOfPastSevenDays";
            this.radioOfPastSevenDays.Size = new System.Drawing.Size(128, 23);
            this.radioOfPastSevenDays.TabIndex = 4;
            this.radioOfPastSevenDays.TabStop = true;
            this.radioOfPastSevenDays.Text = "Depuis 07 jours";
            this.radioOfPastSevenDays.UseVisualStyleBackColor = true;
            // 
            // labelListeFiltre
            // 
            this.labelListeFiltre.AutoSize = true;
            this.labelListeFiltre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListeFiltre.Location = new System.Drawing.Point(4, 23);
            this.labelListeFiltre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListeFiltre.Name = "labelListeFiltre";
            this.labelListeFiltre.Size = new System.Drawing.Size(150, 20);
            this.labelListeFiltre.TabIndex = 3;
            this.labelListeFiltre.Text = "Liste des emprunts :";
            // 
            // radioToday
            // 
            this.radioToday.AutoSize = true;
            this.radioToday.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioToday.Location = new System.Drawing.Point(28, 74);
            this.radioToday.Margin = new System.Windows.Forms.Padding(4);
            this.radioToday.Name = "radioToday";
            this.radioToday.Size = new System.Drawing.Size(112, 23);
            this.radioToday.TabIndex = 2;
            this.radioToday.TabStop = true;
            this.radioToday.Text = "D\'aujourdhui";
            this.radioToday.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 1;
            // 
            // labelNews
            // 
            this.labelNews.AutoSize = true;
            this.labelNews.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNews.Location = new System.Drawing.Point(43, 362);
            this.labelNews.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(41, 19);
            this.labelNews.TabIndex = 52;
            this.labelNews.Text = "Infos";
            // 
            // buttonRendre
            // 
            this.buttonRendre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRendre.Image = global::PixLogic.Properties.Resources.rendre;
            this.buttonRendre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRendre.Location = new System.Drawing.Point(231, 503);
            this.buttonRendre.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRendre.Name = "buttonRendre";
            this.buttonRendre.Size = new System.Drawing.Size(127, 34);
            this.buttonRendre.TabIndex = 50;
            this.buttonRendre.Text = "Rendre";
            this.buttonRendre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRendre.UseVisualStyleBackColor = true;
            this.buttonRendre.Click += new System.EventHandler(this.buttonRendre_Click);
            // 
            // labelListEmprunt
            // 
            this.labelListEmprunt.AutoSize = true;
            this.labelListEmprunt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListEmprunt.Location = new System.Drawing.Point(41, 0);
            this.labelListEmprunt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListEmprunt.Name = "labelListEmprunt";
            this.labelListEmprunt.Size = new System.Drawing.Size(133, 19);
            this.labelListEmprunt.TabIndex = 49;
            this.labelListEmprunt.Text = "Liste des emprunts";
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
            this.panNews.Controls.Add(this.labelDateRetour);
            this.panNews.Location = new System.Drawing.Point(13, 368);
            this.panNews.Margin = new System.Windows.Forms.Padding(4);
            this.panNews.Name = "panNews";
            this.panNews.Size = new System.Drawing.Size(898, 118);
            this.panNews.TabIndex = 48;
            // 
            // valType
            // 
            this.valType.AutoSize = true;
            this.valType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valType.Location = new System.Drawing.Point(189, 80);
            this.valType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valType.Name = "valType";
            this.valType.Size = new System.Drawing.Size(17, 23);
            this.valType.TabIndex = 45;
            this.valType.Text = "-";
            this.valType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valNomReservable
            // 
            this.valNomReservable.AutoSize = true;
            this.valNomReservable.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNomReservable.Location = new System.Drawing.Point(189, 48);
            this.valNomReservable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valNomReservable.Name = "valNomReservable";
            this.valNomReservable.Size = new System.Drawing.Size(17, 23);
            this.valNomReservable.TabIndex = 44;
            this.valNomReservable.Text = "-";
            this.valNomReservable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valNomUser
            // 
            this.valNomUser.AutoSize = true;
            this.valNomUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNomUser.Location = new System.Drawing.Point(189, 16);
            this.valNomUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valNomUser.Name = "valNomUser";
            this.valNomUser.Size = new System.Drawing.Size(17, 23);
            this.valNomUser.TabIndex = 43;
            this.valNomUser.Text = "-";
            this.valNomUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nom du reservable :";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(4, 84);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(45, 19);
            this.labelType.TabIndex = 41;
            this.labelType.Text = "Type :";
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameUser.Location = new System.Drawing.Point(4, 20);
            this.labelNameUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(110, 19);
            this.labelNameUser.TabIndex = 40;
            this.labelNameUser.Text = "Nom utilisateur :";
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDebut.Location = new System.Drawing.Point(473, 20);
            this.labelDateDebut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(85, 19);
            this.labelDateDebut.TabIndex = 6;
            this.labelDateDebut.Text = "Date début :";
            // 
            // valDateDebut
            // 
            this.valDateDebut.AutoSize = true;
            this.valDateDebut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDateDebut.Location = new System.Drawing.Point(629, 15);
            this.valDateDebut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valDateDebut.Name = "valDateDebut";
            this.valDateDebut.Size = new System.Drawing.Size(17, 23);
            this.valDateDebut.TabIndex = 39;
            this.valDateDebut.Text = "-";
            this.valDateDebut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valDateFin
            // 
            this.valDateFin.AutoSize = true;
            this.valDateFin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDateFin.Location = new System.Drawing.Point(629, 50);
            this.valDateFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valDateFin.Name = "valDateFin";
            this.valDateFin.Size = new System.Drawing.Size(17, 23);
            this.valDateFin.TabIndex = 3;
            this.valDateFin.Text = "-";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.Location = new System.Drawing.Point(0, 84);
            this.labelTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(0, 19);
            this.labelTel.TabIndex = 1;
            // 
            // labelDateRetour
            // 
            this.labelDateRetour.AutoSize = true;
            this.labelDateRetour.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateRetour.Location = new System.Drawing.Point(473, 52);
            this.labelDateRetour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateRetour.Name = "labelDateRetour";
            this.labelDateRetour.Size = new System.Drawing.Size(87, 19);
            this.labelDateRetour.TabIndex = 0;
            this.labelDateRetour.Text = "Date retour :";
            // 
            // panTableUsers
            // 
            this.panTableUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTableUsers.Controls.Add(this.buttonExport);
            this.panTableUsers.Controls.Add(this.buttonCancelSearch);
            this.panTableUsers.Controls.Add(this.textBoxSearch);
            this.panTableUsers.Controls.Add(this.labelSearch);
            this.panTableUsers.Controls.Add(this.dataGridEmprunts);
            this.panTableUsers.Location = new System.Drawing.Point(13, 5);
            this.panTableUsers.Margin = new System.Windows.Forms.Padding(4);
            this.panTableUsers.Name = "panTableUsers";
            this.panTableUsers.Size = new System.Drawing.Size(549, 350);
            this.panTableUsers.TabIndex = 47;
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Image = ((System.Drawing.Image)(resources.GetObject("buttonExport.Image")));
            this.buttonExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExport.Location = new System.Drawing.Point(285, 14);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(127, 34);
            this.buttonExport.TabIndex = 44;
            this.buttonExport.Text = "Exporter";
            this.buttonExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonCancelSearch
            // 
            this.buttonCancelSearch.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancelSearch.Location = new System.Drawing.Point(232, 18);
            this.buttonCancelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelSearch.Name = "buttonCancelSearch";
            this.buttonCancelSearch.Size = new System.Drawing.Size(36, 28);
            this.buttonCancelSearch.TabIndex = 3;
            this.buttonCancelSearch.UseVisualStyleBackColor = true;
            this.buttonCancelSearch.Click += new System.EventHandler(this.buttonCancelSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(99, 20);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(127, 22);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyUp);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(12, 22);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(78, 19);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Recherche :";
            // 
            // dataGridEmprunts
            // 
            this.dataGridEmprunts.AllowUserToAddRows = false;
            this.dataGridEmprunts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataGridEmprunts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridEmprunts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridEmprunts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridEmprunts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmprunts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridEmprunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridEmprunts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReservation,
            this.NameUserReservation,
            this.NameReservable,
            this.dateEmprunt,
            this.dateRetour});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmprunts.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridEmprunts.Location = new System.Drawing.Point(-1, 58);
            this.dataGridEmprunts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridEmprunts.MultiSelect = false;
            this.dataGridEmprunts.Name = "dataGridEmprunts";
            this.dataGridEmprunts.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmprunts.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridEmprunts.RowHeadersVisible = false;
            this.dataGridEmprunts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridEmprunts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmprunts.Size = new System.Drawing.Size(549, 288);
            this.dataGridEmprunts.TabIndex = 0;
            this.dataGridEmprunts.Click += new System.EventHandler(this.dataGridEmprunts_Click);
            this.dataGridEmprunts.DoubleClick += new System.EventHandler(this.dataGridEmprunts_DoubleClick);
            this.dataGridEmprunts.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridEmprunts_KeyUp_1);
            // 
            // IdReservation
            // 
            this.IdReservation.HeaderText = "Id";
            this.IdReservation.Name = "IdReservation";
            this.IdReservation.ReadOnly = true;
            this.IdReservation.Width = 40;
            // 
            // NameUserReservation
            // 
            this.NameUserReservation.HeaderText = "Utilisateur";
            this.NameUserReservation.Name = "NameUserReservation";
            this.NameUserReservation.ReadOnly = true;
            this.NameUserReservation.Width = 80;
            // 
            // NameReservable
            // 
            this.NameReservable.HeaderText = "Réservable";
            this.NameReservable.Name = "NameReservable";
            this.NameReservable.ReadOnly = true;
            this.NameReservable.Width = 80;
            // 
            // dateEmprunt
            // 
            this.dateEmprunt.HeaderText = "Date Emprunt";
            this.dateEmprunt.Name = "dateEmprunt";
            this.dateEmprunt.ReadOnly = true;
            this.dateEmprunt.Width = 105;
            // 
            // dateRetour
            // 
            this.dateRetour.HeaderText = "Date Retour";
            this.dateRetour.Name = "dateRetour";
            this.dateRetour.ReadOnly = true;
            this.dateRetour.Width = 105;
            // 
            // panEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelFiltres);
            this.Controls.Add(this.panFiltres);
            this.Controls.Add(this.labelNews);
            this.Controls.Add(this.buttonRendre);
            this.Controls.Add(this.labelListEmprunt);
            this.Controls.Add(this.panNews);
            this.Controls.Add(this.panTableUsers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "panEmprunt";
            this.Size = new System.Drawing.Size(912, 551);
            this.panFiltres.ResumeLayout(false);
            this.panFiltres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReinit)).EndInit();
            this.panNews.ResumeLayout(false);
            this.panNews.PerformLayout();
            this.panTableUsers.ResumeLayout(false);
            this.panTableUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmprunts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFiltres;
        private System.Windows.Forms.Panel panFiltres;
        private System.Windows.Forms.PictureBox pictureReinit;
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
        private System.Windows.Forms.Button buttonRendre;
        private System.Windows.Forms.Label labelListEmprunt;
        private System.Windows.Forms.Panel panNews;
        public System.Windows.Forms.Label valType;
        public System.Windows.Forms.Label valNomReservable;
        public System.Windows.Forms.Label valNomUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.Label labelDateDebut;
        public System.Windows.Forms.Label valDateDebut;
        private System.Windows.Forms.Label valDateFin;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelDateRetour;
        private System.Windows.Forms.Panel panTableUsers;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridEmprunts;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUserReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameReservable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmprunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRetour;
        private System.Windows.Forms.Button buttonExport;
    }
}
