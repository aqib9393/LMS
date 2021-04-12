namespace LibraryManagementSystem
{
    partial class AddBookInterface
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
            this.insertbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.authorcb = new System.Windows.Forms.ComboBox();
            this.categorycb = new System.Windows.Forms.ComboBox();
            this.qtytb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pricetb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titletb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(301, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // insertbtn
            // 
            this.insertbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.insertbtn.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbtn.Location = new System.Drawing.Point(136, 309);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(144, 27);
            this.insertbtn.TabIndex = 7;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = false;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Per Day Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Quantity:";
            // 
            // authorcb
            // 
            this.authorcb.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorcb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.authorcb.FormattingEnabled = true;
            this.authorcb.Location = new System.Drawing.Point(136, 176);
            this.authorcb.Name = "authorcb";
            this.authorcb.Size = new System.Drawing.Size(166, 24);
            this.authorcb.TabIndex = 3;
            this.authorcb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.authorcb_KeyPress);
            // 
            // categorycb
            // 
            this.categorycb.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorycb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.categorycb.FormattingEnabled = true;
            this.categorycb.Location = new System.Drawing.Point(136, 130);
            this.categorycb.Name = "categorycb";
            this.categorycb.Size = new System.Drawing.Size(166, 24);
            this.categorycb.TabIndex = 2;
            // 
            // qtytb
            // 
            this.qtytb.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtytb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.qtytb.Location = new System.Drawing.Point(136, 267);
            this.qtytb.Name = "qtytb";
            this.qtytb.Size = new System.Drawing.Size(64, 23);
            this.qtytb.TabIndex = 6;
            this.qtytb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtytb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Category:";
            // 
            // pricetb
            // 
            this.pricetb.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pricetb.Location = new System.Drawing.Point(136, 222);
            this.pricetb.Name = "pricetb";
            this.pricetb.Size = new System.Drawing.Size(82, 23);
            this.pricetb.TabIndex = 5;
            this.pricetb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pricetb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Author:";
            // 
            // titletb
            // 
            this.titletb.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.titletb.Location = new System.Drawing.Point(136, 87);
            this.titletb.Name = "titletb";
            this.titletb.Size = new System.Drawing.Size(237, 23);
            this.titletb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Book Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "Book Details";
            // 
            // AddBookInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 382);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.authorcb);
            this.Controls.Add(this.categorycb);
            this.Controls.Add(this.qtytb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pricetb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titletb);
            this.Controls.Add(this.label1);
            this.Name = "AddBookInterface";
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.addBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox authorcb;
        private System.Windows.Forms.ComboBox categorycb;
        private System.Windows.Forms.TextBox qtytb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pricetb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titletb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;

    }
}