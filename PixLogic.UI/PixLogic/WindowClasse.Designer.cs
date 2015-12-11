namespace PixLogic
{
    partial class WindowClasse
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
            this.label1 = new System.Windows.Forms.Label();
            this.valCredit = new System.Windows.Forms.TextBox();
            this.labelNbCredit = new System.Windows.Forms.Label();
            this.labelObligatoire = new System.Windows.Forms.Label();
            this.valLibelle = new System.Windows.Forms.TextBox();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonValid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(278, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "*";
            // 
            // valCredit
            // 
            this.valCredit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valCredit.Location = new System.Drawing.Point(116, 55);
            this.valCredit.Name = "valCredit";
            this.valCredit.Size = new System.Drawing.Size(156, 25);
            this.valCredit.TabIndex = 20;
            // 
            // labelNbCredit
            // 
            this.labelNbCredit.AutoSize = true;
            this.labelNbCredit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbCredit.Location = new System.Drawing.Point(5, 58);
            this.labelNbCredit.Name = "labelNbCredit";
            this.labelNbCredit.Size = new System.Drawing.Size(77, 17);
            this.labelNbCredit.TabIndex = 23;
            this.labelNbCredit.Text = "Nb crédits :";
            // 
            // labelObligatoire
            // 
            this.labelObligatoire.AutoSize = true;
            this.labelObligatoire.BackColor = System.Drawing.SystemColors.Control;
            this.labelObligatoire.ForeColor = System.Drawing.Color.Red;
            this.labelObligatoire.Location = new System.Drawing.Point(278, 24);
            this.labelObligatoire.Name = "labelObligatoire";
            this.labelObligatoire.Size = new System.Drawing.Size(11, 13);
            this.labelObligatoire.TabIndex = 22;
            this.labelObligatoire.Text = "*";
            // 
            // valLibelle
            // 
            this.valLibelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valLibelle.Location = new System.Drawing.Point(116, 24);
            this.valLibelle.Name = "valLibelle";
            this.valLibelle.Size = new System.Drawing.Size(156, 25);
            this.valLibelle.TabIndex = 19;
            // 
            // labelLibelle
            // 
            this.labelLibelle.AutoSize = true;
            this.labelLibelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibelle.Location = new System.Drawing.Point(5, 27);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(52, 17);
            this.labelLibelle.TabIndex = 21;
            this.labelLibelle.Text = "Libellé :";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(151, 107);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 27);
            this.buttonCancel.TabIndex = 26;
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
            this.buttonValid.Location = new System.Drawing.Point(57, 107);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(84, 27);
            this.buttonValid.TabIndex = 25;
            this.buttonValid.Text = "Valider";
            this.buttonValid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // WindowClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 141);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonValid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valCredit);
            this.Controls.Add(this.labelNbCredit);
            this.Controls.Add(this.labelObligatoire);
            this.Controls.Add(this.valLibelle);
            this.Controls.Add(this.labelLibelle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowClasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WindowClasse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valCredit;
        private System.Windows.Forms.Label labelNbCredit;
        private System.Windows.Forms.Label labelObligatoire;
        private System.Windows.Forms.TextBox valLibelle;
        private System.Windows.Forms.Label labelLibelle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonValid;
    }
}