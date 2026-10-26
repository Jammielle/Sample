namespace FIRST_TRIAL
{
    partial class Homescreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homescreen));
            lblLogicBomb = new Label();
            lblZeroOne = new Label();
            pictureBomb = new PictureBox();
            label3 = new Label();
            pictureBorder = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnStart = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBomb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblLogicBomb
            // 
            lblLogicBomb.AutoSize = true;
            lblLogicBomb.Font = new Font("Swis721 BlkEx BT", 67.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogicBomb.ForeColor = Color.Lime;
            lblLogicBomb.Location = new Point(22, 40);
            lblLogicBomb.Name = "lblLogicBomb";
            lblLogicBomb.Size = new Size(556, 274);
            lblLogicBomb.TabIndex = 0;
            lblLogicBomb.Text = "LOGIC\r\nBOMB\r\n";
            // 
            // lblZeroOne
            // 
            lblZeroOne.AutoSize = true;
            lblZeroOne.Font = new Font("Swis721 BlkCn BT", 60F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblZeroOne.ForeColor = Color.Lime;
            lblZeroOne.Image = Properties.Resources.Neon_Green_Sci_Fi_Stage_Selector;
            lblZeroOne.Location = new Point(670, 237);
            lblZeroOne.Name = "lblZeroOne";
            lblZeroOne.Size = new Size(374, 360);
            lblZeroOne.TabIndex = 1;
            lblZeroOne.Text = "    0011\r\n  01010\r\n110011\r\n";
            // 
            // pictureBomb
            // 
            pictureBomb.Image = Properties.Resources.Neon_Green_Pixel_Bomb_Sprite;
            pictureBomb.Location = new Point(514, -11);
            pictureBomb.Name = "pictureBomb";
            pictureBomb.Size = new Size(401, 361);
            pictureBomb.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBomb.TabIndex = 2;
            pictureBomb.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BlkCn BT", 60F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(811, 222);
            label3.Margin = new Padding(3, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 120);
            label3.TabIndex = 3;
            label3.Text = "0";
            label3.Click += label3_Click;
            // 
            // pictureBorder
            // 
            pictureBorder.Image = Properties.Resources.Neon_Pixel_Arcade_HUD_Sprite_Sheet;
            pictureBorder.Location = new Point(-33, -55);
            pictureBorder.Name = "pictureBorder";
            pictureBorder.Size = new Size(1096, 92);
            pictureBorder.TabIndex = 4;
            pictureBorder.TabStop = false;
            pictureBorder.Click += pictureBox2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Neon_Pixel_Arcade_HUD_Sprite_Sheet;
            pictureBox1.Location = new Point(-33, -106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 730);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Neon_Pixel_Arcade_HUD_Sprite_Sheet;
            pictureBox2.Location = new Point(972, -68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 665);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Neon_Pixel_Arcade_HUD_Sprite_Sheet;
            pictureBox3.Location = new Point(-33, 538);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1077, 97);
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
            btnStart.Location = new Point(151, 435);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(237, 72);
            btnStart.TabIndex = 8;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-38, -11);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1082, 673);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // Homescreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1056, 636);
            Controls.Add(lblZeroOne);
            Controls.Add(pictureBox4);
            Controls.Add(btnStart);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(pictureBorder);
            Controls.Add(lblLogicBomb);
            Controls.Add(pictureBomb);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Homescreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBomb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogicBomb;
        private Label lblZeroOne;
        private PictureBox pictureBomb;
        private Label label3;
        private PictureBox pictureBorder;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnStart;
        private PictureBox pictureBox4;
    }
}
