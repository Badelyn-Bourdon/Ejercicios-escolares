namespace Aprendiendo_con_john
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 33);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v1ToolStripMenuItem,
            this.v2ToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            this.ventanaToolStripMenuItem.Click += new System.EventHandler(this.ventanaToolStripMenuItem_Click);
            // 
            // v1ToolStripMenuItem
            // 
            this.v1ToolStripMenuItem.Name = "v1ToolStripMenuItem";
            this.v1ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.v1ToolStripMenuItem.Text = "V1";
            this.v1ToolStripMenuItem.Click += new System.EventHandler(this.v1ToolStripMenuItem_Click);
            // 
            // v2ToolStripMenuItem
            // 
            this.v2ToolStripMenuItem.Name = "v2ToolStripMenuItem";
            this.v2ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.v2ToolStripMenuItem.Text = "V2";
            this.v2ToolStripMenuItem.Click += new System.EventHandler(this.v2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v2ToolStripMenuItem;
    }
}

