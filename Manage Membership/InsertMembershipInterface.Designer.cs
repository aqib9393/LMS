namespace LibraryManagementSystem
{
    partial class InsertMembershipInterface
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
            this.typetb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.discounttb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(335, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // typetb
            // 
            this.typetb.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typetb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.typetb.Location = new System.Drawing.Point(169, 77);
            this.typetb.Name = "typetb";
            this.typetb.Size = new System.Drawing.Size(148, 23);
            this.typetb.TabIndex = 12;
            this.typetb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.titletb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Membership Type:";
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchbtn.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(169, 166);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(144, 27);
            this.searchbtn.TabIndex = 15;
            this.searchbtn.Text = "Insert";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // discounttb
            // 
            this.discounttb.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discounttb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.discounttb.Location = new System.Drawing.Point(169, 116);
            this.discounttb.Name = "discounttb";
            this.discounttb.Size = new System.Drawing.Size(148, 23);
            this.discounttb.TabIndex = 16;
            this.discounttb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discounttb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Discount (%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Membership";
            // 
            // InsertMembershipInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 255);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.discounttb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.typetb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InsertMembershipInterface";
            this.Text = "Insert Membership";
            this.Load += new System.EventHandler(this.updateMembership_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox typetb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox discounttb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}