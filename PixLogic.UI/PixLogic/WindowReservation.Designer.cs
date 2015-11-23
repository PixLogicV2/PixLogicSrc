namespace PixLogic
{
    partial class WindowReservation
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
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonValid = new System.Windows.Forms.Button();
            this.valItemId = new System.Windows.Forms.TextBox();
            this.labelItemId = new System.Windows.Forms.Label();
            this.LabelBegin = new System.Windows.Forms.Label();
            this.LabelEnd = new System.Windows.Forms.Label();
            this.panTableUsers = new System.Windows.Forms.Panel();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.IdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NickNameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valBegin = new System.Windows.Forms.DateTimePicker();
            this.valEnd = new System.Windows.Forms.DateTimePicker();
            this.panelGeneral.SuspendLayout();
            this.panTableUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.valEnd);
            this.panelGeneral.Controls.Add(this.valBegin);
            this.panelGeneral.Controls.Add(this.panTableUsers);
            this.panelGeneral.Controls.Add(this.LabelEnd);
            this.panelGeneral.Controls.Add(this.LabelBegin);
            this.panelGeneral.Controls.Add(this.buttonCancel);
            this.panelGeneral.Controls.Add(this.buttonValid);
            this.panelGeneral.Controls.Add(this.valItemId);
            this.panelGeneral.Controls.Add(this.labelItemId);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(786, 579);
            this.panelGeneral.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(193, 508);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 33);
            this.buttonCancel.TabIndex = 11;
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
            this.buttonValid.Location = new System.Drawing.Point(68, 508);
            this.buttonValid.Margin = new System.Windows.Forms.Padding(4);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(112, 33);
            this.buttonValid.TabIndex = 10;
            this.buttonValid.Text = "Valider";
            this.buttonValid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // valItemId
            // 
            this.valItemId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valItemId.Location = new System.Drawing.Point(154, 45);
            this.valItemId.Margin = new System.Windows.Forms.Padding(4);
            this.valItemId.Name = "valItemId";
            this.valItemId.Size = new System.Drawing.Size(207, 29);
            this.valItemId.TabIndex = 2;
            // 
            // labelItemId
            // 
            this.labelItemId.AutoSize = true;
            this.labelItemId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemId.Location = new System.Drawing.Point(13, 51);
            this.labelItemId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelItemId.Name = "labelItemId";
            this.labelItemId.Size = new System.Drawing.Size(95, 23);
            this.labelItemId.TabIndex = 1;
            this.labelItemId.Text = "ID Materiel";
            // 
            // LabelBegin
            // 
            this.LabelBegin.AutoSize = true;
            this.LabelBegin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBegin.Location = new System.Drawing.Point(13, 89);
            this.LabelBegin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBegin.Name = "LabelBegin";
            this.LabelBegin.Size = new System.Drawing.Size(96, 23);
            this.LabelBegin.TabIndex = 13;
            this.LabelBegin.Text = "Date debut";
            // 
            // LabelEnd
            // 
            this.LabelEnd.AutoSize = true;
            this.LabelEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEnd.Location = new System.Drawing.Point(13, 129);
            this.LabelEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEnd.Name = "LabelEnd";
            this.LabelEnd.Size = new System.Drawing.Size(74, 23);
            this.LabelEnd.TabIndex = 14;
            this.LabelEnd.Text = "Date Fin";
            // 
            // panTableUsers
            // 
            this.panTableUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTableUsers.Controls.Add(this.buttonCancelSearch);
            this.panTableUsers.Controls.Add(this.textBoxSearch);
            this.panTableUsers.Controls.Add(this.labelSearch);
            this.panTableUsers.Controls.Add(this.dataGridUsers);
            this.panTableUsers.Location = new System.Drawing.Point(462, 15);
            this.panTableUsers.Margin = new System.Windows.Forms.Padding(4);
            this.panTableUsers.Name = "panTableUsers";
            this.panTableUsers.Size = new System.Drawing.Size(261, 526);
            this.panTableUsers.TabIndex = 23;
            // 
            // buttonCancelSearch
            // 
            this.buttonCancelSearch.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancelSearch.Location = new System.Drawing.Point(223, 20);
            this.buttonCancelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelSearch.Name = "buttonCancelSearch";
            this.buttonCancelSearch.Size = new System.Drawing.Size(36, 28);
            this.buttonCancelSearch.TabIndex = 3;
            this.buttonCancelSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(89, 21);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
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
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUser,
            this.NameUser,
            this.NickNameUser});
            this.dataGridUsers.Location = new System.Drawing.Point(0, 58);
            this.dataGridUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowHeadersVisible = false;
            this.dataGridUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(259, 466);
            this.dataGridUsers.TabIndex = 0;
            // 
            // IdUser
            // 
            this.IdUser.HeaderText = "Id";
            this.IdUser.Name = "IdUser";
            this.IdUser.ReadOnly = true;
            this.IdUser.Width = 60;
            // 
            // NameUser
            // 
            this.NameUser.HeaderText = "Nom";
            this.NameUser.Name = "NameUser";
            this.NameUser.ReadOnly = true;
            this.NameUser.Width = 77;
            // 
            // NickNameUser
            // 
            this.NickNameUser.HeaderText = "Prenom";
            this.NickNameUser.Name = "NickNameUser";
            this.NickNameUser.ReadOnly = true;
            this.NickNameUser.Width = 60;
            // 
            // valBegin
            // 
            this.valBegin.Location = new System.Drawing.Point(154, 100);
            this.valBegin.Name = "valBegin";
            this.valBegin.Size = new System.Drawing.Size(200, 22);
            this.valBegin.TabIndex = 24;
            // 
            // valEnd
            // 
            this.valEnd.Location = new System.Drawing.Point(154, 129);
            this.valEnd.Name = "valEnd";
            this.valEnd.Size = new System.Drawing.Size(200, 22);
            this.valEnd.TabIndex = 25;
            // 
            // WindowReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 579);
            this.Controls.Add(this.panelGeneral);
            this.Name = "WindowReservation";
            this.Text = "WindowReservation";
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.panTableUsers.ResumeLayout(false);
            this.panTableUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonValid;
        private System.Windows.Forms.TextBox valItemId;
        private System.Windows.Forms.Label labelItemId;
        private System.Windows.Forms.Label LabelEnd;
        private System.Windows.Forms.Label LabelBegin;
        private System.Windows.Forms.Panel panTableUsers;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NickNameUser;
        private System.Windows.Forms.DateTimePicker valEnd;
        private System.Windows.Forms.DateTimePicker valBegin;
    }
}