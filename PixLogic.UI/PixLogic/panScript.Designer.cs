namespace PixLogic
{
    partial class panScript
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panScript));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.QueryRTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panTableUsers = new System.Windows.Forms.Panel();
            this.dataGridRequetes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.buttonSupp = new System.Windows.Forms.Button();
            this.panTableUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequetes)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // QueryRTB
            // 
            this.QueryRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryRTB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryRTB.Location = new System.Drawing.Point(292, 19);
            this.QueryRTB.Name = "QueryRTB";
            this.QueryRTB.Size = new System.Drawing.Size(387, 379);
            this.QueryRTB.TabIndex = 0;
            this.QueryRTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Votre requete : ";
            // 
            // panTableUsers
            // 
            this.panTableUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTableUsers.Controls.Add(this.dataGridRequetes);
            this.panTableUsers.Location = new System.Drawing.Point(5, 7);
            this.panTableUsers.Name = "panTableUsers";
            this.panTableUsers.Size = new System.Drawing.Size(280, 391);
            this.panTableUsers.TabIndex = 23;
            // 
            // dataGridRequetes
            // 
            this.dataGridRequetes.AllowUserToAddRows = false;
            this.dataGridRequetes.AllowUserToDeleteRows = false;
            this.dataGridRequetes.AllowUserToResizeRows = false;
            this.dataGridRequetes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRequetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRequetes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nom});
            this.dataGridRequetes.Location = new System.Drawing.Point(-1, 20);
            this.dataGridRequetes.Name = "dataGridRequetes";
            this.dataGridRequetes.ReadOnly = true;
            this.dataGridRequetes.RowHeadersVisible = false;
            this.dataGridRequetes.Size = new System.Drawing.Size(280, 370);
            this.dataGridRequetes.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nom
            // 
            this.nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom.HeaderText = "Nom requête";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liste des requetes : ";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.Location = new System.Drawing.Point(4, 411);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(105, 38);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Sauvegarder";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Image = global::PixLogic.Properties.Resources.load;
            this.LoadBtn.Location = new System.Drawing.Point(115, 411);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(79, 38);
            this.LoadBtn.TabIndex = 7;
            this.LoadBtn.Text = "Charger";
            this.LoadBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Image = global::PixLogic.Properties.Resources.valider_icon;
            this.ExecuteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExecuteBtn.Location = new System.Drawing.Point(591, 411);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(88, 38);
            this.ExecuteBtn.TabIndex = 4;
            this.ExecuteBtn.Text = "Executer";
            this.ExecuteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // buttonSupp
            // 
            this.buttonSupp.Image = global::PixLogic.Properties.Resources.supprimer_icon;
            this.buttonSupp.Location = new System.Drawing.Point(200, 411);
            this.buttonSupp.Name = "buttonSupp";
            this.buttonSupp.Size = new System.Drawing.Size(84, 38);
            this.buttonSupp.TabIndex = 24;
            this.buttonSupp.Text = "Supprimer";
            this.buttonSupp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSupp.UseVisualStyleBackColor = true;
            this.buttonSupp.Click += new System.EventHandler(this.buttonSupp_Click);
            // 
            // panScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSupp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.panTableUsers);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueryRTB);
            this.Name = "panScript";
            this.Size = new System.Drawing.Size(690, 452);
            this.panTableUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox QueryRTB;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Panel panTableUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridRequetes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.Button buttonSupp;
    }
}
