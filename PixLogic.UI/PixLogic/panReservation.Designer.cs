﻿namespace PixLogic
{
    partial class panReservation
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panTableUsers = new System.Windows.Forms.Panel();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridReservations = new System.Windows.Forms.DataGridView();
            this.IdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUserReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameItemReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panNews = new System.Windows.Forms.Panel();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.valDateDebut = new System.Windows.Forms.Label();
            this.valDateFin = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.labelListReservation = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panTableUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservations)).BeginInit();
            this.panNews.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTableUsers
            // 
            this.panTableUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTableUsers.Controls.Add(this.buttonCancelSearch);
            this.panTableUsers.Controls.Add(this.textBoxSearch);
            this.panTableUsers.Controls.Add(this.labelSearch);
            this.panTableUsers.Controls.Add(this.dataGridReservations);
            this.panTableUsers.Location = new System.Drawing.Point(7, 4);
            this.panTableUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panTableUsers.Name = "panTableUsers";
            this.panTableUsers.Size = new System.Drawing.Size(262, 524);
            this.panTableUsers.TabIndex = 23;
            // 
            // buttonCancelSearch
            // 
            this.buttonCancelSearch.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancelSearch.Location = new System.Drawing.Point(223, 20);
            this.buttonCancelSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelSearch.Name = "buttonCancelSearch";
            this.buttonCancelSearch.Size = new System.Drawing.Size(36, 28);
            this.buttonCancelSearch.TabIndex = 3;
            this.buttonCancelSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(89, 21);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(127, 22);
            this.textBoxSearch.TabIndex = 2;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(3, 23);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(78, 19);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Recherche :";
            // 
            // dataGridReservations
            // 
            this.dataGridReservations.AllowUserToAddRows = false;
            this.dataGridReservations.AllowUserToDeleteRows = false;
            this.dataGridReservations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridReservations.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridReservations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUser,
            this.NameUserReservation,
            this.NameItemReservation});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridReservations.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridReservations.Location = new System.Drawing.Point(0, 58);
            this.dataGridReservations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridReservations.Name = "dataGridReservations";
            this.dataGridReservations.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReservations.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridReservations.RowHeadersVisible = false;
            this.dataGridReservations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReservations.Size = new System.Drawing.Size(259, 460);
            this.dataGridReservations.TabIndex = 0;
            // 
            // IdUser
            // 
            this.IdUser.HeaderText = "Id";
            this.IdUser.Name = "IdUser";
            this.IdUser.ReadOnly = true;
            this.IdUser.Width = 60;
            // 
            // NameUserReservation
            // 
            this.NameUserReservation.HeaderText = "Utilisateur";
            this.NameUserReservation.Name = "NameUserReservation";
            this.NameUserReservation.ReadOnly = true;
            this.NameUserReservation.Width = 77;
            // 
            // NameItemReservation
            // 
            this.NameItemReservation.HeaderText = "Item";
            this.NameItemReservation.Name = "NameItemReservation";
            this.NameItemReservation.ReadOnly = true;
            this.NameItemReservation.Width = 60;
            // 
            // panNews
            // 
            this.panNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panNews.Controls.Add(this.labelDateDebut);
            this.panNews.Controls.Add(this.valDateDebut);
            this.panNews.Controls.Add(this.valDateFin);
            this.panNews.Controls.Add(this.labelTel);
            this.panNews.Controls.Add(this.labelDateFin);
            this.panNews.Location = new System.Drawing.Point(303, 225);
            this.panNews.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panNews.Name = "panNews";
            this.panNews.Size = new System.Drawing.Size(351, 139);
            this.panNews.TabIndex = 28;
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDebut.Location = new System.Drawing.Point(0, 20);
            this.labelDateDebut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(85, 19);
            this.labelDateDebut.TabIndex = 6;
            this.labelDateDebut.Text = "Date début :";
            // 
            // valDateDebut
            // 
            this.valDateDebut.AutoSize = true;
            this.valDateDebut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDateDebut.Location = new System.Drawing.Point(96, 17);
            this.valDateDebut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valDateDebut.Name = "valDateDebut";
            this.valDateDebut.Size = new System.Drawing.Size(17, 23);
            this.valDateDebut.TabIndex = 39;
            this.valDateDebut.Text = "-";
            this.valDateDebut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valDateFin
            // 
            this.valDateFin.AutoSize = true;
            this.valDateFin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDateFin.Location = new System.Drawing.Point(96, 50);
            this.valDateFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valDateFin.Name = "valDateFin";
            this.valDateFin.Size = new System.Drawing.Size(17, 23);
            this.valDateFin.TabIndex = 3;
            this.valDateFin.Text = "-";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.Location = new System.Drawing.Point(0, 84);
            this.labelTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(0, 19);
            this.labelTel.TabIndex = 1;
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFin.Location = new System.Drawing.Point(0, 52);
            this.labelDateFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(83, 19);
            this.labelDateFin.TabIndex = 0;
            this.labelDateFin.Text = "Date de fin :";
            // 
            // labelListReservation
            // 
            this.labelListReservation.AutoSize = true;
            this.labelListReservation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListReservation.Location = new System.Drawing.Point(32, -1);
            this.labelListReservation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListReservation.Name = "labelListReservation";
            this.labelListReservation.Size = new System.Drawing.Size(153, 19);
            this.labelListReservation.TabIndex = 41;
            this.labelListReservation.Text = "Liste des reservations";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Image = global::PixLogic.Properties.Resources.ajouter_icon;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(285, 492);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 36);
            this.buttonAdd.TabIndex = 42;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelListReservation);
            this.Controls.Add(this.panNews);
            this.Controls.Add(this.panTableUsers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "panReservation";
            this.Size = new System.Drawing.Size(915, 554);
            this.panTableUsers.ResumeLayout(false);
            this.panTableUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservations)).EndInit();
            this.panNews.ResumeLayout(false);
            this.panNews.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTableUsers;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridReservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUserReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameItemReservation;
        private System.Windows.Forms.Panel panNews;
        private System.Windows.Forms.Label labelDateDebut;
        public System.Windows.Forms.Label valDateDebut;
        private System.Windows.Forms.Label valDateFin;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Label labelListReservation;
        private System.Windows.Forms.Button buttonAdd;
    }
}