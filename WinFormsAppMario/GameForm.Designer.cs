namespace WinFormsAppMario
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            pictureBox_Canvas = new PictureBox();
            timer_Game = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Canvas).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_Canvas
            // 
            pictureBox_Canvas.Location = new Point(12, 12);
            pictureBox_Canvas.Name = "pictureBox_Canvas";
            pictureBox_Canvas.Size = new Size(776, 426);
            pictureBox_Canvas.TabIndex = 0;
            pictureBox_Canvas.TabStop = false;
            pictureBox_Canvas.Paint += pictureBox_Canvas_Paint;
            // 
            // timer_Game
            // 
            timer_Game.Enabled = true;
            timer_Game.Interval = 16;
            timer_Game.Tick += timer_Game_Tick;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox_Canvas);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameForm";
            KeyDown += GameForm_KeyDown;
            KeyUp += GameForm_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Canvas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_Canvas;
        private System.Windows.Forms.Timer timer_Game;
    }
}