namespace filmek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCimUpdate = new System.Windows.Forms.TextBox();
            this.tbMegjeveUpdate = new System.Windows.Forms.TextBox();
            this.tbKorhatarUpdate = new System.Windows.Forms.TextBox();
            this.tbHosszUpdate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCimInsert = new System.Windows.Forms.TextBox();
            this.tbMegjeveInsert = new System.Windows.Forms.TextBox();
            this.tbKorhatarInsert = new System.Windows.Forms.TextBox();
            this.tbHosszInsert = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1075, 191);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cím";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Megjelenés éve";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Korhatár";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hossz(perc)";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cím";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Megjelenés éve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Korhatár";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hossz(perc)";
            // 
            // tbCimUpdate
            // 
            this.tbCimUpdate.Location = new System.Drawing.Point(153, 42);
            this.tbCimUpdate.Name = "tbCimUpdate";
            this.tbCimUpdate.Size = new System.Drawing.Size(192, 23);
            this.tbCimUpdate.TabIndex = 6;
            // 
            // tbMegjeveUpdate
            // 
            this.tbMegjeveUpdate.Location = new System.Drawing.Point(153, 107);
            this.tbMegjeveUpdate.Name = "tbMegjeveUpdate";
            this.tbMegjeveUpdate.Size = new System.Drawing.Size(192, 23);
            this.tbMegjeveUpdate.TabIndex = 7;
            // 
            // tbKorhatarUpdate
            // 
            this.tbKorhatarUpdate.Location = new System.Drawing.Point(153, 174);
            this.tbKorhatarUpdate.Name = "tbKorhatarUpdate";
            this.tbKorhatarUpdate.Size = new System.Drawing.Size(192, 23);
            this.tbKorhatarUpdate.TabIndex = 8;
            // 
            // tbHosszUpdate
            // 
            this.tbHosszUpdate.Location = new System.Drawing.Point(153, 248);
            this.tbHosszUpdate.Name = "tbHosszUpdate";
            this.tbHosszUpdate.Size = new System.Drawing.Size(192, 23);
            this.tbHosszUpdate.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbHosszUpdate);
            this.groupBox1.Controls.Add(this.tbKorhatarUpdate);
            this.groupBox1.Controls.Add(this.tbMegjeveUpdate);
            this.groupBox1.Controls.Add(this.tbCimUpdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 312);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Módósítás";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(16, 585);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(361, 37);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Módósítás";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cím";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Megjelenés éve";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Korhatár";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hossz(perc)";
            // 
            // tbCimInsert
            // 
            this.tbCimInsert.Location = new System.Drawing.Point(163, 42);
            this.tbCimInsert.Name = "tbCimInsert";
            this.tbCimInsert.Size = new System.Drawing.Size(192, 23);
            this.tbCimInsert.TabIndex = 6;
            // 
            // tbMegjeveInsert
            // 
            this.tbMegjeveInsert.Location = new System.Drawing.Point(163, 107);
            this.tbMegjeveInsert.Name = "tbMegjeveInsert";
            this.tbMegjeveInsert.Size = new System.Drawing.Size(192, 23);
            this.tbMegjeveInsert.TabIndex = 7;
            // 
            // tbKorhatarInsert
            // 
            this.tbKorhatarInsert.Location = new System.Drawing.Point(163, 174);
            this.tbKorhatarInsert.Name = "tbKorhatarInsert";
            this.tbKorhatarInsert.Size = new System.Drawing.Size(192, 23);
            this.tbKorhatarInsert.TabIndex = 8;
            // 
            // tbHosszInsert
            // 
            this.tbHosszInsert.Location = new System.Drawing.Point(163, 248);
            this.tbHosszInsert.Name = "tbHosszInsert";
            this.tbHosszInsert.Size = new System.Drawing.Size(192, 23);
            this.tbHosszInsert.TabIndex = 9;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(440, 585);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(361, 37);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Beillesztés";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbHosszInsert);
            this.groupBox2.Controls.Add(this.tbKorhatarInsert);
            this.groupBox2.Controls.Add(this.tbMegjeveInsert);
            this.groupBox2.Controls.Add(this.tbCimInsert);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(440, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 312);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Beillesztés";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(866, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(195, 373);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Törlés";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 656);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbCimUpdate;
        private TextBox tbMegjeveUpdate;
        private TextBox tbKorhatarUpdate;
        private TextBox tbHosszUpdate;
        private GroupBox groupBox1;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn Column5;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbCimInsert;
        private TextBox tbMegjeveInsert;
        private TextBox tbKorhatarInsert;
        private TextBox tbHosszInsert;
        private Button btnInsert;
        private GroupBox groupBox2;
        private Button btnDelete;
    }
}