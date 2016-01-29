namespace PixLogic
{
    partial class WindowDelLog
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
            this.radioById = new System.Windows.Forms.RadioButton();
            this.radioByName = new System.Windows.Forms.RadioButton();
            this.radioBetween = new System.Windows.Forms.RadioButton();
            this.valId = new System.Windows.Forms.TextBox();
            this.valNomReservable = new System.Windows.Forms.TextBox();
            this.dateTimeDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioById
            // 
            this.radioById.AutoSize = true;
            this.radioById.Checked = true;
            this.radioById.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioById.Location = new System.Drawing.Point(12, 21);
            this.radioById.Name = "radioById";
            this.radioById.Size = new System.Drawing.Size(60, 17);
            this.radioById.TabIndex = 0;
            this.radioById.TabStop = true;
            this.radioById.Text = "Par id :";
            this.radioById.UseVisualStyleBackColor = true;
            this.radioById.CheckedChanged += new System.EventHandler(this.radioById_CheckedChanged);
            // 
            // radioByName
            // 
            this.radioByName.AutoSize = true;
            this.radioByName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioByName.Location = new System.Drawing.Point(12, 69);
            this.radioByName.Name = "radioByName";
            this.radioByName.Size = new System.Drawing.Size(73, 17);
            this.radioByName.TabIndex = 1;
            this.radioByName.Text = "Par nom :";
            this.radioByName.UseVisualStyleBackColor = true;
            this.radioByName.CheckedChanged += new System.EventHandler(this.radioByName_CheckedChanged);
            // 
            // radioBetween
            // 
            this.radioBetween.AutoSize = true;
            this.radioBetween.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBetween.Location = new System.Drawing.Point(12, 118);
            this.radioBetween.Name = "radioBetween";
            this.radioBetween.Size = new System.Drawing.Size(57, 17);
            this.radioBetween.TabIndex = 2;
            this.radioBetween.Text = "Entre :";
            this.radioBetween.UseVisualStyleBackColor = true;
            this.radioBetween.CheckedChanged += new System.EventHandler(this.radioBetween_CheckedChanged);
            // 
            // valId
            // 
            this.valId.Location = new System.Drawing.Point(90, 21);
            this.valId.Name = "valId";
            this.valId.ReadOnly = true;
            this.valId.Size = new System.Drawing.Size(165, 20);
            this.valId.TabIndex = 3;
            // 
            // valNomReservable
            // 
            this.valNomReservable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNomReservable.Location = new System.Drawing.Point(90, 68);
            this.valNomReservable.Name = "valNomReservable";
            this.valNomReservable.Size = new System.Drawing.Size(165, 22);
            this.valNomReservable.TabIndex = 4;
            // 
            // dateTimeDebut
            // 
            this.dateTimeDebut.Location = new System.Drawing.Point(90, 118);
            this.dateTimeDebut.Name = "dateTimeDebut";
            this.dateTimeDebut.Size = new System.Drawing.Size(165, 20);
            this.dateTimeDebut.TabIndex = 5;
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(90, 151);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(165, 20);
            this.dateTimeFin.TabIndex = 6;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(141, 197);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 27);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonValider
            // 
            this.buttonValider.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Image = global::PixLogic.Properties.Resources.valider_icon;
            this.buttonValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValider.Location = new System.Drawing.Point(47, 197);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(84, 27);
            this.buttonValider.TabIndex = 12;
            this.buttonValider.Text = "Valider";
            this.buttonValider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // WindowDelLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 232);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.dateTimeDebut);
            this.Controls.Add(this.valNomReservable);
            this.Controls.Add(this.valId);
            this.Controls.Add(this.radioBetween);
            this.Controls.Add(this.radioByName);
            this.Controls.Add(this.radioById);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(283, 271);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(283, 271);
            this.Name = "WindowDelLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Suppression historique";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioById;
        private System.Windows.Forms.RadioButton radioByName;
        private System.Windows.Forms.RadioButton radioBetween;
        private System.Windows.Forms.TextBox valId;
        private System.Windows.Forms.TextBox valNomReservable;
        private System.Windows.Forms.DateTimePicker dateTimeDebut;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonValider;
    }
}