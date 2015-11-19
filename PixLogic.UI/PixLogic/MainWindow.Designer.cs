namespace PixLogic
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
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
            this.panUsers1 = new PixLogic.panUsers();
            this.panItemPack1 = new PixLogic.panItemPack();
            this.boutonMenu4 = new PixLogic.MenuButton();
            this.boutonMenu3 = new PixLogic.MenuButton();
            this.boutonMenu2 = new PixLogic.MenuButton();
            this.boutonMateriel = new PixLogic.MenuButton();
            this.boutonUtilisateur = new PixLogic.MenuButton();
            this.panReservation1 = new PixLogic.panReservation();
            this.barreDeMenu.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.barreDoutils.SuspendLayout();
            this.SuspendLayout();
            // 
            // barreDeMenu
            // 
            this.barreDeMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barreDeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.barreDeMenu.Location = new System.Drawing.Point(0, 0);
            this.barreDeMenu.Name = "barreDeMenu";
            this.barreDeMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.barreDeMenu.Size = new System.Drawing.Size(1103, 28);
            this.barreDeMenu.TabIndex = 0;
            this.barreDeMenu.Text = "barreDeMenu";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.connexionToolStripMenuItem.Text = "Connexion";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 24);
            this.toolStripMenuItem1.Text = "?";
            // 
            // panMenu
            // 
            this.panMenu.Controls.Add(this.boutonMenu4);
            this.panMenu.Controls.Add(this.boutonMenu3);
            this.panMenu.Controls.Add(this.boutonMenu2);
            this.panMenu.Controls.Add(this.boutonMateriel);
            this.panMenu.Controls.Add(this.boutonUtilisateur);
            this.panMenu.Location = new System.Drawing.Point(0, 75);
            this.panMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(187, 530);
            this.panMenu.TabIndex = 1;
            // 
            // barreDoutils
            // 
            this.barreDoutils.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barreDoutils.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoutonNouveauBO});
            this.barreDoutils.Location = new System.Drawing.Point(0, 28);
            this.barreDoutils.Name = "barreDoutils";
            this.barreDoutils.Size = new System.Drawing.Size(1103, 47);
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
            this.BoutonNouveauBO.Size = new System.Drawing.Size(82, 44);
            this.BoutonNouveauBO.Text = "Nouveau";
            this.BoutonNouveauBO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Image = global::PixLogic.Properties.Resources.add_user_icon;
            this.utilisateurToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(172, 40);
            this.utilisateurToolStripMenuItem.Text = "Utilisateur";
            // 
            // matérielToolStripMenuItem
            // 
            this.matérielToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.matérielToolStripMenuItem.Name = "matérielToolStripMenuItem";
            this.matérielToolStripMenuItem.Size = new System.Drawing.Size(172, 40);
            this.matérielToolStripMenuItem.Text = "Matériel";
            // 
            // packToolStripMenuItem
            // 
            this.packToolStripMenuItem.Name = "packToolStripMenuItem";
            this.packToolStripMenuItem.Size = new System.Drawing.Size(172, 40);
            this.packToolStripMenuItem.Text = "Pack";
            // 
            // réservationToolStripMenuItem
            // 
            this.réservationToolStripMenuItem.Name = "réservationToolStripMenuItem";
            this.réservationToolStripMenuItem.Size = new System.Drawing.Size(172, 40);
            this.réservationToolStripMenuItem.Text = "Réservation";
            // 
            // panUsers1
            // 
            this.panUsers1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panUsers1.Location = new System.Drawing.Point(183, 81);
            this.panUsers1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panUsers1.Name = "panUsers1";
            this.panUsers1.Size = new System.Drawing.Size(919, 521);
            this.panUsers1.TabIndex = 4;
            // 
            // panItemPack1
            // 
            this.panItemPack1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panItemPack1.Location = new System.Drawing.Point(183, 81);
            this.panItemPack1.Margin = new System.Windows.Forms.Padding(5);
            this.panItemPack1.Name = "panItemPack1";
            this.panItemPack1.Size = new System.Drawing.Size(919, 520);
            this.panItemPack1.TabIndex = 3;
            // 
            // boutonMenu4
            // 
            this.boutonMenu4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonMenu4.BackgroundImage")));
            this.boutonMenu4.Image = global::PixLogic.Properties.Resources.script_icon2;
            this.boutonMenu4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boutonMenu4.Location = new System.Drawing.Point(0, 348);
            this.boutonMenu4.Margin = new System.Windows.Forms.Padding(5);
            this.boutonMenu4.Name = "boutonMenu4";
            this.boutonMenu4.Size = new System.Drawing.Size(187, 86);
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
            this.boutonMenu3.Location = new System.Drawing.Point(0, 262);
            this.boutonMenu3.Margin = new System.Windows.Forms.Padding(5);
            this.boutonMenu3.Name = "boutonMenu3";
            this.boutonMenu3.Size = new System.Drawing.Size(187, 86);
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
            this.boutonMenu2.Location = new System.Drawing.Point(0, 176);
            this.boutonMenu2.Margin = new System.Windows.Forms.Padding(5);
            this.boutonMenu2.Name = "boutonMenu2";
            this.boutonMenu2.Size = new System.Drawing.Size(187, 86);
            this.boutonMenu2.TabIndex = 2;
            this.boutonMenu2.Text = "         RESERVATION";
            this.boutonMenu2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boutonMenu2.UseCompatibleTextRendering = true;
            // 
            // boutonMateriel
            // 
            this.boutonMateriel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonMateriel.BackgroundImage")));
            this.boutonMateriel.Image = global::PixLogic.Properties.Resources.camera_photo_icon;
            this.boutonMateriel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boutonMateriel.Location = new System.Drawing.Point(0, 90);
            this.boutonMateriel.Margin = new System.Windows.Forms.Padding(5);
            this.boutonMateriel.Name = "boutonMateriel";
            this.boutonMateriel.Size = new System.Drawing.Size(187, 86);
            this.boutonMateriel.TabIndex = 1;
            this.boutonMateriel.Text = "         MATERIEL";
            this.boutonMateriel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boutonMateriel.UseCompatibleTextRendering = true;
            // 
            // boutonUtilisateur
            // 
            this.boutonUtilisateur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonUtilisateur.BackgroundImage")));
            this.boutonUtilisateur.Image = global::PixLogic.Properties.Resources.client_icon2;
            this.boutonUtilisateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boutonUtilisateur.Location = new System.Drawing.Point(0, 4);
            this.boutonUtilisateur.Margin = new System.Windows.Forms.Padding(5);
            this.boutonUtilisateur.Name = "boutonUtilisateur";
            this.boutonUtilisateur.Size = new System.Drawing.Size(187, 86);
            this.boutonUtilisateur.TabIndex = 0;
            this.boutonUtilisateur.Text = "         UTILISATEUR";
            this.boutonUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boutonUtilisateur.UseCompatibleTextRendering = true;
            // 
            // panReservation1
            // 
            this.panReservation1.Location = new System.Drawing.Point(183, 81);
            this.panReservation1.Name = "panReservation1";
            this.panReservation1.Size = new System.Drawing.Size(917, 519);
            this.panReservation1.TabIndex = 5;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 602);
            this.Controls.Add(this.panReservation1);
            this.Controls.Add(this.panUsers1);
            this.Controls.Add(this.panItemPack1);
            this.Controls.Add(this.barreDoutils);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.barreDeMenu);
            this.MainMenuStrip = this.barreDeMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "CE3P Reservation";
            this.barreDeMenu.ResumeLayout(false);
            this.barreDeMenu.PerformLayout();
            this.panMenu.ResumeLayout(false);
            this.barreDoutils.ResumeLayout(false);
            this.barreDoutils.PerformLayout();
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
        private MenuButton boutonUtilisateur;
        private MenuButton boutonMateriel;
        private MenuButton boutonMenu2;
        private MenuButton boutonMenu4;
        private MenuButton boutonMenu3;
        private System.Windows.Forms.ToolStripDropDownButton BoutonNouveauBO;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matérielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réservationToolStripMenuItem;
        private panItemPack panItemPack1;
        private panUsers panUsers1;
        private panReservation panReservation1;
    }
}

