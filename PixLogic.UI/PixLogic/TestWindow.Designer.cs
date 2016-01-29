namespace PixLogic
{
    partial class TestWindow
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
            this.panUsers1 = new PixLogic.panUsers();
            this.SuspendLayout();
            // 
            // panUsers1
            // 
            this.panUsers1.Location = new System.Drawing.Point(25, 31);
            this.panUsers1.Name = "panUsers1";
            this.panUsers1.Size = new System.Drawing.Size(920, 521);
            this.panUsers1.TabIndex = 0;
            // 
            // TestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 633);
            this.Controls.Add(this.panUsers1);
            this.Name = "TestWindow";
            this.Text = "TestWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private panUsers panUsers1;
    }
}