namespace PixLogic
{
    partial class WindowPack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowPack));
            this.labelObligatoire = new System.Windows.Forms.Label();
            this.valName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.valDescription = new System.Windows.Forms.TextBox();
            this.labelDescrip = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonValid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelObligatoire
            // 
            this.labelObligatoire.AutoSize = true;
            this.labelObligatoire.BackColor = System.Drawing.SystemColors.Control;
            this.labelObligatoire.ForeColor = System.Drawing.Color.Red;
            this.labelObligatoire.Location = new System.Drawing.Point(307, 43);
            this.labelObligatoire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelObligatoire.Name = "labelObligatoire";
            this.labelObligatoire.Size = new System.Drawing.Size(13, 17);
            this.labelObligatoire.TabIndex = 18;
            this.labelObligatoire.Text = "*";
            // 
            // valName
            // 
            this.valName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valName.Location = new System.Drawing.Point(136, 36);
            this.valName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valName.Name = "valName";
            this.valName.Size = new System.Drawing.Size(161, 29);
            this.valName.TabIndex = 15;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(13, 39);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 23);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Nom :";
            // 
            // valDescription
            // 
            this.valDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDescription.Location = new System.Drawing.Point(136, 174);
            this.valDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valDescription.Multiline = true;
            this.valDescription.Name = "valDescription";
            this.valDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.valDescription.Size = new System.Drawing.Size(184, 120);
            this.valDescription.TabIndex = 21;
            // 
            // labelDescrip
            // 
            this.labelDescrip.AutoSize = true;
            this.labelDescrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescrip.Location = new System.Drawing.Point(13, 177);
            this.labelDescrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescrip.Name = "labelDescrip";
            this.labelDescrip.Size = new System.Drawing.Size(105, 23);
            this.labelDescrip.TabIndex = 20;
            this.labelDescrip.Text = "Description :";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(179, 347);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 33);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonValid
            // 
            this.buttonValid.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValid.Image = global::PixLogic.Properties.Resources.valider_icon;
            this.buttonValid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValid.Location = new System.Drawing.Point(53, 347);
            this.buttonValid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(112, 33);
            this.buttonValid.TabIndex = 22;
            this.buttonValid.Text = "Valider";
            this.buttonValid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // WindowPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 395);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonValid);
            this.Controls.Add(this.valDescription);
            this.Controls.Add(this.labelDescrip);
            this.Controls.Add(this.labelObligatoire);
            this.Controls.Add(this.valName);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowPack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WindowPack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelObligatoire;
        private System.Windows.Forms.TextBox valName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox valDescription;
        private System.Windows.Forms.Label labelDescrip;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonValid;
    }
}