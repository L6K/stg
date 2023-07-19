
namespace stg_toho
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.EndGameButton = new System.Windows.Forms.Button();
            this.EnemyAppearanceTime = new System.Windows.Forms.Timer(this.components);
            this.ChangeDirection = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EndGameButton
            // 
            this.EndGameButton.Location = new System.Drawing.Point(47, 81);
            this.EndGameButton.Name = "EndGameButton";
            this.EndGameButton.Size = new System.Drawing.Size(107, 23);
            this.EndGameButton.TabIndex = 0;
            this.EndGameButton.Text = "ゲームを終了する";
            this.EndGameButton.UseVisualStyleBackColor = true;
            this.EndGameButton.Click += new System.EventHandler(this.EndGameButton_Click);
            // 
            // EnemyAppearanceTime
            // 
            this.EnemyAppearanceTime.Enabled = true;
            this.EnemyAppearanceTime.Interval = 10000;
            this.EnemyAppearanceTime.Tick += new System.EventHandler(this.EnemyAppearanceTime_Tick);
            // 
            // ChangeDirection
            // 
            this.ChangeDirection.Enabled = true;
            this.ChangeDirection.Interval = 500;
            this.ChangeDirection.Tick += new System.EventHandler(this.ChangeDirection_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("メイリオ", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(583, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 144);
            this.label1.TabIndex = 1;
            this.label1.Text = "GAME OVER";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::stg_toho.Resource1.background;
            this.ClientSize = new System.Drawing.Size(1542, 933);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndGameButton);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EndGameButton;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer EnemyAppearanceTime;
        private System.Windows.Forms.Timer ChangeDirection;
        private System.Windows.Forms.Label label1;
    }
}

