namespace WindowsFormsApp1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.btn_gray = new System.Windows.Forms.Button();
            this.row_txtbox = new System.Windows.Forms.TextBox();
            this.column_txtbox = new System.Windows.Forms.TextBox();
            this.dilation_btn = new System.Windows.Forms.Button();
            this.erosion_btn = new System.Windows.Forms.Button();
            this.otsu_btn = new System.Windows.Forms.Button();
            this.opening_btn = new System.Windows.Forms.Button();
            this.closing_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(26, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 327);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(433, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 319);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(336, 319);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(785, 25);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(75, 23);
            this.open_btn.TabIndex = 2;
            this.open_btn.Text = "Open";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // btn_gray
            // 
            this.btn_gray.Location = new System.Drawing.Point(785, 50);
            this.btn_gray.Name = "btn_gray";
            this.btn_gray.Size = new System.Drawing.Size(75, 23);
            this.btn_gray.TabIndex = 3;
            this.btn_gray.Text = "Gray";
            this.btn_gray.UseVisualStyleBackColor = true;
            this.btn_gray.Click += new System.EventHandler(this.btn_gray_Click);
            // 
            // row_txtbox
            // 
            this.row_txtbox.Location = new System.Drawing.Point(786, 108);
            this.row_txtbox.Name = "row_txtbox";
            this.row_txtbox.Size = new System.Drawing.Size(35, 20);
            this.row_txtbox.TabIndex = 4;
            this.row_txtbox.TextChanged += new System.EventHandler(this.row_txtbox_TextChanged);
            // 
            // column_txtbox
            // 
            this.column_txtbox.Location = new System.Drawing.Point(825, 108);
            this.column_txtbox.Name = "column_txtbox";
            this.column_txtbox.Size = new System.Drawing.Size(35, 20);
            this.column_txtbox.TabIndex = 4;
            this.column_txtbox.TextChanged += new System.EventHandler(this.column_txtbox_TextChanged);
            // 
            // dilation_btn
            // 
            this.dilation_btn.Location = new System.Drawing.Point(785, 133);
            this.dilation_btn.Name = "dilation_btn";
            this.dilation_btn.Size = new System.Drawing.Size(75, 23);
            this.dilation_btn.TabIndex = 5;
            this.dilation_btn.Text = "Dilation";
            this.dilation_btn.UseVisualStyleBackColor = true;
            this.dilation_btn.Click += new System.EventHandler(this.dilation_btn_Click);
            // 
            // erosion_btn
            // 
            this.erosion_btn.Location = new System.Drawing.Point(785, 160);
            this.erosion_btn.Name = "erosion_btn";
            this.erosion_btn.Size = new System.Drawing.Size(75, 23);
            this.erosion_btn.TabIndex = 5;
            this.erosion_btn.Text = "Erotion";
            this.erosion_btn.UseVisualStyleBackColor = true;
            this.erosion_btn.Click += new System.EventHandler(this.erosion_btn_Click);
            // 
            // otsu_btn
            // 
            this.otsu_btn.Location = new System.Drawing.Point(785, 75);
            this.otsu_btn.Name = "otsu_btn";
            this.otsu_btn.Size = new System.Drawing.Size(75, 23);
            this.otsu_btn.TabIndex = 6;
            this.otsu_btn.Text = "Otsu";
            this.otsu_btn.UseVisualStyleBackColor = true;
            this.otsu_btn.Click += new System.EventHandler(this.otsu_btn_Click);
            // 
            // opening_btn
            // 
            this.opening_btn.Location = new System.Drawing.Point(785, 188);
            this.opening_btn.Name = "opening_btn";
            this.opening_btn.Size = new System.Drawing.Size(75, 23);
            this.opening_btn.TabIndex = 7;
            this.opening_btn.Text = "Opening";
            this.opening_btn.UseVisualStyleBackColor = true;
            this.opening_btn.Click += new System.EventHandler(this.opening_btn_Click);
            // 
            // closing_btn
            // 
            this.closing_btn.Location = new System.Drawing.Point(785, 216);
            this.closing_btn.Name = "closing_btn";
            this.closing_btn.Size = new System.Drawing.Size(75, 23);
            this.closing_btn.TabIndex = 8;
            this.closing_btn.Text = "Closing";
            this.closing_btn.UseVisualStyleBackColor = true;
            this.closing_btn.Click += new System.EventHandler(this.closing_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.closing_btn);
            this.Controls.Add(this.opening_btn);
            this.Controls.Add(this.otsu_btn);
            this.Controls.Add(this.erosion_btn);
            this.Controls.Add(this.dilation_btn);
            this.Controls.Add(this.column_txtbox);
            this.Controls.Add(this.row_txtbox);
            this.Controls.Add(this.btn_gray);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button btn_gray;
        private System.Windows.Forms.TextBox row_txtbox;
        private System.Windows.Forms.TextBox column_txtbox;
        private System.Windows.Forms.Button dilation_btn;
        private System.Windows.Forms.Button erosion_btn;
        private System.Windows.Forms.Button otsu_btn;
        private System.Windows.Forms.Button opening_btn;
        private System.Windows.Forms.Button closing_btn;
    }
}

