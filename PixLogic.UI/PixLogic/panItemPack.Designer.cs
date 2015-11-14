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
            this.panNews = new System.Windows.Forms.Panel();
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
            this.buttonRemoveItemInPack = new System.Windows.Forms.Button();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.buttonManagePack = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panNews.SuspendLayout();
            this.panTableItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panNews
            // 
            this.panNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panNews.Controls.Add(this.valQuantity);
            this.panNews.Controls.Add(this.valPrice);
            this.panNews.Controls.Add(this.valDispo);
            this.panNews.Controls.Add(this.labelQuantity);
            this.panNews.Controls.Add(this.labelPrice);
            this.panNews.Controls.Add(this.labelDispo);
            this.panNews.Location = new System.Drawing.Point(335, 197);
            this.panNews.Name = "panNews";
            this.panNews.Size = new System.Drawing.Size(140, 96);
            this.panNews.TabIndex = 26;
            // 
            // valQuantity
            // 
            this.valQuantity.AutoSize = true;
            this.valQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valQuantity.Location = new System.Drawing.Point(80, 66);
            this.valQuantity.Name = "valQuantity";
            this.valQuantity.Size = new System.Drawing.Size(13, 17);
            this.valQuantity.TabIndex = 5;
            this.valQuantity.Text = "-";
            // 
            // valPrice
            // 
            this.valPrice.AutoSize = true;
            this.valPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valPrice.Location = new System.Drawing.Point(80, 41);
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
            this.labelPrice.Size = new System.Drawing.Size(52, 13);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Prix ( € ) :";
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
            this.valDescription.Location = new System.Drawing.Point(211, 197);
            this.valDescription.Multiline = true;
            this.valDescription.Name = "valDescription";
            this.valDescription.ReadOnly = true;
            this.valDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.valDescription.Size = new System.Drawing.Size(118, 96);
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
            this.panTableItem.Controls.Add(this.buttonCancelSearch);
            this.panTableItem.Controls.Add(this.textBoxSearch);
            this.panTableItem.Controls.Add(this.labelSearch);
            this.panTableItem.Controls.Add(this.dataGridItem);
            this.panTableItem.Location = new System.Drawing.Point(5, 3);
            this.panTableItem.Name = "panTableItem";
            this.panTableItem.Size = new System.Drawing.Size(200, 411);
            this.panTableItem.TabIndex = 21;
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
            this.dataGridItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridItem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameItem,
            this.Quantity,
            this.Price});
            this.dataGridItem.Location = new System.Drawing.Point(0, 47);
            this.dataGridItem.Name = "dataGridItem";
            this.dataGridItem.ReadOnly = true;
            this.dataGridItem.RowHeadersVisible = false;
            this.dataGridItem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridItem.Size = new System.Drawing.Size(199, 363);
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
            this.labelNews.Location = new System.Drawing.Point(353, 192);
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
            this.listBoxItem.Size = new System.Drawing.Size(150, 238);
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
            this.buttonTransfert.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransfert.ForeColor = System.Drawing.Color.Blue;
            this.buttonTransfert.Location = new System.Drawing.Point(481, 168);
            this.buttonTransfert.Name = "buttonTransfert";
            this.buttonTransfert.Size = new System.Drawing.Size(43, 23);
            this.buttonTransfert.TabIndex = 34;
            this.buttonTransfert.Text = ">>";
            this.buttonTransfert.UseVisualStyleBackColor = true;
            this.buttonTransfert.Click += new System.EventHandler(this.buttonTransfert_Click);
            // 
            // buttonRemoveItemInPack
            // 
            this.buttonRemoveItemInPack.Image = global::PixLogic.Properties.Resources.supprimer_icon;
            this.buttonRemoveItemInPack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoveItemInPack.Location = new System.Drawing.Point(572, 299);
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
            this.pictureBoxItem.Image = global::PixLogic.Properties.Resources.camera_photo;
            this.pictureBoxItem.InitialImage = null;
            this.pictureBoxItem.Location = new System.Drawing.Point(211, 25);
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
            this.buttonManagePack.Location = new System.Drawing.Point(543, 385);
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
            this.buttonDelete.Location = new System.Drawing.Point(383, 385);
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
            this.buttonModify.Location = new System.Drawing.Point(298, 385);
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
            this.buttonAdd.Location = new System.Drawing.Point(212, 385);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 29);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panItemPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.Name = "panItemPack";
            this.Size = new System.Drawing.Size(690, 423);
            this.panNews.ResumeLayout(false);
            this.panNews.PerformLayout();
            this.panTableItem.ResumeLayout(false);
            this.panTableItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
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
    }
}
