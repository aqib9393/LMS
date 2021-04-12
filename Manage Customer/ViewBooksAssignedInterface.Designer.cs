namespace LibraryManagementSystem
{
    partial class ViewBooksAssignedInterface
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categorycb = new System.Windows.Forms.ComboBox();
            this.statuscb = new System.Windows.Forms.ComboBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nametb = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(761, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 368);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Book Category :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Status:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // categorycb
            // 
            this.categorycb.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorycb.FormattingEnabled = true;
            this.categorycb.Location = new System.Drawing.Point(122, 43);
            this.categorycb.Name = "categorycb";
            this.categorycb.Size = new System.Drawing.Size(190, 24);
            this.categorycb.TabIndex = 16;
            this.categorycb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.categorycb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.categorycb_KeyPress);
            // 
            // statuscb
            // 
            this.statuscb.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuscb.FormattingEnabled = true;
            this.statuscb.Items.AddRange(new object[] {
            "All",
            "Received (0)",
            "Not Received (1)"});
            this.statuscb.Location = new System.Drawing.Point(391, 43);
            this.statuscb.Name = "statuscb";
            this.statuscb.Size = new System.Drawing.Size(166, 24);
            this.statuscb.TabIndex = 17;
            this.statuscb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.categorycb_KeyPress);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchbtn.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(596, 40);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(86, 27);
            this.searchbtn.TabIndex = 18;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(761, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 27);
            this.button1.TabIndex = 19;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nametb
            // 
            this.nametb.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nametb.Location = new System.Drawing.Point(16, 85);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(296, 23);
            this.nametb.TabIndex = 20;
            this.nametb.Text = "Enter Customer Name here";
            this.nametb.TextChanged += new System.EventHandler(this.nametb_TextChanged);
            this.nametb.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.nametb_ControlRemoved);
            this.nametb.Enter += new System.EventHandler(this.nametb_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Moccasin;
            this.button3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(296, 488);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 43);
            this.button3.TabIndex = 21;
            this.button3.Text = "Generate Receipt";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ViewBooksAssignedInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 576);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.statuscb);
            this.Controls.Add(this.categorycb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewBooksAssignedInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Books Assigned - LMS";
            this.Load += new System.EventHandler(this.viewBookAssigned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categorycb;
        private System.Windows.Forms.ComboBox statuscb;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Button button3;
    }
}