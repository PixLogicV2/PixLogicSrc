namespace PixLogic
{
    partial class panItemPack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panItemPack));
            this.panNews = new System.Windows.Forms.Panel();
            this.valCategorie = new System.Windows.Forms.Label();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.valQuantity = new System.Windows.Forms.Label();
            this.valPrice = new System.Windows.Forms.Label();
            this.valDispo = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDispo = new System.Windows.Forms.Label();
            this.valDescription = new System.Windows.Forms.TextBox();
            this.valItemName = new System.Windows.Forms.Label();
            this.labelListItem = new System.Windows.Forms.Label();
            this.panTableItem = new System.Windows.Forms.Panel();
            this.labelCat = new System.Windows.Forms.Label();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridItem = new System.Windows.Forms.DataGridView();
            this.NameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNews = new System.Windows.Forms.Label();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.comboBoxPack = new System.Windows.Forms.ComboBox();
            this.labelPack = new System.Windows.Forms.Label();
            this.buttonTransfert = new System.Windows.Forms.Button();
            this.valItemId = new System.Windows.Forms.Label();
            this.pictureImporter = new System.Windows.Forms.PictureBox();
            this.pictureExport = new System.Windows.Forms.PictureBox();
            this.buttonRemoveItemInPack = new System.Windows.Forms.Button();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.buttonManagePack = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureReserver = new System.Windows.Forms.PictureBox();
            this.panNews.SuspendLayout();
            this.panTableItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImporter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReserver)).BeginInit();
            this.SuspendLayout();
            // 
            // panNews
            // 
            this.panNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panNews.Controls.Add(this.valCategorie);
            this.panNews.Controls.Add(this.labelCategorie);
            this.panNews.Controls.Add(this.valQuantity);
            this.panNews.Controls.Add(this.valPrice);
            this.panNews.Controls.Add(this.valDispo);
            this.panNews.Controls.Add(this.labelQuantity);
            this.panNews.Controls.Add(this.labelPrice);
            this.panNews.Controls.Add(this.labelDispo);
            this.panNews.Location = new System.Drawing.Point(335, 200);
            this.panNews.Name = "panNews";
            this.panNews.Size = new System.Drawing.Size(140, 115);
            this.panNews.TabIndex = 26;
            // 
            // valCategorie
            // 
            this.valCategorie.AutoSize = true;
            this.valCategorie.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valCategorie.Location = new System.Drawing.Point(65, 94);
            this.valCategorie.Name = "valCategorie";
            this.valCategorie.Size = new System.Drawing.Size(0, 13);
            this.valCategorie.TabIndex = 7;
            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorie.Location = new System.Drawing.Point(0, 95);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(63, 13);
            this.labelCategorie.TabIndex = 6;
            this.labelCategorie.Text = "Catégorie :";
            // 
            // valQuantity
            // 
            this.valQuantity.AutoSize = true;
            this.valQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valQuantity.Location = new System.Drawing.Point(65, 66);
            this.valQuantity.Name = "valQuantity";
            this.valQuantity.Size = new System.Drawing.Size(13, 17);
            this.valQuantity.TabIndex = 5;
            this.valQuantity.Text = "-";
            // 
            // valPrice
            // 
            this.valPrice.AutoSize = true;
            this.valPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valPrice.Location = new System.Drawing.Point(81, 41);
            this.valPrice.Name = "valPrice";
            this.valPrice.Size = new System.Drawing.Size(13, 17);
            this.valPrice.TabIndex = 4;
            this.valPrice.Text = "-";
            // 
            // valDispo
            // 
            this.valDispo.AutoSize = true;
            this.valDispo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDispo.Location = new System.Drawing.Point(80, 16);
            this.valDispo.Name = "valDispo";
            this.valDispo.Size = new System.Drawing.Size(11, 13);
            this.valDispo.TabIndex = 3;
            this.valDispo.Text = "-";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(0, 69);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(58, 13);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "Quantité :";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(0, 42);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(76, 13);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Prix (Crédits) :";
            // 
            // labelDispo
            // 
            this.labelDispo.AutoSize = true;
            this.labelDispo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDispo.Location = new System.Drawing.Point(0, 16);
            this.labelDispo.Name = "labelDispo";
            this.labelDispo.Size = new System.Drawing.Size(79, 13);
            this.labelDispo.TabIndex = 0;
            this.labelDispo.Text = "Disponibilité :";
            // 
            // valDescription
            // 
            this.valDescription.BackColor = System.Drawing.Color.White;
            this.valDescription.Location = new System.Drawing.Point(211, 200);
            this.valDescription.Multiline = true;
            this.valDescription.Name = "valDescription";
            this.valDescription.ReadOnly = true;
            this.valDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.valDescription.Size = new System.Drawing.Size(118, 115);
            this.valDescription.TabIndex = 25;
            // 
            // valItemName
            // 
            this.valItemName.AutoSize = true;
            this.valItemName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valItemName.Location = new System.Drawing.Point(207, 1);
            this.valItemName.Name = "valItemName";
            this.valItemName.Size = new System.Drawing.Size(133, 21);
            this.valItemName.TabIndex = 23;
            this.valItemName.Text = "Nom du matériel";
            this.valItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelListItem
            // 
            this.labelListItem.AutoSize = true;
            this.labelListItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListItem.Location = new System.Drawing.Point(23, -2);
            this.labelListItem.Name = "labelListItem";
            this.labelListItem.Size = new System.Drawing.Size(102, 13);
            this.labelListItem.TabIndex = 22;
            this.labelListItem.Text = "Liste des matériels";
            // 
            // panTableItem
            // 
            this.panTableItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTableItem.Controls.Add(this.labelCat);
            this.panTableItem.Controls.Add(this.comboBoxCategorie);
            this.panTableItem.Controls.Add(this.buttonCancelSearch);
            this.panTableItem.Controls.Add(this.textBoxSearch);
            this.panTableItem.Controls.Add(this.labelSearch);
            this.panTableItem.Controls.Add(this.dataGridItem);
            this.panTableItem.Location = new System.Drawing.Point(5, 3);
            this.panTableItem.Name = "panTableItem";
            this.panTableItem.Size = new System.Drawing.Size(200, 426);
            this.panTableItem.TabIndex = 21;
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCat.Location = new System.Drawing.Point(2, 52);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(63, 13);
            this.labelCat.TabIndex = 34;
            this.labelCat.Text = "Catégorie :";
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.ItemHeight = 13;
            this.comboBoxCategorie.Location = new System.Drawing.Point(67, 49);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(127, 21);
            this.comboBoxCategorie.Sorted = true;
            this.comboBoxCategorie.TabIndex = 33;
            this.comboBoxCategorie.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategorie_SelectedIndexChanged);
            this.comboBoxCategorie.Click += new System.EventHandler(this.comboBoxCategorie_Click);
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
            // dataGridItem
            // 
            this.dataGridItem.AllowUserToAddRows = false;
            this.dataGridItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridItem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameItem,
            this.Quantity,
            this.Price});
            this.dataGridItem.Location = new System.Drawing.Point(0, 76);
            this.dataGridItem.MultiSelect = false;
            this.dataGridItem.Name = "dataGridItem";
            this.dataGridItem.ReadOnly = true;
            this.dataGridItem.RowHeadersVisible = false;
            this.dataGridItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridItem.Size = new System.Drawing.Size(199, 349);
            this.dataGridItem.TabIndex = 0;
            this.dataGridItem.Click += new System.EventHandler(this.dataGridItem_Click);
            this.dataGridItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridItem_KeyUp);
            // 
            // NameItem
            // 
            this.NameItem.HeaderText = "Libellé";
            this.NameItem.Name = "NameItem";
            this.NameItem.ReadOnly = true;
            this.NameItem.Width = 77;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantité";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 60;
            // 
            // Price
            // 
            this.Price.HeaderText = "Prix ( € )";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 60;
            // 
            // labelNews
            // 
            this.labelNews.AutoSize = true;
            this.labelNews.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNews.Location = new System.Drawing.Point(353, 195);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(33, 13);
            this.labelNews.TabIndex = 0;
            this.labelNews.Text = "Infos";
            // 
            // listBoxItem
            // 
            this.listBoxItem.AllowDrop = true;
            this.listBoxItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.Location = new System.Drawing.Point(530, 55);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.ScrollAlwaysVisible = true;
            this.listBoxItem.Size = new System.Drawing.Size(150, 212);
            this.listBoxItem.TabIndex = 30;
            this.listBoxItem.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxItem_DragDrop);
            this.listBoxItem.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxItem_DragEnter);
            // 
            // comboBoxPack
            // 
            this.comboBoxPack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPack.FormattingEnabled = true;
            this.comboBoxPack.ItemHeight = 13;
            this.comboBoxPack.Location = new System.Drawing.Point(530, 25);
            this.comboBoxPack.Name = "comboBoxPack";
            this.comboBoxPack.Size = new System.Drawing.Size(150, 21);
            this.comboBoxPack.Sorted = true;
            this.comboBoxPack.TabIndex = 31;
            this.comboBoxPack.SelectedIndexChanged += new System.EventHandler(this.comboBoxPack_SelectedIndexChanged);
            // 
            // labelPack
            // 
            this.labelPack.AutoSize = true;
            this.labelPack.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPack.Location = new System.Drawing.Point(530, 9);
            this.labelPack.Name = "labelPack";
            this.labelPack.Size = new System.Drawing.Size(36, 13);
            this.labelPack.TabIndex = 32;
            this.labelPack.Text = "Pack :";
            // 
            // buttonTransfert
            // 
            this.buttonTransfert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransfert.ForeColor = System.Drawing.Color.Blue;
            this.buttonTransfert.Location = new System.Drawing.Point(481, 171);
            this.buttonTransfert.Name = "buttonTransfert";
            this.buttonTransfert.Size = new System.Drawing.Size(43, 23);
            this.buttonTransfert.TabIndex = 34;
            this.buttonTransfert.Text = ">>";
            this.buttonTransfert.UseVisualStyleBackColor = true;
            this.buttonTransfert.Click += new System.EventHandler(this.buttonTransfert_Click);
            // 
            // valItemId
            // 
            this.valItemId.AutoSize = true;
            this.valItemId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valItemId.Location = new System.Drawing.Point(349, 2);
            this.valItemId.Name = "valItemId";
            this.valItemId.Size = new System.Drawing.Size(25, 21);
            this.valItemId.TabIndex = 39;
            this.valItemId.Text = "Id";
            this.valItemId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureImporter
            // 
            this.pictureImporter.Image = ((System.Drawing.Image)(resources.GetObject("pictureImporter.Image")));
            this.pictureImporter.Location = new System.Drawing.Point(456, 0);
            this.pictureImporter.Name = "pictureImporter";
            this.pictureImporter.Size = new System.Drawing.Size(29, 27);
            this.pictureImporter.TabIndex = 51;
            this.pictureImporter.TabStop = false;
            this.pictureImporter.Click += new System.EventHandler(this.pictureImporter_Click);
            this.pictureImporter.MouseEnter += new System.EventHandler(this.pictureImporter_MouseEnter);
            // 
            // pictureExport
            // 
            this.pictureExport.Image = ((System.Drawing.Image)(resources.GetObject("pictureExport.Image")));
            this.pictureExport.Location = new System.Drawing.Point(422, 1);
            this.pictureExport.Name = "pictureExport";
            this.pictureExport.Size = new System.Drawing.Size(30, 27);
            this.pictureExport.TabIndex = 50;
            this.pictureExport.TabStop = false;
            this.pictureExport.Click += new System.EventHandler(this.pictureExport_Click);
            this.pictureExport.MouseEnter += new System.EventHandler(this.pictureExport_MouseEnter);
            // 
            // buttonRemoveItemInPack
            // 
            this.buttonRemoveItemInPack.Image = global::PixLogic.Properties.Resources.supprimer_icon;
            this.buttonRemoveItemInPack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoveItemInPack.Location = new System.Drawing.Point(566, 273);
            this.buttonRemoveItemInPack.Name = "buttonRemoveItemInPack";
            this.buttonRemoveItemInPack.Size = new System.Drawing.Size(75, 30);
            this.buttonRemoveItemInPack.TabIndex = 37;
            this.buttonRemoveItemInPack.Text = "Enlever";
            this.buttonRemoveItemInPack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRemoveItemInPack.UseVisualStyleBackColor = true;
            this.buttonRemoveItemInPack.Click += new System.EventHandler(this.buttonRemoveItemInPack_Click);
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxItem.Image = global::PixLogic.Properties.Resources.noitem;
            this.pictureBoxItem.InitialImage = null;
            this.pictureBoxItem.Location = new System.Drawing.Point(211, 28);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(264, 166);
            this.pictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxItem.TabIndex = 36;
            this.pictureBoxItem.TabStop = false;
            this.pictureBoxItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxItem_MouseDown);
            // 
            // buttonManagePack
            // 
            this.buttonManagePack.Image = global::PixLogic.Properties.Resources.general_icon;
            this.buttonManagePack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManagePack.Location = new System.Drawing.Point(543, 401);
            this.buttonManagePack.Name = "buttonManagePack";
            this.buttonManagePack.Size = new System.Drawing.Size(121, 28);
            this.buttonManagePack.TabIndex = 35;
            this.buttonManagePack.Text = "Gérer les packs";
            this.buttonManagePack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonManagePack.UseVisualStyleBackColor = true;
            this.buttonManagePack.Click += new System.EventHandler(this.buttonManagePack_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Image = global::PixLogic.Properties.Resources.supprimer_icon;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(383, 401);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(93, 29);
            this.buttonDelete.TabIndex = 29;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.Image = global::PixLogic.Properties.Resources.modifier_icon;
            this.buttonModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModify.Location = new System.Drawing.Point(298, 401);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(78, 29);
            this.buttonModify.TabIndex = 28;
            this.buttonModify.Text = "Modifier";
            this.buttonModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Image = global::PixLogic.Properties.Resources.ajouter_icon;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(212, 401);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 29);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureReserver
            // 
            this.pictureReserver.BackColor = System.Drawing.Color.Transparent;
            this.pictureReserver.Image = ((System.Drawing.Image)(resources.GetObject("pictureReserver.Image")));
            this.pictureReserver.Location = new System.Drawing.Point(452, 311);
            this.pictureReserver.Name = "pictureReserver";
            this.pictureReserver.Size = new System.Drawing.Size(23, 23);
            this.pictureReserver.TabIndex = 41;
            this.pictureReserver.TabStop = false;
            this.pictureReserver.Click += new System.EventHandler(this.pictureReserver_Click);
            this.pictureReserver.MouseEnter += new System.EventHandler(this.pictureReserver_MouseEnter);
            // 
            // panItemPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureImporter);
            this.Controls.Add(this.pictureExport);
            this.Controls.Add(this.valItemId);
            this.Controls.Add(this.buttonRemoveItemInPack);
            this.Controls.Add(this.pictureBoxItem);
            this.Controls.Add(this.buttonManagePack);
            this.Controls.Add(this.buttonTransfert);
            this.Controls.Add(this.labelPack);
            this.Controls.Add(this.comboBoxPack);
            this.Controls.Add(this.listBoxItem);
            this.Controls.Add(this.labelNews);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panNews);
            this.Controls.Add(this.valDescription);
            this.Controls.Add(this.valItemName);
            this.Controls.Add(this.labelListItem);
            this.Controls.Add(this.panTableItem);
            this.Controls.Add(this.pictureReserver);
            this.Name = "panItemPack";
            this.Size = new System.Drawing.Size(690, 452);
            this.panNews.ResumeLayout(false);
            this.panNews.PerformLayout();
            this.panTableItem.ResumeLayout(false);
            this.panTableItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImporter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReserver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panNews;
        private System.Windows.Forms.TextBox valDescription;
        private System.Windows.Forms.Label labelListItem;
        private System.Windows.Forms.Panel panTableItem;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridItem;
        private System.Windows.Forms.Label labelNews;
        private System.Windows.Forms.Label valQuantity;
        private System.Windows.Forms.Label valPrice;
        private System.Windows.Forms.Label valDispo;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDispo;
        private System.Windows.Forms.ListBox listBoxItem;
        private System.Windows.Forms.ComboBox comboBoxPack;
        private System.Windows.Forms.Label labelPack;
        private System.Windows.Forms.Button buttonTransfert;
        private System.Windows.Forms.Button buttonManagePack;
        private System.Windows.Forms.PictureBox pictureBoxItem;
        private System.Windows.Forms.Button buttonRemoveItemInPack;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        public System.Windows.Forms.Label valItemName;
        public System.Windows.Forms.Label valItemId;
        private System.Windows.Forms.PictureBox pictureReserver;
        private System.Windows.Forms.Label valCategorie;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.PictureBox pictureExport;
        private System.Windows.Forms.PictureBox pictureImporter;
    }
}
