namespace PixLogic
{
    partial class WindowMailsSent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelListUser = new System.Windows.Forms.Label();
            this.panTableUsers = new System.Windows.Forms.Panel();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridUsersMail = new System.Windows.Forms.DataGridView();
            this.panelInfos = new System.Windows.Forms.Panel();
            this.valDate = new System.Windows.Forms.Label();
            this.valPrenom = new System.Windows.Forms.Label();
            this.valNom = new System.Windows.Forms.Label();
            this.valMessage = new System.Windows.Forms.TextBox();
            this.valSujet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valMail = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.IdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NickNameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panTableUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsersMail)).BeginInit();
            this.panelInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelListUser
            // 
            this.labelListUser.AutoSize = true;
            this.labelListUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListUser.Location = new System.Drawing.Point(25, 4);
            this.labelListUser.Name = "labelListUser";
            this.labelListUser.Size = new System.Drawing.Size(112, 13);
            this.labelListUser.TabIndex = 42;
            this.labelListUser.Text = "Liste des utilisateurs";
            // 
            // panTableUsers
            // 
            this.panTableUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panTableUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTableUsers.Controls.Add(this.buttonCancelSearch);
            this.panTableUsers.Controls.Add(this.textBoxSearch);
            this.panTableUsers.Controls.Add(this.labelSearch);
            this.panTableUsers.Controls.Add(this.dataGridUsersMail);
            this.panTableUsers.Location = new System.Drawing.Point(7, 9);
            this.panTableUsers.Name = "panTableUsers";
            this.panTableUsers.Size = new System.Drawing.Size(212, 364);
            this.panTableUsers.TabIndex = 41;
            // 
            // buttonCancelSearch
            // 
            this.buttonCancelSearch.Image = global::PixLogic.Properties.Resources.cancel_icon;
            this.buttonCancelSearch.Location = new System.Drawing.Point(167, 16);
            this.buttonCancelSearch.Name = "buttonCancelSearch";
            this.buttonCancelSearch.Size = new System.Drawing.Size(27, 23);
            this.buttonCancelSearch.TabIndex = 3;
            this.buttonCancelSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(67, 17);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(96, 20);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyUp);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(2, 19);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(66, 13);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Recherche :";
            // 
            // dataGridUsersMail
            // 
            this.dataGridUsersMail.AllowUserToAddRows = false;
            this.dataGridUsersMail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(231)))));
            this.dataGridUsersMail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsersMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridUsersMail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridUsersMail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridUsersMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsersMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridUsersMail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUser,
            this.NameUser,
            this.NickNameUser,
            this.dateT});
            this.dataGridUsersMail.Location = new System.Drawing.Point(0, 47);
            this.dataGridUsersMail.MultiSelect = false;
            this.dataGridUsersMail.Name = "dataGridUsersMail";
            this.dataGridUsersMail.ReadOnly = true;
            this.dataGridUsersMail.RowHeadersVisible = false;
            this.dataGridUsersMail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridUsersMail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsersMail.Size = new System.Drawing.Size(211, 315);
            this.dataGridUsersMail.TabIndex = 0;
            this.dataGridUsersMail.Click += new System.EventHandler(this.dataGridUsersMail_Click);
            this.dataGridUsersMail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridUsersMail_KeyUp);
            // 
            // panelInfos
            // 
            this.panelInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfos.Controls.Add(this.valMail);
            this.panelInfos.Controls.Add(this.email);
            this.panelInfos.Controls.Add(this.valDate);
            this.panelInfos.Controls.Add(this.valPrenom);
            this.panelInfos.Controls.Add(this.valNom);
            this.panelInfos.Controls.Add(this.valMessage);
            this.panelInfos.Controls.Add(this.valSujet);
            this.panelInfos.Controls.Add(this.label5);
            this.panelInfos.Controls.Add(this.label4);
            this.panelInfos.Controls.Add(this.label3);
            this.panelInfos.Controls.Add(this.label2);
            this.panelInfos.Controls.Add(this.labelNom);
            this.panelInfos.Location = new System.Drawing.Point(225, 9);
            this.panelInfos.Name = "panelInfos";
            this.panelInfos.Size = new System.Drawing.Size(330, 363);
            this.panelInfos.TabIndex = 43;
            // 
            // valDate
            // 
            this.valDate.AutoSize = true;
            this.valDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDate.Location = new System.Drawing.Point(79, 100);
            this.valDate.Name = "valDate";
            this.valDate.Size = new System.Drawing.Size(12, 15);
            this.valDate.TabIndex = 9;
            this.valDate.Text = "-";
            // 
            // valPrenom
            // 
            this.valPrenom.AutoSize = true;
            this.valPrenom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valPrenom.Location = new System.Drawing.Point(79, 40);
            this.valPrenom.Name = "valPrenom";
            this.valPrenom.Size = new System.Drawing.Size(12, 15);
            this.valPrenom.TabIndex = 8;
            this.valPrenom.Text = "-";
            // 
            // valNom
            // 
            this.valNom.AutoSize = true;
            this.valNom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNom.Location = new System.Drawing.Point(79, 15);
            this.valNom.Name = "valNom";
            this.valNom.Size = new System.Drawing.Size(12, 15);
            this.valNom.TabIndex = 7;
            this.valNom.Text = "-";
            // 
            // valMessage
            // 
            this.valMessage.Location = new System.Drawing.Point(19, 194);
            this.valMessage.Multiline = true;
            this.valMessage.Name = "valMessage";
            this.valMessage.ReadOnly = true;
            this.valMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.valMessage.Size = new System.Drawing.Size(306, 159);
            this.valMessage.TabIndex = 6;
            // 
            // valSujet
            // 
            this.valSujet.Location = new System.Drawing.Point(60, 137);
            this.valSujet.Name = "valSujet";
            this.valSujet.ReadOnly = true;
            this.valSujet.Size = new System.Drawing.Size(265, 20);
            this.valSujet.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Message :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sujet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Envoyé le :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(9, 15);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(40, 15);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Infos";
            // 
            // valMail
            // 
            this.valMail.AutoSize = true;
            this.valMail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valMail.Location = new System.Drawing.Point(79, 66);
            this.valMail.Name = "valMail";
            this.valMail.Size = new System.Drawing.Size(12, 15);
            this.valMail.TabIndex = 11;
            this.valMail.Text = "-";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(9, 66);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(47, 15);
            this.email.TabIndex = 10;
            this.email.Text = "E-mail :";
            // 
            // IdUser
            // 
            this.IdUser.HeaderText = "Id";
            this.IdUser.Name = "IdUser";
            this.IdUser.ReadOnly = true;
            this.IdUser.Visible = false;
            this.IdUser.Width = 60;
            // 
            // NameUser
            // 
            this.NameUser.HeaderText = "Nom";
            this.NameUser.Name = "NameUser";
            this.NameUser.ReadOnly = true;
            this.NameUser.Width = 75;
            // 
            // NickNameUser
            // 
            this.NickNameUser.HeaderText = "Prenom";
            this.NickNameUser.Name = "NickNameUser";
            this.NickNameUser.ReadOnly = true;
            this.NickNameUser.Width = 65;
            // 
            // dateT
            // 
            this.dateT.HeaderText = "Date";
            this.dateT.Name = "dateT";
            this.dateT.ReadOnly = true;
            this.dateT.Width = 70;
            // 
            // WindowMailsSent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelInfos);
            this.Controls.Add(this.labelListUser);
            this.Controls.Add(this.panTableUsers);
            this.MaximizeBox = false;
            this.Name = "WindowMailsSent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des mails envoyés";
            this.panTableUsers.ResumeLayout(false);
            this.panTableUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsersMail)).EndInit();
            this.panelInfos.ResumeLayout(false);
            this.panelInfos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListUser;
        private System.Windows.Forms.Panel panTableUsers;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridUsersMail;
        private System.Windows.Forms.Panel panelInfos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label valDate;
        private System.Windows.Forms.Label valPrenom;
        private System.Windows.Forms.Label valNom;
        private System.Windows.Forms.TextBox valMessage;
        private System.Windows.Forms.TextBox valSujet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label valMail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NickNameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateT;
    }
}