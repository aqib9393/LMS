namespace LibraryManagementSystem
{
    partial class AssignAndUpdateMembershipInterface
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addresstb = new System.Windows.Forms.RichTextBox();
            this.typecb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contacttb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customernametb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.typecb1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namesearchtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(594, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 26);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addresstb);
            this.groupBox1.Controls.Add(this.typecb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.contacttb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.customernametb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assign Membership to New Customer";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // addresstb
            // 
            this.addresstb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addresstb.Location = new System.Drawing.Point(178, 93);
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(258, 76);
            this.addresstb.TabIndex = 2;
            this.addresstb.Text = "";
            // 
            // typecb
            // 
            this.typecb.FormattingEnabled = true;
            this.typecb.Location = new System.Drawing.Point(178, 175);
            this.typecb.Name = "typecb";
            this.typecb.Size = new System.Drawing.Size(132, 24);
            this.typecb.TabIndex = 3;
            this.typecb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.typecb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Membership Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address:";
            // 
            // contacttb
            // 
            this.contacttb.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacttb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.contacttb.Location = new System.Drawing.Point(178, 64);
            this.contacttb.Name = "contacttb";
            this.contacttb.Size = new System.Drawing.Size(258, 23);
            this.contacttb.TabIndex = 1;
            this.contacttb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contacttb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contact No:";
            // 
            // customernametb
            // 
            this.customernametb.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customernametb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.customernametb.Location = new System.Drawing.Point(178, 35);
            this.customernametb.Name = "customernametb";
            this.customernametb.Size = new System.Drawing.Size(258, 23);
            this.customernametb.TabIndex = 0;
            this.customernametb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customernametb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Name:";
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchbtn.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(553, 264);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(144, 27);
            this.searchbtn.TabIndex = 2;
            this.searchbtn.Text = "Assign";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.typecb1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.namesearchtb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 232);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assign (Update) Membership to Existing Customer";
            // 
            // typecb1
            // 
            this.typecb1.FormattingEnabled = true;
            this.typecb1.Location = new System.Drawing.Point(178, 190);
            this.typecb1.Name = "typecb1";
            this.typecb1.Size = new System.Drawing.Size(132, 24);
            this.typecb1.TabIndex = 1;
            this.typecb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.typecb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Membership Type:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 123);
            this.dataGridView1.TabIndex = 5;
            // 
            // namesearchtb
            // 
            this.namesearchtb.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesearchtb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.namesearchtb.Location = new System.Drawing.Point(178, 32);
            this.namesearchtb.Name = "namesearchtb";
            this.namesearchtb.Size = new System.Drawing.Size(258, 23);
            this.namesearchtb.TabIndex = 0;
            this.namesearchtb.TextChanged += new System.EventHandler(this.namesearchtb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer Name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(553, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deletebtn.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(378, 533);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(144, 27);
            this.deletebtn.TabIndex = 14;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // AssignAndUpdateMembershipInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 639);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssignAndUpdateMembershipInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign & Update Membership";
            this.Load += new System.EventHandler(this.assignMembership_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox typecb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contacttb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customernametb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox namesearchtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox addresstb;
        private System.Windows.Forms.ComboBox typecb1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deletebtn;
    }
}