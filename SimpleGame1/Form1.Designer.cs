namespace SimpleGame1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelLose = new System.Windows.Forms.Label();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bg2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.coinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.Color.Brown;
            this.labelLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLose.Location = new System.Drawing.Point(342, 165);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(161, 42);
            this.labelLose.TabIndex = 7;
            this.labelLose.Text = "U LOSE";
            // 
            // PlayAgain
            // 
            this.PlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayAgain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlayAgain.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlayAgain.Location = new System.Drawing.Point(312, 263);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(207, 88);
            this.PlayAgain.TabIndex = 8;
            this.PlayAgain.Text = "PLAY";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.coin.Image = global::SimpleGame1.Properties.Resources.DJV_JUL_2361_01_removebg_preview;
            this.coin.Location = new System.Drawing.Point(312, -600);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(50, 45);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 9;
            this.coin.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.enemy2.Image = global::SimpleGame1.Properties.Resources._F7DEC62B_ED4B_4579_96B3_1173744;
            this.enemy2.Location = new System.Drawing.Point(504, -390);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(74, 118);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 6;
            this.enemy2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.enemy1.Image = global::SimpleGame1.Properties.Resources._F7DEC62B_ED4B_4579_96B3_1173744;
            this.enemy1.Location = new System.Drawing.Point(267, -150);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(74, 118);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 5;
            this.enemy1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Gray;
            this.player.Image = global::SimpleGame1.Properties.Resources._035D10FD_B057_4696_B4DE_DD74D3380439__removebg_preview;
            this.player.Location = new System.Drawing.Point(373, 437);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(81, 136);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bg1
            // 
            this.bg1.BackColor = System.Drawing.Color.Black;
            this.bg1.Image = global::SimpleGame1.Properties.Resources._28273__1_1;
            this.bg1.Location = new System.Drawing.Point(0, 0);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(800, 600);
            this.bg1.TabIndex = 0;
            this.bg1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleGame1.Properties.Resources._28273__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, -601);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 601);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bg2
            // 
            this.bg2.BackColor = System.Drawing.Color.Black;
            this.bg2.Image = global::SimpleGame1.Properties.Resources._28273__1_1;
            this.bg2.Location = new System.Drawing.Point(0, -600);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(800, 600);
            this.bg2.TabIndex = 3;
            this.bg2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = global::SimpleGame1.Properties.Resources._28273__1_1;
            this.pictureBox3.Location = new System.Drawing.Point(0, -600);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(800, 600);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // coinLabel
            // 
            this.coinLabel.AutoSize = true;
            this.coinLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.coinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coinLabel.Location = new System.Drawing.Point(28, 39);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(76, 29);
            this.coinLabel.TabIndex = 10;
            this.coinLabel.Text = "coins:";
            this.coinLabel.Click += new System.EventHandler(this.coinLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.coinLabel);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bg1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bg2);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox bg2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label coinLabel;
    }
}

