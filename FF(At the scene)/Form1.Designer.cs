
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
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btn_2 = new System.Windows.Forms.Button();
            this.txt_Display = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.pic_Chr = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_sentinal = new System.Windows.Forms.Button();
            this.btn_mage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_chrInfoDisplay = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Chr)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 29);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(196, 298);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(158, 33);
            this.btn_2.TabIndex = 6;
            this.btn_2.Text = "button2";
            this.btn_2.UseVisualStyleBackColor = true;
            // 
            // txt_Display
            // 
            this.txt_Display.Location = new System.Drawing.Point(168, 198);
            this.txt_Display.Multiline = true;
            this.txt_Display.Name = "txt_Display";
            this.txt_Display.ReadOnly = true;
            this.txt_Display.Size = new System.Drawing.Size(353, 84);
            this.txt_Display.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_quit);
            this.groupBox1.Controls.Add(this.btn_1);
            this.groupBox1.Controls.Add(this.txt_Display);
            this.groupBox1.Controls.Add(this.btn_2);
            this.groupBox1.Location = new System.Drawing.Point(1111, 639);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 347);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(374, 298);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(147, 33);
            this.btn_quit.TabIndex = 11;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(16, 298);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(157, 33);
            this.btn_1.TabIndex = 10;
            this.btn_1.Text = "button1";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // pic_Chr
            // 
            this.pic_Chr.BackColor = System.Drawing.Color.Transparent;
            this.pic_Chr.Location = new System.Drawing.Point(62, 168);
            this.pic_Chr.Name = "pic_Chr";
            this.pic_Chr.Size = new System.Drawing.Size(209, 488);
            this.pic_Chr.TabIndex = 11;
            this.pic_Chr.TabStop = false;
            // 
            // btn_sentinal
            // 
            this.btn_sentinal.Location = new System.Drawing.Point(318, 612);
            this.btn_sentinal.Name = "btn_sentinal";
            this.btn_sentinal.Size = new System.Drawing.Size(145, 44);
            this.btn_sentinal.TabIndex = 12;
            this.btn_sentinal.Text = "Sentinal";
            this.btn_sentinal.UseVisualStyleBackColor = true;
            this.btn_sentinal.Click += new System.EventHandler(this.btn_sentinal_Click);
            // 
            // btn_mage
            // 
            this.btn_mage.Location = new System.Drawing.Point(318, 612);
            this.btn_mage.Name = "btn_mage";
            this.btn_mage.Size = new System.Drawing.Size(145, 44);
            this.btn_mage.TabIndex = 13;
            this.btn_mage.Text = "Mage";
            this.btn_mage.UseVisualStyleBackColor = true;
            this.btn_mage.Click += new System.EventHandler(this.btn_mage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(852, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "Quit Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_chrInfoDisplay
            // 
            this.txt_chrInfoDisplay.Location = new System.Drawing.Point(318, 373);
            this.txt_chrInfoDisplay.Multiline = true;
            this.txt_chrInfoDisplay.Name = "txt_chrInfoDisplay";
            this.txt_chrInfoDisplay.Size = new System.Drawing.Size(205, 170);
            this.txt_chrInfoDisplay.TabIndex = 15;
            // 
            // FF_Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.ControlBox = false;
            this.Controls.Add(this.txt_chrInfoDisplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_mage);
            this.Controls.Add(this.btn_sentinal);
            this.Controls.Add(this.pic_Chr);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FF_Console";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FF_Console";
            this.Load += new System.EventHandler(this.FF_Console_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Chr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.TextBox txt_Display;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic_Chr;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_sentinal;
        private System.Windows.Forms.Button btn_mage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_chrInfoDisplay;
    }
}

