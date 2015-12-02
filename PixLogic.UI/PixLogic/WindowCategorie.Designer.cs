namespace PixLogic
{
    partial class WindowCategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowCategorie));
            this.valDescription = new System.Windows.Forms.TextBox();
            this.labelDescrip = new System.Windows.Forms.Label();
            this.valLibelle = new System.Windows.Forms.TextBox();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.labelObligatoire = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonValid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.valLevel = new System.Windows.Forms.TextBox();
            this.labelAccessLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valDescription
            // 
            this.valDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDescription.Location = new System.Drawing.Point(123, 94);
            this.valDescription.Multiline = true;
            this.valDescription.Name = "valDescription";
            this.valDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.valDescription.Size = new System.Drawing.Size(156, 98);
            this.valDescription.TabIndex = 12;
            this.valDescription.WordWrap = false;
            // 
            // labelDescrip
            // 
            this.labelDescrip.AutoSize = true;
            this.labelDescrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescrip.Location = new System.Drawing.Point(13, 97);
            this.labelDescrip.Name = "labelDescrip";
            this.labelDescrip.Size = new System.Drawing.Size(83, 17);
            this.labelDescrip.TabIndex = 11;
            this.labelDescrip.Text = "Description :";
            // 
            // valLibelle
            // 
            this.valLibelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valLibelle.Location = new System.Drawing.Point(123, 20);
            this.valLibelle.Name = "valLibelle";
            this.valLibelle.Size = new System.Drawing.Size(156, 25);
            this.valLibelle.TabIndex = 10;
            // 
            // labelLibelle
            // 
            this.labelLibelle.AutoSize = true;
            this.labelLibelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibelle.Location = new System.Drawing.Point(12, 23);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(52, 17);
            this.labelLibelle.TabIndex = 9;
            this.labelLibelle.Text = "Libellé :";
            // 
            // labelObligatoire
            // 
            this.labelObligatoire.AutoSize = true;
            this.labelObligatoire.BackColor = System.Drawing.SystemColors.Control;
            this.labelObligatoire.ForeColor = System.Drawing.Color.Red;
            this.labelObligatoire.Location = new System.Drawing.Point(285, 20);
            this.labelObligatoire.Name = "labelObligatoire";
            this.labelObligatoire.Size = new System.Drawing.Size(11, 13);
            this.labelObligatoire.TabIndex = 13;
            this.labelObligatoire.Text = "*";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(158, 218);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 27);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonValid
            // 
            this.buttonValid.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValid.Image = global::PixLogic.Properties.Resources.valider_icon;
            this.buttonValid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValid.Location = new System.Drawing.Point(64, 218);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(84, 27);
            this.buttonValid.TabIndex = 14;
            this.buttonValid.Text = "Valider";
            this.buttonValid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(285, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "*";
            // 
            // valLevel
            // 
            this.valLevel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valLevel.Location = new System.Drawing.Point(123, 51);
            this.valLevel.Name = "valLevel";
            this.valLevel.Size = new System.Drawing.Size(156, 25);
            this.valLevel.TabIndex = 17;
            // 
            // labelAccessLevel
            // 
            this.labelAccessLevel.AutoSize = true;
            this.labelAccessLevel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccessLevel.Location = new System.Drawing.Point(12, 54);
            this.labelAccessLevel.Name = "labelAccessLevel";
            this.labelAccessLevel.Size = new System.Drawing.Size(104, 17);
            this.labelAccessLevel.TabIndex = 16;
            this.labelAccessLevel.Text = "Niveau d\'accès :";
            // 
            // WindowCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valLevel);
            this.Controls.Add(this.labelAccessLevel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonValid);
            this.Controls.Add(this.labelObligatoire);
            this.Controls.Add(this.valDescription);
            this.Controls.Add(this.labelDescrip);
            this.Controls.Add(this.valLibelle);
            this.Controls.Add(this.labelLibelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowCategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valDescription;
        private System.Windows.Forms.Label labelDescrip;
        private System.Windows.Forms.TextBox valLibelle;
        private System.Windows.Forms.Label labelLibelle;
        private System.Windows.Forms.Label labelObligatoire;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonValid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valLevel;
        private System.Windows.Forms.Label labelAccessLevel;
    }
}