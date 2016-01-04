namespace PixLogic
{
    partial class WindowReservationUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelListItemDispo = new System.Windows.Forms.Panel();
            this.dataGridItem = new System.Windows.Forms.DataGridView();
            this.NameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelFin = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.labelDebut = new System.Windows.Forms.Label();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.labelItemDispo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valCrédits = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.valClasse = new System.Windows.Forms.Label();
            this.valPrenom = new System.Windows.Forms.Label();
            this.valNom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTransfert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridListeItem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonReserver = new System.Windows.Forms.RadioButton();
            this.radioButtonEmprunter = new System.Windows.Forms.RadioButton();
            this.buttonEnlever = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.valTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.valCreditsRestants = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.panelListItemDispo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListeItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelListItemDispo
            // 
            this.panelListItemDispo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelListItemDispo.Controls.Add(this.dataGridItem);
            this.panelListItemDispo.Controls.Add(this.buttonOk);
            this.panelListItemDispo.Controls.Add(this.labelFin);
            this.panelListItemDispo.Controls.Add(this.dateTimeEnd);
            this.panelListItemDispo.Controls.Add(this.labelDebut);
            this.panelListItemDispo.Controls.Add(this.dateTimeBegin);
            this.panelListItemDispo.Location = new System.Drawing.Point(12, 12);
            this.panelListItemDispo.Name = "panelListItemDispo";
            this.panelListItemDispo.Size = new System.Drawing.Size(245, 477);
            this.panelListItemDispo.TabIndex = 0;
            // 
            // dataGridItem
            // 
            this.dataGridItem.AllowUserToAddRows = false;
            this.dataGridItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataGridItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridItem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameItem,
            this.Price});
            this.dataGridItem.Location = new System.Drawing.Point(-1, 99);
            this.dataGridItem.Name = "dataGridItem";
            this.dataGridItem.ReadOnly = true;
            this.dataGridItem.RowHeadersVisible = false;
            this.dataGridItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridItem.Size = new System.Drawing.Size(245, 377);
            this.dataGridItem.TabIndex = 5;
            // 
            // NameItem
            // 
            this.NameItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameItem.HeaderText = "Libellé";
            this.NameItem.Name = "NameItem";
            this.NameItem.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Prix ( Crédits )";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Image = global::PixLogic.Properties.Resources.valider_iconPetit;
            this.buttonOk.Location = new System.Drawing.Point(207, 73);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(29, 20);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            this.buttonOk.MouseEnter += new System.EventHandler(this.buttonOk_MouseEnter);
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFin.Location = new System.Drawing.Point(6, 51);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(29, 13);
            this.labelFin.TabIndex = 3;
            this.labelFin.Text = "Fin :";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(57, 49);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(179, 20);
            this.dateTimeEnd.TabIndex = 2;
            // 
            // labelDebut
            // 
            this.labelDebut.AutoSize = true;
            this.labelDebut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebut.Location = new System.Drawing.Point(6, 23);
            this.labelDebut.Name = "labelDebut";
            this.labelDebut.Size = new System.Drawing.Size(45, 13);
            this.labelDebut.TabIndex = 1;
            this.labelDebut.Text = "Début :";
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Location = new System.Drawing.Point(57, 21);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(179, 20);
            this.dateTimeBegin.TabIndex = 0;
            // 
            // labelItemDispo
            // 
            this.labelItemDispo.AutoSize = true;
            this.labelItemDispo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemDispo.Location = new System.Drawing.Point(29, 7);
            this.labelItemDispo.Name = "labelItemDispo";
            this.labelItemDispo.Size = new System.Drawing.Size(118, 13);
            this.labelItemDispo.TabIndex = 1;
            this.labelItemDispo.Text = "Matériels disponibles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valCrédits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.valClasse);
            this.groupBox1.Controls.Add(this.valPrenom);
            this.groupBox1.Controls.Add(this.valNom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(265, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infos utilisateur";
            // 
            // valCrédits
            // 
            this.valCrédits.AutoSize = true;
            this.valCrédits.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valCrédits.Location = new System.Drawing.Point(94, 107);
            this.valCrédits.Name = "valCrédits";
            this.valCrédits.Size = new System.Drawing.Size(11, 13);
            this.valCrédits.TabIndex = 9;
            this.valCrédits.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Crédits :";
            // 
            // valClasse
            // 
            this.valClasse.AutoSize = true;
            this.valClasse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valClasse.Location = new System.Drawing.Point(94, 77);
            this.valClasse.Name = "valClasse";
            this.valClasse.Size = new System.Drawing.Size(11, 13);
            this.valClasse.TabIndex = 7;
            this.valClasse.Text = "-";
            // 
            // valPrenom
            // 
            this.valPrenom.AutoSize = true;
            this.valPrenom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valPrenom.Location = new System.Drawing.Point(94, 47);
            this.valPrenom.Name = "valPrenom";
            this.valPrenom.Size = new System.Drawing.Size(11, 13);
            this.valPrenom.TabIndex = 6;
            this.valPrenom.Text = "-";
            // 
            // valNom
            // 
            this.valNom.AutoSize = true;
            this.valNom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNom.Location = new System.Drawing.Point(94, 19);
            this.valNom.Name = "valNom";
            this.valNom.Size = new System.Drawing.Size(11, 13);
            this.valNom.TabIndex = 5;
            this.valNom.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Classe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prénom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom :";
            // 
            // buttonTransfert
            // 
            this.buttonTransfert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransfert.ForeColor = System.Drawing.Color.Blue;
            this.buttonTransfert.Location = new System.Drawing.Point(260, 275);
            this.buttonTransfert.Name = "buttonTransfert";
            this.buttonTransfert.Size = new System.Drawing.Size(31, 23);
            this.buttonTransfert.TabIndex = 3;
            this.buttonTransfert.Text = ">>";
            this.buttonTransfert.UseVisualStyleBackColor = true;
            this.buttonTransfert.Click += new System.EventHandler(this.buttonTransfert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Matériels à réserver";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridListeItem);
            this.panel1.Location = new System.Drawing.Point(295, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 201);
            this.panel1.TabIndex = 4;
            // 
            // dataGridListeItem
            // 
            this.dataGridListeItem.AllowUserToAddRows = false;
            this.dataGridListeItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dataGridListeItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridListeItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridListeItem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridListeItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridListeItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridListeItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridListeItem.Location = new System.Drawing.Point(-1, 18);
            this.dataGridListeItem.Name = "dataGridListeItem";
            this.dataGridListeItem.ReadOnly = true;
            this.dataGridListeItem.RowHeadersVisible = false;
            this.dataGridListeItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridListeItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridListeItem.Size = new System.Drawing.Size(276, 182);
            this.dataGridListeItem.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Libellé";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Prix ( Crédits )";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // radioButtonReserver
            // 
            this.radioButtonReserver.AutoSize = true;
            this.radioButtonReserver.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonReserver.Location = new System.Drawing.Point(327, 146);
            this.radioButtonReserver.Name = "radioButtonReserver";
            this.radioButtonReserver.Size = new System.Drawing.Size(68, 17);
            this.radioButtonReserver.TabIndex = 6;
            this.radioButtonReserver.Text = "Réserver";
            this.radioButtonReserver.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmprunter
            // 
            this.radioButtonEmprunter.AutoSize = true;
            this.radioButtonEmprunter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEmprunter.Location = new System.Drawing.Point(432, 146);
            this.radioButtonEmprunter.Name = "radioButtonEmprunter";
            this.radioButtonEmprunter.Size = new System.Drawing.Size(79, 17);
            this.radioButtonEmprunter.TabIndex = 7;
            this.radioButtonEmprunter.Text = "Emprunter";
            this.radioButtonEmprunter.UseVisualStyleBackColor = true;
            // 
            // buttonEnlever
            // 
            this.buttonEnlever.Location = new System.Drawing.Point(295, 386);
            this.buttonEnlever.Name = "buttonEnlever";
            this.buttonEnlever.Size = new System.Drawing.Size(75, 23);
            this.buttonEnlever.TabIndex = 8;
            this.buttonEnlever.Text = "Enlever";
            this.buttonEnlever.UseVisualStyleBackColor = true;
            this.buttonEnlever.Click += new System.EventHandler(this.buttonEnlever_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(429, 391);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(37, 13);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "Total :";
            // 
            // valTotal
            // 
            this.valTotal.AutoSize = true;
            this.valTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTotal.ForeColor = System.Drawing.Color.Blue;
            this.valTotal.Location = new System.Drawing.Point(491, 390);
            this.valTotal.Name = "valTotal";
            this.valTotal.Size = new System.Drawing.Size(13, 17);
            this.valTotal.TabIndex = 10;
            this.valTotal.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(318, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Crédits restants utilisateur :";
            // 
            // valCreditsRestants
            // 
            this.valCreditsRestants.AutoSize = true;
            this.valCreditsRestants.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valCreditsRestants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.valCreditsRestants.Location = new System.Drawing.Point(491, 422);
            this.valCreditsRestants.Name = "valCreditsRestants";
            this.valCreditsRestants.Size = new System.Drawing.Size(13, 17);
            this.valCreditsRestants.TabIndex = 12;
            this.valCreditsRestants.Text = "-";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(438, 462);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 27);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonValider
            // 
            this.buttonValider.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Image = global::PixLogic.Properties.Resources.valider_icon;
            this.buttonValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValider.Location = new System.Drawing.Point(333, 462);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(84, 27);
            this.buttonValider.TabIndex = 13;
            this.buttonValider.Text = "Valider";
            this.buttonValider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // WindowReservationUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 497);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.valCreditsRestants);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.valTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonEnlever);
            this.Controls.Add(this.radioButtonEmprunter);
            this.Controls.Add(this.radioButtonReserver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonTransfert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelItemDispo);
            this.Controls.Add(this.panelListItemDispo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowReservationUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Réservation";
            this.panelListItemDispo.ResumeLayout(false);
            this.panelListItemDispo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListeItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelListItemDispo;
        private System.Windows.Forms.Label labelItemDispo;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label labelDebut;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.DataGridView dataGridItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label valClasse;
        private System.Windows.Forms.Label valPrenom;
        private System.Windows.Forms.Label valNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTransfert;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label valCrédits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridListeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.RadioButton radioButtonReserver;
        private System.Windows.Forms.RadioButton radioButtonEmprunter;
        private System.Windows.Forms.Button buttonEnlever;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label valTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label valCreditsRestants;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonValider;
    }
}