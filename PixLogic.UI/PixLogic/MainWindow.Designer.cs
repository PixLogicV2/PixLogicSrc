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
            this.boutonMenu4 = new PixLogic.MenuButton();
            this.boutonMenu3 = new PixLogic.MenuButton();
            this.boutonMenu2 = new PixLogic.MenuButton();
            this.boutonMenu1 = new PixLogic.MenuButton();
            this.boutonUtilisateur = new PixLogic.MenuButton();
            this.panItemPack1 = new PixLogic.panItemPack();
            this.barreDeMenu.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.barreDoutils.SuspendLayout();
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
            this.barreDeMenu.Size = new System.Drawing.Size(827, 24);
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
            this.panMenu.Location = new System.Drawing.Point(0, 61);
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
            this.barreDoutils.Size = new System.Drawing.Size(827, 38);
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
            // panItemPack1
            // 
            this.panItemPack1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panItemPack1.Location = new System.Drawing.Point(137, 64);
            this.panItemPack1.Name = "panItemPack1";
            this.panItemPack1.Size = new System.Drawing.Size(690, 423);
            this.panItemPack1.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 489);
            this.Controls.Add(this.panItemPack1);
            this.Controls.Add(this.barreDoutils);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.barreDeMenu);
            this.MainMenuStrip = this.barreDeMenu;
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
        private MenuButton boutonMenu1;
        private MenuButton boutonMenu2;
        private MenuButton boutonMenu4;
        private MenuButton boutonMenu3;
        private System.Windows.Forms.ToolStripDropDownButton BoutonNouveauBO;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matérielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réservationToolStripMenuItem;
        private panItemPack panItemPack1;
    }
}

