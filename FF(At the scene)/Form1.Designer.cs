
namespace FF_At_the_scene_
{
    partial class FF_Console
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Press = new System.Windows.Forms.Button();
            this.btn_StatsCheck = new System.Windows.Forms.Button();
            this.txt_StatDispaly = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_Chr = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Chr)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_Press
            // 
            this.btn_Press.Location = new System.Drawing.Point(52, 86);
            this.btn_Press.Name = "btn_Press";
            this.btn_Press.Size = new System.Drawing.Size(98, 30);
            this.btn_Press.TabIndex = 2;
            this.btn_Press.Text = "ImageDispaly";
            this.btn_Press.UseVisualStyleBackColor = true;
            this.btn_Press.Click += new System.EventHandler(this.btn_Press_Click_1);
            // 
            // btn_StatsCheck
            // 
            this.btn_StatsCheck.Location = new System.Drawing.Point(277, 288);
            this.btn_StatsCheck.Name = "btn_StatsCheck";
            this.btn_StatsCheck.Size = new System.Drawing.Size(158, 33);
            this.btn_StatsCheck.TabIndex = 6;
            this.btn_StatsCheck.Text = "ChrStats";
            this.btn_StatsCheck.UseVisualStyleBackColor = true;
            // 
            // txt_StatDispaly
            // 
            this.txt_StatDispaly.Location = new System.Drawing.Point(168, 198);
            this.txt_StatDispaly.Multiline = true;
            this.txt_StatDispaly.Name = "txt_StatDispaly";
            this.txt_StatDispaly.Size = new System.Drawing.Size(353, 84);
            this.txt_StatDispaly.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "YO ",
            "Testing this ",
            "What is Good "});
            this.listBox1.Location = new System.Drawing.Point(16, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 173);
            this.listBox1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.txt_StatDispaly);
            this.groupBox1.Controls.Add(this.btn_StatsCheck);
            this.groupBox1.Location = new System.Drawing.Point(1113, 540);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 347);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // pic_Chr
            // 
            this.pic_Chr.BackColor = System.Drawing.Color.Transparent;
            this.pic_Chr.Location = new System.Drawing.Point(62, 168);
            this.pic_Chr.Name = "pic_Chr";
            this.pic_Chr.Size = new System.Drawing.Size(209, 488);
            this.pic_Chr.TabIndex = 11;
            this.pic_Chr.TabStop = false;
            this.pic_Chr.Click += new System.EventHandler(this.pic_Chr_Click_1);
            // 
            // FF_Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1854, 917);
            this.ControlBox = false;
            this.Controls.Add(this.pic_Chr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Press);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FF_Console";
            this.Text = "FF_Console";
            this.Load += new System.EventHandler(this.FF_Console_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Chr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_Press;
        private System.Windows.Forms.Button btn_StatsCheck;
        private System.Windows.Forms.TextBox txt_StatDispaly;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic_Chr;
    }
}

