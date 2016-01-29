namespace PixLogic
{
    partial class WindowAddCredit
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
            this.labelNom = new System.Windows.Forms.Label();
            this.valNomPrenom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valCredit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valCreditToAdd = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonValid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(9, 19);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(94, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom et prénom :";
            // 
            // valNomPrenom
            // 
            this.valNomPrenom.AutoSize = true;
            this.valNomPrenom.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNomPrenom.Location = new System.Drawing.Point(112, 19);
            this.valNomPrenom.Name = "valNomPrenom";
            this.valNomPrenom.Size = new System.Drawing.Size(11, 13);
            this.valNomPrenom.TabIndex = 1;
            this.valNomPrenom.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Crédit actuel :";
            // 
            // valCredit
            // 
            this.valCredit.AutoSize = true;
            this.valCredit.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valCredit.Location = new System.Drawing.Point(112, 50);
            this.valCredit.Name = "valCredit";
            this.valCredit.Size = new System.Drawing.Size(11, 13);
            this.valCredit.TabIndex = 3;
            this.valCredit.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Crédit ajout/soust. :";
            // 
            // valCreditToAdd
            // 
            this.valCreditToAdd.Location = new System.Drawing.Point(115, 83);
            this.valCreditToAdd.Name = "valCreditToAdd";
            this.valCreditToAdd.Size = new System.Drawing.Size(167, 20);
            this.valCreditToAdd.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(149, 126);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 27);
            this.buttonCancel.TabIndex = 12;
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
            this.buttonValid.Location = new System.Drawing.Point(55, 126);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(84, 27);
            this.buttonValid.TabIndex = 11;
            this.buttonValid.Text = "Valider";
            this.buttonValid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // WindowAddCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 162);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonValid);
            this.Controls.Add(this.valCreditToAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valCredit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valNomPrenom);
            this.Controls.Add(this.labelNom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowAddCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifier crédit d\'un utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label valNomPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label valCredit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valCreditToAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonValid;
    }
}