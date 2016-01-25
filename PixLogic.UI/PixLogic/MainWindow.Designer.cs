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
            this.buttonMenu = new System.Windows.Forms.Panel();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.labelFleche = new System.Windows.Forms.Label();
            this.barreDoutils = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.panelAllPan = new System.Windows.Forms.Panel();
            this.panScript1 = new PixLogic.panScript();
            this.panUsers1 = new PixLogic.panUsers();
            this.panLog1 = new PixLogic.panLog();
            this.panEmprunt1 = new PixLogic.panEmprunt();
            this.panReservation1 = new PixLogic.panReservation();
            this.panItemPack1 = new PixLogic.panItemPack();
            this.BoutonActionBO = new System.Windows.Forms.ToolStripDropDownButton();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matérielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolButtonExport = new System.Windows.Forms.ToolStripButton();
            this.toolButtonImport = new System.Windows.Forms.ToolStripButton();
            this.toolButtonDeconnexion = new System.Windows.Forms.ToolStripButton();
            this.toolButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.boutonEmprunt = new PixLogic.MenuButton();
            this.boutonScript = new PixLogic.MenuButton();
            this.boutonHistorique = new PixLogic.MenuButton();
            this.boutonReservation = new PixLogic.MenuButton();
            this.boutonMateriel = new PixLogic.MenuButton();
            this.boutonUtilisateur = new PixLogic.MenuButton();
            this.seDéconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDéconnecterToolStripMenuItem});
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
            this.panMenu.Location = new System.Drawing.Point(0, 63);
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
            this.BoutonActionBO,
            this.toolStripSeparator1,
            this.toolButtonExport,
            this.toolButtonImport,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolButtonDeconnexion,
            this.toolStripSeparator3,
            this.toolButtonRefresh});
            this.barreDoutils.Location = new System.Drawing.Point(0, 24);
            this.barreDoutils.Name = "barreDoutils";
            this.barreDoutils.Size = new System.Drawing.Size(827, 42);
            this.barreDoutils.TabIndex = 2;
            this.barreDoutils.Text = "barreDoutils";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(442, 39);
            this.toolStripLabel1.Text = "                                                                                 " +
    "                                                                ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // panelAllPan
            // 
            this.panelAllPan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAllPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAllPan.Controls.Add(this.panScript1);
            this.panelAllPan.Controls.Add(this.panUsers1);
            this.panelAllPan.Controls.Add(this.panLog1);
            this.panelAllPan.Controls.Add(this.panEmprunt1);
            this.panelAllPan.Controls.Add(this.panReservation1);
            this.panelAllPan.Controls.Add(this.panItemPack1);
            this.panelAllPan.Location = new System.Drawing.Point(137, 63);
            this.panelAllPan.Name = "panelAllPan";
            this.panelAllPan.Size = new System.Drawing.Size(690, 455);
            this.panelAllPan.TabIndex = 3;
            // 
            // panScript1
            // 
            this.panScript1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panScript1.Location = new System.Drawing.Point(0, 2);
            this.panScript1.Margin = new System.Windows.Forms.Padding(4);
            this.panScript1.Name = "panScript1";
            this.panScript1.Size = new System.Drawing.Size(690, 452);
            this.panScript1.TabIndex = 11;
            // 
            // panUsers1
            // 
            this.panUsers1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panUsers1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panUsers1.Location = new System.Drawing.Point(0, 2);
            this.panUsers1.Margin = new System.Windows.Forms.Padding(2);
            this.panUsers1.Name = "panUsers1";
            this.panUsers1.Size = new System.Drawing.Size(688, 453);
            this.panUsers1.TabIndex = 7;
            // 
            // panLog1
            // 
            this.panLog1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panLog1.Location = new System.Drawing.Point(2, 2);
            this.panLog1.Margin = new System.Windows.Forms.Padding(2);
            this.panLog1.Name = "panLog1";
            this.panLog1.Size = new System.Drawing.Size(687, 452);
            this.panLog1.TabIndex = 12;
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
            this.panReservation1.Margin = new System.Windows.Forms.Padding(2);
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
            // BoutonActionBO
            // 
            this.BoutonActionBO.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem,
            this.matérielToolStripMenuItem});
            this.BoutonActionBO.Image = ((System.Drawing.Image)(resources.GetObject("BoutonActionBO.Image")));
            this.BoutonActionBO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoutonActionBO.Name = "BoutonActionBO";
            this.BoutonActionBO.Size = new System.Drawing.Size(68, 39);
            this.BoutonActionBO.Text = "Nouveau";
            this.BoutonActionBO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.AutoSize = false;
            this.utilisateurToolStripMenuItem.Image = global::PixLogic.Properties.Resources.add_user;
            this.utilisateurToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.utilisateurToolStripMenuItem.Text = "Utilisateur";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // matérielToolStripMenuItem
            // 
            this.matérielToolStripMenuItem.AutoSize = false;
            this.matérielToolStripMenuItem.Image = global::PixLogic.Properties.Resources.add_item;
            this.matérielToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.matérielToolStripMenuItem.Name = "matérielToolStripMenuItem";
            this.matérielToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.matérielToolStripMenuItem.Text = "Matériel";
            this.matérielToolStripMenuItem.Click += new System.EventHandler(this.matérielToolStripMenuItem_Click);
            // 
            // toolButtonExport
            // 
            this.toolButtonExport.Image = global::PixLogic.Properties.Resources.exporter;
            this.toolButtonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonExport.Name = "toolButtonExport";
            this.toolButtonExport.Size = new System.Drawing.Size(54, 39);
            this.toolButtonExport.Text = "Exporter";
            this.toolButtonExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolButtonExport.ToolTipText = "Exporter La liste du panneau actuel";
            this.toolButtonExport.Click += new System.EventHandler(this.toolButtonExport_Click);
            // 
            // toolButtonImport
            // 
            this.toolButtonImport.Image = global::PixLogic.Properties.Resources.importer;
            this.toolButtonImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonImport.Name = "toolButtonImport";
            this.toolButtonImport.Size = new System.Drawing.Size(57, 39);
            this.toolButtonImport.Text = "Importer";
            this.toolButtonImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolButtonImport.ToolTipText = "Importer des éléments dans le panneau actuel";
            this.toolButtonImport.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolButtonDeconnexion
            // 
            this.toolButtonDeconnexion.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonDeconnexion.Image")));
            this.toolButtonDeconnexion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonDeconnexion.Name = "toolButtonDeconnexion";
            this.toolButtonDeconnexion.Size = new System.Drawing.Size(80, 39);
            this.toolButtonDeconnexion.Text = "Déconnexion";
            this.toolButtonDeconnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolButtonDeconnexion.ToolTipText = "Se déconnecter";
            this.toolButtonDeconnexion.Click += new System.EventHandler(this.toolButtonDeconnexion_Click);
            // 
            // toolButtonRefresh
            // 
            this.toolButtonRefresh.Image = global::PixLogic.Properties.Resources.reinit_icon;
            this.toolButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonRefresh.Name = "toolButtonRefresh";
            this.toolButtonRefresh.Size = new System.Drawing.Size(61, 39);
            this.toolButtonRefresh.Text = "Rafraichir";
            this.toolButtonRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolButtonRefresh.ToolTipText = "Rafraichir le panneau";
            this.toolButtonRefresh.Click += new System.EventHandler(this.toolButtonRefresh_Click);
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
            this.boutonScript.Image = ((System.Drawing.Image)(resources.GetObject("boutonScript.Image")));
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
            this.boutonMateriel.Image = ((System.Drawing.Image)(resources.GetObject("boutonMateriel.Image")));
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
            this.boutonUtilisateur.Image = global::PixLogic.Properties.Resources.utilisateur2;
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
            // seDéconnecterToolStripMenuItem
            // 
            this.seDéconnecterToolStripMenuItem.Image = global::PixLogic.Properties.Resources.deconnexion;
            this.seDéconnecterToolStripMenuItem.Name = "seDéconnecterToolStripMenuItem";
            this.seDéconnecterToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.seDéconnecterToolStripMenuItem.Text = "Se déconnecter";
            this.seDéconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDéconnecterToolStripMenuItem_Click);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 518);
            this.Controls.Add(this.barreDoutils);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.barreDeMenu);
            this.Controls.Add(this.panelAllPan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.barreDeMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(843, 557);
            this.MinimumSize = new System.Drawing.Size(843, 557);
            this.Name = "MainWindow";
            this.Text = "CE3P Reservation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolButtonExport;
        private System.Windows.Forms.ToolStripButton toolButtonImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolButtonDeconnexion;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolButtonRefresh;
        private System.Windows.Forms.ToolStripMenuItem seDéconnecterToolStripMenuItem;
    }
}

