
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FF_Console));
            this.btn_sentinal = new System.Windows.Forms.Button();
            this.btn_mage = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.btn_Warrior = new System.Windows.Forms.Button();
            this.txt_Introduction = new System.Windows.Forms.TextBox();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_HelpCloseIntro = new System.Windows.Forms.Button();
            this.pic_Chr = new System.Windows.Forms.PictureBox();
            this.btn_Return = new System.Windows.Forms.Button();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_chrInfoDisplay = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Chr)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sentinal
            // 
            this.btn_sentinal.Location = new System.Drawing.Point(334, 866);
            this.btn_sentinal.Name = "btn_sentinal";
            this.btn_sentinal.Size = new System.Drawing.Size(145, 44);
            this.btn_sentinal.TabIndex = 12;
            this.btn_sentinal.Text = "Sentinal";
            this.btn_sentinal.UseVisualStyleBackColor = true;
            this.btn_sentinal.Click += new System.EventHandler(this.btn_sentinal_Click);
            // 
            // btn_mage
            // 
            this.btn_mage.Location = new System.Drawing.Point(334, 866);
            this.btn_mage.Name = "btn_mage";
            this.btn_mage.Size = new System.Drawing.Size(145, 44);
            this.btn_mage.TabIndex = 13;
            this.btn_mage.Text = "Mage";
            this.btn_mage.UseVisualStyleBackColor = true;
            this.btn_mage.Click += new System.EventHandler(this.btn_mage_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(1488, 866);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(145, 44);
            this.btn_Quit.TabIndex = 14;
            this.btn_Quit.Text = "Quit Game";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // btn_Warrior
            // 
            this.btn_Warrior.Location = new System.Drawing.Point(334, 866);
            this.btn_Warrior.Name = "btn_Warrior";
            this.btn_Warrior.Size = new System.Drawing.Size(145, 44);
            this.btn_Warrior.TabIndex = 17;
            this.btn_Warrior.Text = "Warrior";
            this.btn_Warrior.UseVisualStyleBackColor = true;
            this.btn_Warrior.Click += new System.EventHandler(this.btn_Warrior_Click);
            // 
            // txt_Introduction
            // 
            this.txt_Introduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Introduction.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Introduction.Location = new System.Drawing.Point(1149, 533);
            this.txt_Introduction.Multiline = true;
            this.txt_Introduction.Name = "txt_Introduction";
            this.txt_Introduction.ReadOnly = true;
            this.txt_Introduction.Size = new System.Drawing.Size(484, 154);
            this.txt_Introduction.TabIndex = 18;
            this.txt_Introduction.Text = resources.GetString("txt_Introduction.Text");
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(1149, 866);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(145, 44);
            this.btn_Help.TabIndex = 19;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(1322, 866);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(145, 44);
            this.btn_Load.TabIndex = 20;
            this.btn_Load.Text = "Load Save";
            this.btn_Load.UseVisualStyleBackColor = true;
            // 
            // btn_HelpCloseIntro
            // 
            this.btn_HelpCloseIntro.Location = new System.Drawing.Point(1149, 866);
            this.btn_HelpCloseIntro.Name = "btn_HelpCloseIntro";
            this.btn_HelpCloseIntro.Size = new System.Drawing.Size(145, 44);
            this.btn_HelpCloseIntro.TabIndex = 21;
            this.btn_HelpCloseIntro.Text = "Help";
            this.btn_HelpCloseIntro.UseVisualStyleBackColor = true;
            this.btn_HelpCloseIntro.Click += new System.EventHandler(this.btn_HelpCloseIntro_Click);
            // 
            // pic_Chr
            // 
            this.pic_Chr.BackColor = System.Drawing.Color.Transparent;
            this.pic_Chr.Location = new System.Drawing.Point(12, 335);
            this.pic_Chr.Name = "pic_Chr";
            this.pic_Chr.Size = new System.Drawing.Size(316, 575);
            this.pic_Chr.TabIndex = 11;
            this.pic_Chr.TabStop = false;
            this.pic_Chr.Click += new System.EventHandler(this.pic_Chr_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(334, 866);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(145, 44);
            this.btn_Return.TabIndex = 22;
            this.btn_Return.Text = "Return To Game";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 29);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_chrInfoDisplay
            // 
            this.txt_chrInfoDisplay.Location = new System.Drawing.Point(353, 699);
            this.txt_chrInfoDisplay.Name = "txt_chrInfoDisplay";
            this.txt_chrInfoDisplay.Size = new System.Drawing.Size(100, 146);
            this.txt_chrInfoDisplay.TabIndex = 23;
            this.txt_chrInfoDisplay.Text = "";
            // 
            // FF_Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2039, 1104);
            this.ControlBox = false;
            this.Controls.Add(this.txt_chrInfoDisplay);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.btn_HelpCloseIntro);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.txt_Introduction);
            this.Controls.Add(this.btn_Warrior);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_mage);
            this.Controls.Add(this.btn_sentinal);
            this.Controls.Add(this.pic_Chr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FF_Console";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FF_Console";
            this.Load += new System.EventHandler(this.FF_Console_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Chr)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_Chr;
        private System.Windows.Forms.Button btn_sentinal;
        private System.Windows.Forms.Button btn_mage;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Button btn_Warrior;
        private System.Windows.Forms.TextBox txt_Introduction;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_HelpCloseIntro;
        public System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.RichTextBox txt_chrInfoDisplay;
    }
}

