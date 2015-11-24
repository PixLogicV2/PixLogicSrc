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
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // QueryRTB
            // 
            this.QueryRTB.Location = new System.Drawing.Point(19, 43);
            this.QueryRTB.Name = "QueryRTB";
            this.QueryRTB.Size = new System.Drawing.Size(465, 166);
            this.QueryRTB.TabIndex = 0;
            this.QueryRTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Votre requete : ";
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Image = global::PixLogic.Properties.Resources.valider_icon;
            this.ExecuteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExecuteBtn.Location = new System.Drawing.Point(526, 178);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(78, 31);
            this.ExecuteBtn.TabIndex = 4;
            this.ExecuteBtn.Text = "Executer";
            this.ExecuteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // ResultDGV
            // 
            this.ResultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDGV.Location = new System.Drawing.Point(19, 260);
            this.ResultDGV.Name = "ResultDGV";
            this.ResultDGV.Size = new System.Drawing.Size(465, 180);
            this.ResultDGV.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Résultat : ";
            // 
            // panScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
