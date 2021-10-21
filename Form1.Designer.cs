
namespace CW1_GUI
{
    partial class Form1
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
            this.Go_forward = new System.Windows.Forms.Button();
            this.Search_box = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Display = new System.Windows.Forms.RichTextBox();
            this.Home = new System.Windows.Forms.Button();
            this.Set_home = new System.Windows.Forms.Button();
            this.Go_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Go_forward
            // 
            this.Go_forward.Location = new System.Drawing.Point(93, 16);
            this.Go_forward.Name = "Go_forward";
            this.Go_forward.Size = new System.Drawing.Size(75, 23);
            this.Go_forward.TabIndex = 1;
            this.Go_forward.Text = ">";
            this.Go_forward.UseVisualStyleBackColor = true;
            // 
            // Search_box
            // 
            this.Search_box.Location = new System.Drawing.Point(174, 18);
            this.Search_box.Name = "Search_box";
            this.Search_box.Size = new System.Drawing.Size(367, 20);
            this.Search_box.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(547, 16);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(55, 23);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(608, 16);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(72, 23);
            this.Refresh.TabIndex = 4;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Progress
            // 
            this.Progress.AutoSize = true;
            this.Progress.Location = new System.Drawing.Point(0, 429);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(51, 13);
            this.Progress.TabIndex = 5;
            this.Progress.Text = "Progress:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(68, 429);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(192, 13);
            this.progressBar1.TabIndex = 6;
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(13, 57);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(736, 337);
            this.Display.TabIndex = 7;
            this.Display.TabStop = false;
            this.Display.Text = "";
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(746, 31);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(53, 20);
            this.Home.TabIndex = 8;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Set_home
            // 
            this.Set_home.Location = new System.Drawing.Point(726, 11);
            this.Set_home.Name = "Set_home";
            this.Set_home.Size = new System.Drawing.Size(72, 20);
            this.Set_home.TabIndex = 9;
            this.Set_home.Text = "Set_Home";
            this.Set_home.UseVisualStyleBackColor = true;
            this.Set_home.Click += new System.EventHandler(this.Set_home_Click);
            // 
            // Go_back
            // 
            this.Go_back.Location = new System.Drawing.Point(12, 16);
            this.Go_back.Name = "Go_back";
            this.Go_back.Size = new System.Drawing.Size(75, 23);
            this.Go_back.TabIndex = 10;
            this.Go_back.Text = "<";
            this.Go_back.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Go_back);
            this.Controls.Add(this.Set_home);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Search_box);
            this.Controls.Add(this.Go_forward);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Go_forward;
        private System.Windows.Forms.TextBox Search_box;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label Progress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox Display;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Set_home;
        private System.Windows.Forms.Button Go_back;
    }
}

