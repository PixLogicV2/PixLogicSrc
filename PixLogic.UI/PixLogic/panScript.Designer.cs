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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.QueryRTB = new System.Windows.Forms.RichTextBox();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // QueryRTB
            // 
            this.QueryRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryRTB.Location = new System.Drawing.Point(3, 26);
            this.QueryRTB.Name = "QueryRTB";
            this.QueryRTB.Size = new System.Drawing.Size(684, 379);
            this.QueryRTB.TabIndex = 0;
            this.QueryRTB.Text = "";
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Image = global::PixLogic.Properties.Resources.valider_icon;
            this.ExecuteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExecuteBtn.Location = new System.Drawing.Point(6, 411);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(88, 38);
            this.ExecuteBtn.TabIndex = 4;
            this.ExecuteBtn.Text = "Executer";
            this.ExecuteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Votre requete : ";
            // 
            // panScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueryRTB);
            this.Name = "panScript";
            this.Size = new System.Drawing.Size(690, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox QueryRTB;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.Label label1;
    }
}
