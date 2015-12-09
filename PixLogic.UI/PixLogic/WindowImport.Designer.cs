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
            this.buttonImporter = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelListToImport = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelChemin = new System.Windows.Forms.Label();
            this.valChemin = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelListe = new System.Windows.Forms.Label();
            this.valListe = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonImporter
            // 
            this.buttonImporter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImporter.Image = global::PixLogic.Properties.Resources.valider_icon;
            this.buttonImporter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImporter.Location = new System.Drawing.Point(81, 310);
            this.buttonImporter.Name = "buttonImporter";
            this.buttonImporter.Size = new System.Drawing.Size(84, 27);
            this.buttonImporter.TabIndex = 10;
            this.buttonImporter.Text = "Importer";
            this.buttonImporter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonImporter.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(175, 310);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 27);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelListToImport
            // 
            this.labelListToImport.AutoSize = true;
            this.labelListToImport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListToImport.Location = new System.Drawing.Point(26, 95);
            this.labelListToImport.Name = "labelListToImport";
            this.labelListToImport.Size = new System.Drawing.Size(88, 13);
            this.labelListToImport.TabIndex = 32;
            this.labelListToImport.Text = "Liste à importer";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 205);
            this.panel1.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(322, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelChemin
            // 
            this.labelChemin.AutoSize = true;
            this.labelChemin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChemin.Location = new System.Drawing.Point(15, 51);
            this.labelChemin.Name = "labelChemin";
            this.labelChemin.Size = new System.Drawing.Size(58, 15);
            this.labelChemin.TabIndex = 33;
            this.labelChemin.Text = "Chemin : ";
            // 
            // valChemin
            // 
            this.valChemin.Location = new System.Drawing.Point(79, 49);
            this.valChemin.Name = "valChemin";
            this.valChemin.ReadOnly = true;
            this.valChemin.Size = new System.Drawing.Size(180, 20);
            this.valChemin.TabIndex = 34;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(265, 47);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 35;
            this.buttonBrowse.Text = "Parcourir";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelListe
            // 
            this.labelListe.AutoSize = true;
            this.labelListe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListe.Location = new System.Drawing.Point(15, 9);
            this.labelListe.Name = "labelListe";
            this.labelListe.Size = new System.Drawing.Size(39, 15);
            this.labelListe.TabIndex = 36;
            this.labelListe.Text = "Liste :";
            // 
            // valListe
            // 
            this.valListe.AutoSize = true;
            this.valListe.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valListe.Location = new System.Drawing.Point(76, 9);
            this.valListe.Name = "valListe";
            this.valListe.Size = new System.Drawing.Size(12, 15);
            this.valListe.TabIndex = 37;
            this.valListe.Text = "-";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // WindowImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 367);
            this.Controls.Add(this.valListe);
            this.Controls.Add(this.labelListe);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonImporter;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelListToImport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelChemin;
        private System.Windows.Forms.TextBox valChemin;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelListe;
        private System.Windows.Forms.Label valListe;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}