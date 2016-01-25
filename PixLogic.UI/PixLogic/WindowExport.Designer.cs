namespace PixLogic
{
    partial class WindowExport
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
            this.panPdf = new System.Windows.Forms.Panel();
            this.labelExporterPDF = new System.Windows.Forms.Label();
            this.pictureBoxPdf = new System.Windows.Forms.PictureBox();
            this.panCsv = new System.Windows.Forms.Panel();
            this.labelExportCsv = new System.Windows.Forms.Label();
            this.pictureBoxCSV = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valChemin = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxOpen = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExporter = new System.Windows.Forms.Button();
            this.panPdf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPdf)).BeginInit();
            this.panCsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // panPdf
            // 
            this.panPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panPdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPdf.Controls.Add(this.labelExporterPDF);
            this.panPdf.Controls.Add(this.pictureBoxPdf);
            this.panPdf.Location = new System.Drawing.Point(64, 50);
            this.panPdf.Name = "panPdf";
            this.panPdf.Size = new System.Drawing.Size(205, 68);
            this.panPdf.TabIndex = 0;
            this.panPdf.Click += new System.EventHandler(this.panPdf_Click);
            this.panPdf.MouseEnter += new System.EventHandler(this.panPdf_MouseEnter);
            // 
            // labelExporterPDF
            // 
            this.labelExporterPDF.AutoSize = true;
            this.labelExporterPDF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExporterPDF.ForeColor = System.Drawing.Color.White;
            this.labelExporterPDF.Location = new System.Drawing.Point(67, 22);
            this.labelExporterPDF.Name = "labelExporterPDF";
            this.labelExporterPDF.Size = new System.Drawing.Size(121, 21);
            this.labelExporterPDF.TabIndex = 1;
            this.labelExporterPDF.Text = "Exporter en PDF";
            this.labelExporterPDF.Click += new System.EventHandler(this.labelExporterPDF_Click);
            // 
            // pictureBoxPdf
            // 
            this.pictureBoxPdf.Image = global::PixLogic.Properties.Resources.pdf_export;
            this.pictureBoxPdf.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxPdf.Name = "pictureBoxPdf";
            this.pictureBoxPdf.Size = new System.Drawing.Size(57, 67);
            this.pictureBoxPdf.TabIndex = 0;
            this.pictureBoxPdf.TabStop = false;
            this.pictureBoxPdf.Click += new System.EventHandler(this.pictureBoxPdf_Click);
            // 
            // panCsv
            // 
            this.panCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(174)))), ((int)(((byte)(74)))));
            this.panCsv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panCsv.Controls.Add(this.labelExportCsv);
            this.panCsv.Controls.Add(this.pictureBoxCSV);
            this.panCsv.Location = new System.Drawing.Point(64, 121);
            this.panCsv.Name = "panCsv";
            this.panCsv.Size = new System.Drawing.Size(205, 68);
            this.panCsv.TabIndex = 1;
            this.panCsv.Click += new System.EventHandler(this.panCsv_Click);
            this.panCsv.MouseEnter += new System.EventHandler(this.panCsv_MouseEnter);
            // 
            // labelExportCsv
            // 
            this.labelExportCsv.AutoSize = true;
            this.labelExportCsv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExportCsv.ForeColor = System.Drawing.Color.White;
            this.labelExportCsv.Location = new System.Drawing.Point(67, 22);
            this.labelExportCsv.Name = "labelExportCsv";
            this.labelExportCsv.Size = new System.Drawing.Size(122, 21);
            this.labelExportCsv.TabIndex = 1;
            this.labelExportCsv.Text = "Exporter en CSV";
            this.labelExportCsv.Click += new System.EventHandler(this.labelExportCsv_Click);
            // 
            // pictureBoxCSV
            // 
            this.pictureBoxCSV.Image = global::PixLogic.Properties.Resources.csv_export;
            this.pictureBoxCSV.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxCSV.Name = "pictureBoxCSV";
            this.pictureBoxCSV.Size = new System.Drawing.Size(57, 67);
            this.pictureBoxCSV.TabIndex = 0;
            this.pictureBoxCSV.TabStop = false;
            this.pictureBoxCSV.Click += new System.EventHandler(this.pictureBoxCSV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exporter en :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chemin :";
            // 
            // valChemin
            // 
            this.valChemin.Location = new System.Drawing.Point(69, 211);
            this.valChemin.Name = "valChemin";
            this.valChemin.ReadOnly = true;
            this.valChemin.Size = new System.Drawing.Size(240, 20);
            this.valChemin.TabIndex = 4;
            // 
            // checkBoxOpen
            // 
            this.checkBoxOpen.AutoSize = true;
            this.checkBoxOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOpen.Location = new System.Drawing.Point(192, 247);
            this.checkBoxOpen.Name = "checkBoxOpen";
            this.checkBoxOpen.Size = new System.Drawing.Size(123, 17);
            this.checkBoxOpen.TabIndex = 14;
            this.checkBoxOpen.Text = "Ouvrir le document";
            this.checkBoxOpen.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(173, 283);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 27);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonExporter
            // 
            this.buttonExporter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExporter.Image = global::PixLogic.Properties.Resources.valider_icon;
            this.buttonExporter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExporter.Location = new System.Drawing.Point(79, 283);
            this.buttonExporter.Name = "buttonExporter";
            this.buttonExporter.Size = new System.Drawing.Size(84, 27);
            this.buttonExporter.TabIndex = 12;
            this.buttonExporter.Text = "Exporter";
            this.buttonExporter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExporter.UseVisualStyleBackColor = true;
            this.buttonExporter.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // WindowExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 319);
            this.Controls.Add(this.checkBoxOpen);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonExporter);
            this.Controls.Add(this.valChemin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panCsv);
            this.Controls.Add(this.panPdf);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exporter";
            this.panPdf.ResumeLayout(false);
            this.panPdf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPdf)).EndInit();
            this.panCsv.ResumeLayout(false);
            this.panCsv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panPdf;
        private System.Windows.Forms.PictureBox pictureBoxPdf;
        private System.Windows.Forms.Label labelExporterPDF;
        private System.Windows.Forms.Panel panCsv;
        private System.Windows.Forms.Label labelExportCsv;
        private System.Windows.Forms.PictureBox pictureBoxCSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valChemin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExporter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.CheckBox checkBoxOpen;
    }
}