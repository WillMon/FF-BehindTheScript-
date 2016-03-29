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
            this.components = new System.ComponentModel.Container();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.pgb_Turn = new System.Windows.Forms.ProgressBar();
            this.pic_Chr = new System.Windows.Forms.PictureBox();
            this.timer_Player = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Chr)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(1696, 12);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(145, 44);
            this.btn_Quit.TabIndex = 15;
            this.btn_Quit.Text = "Retuen To Main";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // pgb_Turn
            // 
            this.pgb_Turn.Location = new System.Drawing.Point(54, 987);
            this.pgb_Turn.Name = "pgb_Turn";
            this.pgb_Turn.Size = new System.Drawing.Size(369, 29);
            this.pgb_Turn.TabIndex = 16;
            // 
            // pic_Chr
            // 
            this.pic_Chr.BackColor = System.Drawing.Color.Transparent;
            this.pic_Chr.Location = new System.Drawing.Point(75, 380);
            this.pic_Chr.Name = "pic_Chr";
            this.pic_Chr.Size = new System.Drawing.Size(316, 575);
            this.pic_Chr.TabIndex = 17;
            this.pic_Chr.TabStop = false;
            this.pic_Chr.Click += new System.EventHandler(this.pic_Chr_Click);
            // 
            // timer_Player
            // 
            this.timer_Player.Enabled = true;
            this.timer_Player.Interval = 10;
            // 
            // Combot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1935, 1081);
            this.ControlBox = false;
            this.Controls.Add(this.pic_Chr);
            this.Controls.Add(this.pgb_Turn);
            this.Controls.Add(this.btn_Quit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Combot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Combot";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Chr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.ProgressBar pgb_Turn;
        private System.Windows.Forms.PictureBox pic_Chr;
        private System.Windows.Forms.Timer timer_Player;
    }
}