
namespace Simple_Password_Generator_By_Jules_Legros
{
    partial class Password_Generator
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
            this.CopyBtn = new System.Windows.Forms.Button();
            this.Slider = new System.Windows.Forms.TrackBar();
            this.Box = new System.Windows.Forms.GroupBox();
            this.SliderLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.InfBtn = new System.Windows.Forms.Button();
            this.GithubBtn = new System.Windows.Forms.LinkLabel();
            this.LinkedinBtn = new System.Windows.Forms.LinkLabel();
            this.Line = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            this.Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // CopyBtn
            // 
            this.CopyBtn.Image = global::Simple_Password_Generator_By_Jules_Legros.Properties.Resources.icons8_presse_papiers_30;
            this.CopyBtn.Location = new System.Drawing.Point(22, 253);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(169, 46);
            this.CopyBtn.TabIndex = 0;
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Slider
            // 
            this.Slider.Location = new System.Drawing.Point(10, 22);
            this.Slider.Maximum = 32;
            this.Slider.Minimum = 5;
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(335, 45);
            this.Slider.TabIndex = 2;
            this.Slider.Value = 5;
            this.Slider.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // Box
            // 
            this.Box.Controls.Add(this.SliderLabel);
            this.Box.Controls.Add(this.Slider);
            this.Box.Location = new System.Drawing.Point(22, 148);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(351, 67);
            this.Box.TabIndex = 3;
            this.Box.TabStop = false;
            this.Box.Text = "Longeur du mot de passe (En caractères) :";
            this.Box.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SliderLabel
            // 
            this.SliderLabel.AutoSize = true;
            this.SliderLabel.Location = new System.Drawing.Point(237, 0);
            this.SliderLabel.Name = "SliderLabel";
            this.SliderLabel.Size = new System.Drawing.Size(13, 15);
            this.SliderLabel.TabIndex = 3;
            this.SliderLabel.Text = "5";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(376, 26);
            this.Title.TabIndex = 3;
            this.Title.Text = "Simple Password Generator By Jules Legros";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(22, 81);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(351, 23);
            this.Password.TabIndex = 4;
            // 
            // InfBtn
            // 
            this.InfBtn.Image = global::Simple_Password_Generator_By_Jules_Legros.Properties.Resources.icons8_info_30;
            this.InfBtn.Location = new System.Drawing.Point(203, 253);
            this.InfBtn.Name = "InfBtn";
            this.InfBtn.Size = new System.Drawing.Size(170, 46);
            this.InfBtn.TabIndex = 5;
            this.InfBtn.UseVisualStyleBackColor = true;
            this.InfBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // GithubBtn
            // 
            this.GithubBtn.AutoSize = true;
            this.GithubBtn.Location = new System.Drawing.Point(346, 332);
            this.GithubBtn.Name = "GithubBtn";
            this.GithubBtn.Size = new System.Drawing.Size(43, 15);
            this.GithubBtn.TabIndex = 6;
            this.GithubBtn.TabStop = true;
            this.GithubBtn.Text = "Github";
            this.GithubBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LinkedinBtn
            // 
            this.LinkedinBtn.AutoSize = true;
            this.LinkedinBtn.Location = new System.Drawing.Point(270, 331);
            this.LinkedinBtn.Name = "LinkedinBtn";
            this.LinkedinBtn.Size = new System.Drawing.Size(52, 15);
            this.LinkedinBtn.TabIndex = 7;
            this.LinkedinBtn.TabStop = true;
            this.LinkedinBtn.Text = "LinkedIn";
            this.LinkedinBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkedinBtn_LinkClicked);
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Line.Location = new System.Drawing.Point(328, 328);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(15, 20);
            this.Line.TabIndex = 8;
            this.Line.Text = "-";
            // 
            // Password_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 355);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.LinkedinBtn);
            this.Controls.Add(this.GithubBtn);
            this.Controls.Add(this.InfBtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.CopyBtn);
            this.MaximumSize = new System.Drawing.Size(417, 394);
            this.MinimumSize = new System.Drawing.Size(417, 394);
            this.Name = "Password_Generator";
            this.Text = "Simple Password Generator By Jules Legros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            this.Box.ResumeLayout(false);
            this.Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.TrackBar Slider;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button InfBtn;
        private System.Windows.Forms.Label SliderLabel;
        private System.Windows.Forms.LinkLabel GithubBtn;
        private System.Windows.Forms.LinkLabel LinkedinBtn;
        private System.Windows.Forms.Label Line;
    }
}

