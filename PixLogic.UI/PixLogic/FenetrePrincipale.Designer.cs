namespace PixLogic
{
    partial class FenetrePrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetrePrincipale));
            this.barreDeMenu = new System.Windows.Forms.MenuStrip();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panMenu = new System.Windows.Forms.Panel();
            this.barreDoutils = new System.Windows.Forms.ToolStrip();
            this.BoutonNouveauBO = new System.Windows.Forms.ToolStripDropDownButton();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matérielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panItemPack = new System.Windows.Forms.Panel();
            this.panTableItem = new System.Windows.Forms.Panel();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridItem = new System.Windows.Forms.DataGridView();
            this.NameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelListItem = new System.Windows.Forms.Label();
            this.boutonMenu4 = new PixLogic.BoutonMenu();
            this.boutonMenu3 = new PixLogic.BoutonMenu();
            this.boutonMenu2 = new PixLogic.BoutonMenu();
            this.boutonMenu1 = new PixLogic.BoutonMenu();
            this.boutonUtilisateur = new PixLogic.BoutonMenu();
            this.barreDeMenu.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.barreDoutils.SuspendLayout();
            this.panItemPack.SuspendLayout();
            this.panTableItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItem)).BeginInit();
            this.SuspendLayout();
            // 
            // barreDeMenu
            // 
            this.barreDeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.barreDeMenu.Location = new System.Drawing.Point(0, 0);
            this.barreDeMenu.Name = "barreDeMenu";
            this.barreDeMenu.Size = new System.Drawing.Size(784, 24);
            this.barreDeMenu.TabIndex = 0;
            this.barreDeMenu.Text = "barreDeMenu";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.connexionToolStripMenuItem.Text = "Connexion";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // panMenu
            // 
            this.panMenu.Controls.Add(this.boutonMenu4);
            this.panMenu.Controls.Add(this.boutonMenu3);
            this.panMenu.Controls.Add(this.boutonMenu2);
            this.panMenu.Controls.Add(this.boutonMenu1);
            this.panMenu.Controls.Add(this.boutonUtilisateur);
            this.panMenu.Location = new System.Drawing.Point(0, 68);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(140, 431);
            this.panMenu.TabIndex = 1;
            // 
            // barreDoutils
            // 
            this.barreDoutils.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoutonNouveauBO});
            this.barreDoutils.Location = new System.Drawing.Point(0, 24);
            this.barreDoutils.Name = "barreDoutils";
            this.barreDoutils.Size = new System.Drawing.Size(784, 38);
            this.barreDoutils.TabIndex = 2;
            this.barreDoutils.Text = "barreDoutils";
            // 
            // BoutonNouveauBO
            // 
            this.BoutonNouveauBO.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem,
            this.matérielToolStripMenuItem,
            this.packToolStripMenuItem,
            this.réservationToolStripMenuItem});
            this.BoutonNouveauBO.Image = ((System.Drawing.Image)(resources.GetObject("BoutonNouveauBO.Image")));
            this.BoutonNouveauBO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoutonNouveauBO.Name = "BoutonNouveauBO";
            this.BoutonNouveauBO.Size = new System.Drawing.Size(68, 35);
            this.BoutonNouveauBO.Text = "Nouveau";
            this.BoutonNouveauBO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Image = global::PixLogic.Properties.Resources.add_user_icon;
            this.utilisateurToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(150, 40);
            this.utilisateurToolStripMenuItem.Text = "Utilisateur";
            // 
            // matérielToolStripMenuItem
            // 
            this.matérielToolStripMenuItem.Image = global::PixLogic.Properties.Resources.add_item_icon;
            this.matérielToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.matérielToolStripMenuItem.Name = "matérielToolStripMenuItem";
            this.matérielToolStripMenuItem.Size = new System.Drawing.Size(150, 40);
            this.matérielToolStripMenuItem.Text = "Matériel";
            // 
            // packToolStripMenuItem
            // 
            this.packToolStripMenuItem.Name = "packToolStripMenuItem";
            this.packToolStripMenuItem.Size = new System.Drawing.Size(150, 40);
            this.packToolStripMenuItem.Text = "Pack";
            // 
            // réservationToolStripMenuItem
            // 
            this.réservationToolStripMenuItem.Name = "réservationToolStripMenuItem";
            this.réservationToolStripMenuItem.Size = new System.Drawing.Size(150, 40);
            this.réservationToolStripMenuItem.Text = "Réservation";
            // 
            // panItemPack
            // 
            this.panItemPack.Controls.Add(this.labelListItem);
            this.panItemPack.Controls.Add(this.panTableItem);
            this.panItemPack.Location = new System.Drawing.Point(139, 64);
            this.panItemPack.Name = "panItemPack";
            this.panItemPack.Size = new System.Drawing.Size(644, 428);
            this.panItemPack.TabIndex = 3;
            // 
            // panTableItem
            // 
            this.panTableItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTableItem.Controls.Add(this.buttonCancelSearch);
            this.panTableItem.Controls.Add(this.textBox1);
            this.panTableItem.Controls.Add(this.labelSearch);
            this.panTableItem.Controls.Add(this.dataGridItem);
            this.panTableItem.Location = new System.Drawing.Point(1, 7);
            this.panTableItem.Name = "panTableItem";
            this.panTableItem.Size = new System.Drawing.Size(200, 422);
            this.panTableItem.TabIndex = 0;
            // 
            // buttonCancelSearch
            // 
            this.buttonCancelSearch.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancelSearch.Location = new System.Drawing.Point(167, 16);
            this.buttonCancelSearch.Name = "buttonCancelSearch";
            this.buttonCancelSearch.Size = new System.Drawing.Size(27, 23);
            this.buttonCancelSearch.TabIndex = 3;
            this.buttonCancelSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 2;
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
            this.dataGridItem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameItem,
            this.Quantity,
            this.Price});
            this.dataGridItem.Location = new System.Drawing.Point(0, 47);
            this.dataGridItem.Name = "dataGridItem";
            this.dataGridItem.ReadOnly = true;
            this.dataGridItem.RowHeadersVisible = false;
            this.dataGridItem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridItem.Size = new System.Drawing.Size(198, 370);
            this.dataGridItem.TabIndex = 0;
            // 
            // NameItem
            // 
            this.NameItem.HeaderText = "Libellé";
            this.NameItem.Name = "NameItem";
            this.NameItem.ReadOnly = true;
            this.NameItem.Width = 75;
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
            this.Price.HeaderText = "Prix";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 60;
            // 
            // labelListItem
            // 
            this.labelListItem.AutoSize = true;
            this.labelListItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListItem.Location = new System.Drawing.Point(11, 2);
            this.labelListItem.Name = "labelListItem";
            this.labelListItem.Size = new System.Drawing.Size(102, 13);
            this.labelListItem.TabIndex = 1;
            this.labelListItem.Text = "Liste des matériels";
            // 
            // boutonMenu4
            // 
            this.boutonMenu4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonMenu4.BackgroundImage")));
            this.boutonMenu4.Image = global::PixLogic.Properties.Resources.script_icon2;
            this.boutonMenu4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boutonMenu4.Location = new System.Drawing.Point(0, 283);
            this.boutonMenu4.Name = "boutonMenu4";
            this.boutonMenu4.Size = new System.Drawing.Size(140, 70);
            this.boutonMenu4.TabIndex = 4;
            this.boutonMenu4.Text = "         SCRIPT";
            this.boutonMenu4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boutonMenu4.UseCompatibleTextRendering = true;
            // 
            // boutonMenu3
            // 
            this.boutonMenu3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonMenu3.BackgroundImage")));
            this.boutonMenu3.Image = global::PixLogic.Properties.Resources.historique_icon2;
            this.boutonMenu3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boutonMenu3.Location = new System.Drawing.Point(0, 213);
            this.boutonMenu3.Name = "boutonMenu3";
            this.boutonMenu3.Size = new System.Drawing.Size(140, 70);
            this.boutonMenu3.TabIndex = 3;
            this.boutonMenu3.Text = "         HISTORIQUE";
            this.boutonMenu3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boutonMenu3.UseCompatibleTextRendering = true;
            // 
            // boutonMenu2
            // 
            this.boutonMenu2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonMenu2.BackgroundImage")));
            this.boutonMenu2.Image = global::PixLogic.Properties.Resources.reservation_icon2;
            this.boutonMenu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boutonMenu2.Location = new System.Drawing.Point(0, 143);
            this.boutonMenu2.Name = "boutonMenu2";
            this.boutonMenu2.Size = new System.Drawing.Size(140, 70);
            this.boutonMenu2.TabIndex = 2;
            this.boutonMenu2.Text = "         RESERVATION";
            this.boutonMenu2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boutonMenu2.UseCompatibleTextRendering = true;
            // 
            // boutonMenu1
            // 
            this.boutonMenu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonMenu1.BackgroundImage")));
            this.boutonMenu1.Image = global::PixLogic.Properties.Resources.camera_photo_icon;
            this.boutonMenu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boutonMenu1.Location = new System.Drawing.Point(0, 73);
            this.boutonMenu1.Name = "boutonMenu1";
            this.boutonMenu1.Size = new System.Drawing.Size(140, 70);
            this.boutonMenu1.TabIndex = 1;
            this.boutonMenu1.Text = "         MATERIEL";
            this.boutonMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boutonMenu1.UseCompatibleTextRendering = true;
            // 
            // boutonUtilisateur
            // 
            this.boutonUtilisateur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonUtilisateur.BackgroundImage")));
            this.boutonUtilisateur.Image = global::PixLogic.Properties.Resources.client_icon2;
            this.boutonUtilisateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boutonUtilisateur.Location = new System.Drawing.Point(0, 3);
            this.boutonUtilisateur.Name = "boutonUtilisateur";
            this.boutonUtilisateur.Size = new System.Drawing.Size(140, 70);
            this.boutonUtilisateur.TabIndex = 0;
            this.boutonUtilisateur.Text = "         UTILISATEUR";
            this.boutonUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boutonUtilisateur.UseCompatibleTextRendering = true;
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 492);
            this.Controls.Add(this.panItemPack);
            this.Controls.Add(this.barreDoutils);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.barreDeMenu);
            this.MainMenuStrip = this.barreDeMenu;
            this.Name = "FenetrePrincipale";
            this.Text = "CE3P Reservation";
            this.barreDeMenu.ResumeLayout(false);
            this.barreDeMenu.PerformLayout();
            this.panMenu.ResumeLayout(false);
            this.barreDoutils.ResumeLayout(false);
            this.barreDoutils.PerformLayout();
            this.panItemPack.ResumeLayout(false);
            this.panItemPack.PerformLayout();
            this.panTableItem.ResumeLayout(false);
            this.panTableItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip barreDeMenu;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.ToolStrip barreDoutils;
        private BoutonMenu boutonUtilisateur;
        private BoutonMenu boutonMenu1;
        private BoutonMenu boutonMenu2;
        private BoutonMenu boutonMenu4;
        private BoutonMenu boutonMenu3;
        private System.Windows.Forms.ToolStripDropDownButton BoutonNouveauBO;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matérielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réservationToolStripMenuItem;
        private System.Windows.Forms.Panel panItemPack;
        private System.Windows.Forms.Panel panTableItem;
        private System.Windows.Forms.DataGridView dataGridItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelListItem;
    }
}

