namespace FF_At_the_scene_
{
    partial class Form3
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
            this.gb_vic_lose = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.pic_vic_death = new System.Windows.Forms.PictureBox();
            this.gb_vic_lose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_vic_death)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_vic_lose
            // 
            this.gb_vic_lose.BackColor = System.Drawing.Color.White;
            this.gb_vic_lose.Controls.Add(this.button2);
            this.gb_vic_lose.Controls.Add(this.btn_Load);
            this.gb_vic_lose.Controls.Add(this.pic_vic_death);
            this.gb_vic_lose.Location = new System.Drawing.Point(31, 30);
            this.gb_vic_lose.Name = "gb_vic_lose";
            this.gb_vic_lose.Size = new System.Drawing.Size(598, 413);
            this.gb_vic_lose.TabIndex = 28;
            this.gb_vic_lose.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(366, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "Rest";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.White;
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.Location = new System.Drawing.Point(55, 324);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(169, 44);
            this.btn_Load.TabIndex = 16;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // pic_vic_death
            // 
            this.pic_vic_death.Location = new System.Drawing.Point(55, 19);
            this.pic_vic_death.Name = "pic_vic_death";
            this.pic_vic_death.Size = new System.Drawing.Size(480, 282);
            this.pic_vic_death.TabIndex = 0;
            this.pic_vic_death.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 473);
            this.Controls.Add(this.gb_vic_lose);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gb_vic_lose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_vic_death)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_vic_lose;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.PictureBox pic_vic_death;
    }
}