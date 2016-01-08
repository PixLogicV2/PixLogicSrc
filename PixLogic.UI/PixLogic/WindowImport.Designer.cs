namespace PixLogic
{
    partial class WindowImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowImport));
            this.labelListToImport = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridImport = new System.Windows.Forms.DataGridView();
            this.labelChemin = new System.Windows.Forms.Label();
            this.valChemin = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.radioVirgule = new System.Windows.Forms.RadioButton();
            this.radioPointVirgule = new System.Windows.Forms.RadioButton();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelDelimiteur = new System.Windows.Forms.Label();
            this.labelOption = new System.Windows.Forms.Label();
            this.panelChamps = new System.Windows.Forms.Panel();
            this.valImport = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.champs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCocher = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonImporter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImport)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelChamps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListToImport
            // 
            this.labelListToImport.AutoSize = true;
            this.labelListToImport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListToImport.Location = new System.Drawing.Point(26, 328);
            this.labelListToImport.Name = "labelListToImport";
            this.labelListToImport.Size = new System.Drawing.Size(88, 13);
            this.labelListToImport.TabIndex = 32;
            this.labelListToImport.Text = "Liste à importer";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridImport);
            this.panel1.Location = new System.Drawing.Point(12, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 209);
            this.panel1.TabIndex = 31;
            // 
            // dataGridImport
            // 
            this.dataGridImport.AllowUserToAddRows = false;
            this.dataGridImport.AllowUserToDeleteRows = false;
            this.dataGridImport.AllowUserToResizeRows = false;
            this.dataGridImport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridImport.Location = new System.Drawing.Point(-1, 21);
            this.dataGridImport.MultiSelect = false;
            this.dataGridImport.Name = "dataGridImport";
            this.dataGridImport.ReadOnly = true;
            this.dataGridImport.RowHeadersVisible = false;
            this.dataGridImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridImport.Size = new System.Drawing.Size(469, 187);
            this.dataGridImport.TabIndex = 0;
            // 
            // labelChemin
            // 
            this.labelChemin.AutoSize = true;
            this.labelChemin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChemin.Location = new System.Drawing.Point(15, 119);
            this.labelChemin.Name = "labelChemin";
            this.labelChemin.Size = new System.Drawing.Size(58, 15);
            this.labelChemin.TabIndex = 33;
            this.labelChemin.Text = "Chemin : ";
            // 
            // valChemin
            // 
            this.valChemin.Location = new System.Drawing.Point(79, 117);
            this.valChemin.Name = "valChemin";
            this.valChemin.ReadOnly = true;
            this.valChemin.Size = new System.Drawing.Size(320, 20);
            this.valChemin.TabIndex = 34;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(405, 115);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 35;
            this.buttonBrowse.Text = "Parcourir";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.radioVirgule);
            this.panel2.Controls.Add(this.radioPointVirgule);
            this.panel2.Controls.Add(this.labelHeader);
            this.panel2.Controls.Add(this.labelDelimiteur);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 89);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioNo);
            this.panel3.Controls.Add(this.radioYes);
            this.panel3.Location = new System.Drawing.Point(293, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 43);
            this.panel3.TabIndex = 42;
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNo.Location = new System.Drawing.Point(0, 25);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(48, 19);
            this.radioNo.TabIndex = 43;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "Non";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioYes.Location = new System.Drawing.Point(0, 0);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(44, 19);
            this.radioYes.TabIndex = 42;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Oui";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // radioVirgule
            // 
            this.radioVirgule.AutoSize = true;
            this.radioVirgule.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVirgule.Location = new System.Drawing.Point(77, 38);
            this.radioVirgule.Name = "radioVirgule";
            this.radioVirgule.Size = new System.Drawing.Size(83, 19);
            this.radioVirgule.TabIndex = 41;
            this.radioVirgule.TabStop = true;
            this.radioVirgule.Text = "Virgule ( , )";
            this.radioVirgule.UseVisualStyleBackColor = true;
            // 
            // radioPointVirgule
            // 
            this.radioPointVirgule.AutoSize = true;
            this.radioPointVirgule.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPointVirgule.Location = new System.Drawing.Point(77, 14);
            this.radioPointVirgule.Name = "radioPointVirgule";
            this.radioPointVirgule.Size = new System.Drawing.Size(112, 19);
            this.radioPointVirgule.TabIndex = 40;
            this.radioPointVirgule.TabStop = true;
            this.radioPointVirgule.Text = "Point virgule ( ; )";
            this.radioPointVirgule.UseVisualStyleBackColor = true;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(241, 16);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(46, 15);
            this.labelHeader.TabIndex = 37;
            this.labelHeader.Text = "Entête :";
            // 
            // labelDelimiteur
            // 
            this.labelDelimiteur.AutoSize = true;
            this.labelDelimiteur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelimiteur.Location = new System.Drawing.Point(3, 16);
            this.labelDelimiteur.Name = "labelDelimiteur";
            this.labelDelimiteur.Size = new System.Drawing.Size(68, 15);
            this.labelDelimiteur.TabIndex = 34;
            this.labelDelimiteur.Text = "Délimiteur :";
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOption.Location = new System.Drawing.Point(28, 7);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(48, 13);
            this.labelOption.TabIndex = 40;
            this.labelOption.Text = "Options";
            // 
            // panelChamps
            // 
            this.panelChamps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChamps.Controls.Add(this.valImport);
            this.panelChamps.Controls.Add(this.dataGrid);
            this.panelChamps.Location = new System.Drawing.Point(127, 150);
            this.panelChamps.Name = "panelChamps";
            this.panelChamps.Size = new System.Drawing.Size(249, 148);
            this.panelChamps.TabIndex = 41;
            // 
            // valImport
            // 
            this.valImport.AutoSize = true;
            this.valImport.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valImport.Location = new System.Drawing.Point(2, 4);
            this.valImport.Name = "valImport";
            this.valImport.Size = new System.Drawing.Size(11, 13);
            this.valImport.TabIndex = 1;
            this.valImport.Text = "-";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.champs,
            this.aCocher});
            this.dataGrid.Location = new System.Drawing.Point(-1, 24);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.Size = new System.Drawing.Size(249, 123);
            this.dataGrid.TabIndex = 0;
            // 
            // champs
            // 
            this.champs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.champs.HeaderText = "Champs";
            this.champs.Name = "champs";
            this.champs.ReadOnly = true;
            // 
            // aCocher
            // 
            this.aCocher.HeaderText = "Pris en compte";
            this.aCocher.Name = "aCocher";
            this.aCocher.ReadOnly = true;
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo.Image")));
            this.pictureBoxInfo.Location = new System.Drawing.Point(416, 293);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(33, 34);
            this.pictureBoxInfo.TabIndex = 43;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.Click += new System.EventHandler(this.pictureBoxInfo_Click);
            this.pictureBoxInfo.MouseEnter += new System.EventHandler(this.pictureBoxInfo_MouseEnter);
            // 
            // buttonValider
            // 
            this.buttonValider.Image = global::PixLogic.Properties.Resources.valider_icon;
            this.buttonValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValider.Location = new System.Drawing.Point(224, 304);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(49, 23);
            this.buttonValider.TabIndex = 42;
            this.buttonValider.Text = "Ok";
            this.buttonValider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(256, 548);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 27);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonImporter
            // 
            this.buttonImporter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImporter.Image = global::PixLogic.Properties.Resources.valider_icon;
            this.buttonImporter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImporter.Location = new System.Drawing.Point(162, 548);
            this.buttonImporter.Name = "buttonImporter";
            this.buttonImporter.Size = new System.Drawing.Size(84, 27);
            this.buttonImporter.TabIndex = 10;
            this.buttonImporter.Text = "Importer";
            this.buttonImporter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonImporter.UseVisualStyleBackColor = true;
            this.buttonImporter.Click += new System.EventHandler(this.buttonImporter_Click);
            // 
            // WindowImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 580);
            this.Controls.Add(this.pictureBoxInfo);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.panelChamps);
            this.Controls.Add(this.labelOption);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.valChemin);
            this.Controls.Add(this.labelChemin);
            this.Controls.Add(this.labelListToImport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonImporter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelChamps.ResumeLayout(false);
            this.panelChamps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonImporter;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelListToImport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridImport;
        private System.Windows.Forms.Label labelChemin;
        private System.Windows.Forms.TextBox valChemin;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.RadioButton radioVirgule;
        private System.Windows.Forms.RadioButton radioPointVirgule;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelDelimiteur;
        private System.Windows.Forms.Label labelOption;
        private System.Windows.Forms.Panel panelChamps;
        private System.Windows.Forms.Label valImport;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.DataGridViewTextBoxColumn champs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aCocher;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
    }
}