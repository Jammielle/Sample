namespace FIRST_TRIAL
{
    partial class HomeScreenDisplay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogicBomb = new Label();
            lblZeroOne = new Label();
            pictureBomb = new PictureBox();
            pictureBorder = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnStart = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            btnHowToPlay = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBomb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lblLogicBomb
            // 
            lblLogicBomb.AutoSize = true;
            lblLogicBomb.BackColor = Color.Transparent;
            lblLogicBomb.Font = new Font("Swis721 BlkEx BT", 115.200005F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogicBomb.ForeColor = Color.Lime;
            lblLogicBomb.Location = new Point(73, 54);
            lblLogicBomb.Name = "lblLogicBomb";
            lblLogicBomb.Size = new Size(940, 464);
            lblLogicBomb.TabIndex = 0;
            lblLogicBomb.Text = "LOGIC\r\nBOMB\r\n";
            // 
            // lblZeroOne
            // 
            lblZeroOne.AutoSize = true;
            lblZeroOne.Font = new Font("Swis721 BlkCn BT", 60F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblZeroOne.ForeColor = Color.Lime;
            lblZeroOne.Location = new Point(1195, 362);
            lblZeroOne.Name = "lblZeroOne";
            lblZeroOne.Size = new Size(644, 600);
            lblZeroOne.TabIndex = 1;
            lblZeroOne.Text = "                 0 1\r\n              0110\r\n          100110\r\n    001110011\r\n01001001001";
            lblZeroOne.Click += lblZeroOne_Click;
            // 
            // pictureBomb
            // 
            pictureBomb.Image = Properties.Resources.Neon_Green_Pixel_Bomb_Sprite;
            pictureBomb.Location = new Point(879, -22);
            pictureBomb.Name = "pictureBomb";
            pictureBomb.Size = new Size(708, 631);
            pictureBomb.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBomb.TabIndex = 2;
            pictureBomb.TabStop = false;
            pictureBomb.Click += pictureBomb_Click;
            // 
            // pictureBorder
            // 
            pictureBorder.Image = Properties.Resources.Neon_Pixel_Arcade_HUD_Sprite_Sheet;
            pictureBorder.Location = new Point(-44, -41);
            pictureBorder.Name = "pictureBorder";
            pictureBorder.Size = new Size(1428, 92);
            pictureBorder.TabIndex = 4;
            pictureBorder.TabStop = false;
            pictureBorder.Click += pictureBox2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Neon_Pixel_Arcade_HUD_Sprite_Sheet;
            pictureBox1.Location = new Point(-9, -27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 1095);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Neon_Pixel_Arcade_HUD_Sprite_Sheet;
            pictureBox2.Location = new Point(1829, -41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 1135);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Neon_Pixel_Arcade_HUD_Sprite_Sheet;
            pictureBox3.Location = new Point(-61, 964);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1436, 104);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.ActiveCaptionText;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Swis721 BlkCn BT", 34.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.Lime;
            btnStart.Image = Properties.Resources.Design;
            btnStart.Location = new Point(160, 521);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(474, 99);
            btnStart.TabIndex = 8;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Neon_Pixel_Arcade_HUD_Sprite_Sheet;
            pictureBox4.Location = new Point(480, -41);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1428, 92);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Neon_Pixel_Arcade_HUD_Sprite_Sheet;
            pictureBox5.Location = new Point(1237, 965);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(662, 92);
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // btnHowToPlay
            // 
            btnHowToPlay.BackColor = SystemColors.ActiveCaptionText;
            btnHowToPlay.FlatStyle = FlatStyle.Flat;
            btnHowToPlay.Font = new Font("Swis721 BlkCn BT", 34.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHowToPlay.ForeColor = Color.Lime;
            btnHowToPlay.Image = Properties.Resources.Design;
            btnHowToPlay.Location = new Point(160, 649);
            btnHowToPlay.Name = "btnHowToPlay";
            btnHowToPlay.Size = new Size(474, 99);
            btnHowToPlay.TabIndex = 11;
            btnHowToPlay.Text = "HOW TO PLAY";
            btnHowToPlay.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaptionText;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Swis721 BlkCn BT", 34.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Lime;
            btnExit.Image = Properties.Resources.Design;
            btnExit.Location = new Point(160, 777);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(474, 99);
            btnExit.TabIndex = 12;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // HomeScreenDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1920, 1080);
            Controls.Add(pictureBorder);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnHowToPlay);
            Controls.Add(btnStart);
            Controls.Add(lblLogicBomb);
            Controls.Add(pictureBomb);
            Controls.Add(lblZeroOne);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "HomeScreenDisplay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBomb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogicBomb;
        private Label lblZeroOne;
        private PictureBox pictureBomb;
        private PictureBox pictureBorder;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnStart;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button btnHowToPlay;
        private Button button1;
        private Button btnExit;
    }
}
