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
            this.pgb_eh = new System.Windows.Forms.ProgressBar();
            this.pic_EneAtt = new System.Windows.Forms.PictureBox();
            this.pic_ChrAtt = new System.Windows.Forms.PictureBox();
            this.txt_en = new System.Windows.Forms.TextBox();
            this.txt_pn = new System.Windows.Forms.TextBox();
            this.txt_Turns = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EneAtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ChrAtt)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quit
            // 
            this.btn_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.Location = new System.Drawing.Point(1634, 39);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(169, 44);
            this.btn_Quit.TabIndex = 15;
            this.btn_Quit.Text = "Retuen To Main";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Return_To_Start_Click);
            // 
            // pgb_ph
            // 
            this.pgb_ph.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pgb_ph.Location = new System.Drawing.Point(62, 981);
            this.pgb_ph.Name = "pgb_ph";
            this.pgb_ph.Size = new System.Drawing.Size(430, 29);
            this.pgb_ph.TabIndex = 16;
            this.pgb_ph.Click += new System.EventHandler(this.pgb_Turn_Click);
            // 
            // pgb_eh
            // 
            this.pgb_eh.BackColor = System.Drawing.Color.Yellow;
            this.pgb_eh.Location = new System.Drawing.Point(1451, 981);
            this.pgb_eh.Name = "pgb_eh";
            this.pgb_eh.Size = new System.Drawing.Size(430, 29);
            this.pgb_eh.TabIndex = 19;
            this.pgb_eh.Click += new System.EventHandler(this.progressBar1_Click);
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
            this.pic_ChrAtt.Location = new System.Drawing.Point(95, 380);
            this.pic_ChrAtt.Name = "pic_ChrAtt";
            this.pic_ChrAtt.Size = new System.Drawing.Size(369, 575);
            this.pic_ChrAtt.TabIndex = 17;
            this.pic_ChrAtt.TabStop = false;
            this.pic_ChrAtt.Click += new System.EventHandler(this.pic_ChrAtt_Click);
            // 
            // txt_en
            // 
            this.txt_en.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_en.Location = new System.Drawing.Point(1569, 307);
            this.txt_en.Multiline = true;
            this.txt_en.Name = "txt_en";
            this.txt_en.ReadOnly = true;
            this.txt_en.Size = new System.Drawing.Size(211, 49);
            this.txt_en.TabIndex = 22;
            // 
            // txt_pn
            // 
            this.txt_pn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pn.Location = new System.Drawing.Point(152, 307);
            this.txt_pn.Multiline = true;
            this.txt_pn.Name = "txt_pn";
            this.txt_pn.ReadOnly = true;
            this.txt_pn.Size = new System.Drawing.Size(211, 49);
            this.txt_pn.TabIndex = 23;
            this.txt_pn.TextChanged += new System.EventHandler(this.txt_pn_TextChanged);
            // 
            // txt_Turns
            // 
            this.txt_Turns.Location = new System.Drawing.Point(743, 307);
            this.txt_Turns.Multiline = true;
            this.txt_Turns.Name = "txt_Turns";
            this.txt_Turns.Size = new System.Drawing.Size(378, 87);
            this.txt_Turns.TabIndex = 24;
            // 
            // Combot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1968, 1104);
            this.ControlBox = false;
            this.Controls.Add(this.txt_Turns);
            this.Controls.Add(this.txt_pn);
            this.Controls.Add(this.txt_en);
            this.Controls.Add(this.pgb_eh);
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
        private System.Windows.Forms.ProgressBar pgb_eh;
        private System.Windows.Forms.TextBox txt_en;
        private System.Windows.Forms.TextBox txt_pn;
        private System.Windows.Forms.TextBox txt_Turns;
    }
}