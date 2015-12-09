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
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panMenu = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Panel();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.labelFleche = new System.Windows.Forms.Label();
            this.barreDoutils = new System.Windows.Forms.ToolStrip();
            this.BoutonActionBO = new System.Windows.Forms.ToolStripDropDownButton();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matérielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAllPan = new System.Windows.Forms.Panel();
            this.boutonEmprunt = new PixLogic.MenuButton();
            this.boutonScript = new PixLogic.MenuButton();
            this.boutonHistorique = new PixLogic.MenuButton();
            this.boutonReservation = new PixLogic.MenuButton();
            this.boutonMateriel = new PixLogic.MenuButton();
            this.boutonUtilisateur = new PixLogic.MenuButton();
            this.panLog1 = new PixLogic.panLog();
            this.panScript1 = new PixLogic.panScript();
            this.panEmprunt1 = new PixLogic.panEmprunt();
            this.panReservation1 = new PixLogic.panReservation();
            this.panItemPack1 = new PixLogic.panItemPack();
            this.panUsers1 = new PixLogic.panUsers();
            this.barreDeMenu.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.buttonMenu.SuspendLayout();
            this.barreDoutils.SuspendLayout();
            this.panelAllPan.SuspendLayout();
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
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Image = global::PixLogic.Properties.Resources.parametres_icon;
            this.paramètresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            this.paramètresToolStripMenuItem.Click += new System.EventHandler(this.paramètresToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // panMenu
            // 
            this.panMenu.Controls.Add(this.buttonMenu);
            this.panMenu.Controls.Add(this.boutonEmprunt);
            this.panMenu.Controls.Add(this.boutonScript);
            this.panMenu.Controls.Add(this.boutonHistorique);
            this.panMenu.Controls.Add(this.boutonReservation);
            this.panMenu.Controls.Add(this.boutonMateriel);
            this.panMenu.Controls.Add(this.boutonUtilisateur);
            this.panMenu.Location = new System.Drawing.Point(0, 61);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(140, 458);
            this.panMenu.TabIndex = 1;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.buttonMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonMenu.Controls.Add(this.labelMainMenu);
            this.buttonMenu.Controls.Add(this.labelFleche);
            this.buttonMenu.Location = new System.Drawing.Point(0, 423);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(140, 34);
            this.buttonMenu.TabIndex = 6;
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.AutoSize = true;
            this.labelMainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelMainMenu.Location = new System.Drawing.Point(15, 13);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(104, 15);
            this.labelMainMenu.TabIndex = 0;
            this.labelMainMenu.Text = "MENU PRINCIPAL";
            // 
            // labelFleche
            // 
            this.labelFleche.AutoSize = true;
            this.labelFleche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFleche.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFleche.Location = new System.Drawing.Point(60, 2);
            this.labelFleche.Name = "labelFleche";
            this.labelFleche.Size = new System.Drawing.Size(16, 20);
            this.labelFleche.TabIndex = 1;
            this.labelFleche.Text = "^";
            // 
            // barreDoutils
            // 
            this.barreDoutils.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barreDoutils.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoutonActionBO});
            this.barreDoutils.Location = new System.Drawing.Point(0, 24);
            this.barreDoutils.Name = "barreDoutils";
            this.barreDoutils.Size = new System.Drawing.Size(827, 42);
            this.barreDoutils.TabIndex = 2;
            this.barreDoutils.Text = "barreDoutils";
            // 
            // BoutonActionBO
            // 
            this.BoutonActionBO.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem,
            this.matérielToolStripMenuItem,
            this.packToolStripMenuItem,
            this.réservationToolStripMenuItem});
            this.BoutonActionBO.Image = ((System.Drawing.Image)(resources.GetObject("BoutonActionBO.Image")));
            this.BoutonActionBO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoutonActionBO.Name = "BoutonActionBO";
            this.BoutonActionBO.Size = new System.Drawing.Size(68, 39);
            this.BoutonActionBO.Text = "Nouveau";
            this.BoutonActionBO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // panelAllPan
            // 
            this.panelAllPan.Controls.Add(this.panLog1);
            this.panelAllPan.Controls.Add(this.panScript1);
            this.panelAllPan.Controls.Add(this.panEmprunt1);
            this.panelAllPan.Controls.Add(this.panReservation1);
            this.panelAllPan.Controls.Add(this.panItemPack1);
            this.panelAllPan.Controls.Add(this.panUsers1);
            this.panelAllPan.Location = new System.Drawing.Point(137, 64);
            this.panelAllPan.Name = "panelAllPan";
            this.panelAllPan.Size = new System.Drawing.Size(690, 455);
            this.panelAllPan.TabIndex = 3;
            // 
            // boutonEmprunt
            // 
            this.boutonEmprunt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonEmprunt.BackgroundImage")));
            this.boutonEmprunt.Image = global::PixLogic.Properties.Resources.aa;
            this.boutonEmprunt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boutonEmprunt.Location = new System.Drawing.Point(0, 213);
            this.boutonEmprunt.Margin = new System.Windows.Forms.Padding(4);
            this.boutonEmprunt.Name = "boutonEmprunt";
            this.boutonEmprunt.Size = new System.Drawing.Size(140, 70);
            this.boutonEmprunt.TabIndex = 5;
            this.boutonEmprunt.Text = "         EMPRUNT";
            this.boutonEmprunt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boutonEmprunt.UseCompatibleTextRendering = true;
            // 
            // boutonScript
            // 
            this.boutonScript.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonScript.BackgroundImage")));
            this.boutonScript.Image = global::PixLogic.Properties.Resources.script_icon2;
            this.boutonScript.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boutonScript.Location = new System.Drawing.Point(0, 353);
            this.boutonScript.Margin = new System.Windows.Forms.Padding(4);
            this.boutonScript.Name = "boutonScript";
            this.boutonScript.Size = new System.Drawing.Size(140, 70);
            this.boutonScript.TabIndex = 4;
            this.boutonScript.Text = "         SCRIPT";
            this.boutonScript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boutonScript.UseCompatibleTextRendering = true;
            // 
            // boutonHistorique
            // 
            this.boutonHistorique.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonHistorique.BackgroundImage")));
            this.boutonHistorique.Image = global::PixLogic.Properties.Resources.historique_icon2;
            this.boutonHistorique.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boutonHistorique.Location = new System.Drawing.Point(0, 283);
            this.boutonHistorique.Margin = new System.Windows.Forms.Padding(4);
            this.boutonHistorique.Name = "boutonHistorique";
            this.boutonHistorique.Size = new System.Drawing.Size(140, 70);
            this.boutonHistorique.TabIndex = 3;
            this.boutonHistorique.Text = "         HISTORIQUE";
            this.boutonHistorique.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boutonHistorique.UseCompatibleTextRendering = true;
            // 
            // boutonReservation
            // 
            this.boutonReservation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonReservation.BackgroundImage")));
            this.boutonReservation.Image = global::PixLogic.Properties.Resources.reservation_icon2;
            this.boutonReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boutonReservation.Location = new System.Drawing.Point(0, 143);
            this.boutonReservation.Margin = new System.Windows.Forms.Padding(4);
            this.boutonReservation.Name = "boutonReservation";
            this.boutonReservation.Size = new System.Drawing.Size(140, 70);
            this.boutonReservation.TabIndex = 2;
            this.boutonReservation.Text = "         RESERVATION";
            this.boutonReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boutonReservation.UseCompatibleTextRendering = true;
            // 
            // boutonMateriel
            // 
            this.boutonMateriel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonMateriel.BackgroundImage")));
            this.boutonMateriel.Image = global::PixLogic.Properties.Resources.camera_photo_icon;
            this.boutonMateriel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boutonMateriel.Location = new System.Drawing.Point(0, 73);
            this.boutonMateriel.Margin = new System.Windows.Forms.Padding(4);
            this.boutonMateriel.Name = "boutonMateriel";
            this.boutonMateriel.Size = new System.Drawing.Size(140, 70);
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
            this.boutonUtilisateur.Location = new System.Drawing.Point(0, 3);
            this.boutonUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.boutonUtilisateur.Name = "boutonUtilisateur";
            this.boutonUtilisateur.Size = new System.Drawing.Size(140, 70);
            this.boutonUtilisateur.TabIndex = 0;
            this.boutonUtilisateur.Text = "         UTILISATEUR";
            this.boutonUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boutonUtilisateur.UseCompatibleTextRendering = true;
            // 
            // panLog1
            // 
            this.panLog1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panLog1.Location = new System.Drawing.Point(3, 2);
            this.panLog1.Margin = new System.Windows.Forms.Padding(2);
            this.panLog1.Name = "panLog1";
            this.panLog1.Size = new System.Drawing.Size(687, 452);
            this.panLog1.TabIndex = 12;
            // 
            // panScript1
            // 
            this.panScript1.Location = new System.Drawing.Point(4, 5);
            this.panScript1.Margin = new System.Windows.Forms.Padding(4);
            this.panScript1.Name = "panScript1";
            this.panScript1.Size = new System.Drawing.Size(690, 452);
            this.panScript1.TabIndex = 11;
            // 
            // panEmprunt1
            // 
            this.panEmprunt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panEmprunt1.Location = new System.Drawing.Point(2, 2);
            this.panEmprunt1.Margin = new System.Windows.Forms.Padding(2);
            this.panEmprunt1.Name = "panEmprunt1";
            this.panEmprunt1.Size = new System.Drawing.Size(687, 451);
            this.panEmprunt1.TabIndex = 10;
            // 
            // panReservation1
            // 
            this.panReservation1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panReservation1.Location = new System.Drawing.Point(2, 2);
            this.panReservation1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panReservation1.Name = "panReservation1";
            this.panReservation1.Size = new System.Drawing.Size(688, 453);
            this.panReservation1.TabIndex = 9;
            // 
            // panItemPack1
            // 
            this.panItemPack1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panItemPack1.Location = new System.Drawing.Point(2, 2);
            this.panItemPack1.Margin = new System.Windows.Forms.Padding(4);
            this.panItemPack1.Name = "panItemPack1";
            this.panItemPack1.Size = new System.Drawing.Size(690, 453);
            this.panItemPack1.TabIndex = 8;
            // 
            // panUsers1
            // 
            this.panUsers1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panUsers1.Location = new System.Drawing.Point(2, 2);
            this.panUsers1.Margin = new System.Windows.Forms.Padding(2);
            this.panUsers1.Name = "panUsers1";
            this.panUsers1.Size = new System.Drawing.Size(688, 453);
            this.panUsers1.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 519);
            this.Controls.Add(this.barreDoutils);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.barreDeMenu);
            this.Controls.Add(this.panelAllPan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.barreDeMenu;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "CE3P Reservation";
            this.barreDeMenu.ResumeLayout(false);
            this.barreDeMenu.PerformLayout();
            this.panMenu.ResumeLayout(false);
            this.buttonMenu.ResumeLayout(false);
            this.buttonMenu.PerformLayout();
            this.barreDoutils.ResumeLayout(false);
            this.barreDoutils.PerformLayout();
            this.panelAllPan.ResumeLayout(false);
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
        private MenuButton boutonReservation;
        private MenuButton boutonScript;
        private MenuButton boutonHistorique;
        private System.Windows.Forms.ToolStripDropDownButton BoutonActionBO;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matérielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réservationToolStripMenuItem;
        private MenuButton boutonEmprunt;
        private System.Windows.Forms.Panel buttonMenu;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.Label labelFleche;
        private System.Windows.Forms.Panel panelAllPan;
        private panEmprunt panEmprunt1;
        private panReservation panReservation1;
        private panItemPack panItemPack1;
        private panUsers panUsers1;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private panScript panScript1;
        private panLog panLog1;
    }
}

