namespace PixLogic
{
    partial class WindowSetReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowSetReservation));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.valDateDebut = new System.Windows.Forms.Label();
            this.valDateFin = new System.Windows.Forms.Label();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.valType = new System.Windows.Forms.Label();
            this.valNomReservable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelInfos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPresent = new System.Windows.Forms.Label();
            this.dataGridReservAvenir = new System.Windows.Forms.DataGridView();
            this.dateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelModifierDate = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonValid = new System.Windows.Forms.Button();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservAvenir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.labelDateDebut);
            this.panelInfo.Controls.Add(this.valDateDebut);
            this.panelInfo.Controls.Add(this.valDateFin);
            this.panelInfo.Controls.Add(this.labelDateFin);
            this.panelInfo.Controls.Add(this.valType);
            this.panelInfo.Controls.Add(this.valNomReservable);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.labelType);
            this.panelInfo.Location = new System.Drawing.Point(12, 12);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(248, 116);
            this.panelInfo.TabIndex = 0;
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDebut.Location = new System.Drawing.Point(3, 67);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(71, 13);
            this.labelDateDebut.TabIndex = 52;
            this.labelDateDebut.Text = "Date début :";
            // 
            // valDateDebut
            // 
            this.valDateDebut.AutoSize = true;
            this.valDateDebut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDateDebut.Location = new System.Drawing.Point(80, 64);
            this.valDateDebut.Name = "valDateDebut";
            this.valDateDebut.Size = new System.Drawing.Size(12, 15);
            this.valDateDebut.TabIndex = 53;
            this.valDateDebut.Text = "-";
            this.valDateDebut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valDateFin
            // 
            this.valDateFin.AutoSize = true;
            this.valDateFin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDateFin.Location = new System.Drawing.Point(80, 93);
            this.valDateFin.Name = "valDateFin";
            this.valDateFin.Size = new System.Drawing.Size(12, 15);
            this.valDateFin.TabIndex = 51;
            this.valDateFin.Text = "-";
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFin.Location = new System.Drawing.Point(3, 93);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(70, 13);
            this.labelDateFin.TabIndex = 50;
            this.labelDateFin.Text = "Date de fin :";
            // 
            // valType
            // 
            this.valType.AutoSize = true;
            this.valType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valType.Location = new System.Drawing.Point(81, 39);
            this.valType.Name = "valType";
            this.valType.Size = new System.Drawing.Size(12, 15);
            this.valType.TabIndex = 49;
            this.valType.Text = "-";
            this.valType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valNomReservable
            // 
            this.valNomReservable.AutoSize = true;
            this.valNomReservable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNomReservable.Location = new System.Drawing.Point(81, 13);
            this.valNomReservable.Name = "valNomReservable";
            this.valNomReservable.Size = new System.Drawing.Size(12, 15);
            this.valNomReservable.TabIndex = 48;
            this.valNomReservable.Text = "-";
            this.valNomReservable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nom :";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(3, 41);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(35, 13);
            this.labelType.TabIndex = 46;
            this.labelType.Text = "Type :";
            // 
            // labelInfos
            // 
            this.labelInfos.AutoSize = true;
            this.labelInfos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfos.Location = new System.Drawing.Point(28, 8);
            this.labelInfos.Name = "labelInfos";
            this.labelInfos.Size = new System.Drawing.Size(33, 13);
            this.labelInfos.TabIndex = 1;
            this.labelInfos.Text = "Infos";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 136);
            this.panel1.TabIndex = 3;
            // 
            // labelPresent
            // 
            this.labelPresent.AutoSize = true;
            this.labelPresent.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresent.Location = new System.Drawing.Point(27, 137);
            this.labelPresent.Name = "labelPresent";
            this.labelPresent.Size = new System.Drawing.Size(126, 13);
            this.labelPresent.TabIndex = 4;
            this.labelPresent.Text = "Réservations présentes";
            // 
            // dataGridReservAvenir
            // 
            this.dataGridReservAvenir.AllowUserToAddRows = false;
            this.dataGridReservAvenir.AllowUserToDeleteRows = false;
            this.dataGridReservAvenir.AllowUserToResizeRows = false;
            this.dataGridReservAvenir.BackgroundColor = System.Drawing.Color.White;
            this.dataGridReservAvenir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservAvenir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDebut,
            this.dateFin});
            this.dataGridReservAvenir.Location = new System.Drawing.Point(12, 161);
            this.dataGridReservAvenir.MultiSelect = false;
            this.dataGridReservAvenir.Name = "dataGridReservAvenir";
            this.dataGridReservAvenir.ReadOnly = true;
            this.dataGridReservAvenir.RowHeadersVisible = false;
            this.dataGridReservAvenir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridReservAvenir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReservAvenir.Size = new System.Drawing.Size(379, 116);
            this.dataGridReservAvenir.TabIndex = 0;
            // 
            // dateDebut
            // 
            this.dateDebut.HeaderText = "Date debut";
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.ReadOnly = true;
            this.dateDebut.Width = 188;
            // 
            // dateFin
            // 
            this.dateFin.HeaderText = "Date fin";
            this.dateFin.Name = "dateFin";
            this.dateFin.ReadOnly = true;
            this.dateFin.Width = 188;
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxItem.Location = new System.Drawing.Point(257, 12);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(135, 116);
            this.pictureBoxItem.TabIndex = 2;
            this.pictureBoxItem.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateTimeEnd);
            this.panel2.Controls.Add(this.dateTimeBegin);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 92);
            this.panel2.TabIndex = 5;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(92, 57);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(179, 20);
            this.dateTimeEnd.TabIndex = 3;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Location = new System.Drawing.Point(92, 21);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(179, 20);
            this.dateTimeBegin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Date de fin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Date début :";
            // 
            // labelModifierDate
            // 
            this.labelModifierDate.AutoSize = true;
            this.labelModifierDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModifierDate.Location = new System.Drawing.Point(28, 286);
            this.labelModifierDate.Name = "labelModifierDate";
            this.labelModifierDate.Size = new System.Drawing.Size(100, 13);
            this.labelModifierDate.TabIndex = 6;
            this.labelModifierDate.Text = "Modifier les dates";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(206, 396);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 27);
            this.buttonCancel.TabIndex = 5;
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
            this.buttonValid.Location = new System.Drawing.Point(112, 396);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(84, 27);
            this.buttonValid.TabIndex = 4;
            this.buttonValid.Text = "Valider";
            this.buttonValid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // WindowSetReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 431);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonValid);
            this.Controls.Add(this.labelModifierDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridReservAvenir);
            this.Controls.Add(this.labelPresent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxItem);
            this.Controls.Add(this.labelInfos);
            this.Controls.Add(this.panelInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowSetReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modification réservation";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservAvenir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelInfos;
        private System.Windows.Forms.PictureBox pictureBoxItem;
        public System.Windows.Forms.Label valType;
        public System.Windows.Forms.Label valNomReservable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDateDebut;
        public System.Windows.Forms.Label valDateDebut;
        private System.Windows.Forms.Label valDateFin;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridReservAvenir;
        private System.Windows.Forms.Label labelPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelModifierDate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonValid;
    }
}