namespace D_Eject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EjectButton = new System.Windows.Forms.Button();
            this.MountButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eJECTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOUNTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayBar = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // EjectButton
            // 
            this.EjectButton.Location = new System.Drawing.Point(12, 12);
            this.EjectButton.Name = "EjectButton";
            this.EjectButton.Size = new System.Drawing.Size(110, 32);
            this.EjectButton.TabIndex = 0;
            this.EjectButton.Text = "EJECT";
            this.EjectButton.UseVisualStyleBackColor = true;
            this.EjectButton.Click += new System.EventHandler(this.EjectButton_Click);
            // 
            // MountButton
            // 
            this.MountButton.Location = new System.Drawing.Point(128, 12);
            this.MountButton.Name = "MountButton";
            this.MountButton.Size = new System.Drawing.Size(110, 32);
            this.MountButton.TabIndex = 1;
            this.MountButton.Text = "MOUNT";
            this.MountButton.UseVisualStyleBackColor = true;
            this.MountButton.Click += new System.EventHandler(this.MountButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 50);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(226, 21);
            this.progressBar1.TabIndex = 2;
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Interval = 1000;
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eJECTToolStripMenuItem,
            this.mOUNTToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.ShowImageMargin = false;
            this.MenuBar.Size = new System.Drawing.Size(86, 70);
            // 
            // eJECTToolStripMenuItem
            // 
            this.eJECTToolStripMenuItem.Name = "eJECTToolStripMenuItem";
            this.eJECTToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.eJECTToolStripMenuItem.Text = "EJECT";
            this.eJECTToolStripMenuItem.Click += new System.EventHandler(this.eJECTToolStripMenuItem_Click);
            // 
            // mOUNTToolStripMenuItem
            // 
            this.mOUNTToolStripMenuItem.Name = "mOUNTToolStripMenuItem";
            this.mOUNTToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.mOUNTToolStripMenuItem.Text = "MOUNT";
            this.mOUNTToolStripMenuItem.Click += new System.EventHandler(this.mOUNTToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // TrayBar
            // 
            this.TrayBar.ContextMenuStrip = this.MenuBar;
            this.TrayBar.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayBar.Icon")));
            this.TrayBar.Text = "D-Eject";
            this.TrayBar.Visible = true;
            this.TrayBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayBar_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 83);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.MountButton);
            this.Controls.Add(this.EjectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "D-Eject";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.MenuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EjectButton;
        private System.Windows.Forms.Button MountButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer ProgressTimer;
        private System.Windows.Forms.ContextMenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem eJECTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOUNTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon TrayBar;
    }
}

