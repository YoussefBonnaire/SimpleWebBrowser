
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
            this.Fav_Modifier = new System.Windows.Forms.ToolStripSplitButton();
            this.label_box = new System.Windows.Forms.ToolStripTextBox();
            this.url_box = new System.Windows.Forms.ToolStripTextBox();
            this.addtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.editUrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulk_download = new System.Windows.Forms.Button();
            this.bulk_box = new System.Windows.Forms.TextBox();
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
            this.Display.Location = new System.Drawing.Point(12, 57);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(751, 345);
            this.Display.TabIndex = 7;
            this.Display.TabStop = false;
            this.Display.Text = "";
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(90, 31);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(91, 20);
            this.Home.TabIndex = 8;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Set_home
            // 
            this.Set_home.Location = new System.Drawing.Point(12, 31);
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
            this.Favourites,
            this.Fav_Modifier});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(796, 25);
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
            this.Search_box.Size = new System.Drawing.Size(375, 25);
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
            this.Favourites.Image = ((System.Drawing.Image)(resources.GetObject("Favourites.Image")));
            this.Favourites.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Favourites.Name = "Favourites";
            this.Favourites.Size = new System.Drawing.Size(77, 22);
            this.Favourites.Text = "Favourites";
            this.Favourites.ButtonClick += new System.EventHandler(this.Favourites_ButtonClick);
            // 
            // Fav_Modifier
            // 
            this.Fav_Modifier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Fav_Modifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_box,
            this.url_box,
            this.addtoolStripMenuItem1,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.editUrlToolStripMenuItem});
            this.Fav_Modifier.Image = ((System.Drawing.Image)(resources.GetObject("Fav_Modifier.Image")));
            this.Fav_Modifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Fav_Modifier.Name = "Fav_Modifier";
            this.Fav_Modifier.Size = new System.Drawing.Size(89, 19);
            this.Fav_Modifier.Text = "Fav Modifier";
            // 
            // label_box
            // 
            this.label_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_box.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_box.Name = "label_box";
            this.label_box.Size = new System.Drawing.Size(100, 23);
            // 
            // url_box
            // 
            this.url_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.url_box.Name = "url_box";
            this.url_box.Size = new System.Drawing.Size(100, 23);
            // 
            // addtoolStripMenuItem1
            // 
            this.addtoolStripMenuItem1.BackColor = System.Drawing.Color.Chartreuse;
            this.addtoolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addtoolStripMenuItem1.Name = "addtoolStripMenuItem1";
            this.addtoolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.addtoolStripMenuItem1.Text = "add";
            this.addtoolStripMenuItem1.Click += new System.EventHandler(this.addtoolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.Red;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem5.Text = "delete";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.BackColor = System.Drawing.Color.Orange;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem6.Text = "edit name";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.editNameToolStripMenuItem_Click);
            // 
            // editUrlToolStripMenuItem
            // 
            this.editUrlToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.editUrlToolStripMenuItem.Name = "editUrlToolStripMenuItem";
            this.editUrlToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editUrlToolStripMenuItem.Text = "edit url";
            this.editUrlToolStripMenuItem.Click += new System.EventHandler(this.editUrlToolStripMenuItem_Click);
            // 
            // urlToolStripMenuItem
            // 
            this.urlToolStripMenuItem.Name = "urlToolStripMenuItem";
            this.urlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urlToolStripMenuItem.Text = "url";
            // 
            // bulk_download
            // 
            this.bulk_download.Location = new System.Drawing.Point(665, 31);
            this.bulk_download.Name = "bulk_download";
            this.bulk_download.Size = new System.Drawing.Size(97, 22);
            this.bulk_download.TabIndex = 12;
            this.bulk_download.Text = "Bulk Download";
            this.bulk_download.UseVisualStyleBackColor = true;
            this.bulk_download.Click += new System.EventHandler(this.bulk_download_Click);
            // 
            // bulk_box
            // 
            this.bulk_box.Location = new System.Drawing.Point(547, 32);
            this.bulk_box.Name = "bulk_box";
            this.bulk_box.Size = new System.Drawing.Size(112, 20);
            this.bulk_box.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 456);
            this.Controls.Add(this.bulk_box);
            this.Controls.Add(this.bulk_download);
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
        private System.Windows.Forms.ToolStripMenuItem urlToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton Fav_Modifier;
        private System.Windows.Forms.ToolStripTextBox label_box;
        private System.Windows.Forms.ToolStripTextBox url_box;
        private System.Windows.Forms.ToolStripMenuItem addtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem editUrlToolStripMenuItem;
        private System.Windows.Forms.Button bulk_download;
        private System.Windows.Forms.TextBox bulk_box;
    }
}

