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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.panTableUsers = new System.Windows.Forms.Panel();
            this.QueryListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panTableUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // QueryRTB
            // 
            this.QueryRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryRTB.Location = new System.Drawing.Point(256, 26);
            this.QueryRTB.Name = "QueryRTB";
            this.QueryRTB.Size = new System.Drawing.Size(431, 379);
            this.QueryRTB.TabIndex = 0;
            this.QueryRTB.Text = "";
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Image = global::PixLogic.Properties.Resources.valider_icon;
            this.ExecuteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExecuteBtn.Location = new System.Drawing.Point(599, 411);
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
            this.label1.Location = new System.Drawing.Point(253, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Votre requete : ";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(14, 411);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(88, 38);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Sauvegarder";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(108, 411);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(88, 38);
            this.LoadBtn.TabIndex = 7;
            this.LoadBtn.Text = "Charger";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // panTableUsers
            // 
            this.panTableUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTableUsers.Controls.Add(this.QueryListBox);
            this.panTableUsers.Location = new System.Drawing.Point(14, 26);
            this.panTableUsers.Name = "panTableUsers";
            this.panTableUsers.Size = new System.Drawing.Size(236, 379);
            this.panTableUsers.TabIndex = 23;
            // 
            // QueryListBox
            // 
            this.QueryListBox.FormattingEnabled = true;
            this.QueryListBox.Location = new System.Drawing.Point(-1, 32);
            this.QueryListBox.Name = "QueryListBox";
            this.QueryListBox.Size = new System.Drawing.Size(236, 342);
            this.QueryListBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liste des requetes : ";
            // 
            // panScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panTableUsers);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueryRTB);
            this.Name = "panScript";
            this.Size = new System.Drawing.Size(690, 452);
            this.Load += new System.EventHandler(this.panScript_Load);
            this.panTableUsers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox QueryRTB;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Panel panTableUsers;
        private System.Windows.Forms.ListBox QueryListBox;
        private System.Windows.Forms.Label label2;
    }
}
