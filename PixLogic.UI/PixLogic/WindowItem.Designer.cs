namespace PixLogic
{
    partial class WindowItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowItem));
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.buttonAddCategorie = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelObligatoire = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonValid = new System.Windows.Forms.Button();
            this.pictureBoxSelection = new System.Windows.Forms.PictureBox();
            this.valDescription = new System.Windows.Forms.TextBox();
            this.labelDescrip = new System.Windows.Forms.Label();
            this.valQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.valPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.valName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.buttonAddCategorie);
            this.panelGeneral.Controls.Add(this.label3);
            this.panelGeneral.Controls.Add(this.comboBoxCategorie);
            this.panelGeneral.Controls.Add(this.labelCategorie);
            this.panelGeneral.Controls.Add(this.label2);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Controls.Add(this.labelObligatoire);
            this.panelGeneral.Controls.Add(this.buttonCancel);
            this.panelGeneral.Controls.Add(this.buttonValid);
            this.panelGeneral.Controls.Add(this.pictureBoxSelection);
            this.panelGeneral.Controls.Add(this.valDescription);
            this.panelGeneral.Controls.Add(this.labelDescrip);
            this.panelGeneral.Controls.Add(this.valQuantity);
            this.panelGeneral.Controls.Add(this.labelQuantity);
            this.panelGeneral.Controls.Add(this.valPrice);
            this.panelGeneral.Controls.Add(this.labelPrice);
            this.panelGeneral.Controls.Add(this.valName);
            this.panelGeneral.Controls.Add(this.labelName);
            this.panelGeneral.Controls.Add(this.pictureBoxItem);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(302, 481);
            this.panelGeneral.TabIndex = 0;
            // 
            // buttonAddCategorie
            // 
            this.buttonAddCategorie.Image = global::PixLogic.Properties.Resources.categorie_racAdd;
            this.buttonAddCategorie.Location = new System.Drawing.Point(274, 302);
            this.buttonAddCategorie.Name = "buttonAddCategorie";
            this.buttonAddCategorie.Size = new System.Drawing.Size(22, 21);
            this.buttonAddCategorie.TabIndex = 6;
            this.buttonAddCategorie.UseVisualStyleBackColor = true;
            this.buttonAddCategorie.Click += new System.EventHandler(this.buttonAddCategorie_Click);
            this.buttonAddCategorie.MouseEnter += new System.EventHandler(this.buttonAddCategorie_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(261, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "*";
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.ItemHeight = 13;
            this.comboBoxCategorie.Location = new System.Drawing.Point(99, 302);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(156, 21);
            this.comboBoxCategorie.Sorted = true;
            this.comboBoxCategorie.TabIndex = 5;
            this.comboBoxCategorie.Click += new System.EventHandler(this.comboBoxCategorie_Click);
            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorie.Location = new System.Drawing.Point(10, 302);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(73, 17);
            this.labelCategorie.TabIndex = 15;
            this.labelCategorie.Text = "Catégorie :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(261, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(261, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "*";
            // 
            // labelObligatoire
            // 
            this.labelObligatoire.AutoSize = true;
            this.labelObligatoire.BackColor = System.Drawing.SystemColors.Control;
            this.labelObligatoire.ForeColor = System.Drawing.Color.Red;
            this.labelObligatoire.Location = new System.Drawing.Point(261, 208);
            this.labelObligatoire.Name = "labelObligatoire";
            this.labelObligatoire.Size = new System.Drawing.Size(11, 13);
            this.labelObligatoire.TabIndex = 12;
            this.labelObligatoire.Text = "*";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(181, 448);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 27);
            this.buttonCancel.TabIndex = 9;
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
            this.buttonValid.Location = new System.Drawing.Point(87, 448);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(84, 27);
            this.buttonValid.TabIndex = 8;
            this.buttonValid.Text = "Valider";
            this.buttonValid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // pictureBoxSelection
            // 
            this.pictureBoxSelection.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBoxSelection.Image = global::PixLogic.Properties.Resources.enregistrer_icon;
            this.pictureBoxSelection.Location = new System.Drawing.Point(222, 154);
            this.pictureBoxSelection.Name = "pictureBoxSelection";
            this.pictureBoxSelection.Size = new System.Drawing.Size(32, 24);
            this.pictureBoxSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSelection.TabIndex = 9;
            this.pictureBoxSelection.TabStop = false;
            this.pictureBoxSelection.Click += new System.EventHandler(this.pictureBoxSelection_Click);
            this.pictureBoxSelection.MouseEnter += new System.EventHandler(this.pictureBoxSelection_MouseEnter);
            // 
            // valDescription
            // 
            this.valDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDescription.Location = new System.Drawing.Point(99, 333);
            this.valDescription.Multiline = true;
            this.valDescription.Name = "valDescription";
            this.valDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.valDescription.Size = new System.Drawing.Size(156, 98);
            this.valDescription.TabIndex = 7;
            this.valDescription.WordWrap = false;
            // 
            // labelDescrip
            // 
            this.labelDescrip.AutoSize = true;
            this.labelDescrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescrip.Location = new System.Drawing.Point(10, 336);
            this.labelDescrip.Name = "labelDescrip";
            this.labelDescrip.Size = new System.Drawing.Size(83, 17);
            this.labelDescrip.TabIndex = 7;
            this.labelDescrip.Text = "Description :";
            // 
            // valQuantity
            // 
            this.valQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valQuantity.Location = new System.Drawing.Point(99, 267);
            this.valQuantity.Name = "valQuantity";
            this.valQuantity.Size = new System.Drawing.Size(156, 25);
            this.valQuantity.TabIndex = 4;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(10, 270);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(68, 17);
            this.labelQuantity.TabIndex = 5;
            this.labelQuantity.Text = "Quantité :";
            // 
            // valPrice
            // 
            this.valPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valPrice.Location = new System.Drawing.Point(99, 236);
            this.valPrice.Name = "valPrice";
            this.valPrice.Size = new System.Drawing.Size(156, 25);
            this.valPrice.TabIndex = 3;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(10, 239);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(92, 17);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Prix (Crédits) :";
            // 
            // valName
            // 
            this.valName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valName.Location = new System.Drawing.Point(99, 205);
            this.valName.Name = "valName";
            this.valName.Size = new System.Drawing.Size(156, 25);
            this.valName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(10, 208);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nom :";
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxItem.Location = new System.Drawing.Point(27, 12);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(228, 167);
            this.pictureBoxItem.TabIndex = 0;
            this.pictureBoxItem.TabStop = false;
            // 
            // WindowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 481);
            this.Controls.Add(this.panelGeneral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouveau matériel";
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.TextBox valDescription;
        private System.Windows.Forms.Label labelDescrip;
        private System.Windows.Forms.TextBox valQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox valPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox valName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonValid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelObligatoire;
        private System.Windows.Forms.PictureBox pictureBoxSelection;
        private System.Windows.Forms.PictureBox pictureBoxItem;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddCategorie;
    }
}