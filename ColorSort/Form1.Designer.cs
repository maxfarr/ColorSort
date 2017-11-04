﻿namespace ColorSort
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sortTick = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomHueUnlimitedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rainbowHueROYGBIVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bubbleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bubbleWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 138);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sortTick
            // 
            this.sortTick.Enabled = true;
            this.sortTick.Interval = 5;
            this.sortTick.Tick += new System.EventHandler(this.sortTick_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortsToolStripMenuItem,
            this.sortsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(232, 44);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sortsToolStripMenuItem
            // 
            this.sortsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomHueUnlimitedToolStripMenuItem,
            this.rainbowHueROYGBIVToolStripMenuItem});
            this.sortsToolStripMenuItem.Name = "sortsToolStripMenuItem";
            this.sortsToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.sortsToolStripMenuItem.Text = "Initialize";
            this.sortsToolStripMenuItem.Click += new System.EventHandler(this.sortsToolStripMenuItem_Click);
            // 
            // randomHueUnlimitedToolStripMenuItem
            // 
            this.randomHueUnlimitedToolStripMenuItem.Name = "randomHueUnlimitedToolStripMenuItem";
            this.randomHueUnlimitedToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.randomHueUnlimitedToolStripMenuItem.Text = "Random Hue (Unlimited)";
            this.randomHueUnlimitedToolStripMenuItem.Click += new System.EventHandler(this.randomHueUnlimitedToolStripMenuItem_Click);
            // 
            // rainbowHueROYGBIVToolStripMenuItem
            // 
            this.rainbowHueROYGBIVToolStripMenuItem.Name = "rainbowHueROYGBIVToolStripMenuItem";
            this.rainbowHueROYGBIVToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.rainbowHueROYGBIVToolStripMenuItem.Text = "Rainbow Hue (ROYGBIV)";
            this.rainbowHueROYGBIVToolStripMenuItem.Click += new System.EventHandler(this.rainbowHueROYGBIVToolStripMenuItem_Click);
            // 
            // sortsToolStripMenuItem1
            // 
            this.sortsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bubbleToolStripMenuItem});
            this.sortsToolStripMenuItem1.Name = "sortsToolStripMenuItem1";
            this.sortsToolStripMenuItem1.Size = new System.Drawing.Size(70, 36);
            this.sortsToolStripMenuItem1.Text = "Sort";
            // 
            // bubbleToolStripMenuItem
            // 
            this.bubbleToolStripMenuItem.Name = "bubbleToolStripMenuItem";
            this.bubbleToolStripMenuItem.Size = new System.Drawing.Size(189, 38);
            this.bubbleToolStripMenuItem.Text = "Bubble";
            this.bubbleToolStripMenuItem.Click += new System.EventHandler(this.bubbleToolStripMenuItem_Click);
            // 
            // bubbleWorker
            // 
            this.bubbleWorker.WorkerReportsProgress = true;
            this.bubbleWorker.WorkerSupportsCancellation = true;
            this.bubbleWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bubbleWorker_DoWork);
            this.bubbleWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bubbleWorker_ProgressChanged);
            this.bubbleWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bubbleWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 182);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "ColorSort";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer sortTick;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bubbleToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bubbleWorker;
        private System.Windows.Forms.ToolStripMenuItem randomHueUnlimitedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rainbowHueROYGBIVToolStripMenuItem;
    }
}

