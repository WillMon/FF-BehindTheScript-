namespace FF_At_the_scene_
{
    partial class Combat
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
            this.pgb_playerHealth = new System.Windows.Forms.ProgressBar();
            this.pgb_EnemyHealth = new System.Windows.Forms.ProgressBar();
            this.pic_EnemyAttack = new System.Windows.Forms.PictureBox();
            this.pic_PlayerAttack = new System.Windows.Forms.PictureBox();
            this.txt_en = new System.Windows.Forms.TextBox();
            this.txt_pn = new System.Windows.Forms.TextBox();
            this.txt_Turns = new System.Windows.Forms.TextBox();
            this.btn_SaveGame = new System.Windows.Forms.Button();
            this.expBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EnemyAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PlayerAttack)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.White;
            this.btn_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.Location = new System.Drawing.Point(1634, 39);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(169, 44);
            this.btn_Quit.TabIndex = 15;
            this.btn_Quit.Text = "Retuen To Main";
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Return_To_Start_Click);
            // 
            // pgb_ph
            // 
            this.pgb_playerHealth.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pgb_playerHealth.Location = new System.Drawing.Point(63, 971);
            this.pgb_playerHealth.Name = "pgb_ph";
            this.pgb_playerHealth.Size = new System.Drawing.Size(430, 29);
            this.pgb_playerHealth.TabIndex = 16;
            // 
            // pgb_eh
            // 
            this.pgb_EnemyHealth.BackColor = System.Drawing.Color.Yellow;
            this.pgb_EnemyHealth.Location = new System.Drawing.Point(1451, 981);
            this.pgb_EnemyHealth.Name = "pgb_eh";
            this.pgb_EnemyHealth.Size = new System.Drawing.Size(430, 29);
            this.pgb_EnemyHealth.TabIndex = 19;
            // 
            // pic_EneAtt
            // 
            this.pic_EnemyAttack.BackColor = System.Drawing.Color.Transparent;
            this.pic_EnemyAttack.Location = new System.Drawing.Point(1485, 380);
            this.pic_EnemyAttack.Name = "pic_EneAtt";
            this.pic_EnemyAttack.Size = new System.Drawing.Size(369, 575);
            this.pic_EnemyAttack.TabIndex = 18;
            this.pic_EnemyAttack.TabStop = false;
            this.pic_EnemyAttack.Click += new System.EventHandler(this.pic_EnemyAttack_Click);
            // 
            // pic_ChrAtt
            // 
            this.pic_PlayerAttack.BackColor = System.Drawing.Color.Transparent;
            this.pic_PlayerAttack.Location = new System.Drawing.Point(95, 380);
            this.pic_PlayerAttack.Name = "pic_ChrAtt";
            this.pic_PlayerAttack.Size = new System.Drawing.Size(369, 575);
            this.pic_PlayerAttack.TabIndex = 17;
            this.pic_PlayerAttack.TabStop = false;
            this.pic_PlayerAttack.Click += new System.EventHandler(this.pic_PlayerAttack_Click);
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
            this.txt_pn.Location = new System.Drawing.Point(207, 307);
            this.txt_pn.Multiline = true;
            this.txt_pn.Name = "txt_pn";
            this.txt_pn.ReadOnly = true;
            this.txt_pn.Size = new System.Drawing.Size(211, 49);
            this.txt_pn.TabIndex = 23;
            // 
            // txt_Turns
            // 
            this.txt_Turns.Location = new System.Drawing.Point(810, 325);
            this.txt_Turns.Multiline = true;
            this.txt_Turns.Name = "txt_Turns";
            this.txt_Turns.Size = new System.Drawing.Size(378, 87);
            this.txt_Turns.TabIndex = 24;
            // 
            // btn_SaveGame
            // 
            this.btn_SaveGame.BackColor = System.Drawing.Color.White;
            this.btn_SaveGame.Location = new System.Drawing.Point(1634, 119);
            this.btn_SaveGame.Name = "btn_SaveGame";
            this.btn_SaveGame.Size = new System.Drawing.Size(169, 44);
            this.btn_SaveGame.TabIndex = 25;
            this.btn_SaveGame.Text = "Save";
            this.btn_SaveGame.UseVisualStyleBackColor = false;
            this.btn_SaveGame.Click += new System.EventHandler(this.btn_SaveGame_Click);
            // 
            // expBar
            // 
            this.expBar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.expBar.Location = new System.Drawing.Point(149, 1006);
            this.expBar.Name = "expBar";
            this.expBar.Size = new System.Drawing.Size(247, 29);
            this.expBar.TabIndex = 26;
            // 
            // Combot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1968, 1104);
            this.ControlBox = false;
            this.Controls.Add(this.expBar);
            this.Controls.Add(this.btn_SaveGame);
            this.Controls.Add(this.txt_Turns);
            this.Controls.Add(this.txt_pn);
            this.Controls.Add(this.txt_en);
            this.Controls.Add(this.pgb_EnemyHealth);
            this.Controls.Add(this.pic_EnemyAttack);
            this.Controls.Add(this.pic_PlayerAttack);
            this.Controls.Add(this.pgb_playerHealth);
            this.Controls.Add(this.btn_Quit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Combot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Combot";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_EnemyAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PlayerAttack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.ProgressBar pgb_playerHealth;
        private System.Windows.Forms.PictureBox pic_PlayerAttack;
        private System.Windows.Forms.PictureBox pic_EnemyAttack;
        private System.Windows.Forms.ProgressBar pgb_EnemyHealth;
        private System.Windows.Forms.TextBox txt_en;
        private System.Windows.Forms.TextBox txt_pn;
        private System.Windows.Forms.TextBox txt_Turns;
        private System.Windows.Forms.Button btn_SaveGame;
        private System.Windows.Forms.ProgressBar expBar;
    }
}