
namespace stg_toho
{
    partial class SettingsForm
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
            this.returnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FullScreen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // returnMenu
            // 
            this.returnMenu.Location = new System.Drawing.Point(672, 415);
            this.returnMenu.Name = "returnMenu";
            this.returnMenu.Size = new System.Drawing.Size(116, 23);
            this.returnMenu.TabIndex = 0;
            this.returnMenu.Text = "メニューに戻る";
            this.returnMenu.UseVisualStyleBackColor = true;
            this.returnMenu.Click += new System.EventHandler(this.returnMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ウィンドウ";
            // 
            // FullScreen
            // 
            this.FullScreen.AutoSize = true;
            this.FullScreen.Location = new System.Drawing.Point(0, 18);
            this.FullScreen.Name = "FullScreen";
            this.FullScreen.Size = new System.Drawing.Size(87, 19);
            this.FullScreen.TabIndex = 2;
            this.FullScreen.Text = "フルスクリーン";
            this.FullScreen.UseVisualStyleBackColor = true;
            this.FullScreen.CheckedChanged += new System.EventHandler(this.FullScreen_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FullScreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnMenu);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox FullScreen;
    }
}