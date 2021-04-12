namespace LibraryManagementSystem
{
    partial class SearchBookInterface
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
            this.searchbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Namecb = new System.Windows.Forms.ComboBox();
            this.categorycb = new System.Windows.Forms.ComboBox();
            this.authorcb = new System.Windows.Forms.ComboBox();
            this.resetbtn = new System.Windows.Forms.Button();
            this.nametb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchbtn.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(824, 46);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(86, 27);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(906, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Author";
            // 
            // Namecb
            // 
            this.Namecb.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namecb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Namecb.FormattingEnabled = true;
            this.Namecb.Location = new System.Drawing.Point(27, 49);
            this.Namecb.Name = "Namecb";
            this.Namecb.Size = new System.Drawing.Size(286, 23);
            this.Namecb.TabIndex = 0;
            this.Namecb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Namecb_KeyPress);
            // 
            // categorycb
            // 
            this.categorycb.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorycb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.categorycb.FormattingEnabled = true;
            this.categorycb.Location = new System.Drawing.Point(321, 49);
            this.categorycb.Name = "categorycb";
            this.categorycb.Size = new System.Drawing.Size(152, 23);
            this.categorycb.TabIndex = 1;
            this.categorycb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Namecb_KeyPress);
            // 
            // authorcb
            // 
            this.authorcb.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorcb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.authorcb.FormattingEnabled = true;
            this.authorcb.Location = new System.Drawing.Point(481, 49);
            this.authorcb.Name = "authorcb";
            this.authorcb.Size = new System.Drawing.Size(152, 23);
            this.authorcb.TabIndex = 2;
            this.authorcb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Namecb_KeyPress);
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.resetbtn.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.Location = new System.Drawing.Point(824, 79);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(86, 27);
            this.resetbtn.TabIndex = 5;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(27, 89);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(286, 22);
            this.nametb.TabIndex = 8;
            this.nametb.Text = "Enter Book Title Here";
            this.nametb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.nametb.TextChanged += new System.EventHandler(this.nametb_TextChanged);
            this.nametb.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.nametb_ControlRemoved);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(883, 298);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // insertbtn
            // 
            this.insertbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.insertbtn.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbtn.Location = new System.Drawing.Point(916, 172);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(104, 49);
            this.insertbtn.TabIndex = 7;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = false;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(916, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 49);
            this.button3.TabIndex = 6;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deletebtn.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(916, 227);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(104, 49);
            this.deletebtn.TabIndex = 16;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // SearchBookInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 493);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.authorcb);
            this.Controls.Add(this.categorycb);
            this.Controls.Add(this.Namecb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchbtn);
            this.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchBookInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Book - LMS";
            this.Load += new System.EventHandler(this.ManageBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Namecb;
        private System.Windows.Forms.ComboBox categorycb;
        private System.Windows.Forms.ComboBox authorcb;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button deletebtn;
    }
}