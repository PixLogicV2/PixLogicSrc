namespace PixLogic
{
    partial class WindowScriptResult
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
            this.ResultDGV = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultDGV
            // 
            this.ResultDGV.AllowUserToAddRows = false;
            this.ResultDGV.AllowUserToDeleteRows = false;
            this.ResultDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDGV.Location = new System.Drawing.Point(12, 12);
            this.ResultDGV.Name = "ResultDGV";
            this.ResultDGV.ReadOnly = true;
            this.ResultDGV.RowHeadersVisible = false;
            this.ResultDGV.Size = new System.Drawing.Size(671, 500);
            this.ResultDGV.TabIndex = 6;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.Location = new System.Drawing.Point(12, 517);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(84, 33);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Fermer";
            this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.Image = global::PixLogic.Properties.Resources.exporter;
            this.exportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportBtn.Location = new System.Drawing.Point(596, 517);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(87, 33);
            this.exportBtn.TabIndex = 10;
            this.exportBtn.Text = "Exporter";
            this.exportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // WindowScriptResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 553);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.ResultDGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowScriptResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Résultats";
            this.Load += new System.EventHandler(this.WindowScriptResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultDGV;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button exportBtn;
    }
}