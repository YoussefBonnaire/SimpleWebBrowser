
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Progress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Display = new System.Windows.Forms.RichTextBox();
            this.Home = new System.Windows.Forms.Button();
            this.Set_home = new System.Windows.Forms.Button();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.Back = new System.Windows.Forms.ToolStripButton();
            this.Forward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Search_box = new System.Windows.Forms.ToolStripTextBox();
            this.Search_button = new System.Windows.Forms.ToolStripButton();
            this.Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.History = new System.Windows.Forms.ToolStripSplitButton();
            this.Favourites = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gfdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.Set_home.Location = new System.Drawing.Point(668, 31);
            this.Set_home.Name = "Set_home";
            this.Set_home.Size = new System.Drawing.Size(72, 20);
            this.Set_home.TabIndex = 9;
            this.Set_home.Text = "Set_Home";
            this.Set_home.UseVisualStyleBackColor = true;
            this.Set_home.Click += new System.EventHandler(this.Set_home_Click);
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back,
            this.Forward,
            this.toolStripSeparator1,
            this.Search_box,
            this.Search_button,
            this.Refresh,
            this.toolStripSeparator2,
            this.History,
            this.Favourites});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(800, 25);
            this.ToolStrip.TabIndex = 11;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // Back
            // 
            this.Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(23, 22);
            this.Back.Text = "<";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Forward
            // 
            this.Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Forward.Image = ((System.Drawing.Image)(resources.GetObject("Forward.Image")));
            this.Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(23, 22);
            this.Forward.Text = ">";
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Search_box
            // 
            this.Search_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Search_box.Name = "Search_box";
            this.Search_box.Size = new System.Drawing.Size(400, 25);
            // 
            // Search_button
            // 
            this.Search_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Search_button.Image = ((System.Drawing.Image)(resources.GetObject("Search_button.Image")));
            this.Search_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(46, 22);
            this.Search_button.Text = "Search";
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Refresh
            // 
            this.Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.Image")));
            this.Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(50, 22);
            this.Refresh.Text = "Refresh";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // History
            // 
            this.History.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.History.ForeColor = System.Drawing.SystemColors.ControlText;
            this.History.Image = ((System.Drawing.Image)(resources.GetObject("History.Image")));
            this.History.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(61, 22);
            this.History.Text = "History";
            this.History.ButtonClick += new System.EventHandler(this.History_ButtonClick);
            // 
            // Favourites
            // 
            this.Favourites.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Favourites.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.gfdToolStripMenuItem,
            this.toolStripTextBox1});
            this.Favourites.Image = ((System.Drawing.Image)(resources.GetObject("Favourites.Image")));
            this.Favourites.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Favourites.Name = "Favourites";
            this.Favourites.Size = new System.Drawing.Size(77, 22);
            this.Favourites.Text = "Favourites";
            this.Favourites.ButtonClick += new System.EventHandler(this.Favourites_ButtonClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // gfdToolStripMenuItem
            // 
            this.gfdToolStripMenuItem.Name = "gfdToolStripMenuItem";
            this.gfdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gfdToolStripMenuItem.Text = "gfd";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.Set_home);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Progress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Progress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox Display;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Set_home;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton Back;
        private System.Windows.Forms.ToolStripButton Forward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Search_button;
        private System.Windows.Forms.ToolStripButton Refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton Favourites;
        private System.Windows.Forms.ToolStripSplitButton History;
        private System.Windows.Forms.ToolStripTextBox Search_box;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gfdToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

