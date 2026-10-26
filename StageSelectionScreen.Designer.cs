namespace FIRST_TRIAL
{
    partial class StageSelectionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StageSelectionScreen));
            lblStage = new Label();
            btnEasy = new Button();
            btnMediumStage = new Button();
            btnHardStage = new Button();
            btnBackToHomescreen = new Button();
            SuspendLayout();
            // 
            // lblStage
            // 
            lblStage.AutoSize = true;
            lblStage.BackColor = Color.Transparent;
            lblStage.FlatStyle = FlatStyle.Flat;
            lblStage.Font = new Font("Swis721 BlkEx BT", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStage.ForeColor = Color.Lime;
            lblStage.Image = Properties.Resources.jsjst;
            lblStage.Location = new Point(303, 135);
            lblStage.Name = "lblStage";
            lblStage.Size = new Size(1342, 101);
            lblStage.TabIndex = 0;
            lblStage.Text = "CHOOSE YOUR STAGE";
            // 
            // btnEasy
            // 
            btnEasy.BackColor = Color.Lime;
            btnEasy.BackgroundImage = Properties.Resources.EASY_DOOR;
            btnEasy.BackgroundImageLayout = ImageLayout.Stretch;
            btnEasy.FlatStyle = FlatStyle.Flat;
            btnEasy.Font = new Font("Swis721 BlkCn BT", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEasy.ForeColor = Color.Black;
            btnEasy.Location = new Point(73, 321);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(534, 595);
            btnEasy.TabIndex = 1;
            btnEasy.UseVisualStyleBackColor = false;
            btnEasy.Click += btnEasy_Click;
            // 
            // btnMediumStage
            // 
            btnMediumStage.BackColor = Color.Lime;
            btnMediumStage.BackgroundImage = (Image)resources.GetObject("btnMediumStage.BackgroundImage");
            btnMediumStage.BackgroundImageLayout = ImageLayout.Stretch;
            btnMediumStage.FlatStyle = FlatStyle.Flat;
            btnMediumStage.Font = new Font("Swis721 BlkCn BT", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMediumStage.ForeColor = Color.Black;
            btnMediumStage.Location = new Point(682, 321);
            btnMediumStage.Name = "btnMediumStage";
            btnMediumStage.Size = new Size(534, 595);
            btnMediumStage.TabIndex = 2;
            btnMediumStage.TextAlign = ContentAlignment.TopCenter;
            btnMediumStage.UseVisualStyleBackColor = false;
            btnMediumStage.Click += btnMediumStage_Click;
            // 
            // btnHardStage
            // 
            btnHardStage.BackColor = Color.Lime;
            btnHardStage.BackgroundImage = Properties.Resources.HArd;
            btnHardStage.BackgroundImageLayout = ImageLayout.Stretch;
            btnHardStage.FlatStyle = FlatStyle.Flat;
            btnHardStage.Font = new Font("Swis721 BlkCn BT", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHardStage.Location = new Point(1300, 321);
            btnHardStage.Name = "btnHardStage";
            btnHardStage.Size = new Size(534, 595);
            btnHardStage.TabIndex = 3;
            btnHardStage.TextAlign = ContentAlignment.TopCenter;
            btnHardStage.UseVisualStyleBackColor = false;
            btnHardStage.Click += btnHardStage_Click;
            // 
            // btnBackToHomescreen
            // 
            btnBackToHomescreen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBackToHomescreen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBackToHomescreen.BackColor = SystemColors.ActiveCaptionText;
            btnBackToHomescreen.BackgroundImage = Properties.Resources.ui_close_button;
            btnBackToHomescreen.BackgroundImageLayout = ImageLayout.Stretch;
            btnBackToHomescreen.Location = new Point(1770, 46);
            btnBackToHomescreen.Name = "btnBackToHomescreen";
            btnBackToHomescreen.Size = new Size(83, 79);
            btnBackToHomescreen.TabIndex = 4;
            btnBackToHomescreen.UseVisualStyleBackColor = false;
            btnBackToHomescreen.Click += btnBackToHomescreen_Click;
            // 
            // StageSelectionScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1920, 1080);
            Controls.Add(btnBackToHomescreen);
            Controls.Add(btnHardStage);
            Controls.Add(btnMediumStage);
            Controls.Add(btnEasy);
            Controls.Add(lblStage);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "StageSelectionScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStage;
        private Button btnEasy;
        private Button btnMediumStage;
        private Button btnHardStage;
        private Button btnBackToHomescreen;
    }
}