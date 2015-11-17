namespace PixLogic
{
    partial class WindowPackManager
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
            this.labelListPack = new System.Windows.Forms.Label();
            this.panTablePack = new System.Windows.Forms.Panel();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridPack = new System.Windows.Forms.DataGridView();
            this.NameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNews = new System.Windows.Forms.Label();
            this.panNews = new System.Windows.Forms.Panel();
            this.valDescription = new System.Windows.Forms.TextBox();
            this.labelDescrip = new System.Windows.Forms.Label();
            this.valNbItems = new System.Windows.Forms.Label();
            this.valPrice = new System.Windows.Forms.Label();
            this.valDispo = new System.Windows.Forms.Label();
            this.labelNbItems = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDispo = new System.Windows.Forms.Label();
            this.panPackContain = new System.Windows.Forms.Panel();
            this.listBoxItemsOfPack = new System.Windows.Forms.ListBox();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.labelListItem = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.valNamePack = new System.Windows.Forms.Label();
            this.panTablePack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPack)).BeginInit();
            this.panNews.SuspendLayout();
            this.panPackContain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListPack
            // 
            this.labelListPack.AutoSize = true;
            this.labelListPack.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListPack.Location = new System.Drawing.Point(22, 0);
            this.labelListPack.Name = "labelListPack";
            this.labelListPack.Size = new System.Drawing.Size(84, 13);
            this.labelListPack.TabIndex = 24;
            this.labelListPack.Text = "Liste des packs";
            // 
            // panTablePack
            // 
            this.panTablePack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTablePack.Controls.Add(this.buttonCancelSearch);
            this.panTablePack.Controls.Add(this.textBoxSearch);
            this.panTablePack.Controls.Add(this.labelSearch);
            this.panTablePack.Controls.Add(this.dataGridPack);
            this.panTablePack.Location = new System.Drawing.Point(4, 5);
            this.panTablePack.Name = "panTablePack";
            this.panTablePack.Size = new System.Drawing.Size(200, 411);
            this.panTablePack.TabIndex = 23;
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
            // dataGridPack
            // 
            this.dataGridPack.AllowUserToAddRows = false;
            this.dataGridPack.AllowUserToDeleteRows = false;
            this.dataGridPack.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridPack.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridPack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridPack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameItem,
            this.Price,
            this.Available});
            this.dataGridPack.Location = new System.Drawing.Point(0, 47);
            this.dataGridPack.Name = "dataGridPack";
            this.dataGridPack.ReadOnly = true;
            this.dataGridPack.RowHeadersVisible = false;
            this.dataGridPack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridPack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPack.Size = new System.Drawing.Size(199, 363);
            this.dataGridPack.TabIndex = 0;
            this.dataGridPack.Click += new System.EventHandler(this.dataGridPack_Click);
            // 
            // NameItem
            // 
            this.NameItem.HeaderText = "Libellé";
            this.NameItem.Name = "NameItem";
            this.NameItem.ReadOnly = true;
            this.NameItem.Width = 87;
            // 
            // Price
            // 
            this.Price.HeaderText = "Prix ( € )";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 60;
            // 
            // Available
            // 
            this.Available.HeaderText = "Dispo";
            this.Available.Name = "Available";
            this.Available.ReadOnly = true;
            this.Available.Width = 50;
            // 
            // labelNews
            // 
            this.labelNews.AutoSize = true;
            this.labelNews.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNews.Location = new System.Drawing.Point(228, 188);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(33, 13);
            this.labelNews.TabIndex = 27;
            this.labelNews.Text = "Infos";
            // 
            // panNews
            // 
            this.panNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panNews.Controls.Add(this.valDescription);
            this.panNews.Controls.Add(this.labelDescrip);
            this.panNews.Controls.Add(this.valNbItems);
            this.panNews.Controls.Add(this.valPrice);
            this.panNews.Controls.Add(this.valDispo);
            this.panNews.Controls.Add(this.labelNbItems);
            this.panNews.Controls.Add(this.labelPrice);
            this.panNews.Controls.Add(this.labelDispo);
            this.panNews.Location = new System.Drawing.Point(210, 193);
            this.panNews.Name = "panNews";
            this.panNews.Size = new System.Drawing.Size(409, 153);
            this.panNews.TabIndex = 28;
            // 
            // valDescription
            // 
            this.valDescription.BackColor = System.Drawing.Color.White;
            this.valDescription.Location = new System.Drawing.Point(122, 97);
            this.valDescription.Multiline = true;
            this.valDescription.Name = "valDescription";
            this.valDescription.ReadOnly = true;
            this.valDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.valDescription.Size = new System.Drawing.Size(282, 51);
            this.valDescription.TabIndex = 7;
            // 
            // labelDescrip
            // 
            this.labelDescrip.AutoSize = true;
            this.labelDescrip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescrip.Location = new System.Drawing.Point(0, 97);
            this.labelDescrip.Name = "labelDescrip";
            this.labelDescrip.Size = new System.Drawing.Size(72, 13);
            this.labelDescrip.TabIndex = 6;
            this.labelDescrip.Text = "Description :";
            // 
            // valNbItems
            // 
            this.valNbItems.AutoSize = true;
            this.valNbItems.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNbItems.Location = new System.Drawing.Point(119, 66);
            this.valNbItems.Name = "valNbItems";
            this.valNbItems.Size = new System.Drawing.Size(13, 17);
            this.valNbItems.TabIndex = 5;
            this.valNbItems.Text = "-";
            // 
            // valPrice
            // 
            this.valPrice.AutoSize = true;
            this.valPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valPrice.Location = new System.Drawing.Point(119, 41);
            this.valPrice.Name = "valPrice";
            this.valPrice.Size = new System.Drawing.Size(13, 17);
            this.valPrice.TabIndex = 4;
            this.valPrice.Text = "-";
            // 
            // valDispo
            // 
            this.valDispo.AutoSize = true;
            this.valDispo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDispo.Location = new System.Drawing.Point(119, 16);
            this.valDispo.Name = "valDispo";
            this.valDispo.Size = new System.Drawing.Size(11, 13);
            this.valDispo.TabIndex = 3;
            this.valDispo.Text = "-";
            // 
            // labelNbItems
            // 
            this.labelNbItems.AutoSize = true;
            this.labelNbItems.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbItems.Location = new System.Drawing.Point(0, 69);
            this.labelNbItems.Name = "labelNbItems";
            this.labelNbItems.Size = new System.Drawing.Size(93, 13);
            this.labelNbItems.TabIndex = 2;
            this.labelNbItems.Text = "Matériels inclus :";
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
            // panPackContain
            // 
            this.panPackContain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPackContain.Controls.Add(this.listBoxItemsOfPack);
            this.panPackContain.Controls.Add(this.pictureBoxItem);
            this.panPackContain.Location = new System.Drawing.Point(210, 22);
            this.panPackContain.Name = "panPackContain";
            this.panPackContain.Size = new System.Drawing.Size(408, 160);
            this.panPackContain.TabIndex = 29;
            // 
            // listBoxItemsOfPack
            // 
            this.listBoxItemsOfPack.FormattingEnabled = true;
            this.listBoxItemsOfPack.Location = new System.Drawing.Point(-1, -1);
            this.listBoxItemsOfPack.Name = "listBoxItemsOfPack";
            this.listBoxItemsOfPack.ScrollAlwaysVisible = true;
            this.listBoxItemsOfPack.Size = new System.Drawing.Size(219, 160);
            this.listBoxItemsOfPack.TabIndex = 1;
            this.listBoxItemsOfPack.SelectedIndexChanged += new System.EventHandler(this.listBoxItemsOfPack_SelectedIndexChanged);
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxItem.Location = new System.Drawing.Point(224, -1);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(183, 166);
            this.pictureBoxItem.TabIndex = 0;
            this.pictureBoxItem.TabStop = false;
            // 
            // labelListItem
            // 
            this.labelListItem.AutoSize = true;
            this.labelListItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListItem.Location = new System.Drawing.Point(207, -1);
            this.labelListItem.Name = "labelListItem";
            this.labelListItem.Size = new System.Drawing.Size(171, 17);
            this.labelListItem.TabIndex = 30;
            this.labelListItem.Text = "Liste des matériels du pack";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Image = global::PixLogic.Properties.Resources.supprimer_icon;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(486, 388);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(93, 29);
            this.buttonDelete.TabIndex = 35;
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
            this.buttonModify.Location = new System.Drawing.Point(366, 388);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(78, 29);
            this.buttonModify.TabIndex = 34;
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
            this.buttonAdd.Location = new System.Drawing.Point(246, 388);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 29);
            this.buttonAdd.TabIndex = 33;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // valNamePack
            // 
            this.valNamePack.AutoSize = true;
            this.valNamePack.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNamePack.Location = new System.Drawing.Point(384, -1);
            this.valNamePack.Name = "valNamePack";
            this.valNamePack.Size = new System.Drawing.Size(13, 17);
            this.valNamePack.TabIndex = 36;
            this.valNamePack.Text = "-";
            // 
            // WindowPackManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 425);
            this.Controls.Add(this.valNamePack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelListItem);
            this.Controls.Add(this.panPackContain);
            this.Controls.Add(this.labelNews);
            this.Controls.Add(this.panNews);
            this.Controls.Add(this.labelListPack);
            this.Controls.Add(this.panTablePack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowPackManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire de packs";
            this.panTablePack.ResumeLayout(false);
            this.panTablePack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPack)).EndInit();
            this.panNews.ResumeLayout(false);
            this.panNews.PerformLayout();
            this.panPackContain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListPack;
        private System.Windows.Forms.Panel panTablePack;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridPack;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.Label labelNews;
        private System.Windows.Forms.Panel panNews;
        private System.Windows.Forms.Label valNbItems;
        private System.Windows.Forms.Label valPrice;
        private System.Windows.Forms.Label valDispo;
        private System.Windows.Forms.Label labelNbItems;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDispo;
        private System.Windows.Forms.TextBox valDescription;
        private System.Windows.Forms.Label labelDescrip;
        private System.Windows.Forms.Panel panPackContain;
        private System.Windows.Forms.PictureBox pictureBoxItem;
        private System.Windows.Forms.Label labelListItem;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxItemsOfPack;
        public System.Windows.Forms.Label valNamePack;
    }
}