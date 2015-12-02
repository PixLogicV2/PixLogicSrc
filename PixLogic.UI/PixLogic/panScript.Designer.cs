namespace PixLogic
{
    partial class panScript
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QueryRTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.ResultDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // QueryRTB
            // 
            this.QueryRTB.Location = new System.Drawing.Point(3, 16);
            this.QueryRTB.Name = "QueryRTB";
            this.QueryRTB.Size = new System.Drawing.Size(481, 193);
            this.QueryRTB.TabIndex = 0;
            this.QueryRTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Votre requete : ";
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Image = global::PixLogic.Properties.Resources.valider_icon;
            this.ExecuteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExecuteBtn.Location = new System.Drawing.Point(490, 171);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(88, 38);
            this.ExecuteBtn.TabIndex = 4;
            this.ExecuteBtn.Text = "Executer";
            this.ExecuteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // ResultDGV
            // 
            this.ResultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDGV.Location = new System.Drawing.Point(3, 228);
            this.ResultDGV.Name = "ResultDGV";
            this.ResultDGV.ReadOnly = true;
            this.ResultDGV.Size = new System.Drawing.Size(684, 212);
            this.ResultDGV.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Résultat : ";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(490, 146);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(197, 20);
            this.PathTextBox.TabIndex = 7;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Image = global::PixLogic.Properties.Resources.box_icon2;
            this.BrowseBtn.Location = new System.Drawing.Point(490, 108);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(88, 32);
            this.BrowseBtn.TabIndex = 8;
            this.BrowseBtn.Text = "Parcourir";
            this.BrowseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(584, 108);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(88, 32);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.Text = "Sauvegarder";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // panScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultDGV);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueryRTB);
            this.Name = "panScript";
            this.Size = new System.Drawing.Size(690, 452);
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox QueryRTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.DataGridView ResultDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button SaveBtn;
    }
}
