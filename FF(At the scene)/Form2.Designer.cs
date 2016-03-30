namespace FF_At_the_scene_
{
    partial class Combot
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
            this.btn_Quit = new System.Windows.Forms.Button();
            this.pgb_ph = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pic_EneAtt = new System.Windows.Forms.PictureBox();
            this.pic_ChrAtt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EneAtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ChrAtt)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(1979, 12);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(169, 44);
            this.btn_Quit.TabIndex = 15;
            this.btn_Quit.Text = "Retuen To Main";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Return_To_Start_Click);
            // 
            // pgb_ph
            // 
            this.pgb_ph.Location = new System.Drawing.Point(62, 981);
            this.pgb_ph.Name = "pgb_ph";
            this.pgb_ph.Size = new System.Drawing.Size(430, 29);
            this.pgb_ph.TabIndex = 16;
            this.pgb_ph.Click += new System.EventHandler(this.pgb_Turn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1451, 981);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(430, 29);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 278);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(284, 71);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1522, 278);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(284, 71);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pic_EneAtt
            // 
            this.pic_EneAtt.BackColor = System.Drawing.Color.Transparent;
            this.pic_EneAtt.Location = new System.Drawing.Point(1485, 380);
            this.pic_EneAtt.Name = "pic_EneAtt";
            this.pic_EneAtt.Size = new System.Drawing.Size(369, 575);
            this.pic_EneAtt.TabIndex = 18;
            this.pic_EneAtt.TabStop = false;
            this.pic_EneAtt.Click += new System.EventHandler(this.pic_EneAtt_Click);
            // 
            // pic_ChrAtt
            // 
            this.pic_ChrAtt.BackColor = System.Drawing.Color.Transparent;
            this.pic_ChrAtt.Location = new System.Drawing.Point(87, 380);
            this.pic_ChrAtt.Name = "pic_ChrAtt";
            this.pic_ChrAtt.Size = new System.Drawing.Size(369, 575);
            this.pic_ChrAtt.TabIndex = 17;
            this.pic_ChrAtt.TabStop = false;
            this.pic_ChrAtt.Click += new System.EventHandler(this.pic_ChrAtt_Click);
            // 
            // Combot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2039, 1104);
            this.ControlBox = false;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pic_EneAtt);
            this.Controls.Add(this.pic_ChrAtt);
            this.Controls.Add(this.pgb_ph);
            this.Controls.Add(this.btn_Quit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Combot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Combot";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_EneAtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ChrAtt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.ProgressBar pgb_ph;
        private System.Windows.Forms.PictureBox pic_ChrAtt;
        private System.Windows.Forms.PictureBox pic_EneAtt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox2;
        protected internal System.Windows.Forms.TextBox textBox1;
    }
}