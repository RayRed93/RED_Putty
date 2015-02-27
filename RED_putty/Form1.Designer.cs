namespace RED_putty
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
			this.Connect = new System.Windows.Forms.Button();
			this.passbox = new System.Windows.Forms.TextBox();
			this.idbox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.disconnect = new System.Windows.Forms.Button();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.puttyLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// Connect
			// 
			this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Connect.Location = new System.Drawing.Point(321, 175);
			this.Connect.Name = "Connect";
			this.Connect.Size = new System.Drawing.Size(99, 40);
			this.Connect.TabIndex = 0;
			this.Connect.Text = "Connect";
			this.Connect.UseVisualStyleBackColor = true;
			this.Connect.Click += new System.EventHandler(this.Connect_Click);
			// 
			// passbox
			// 
			this.passbox.Location = new System.Drawing.Point(6, 19);
			this.passbox.Name = "passbox";
			this.passbox.Size = new System.Drawing.Size(112, 20);
			this.passbox.TabIndex = 1;
			this.passbox.UseSystemPasswordChar = true;
			// 
			// idbox
			// 
			this.idbox.Location = new System.Drawing.Point(6, 19);
			this.idbox.Name = "idbox";
			this.idbox.Size = new System.Drawing.Size(115, 20);
			this.idbox.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.idbox);
			this.groupBox1.Location = new System.Drawing.Point(10, 31);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(127, 50);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ID";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.passbox);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Location = new System.Drawing.Point(143, 31);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(124, 50);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Password";
			// 
			// groupBox3
			// 
			this.groupBox3.Location = new System.Drawing.Point(60, 56);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(128, 89);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "groupBox3";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(18, 22);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(94, 17);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Remember me";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(18, 45);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(70, 17);
			this.checkBox2.TabIndex = 6;
			this.checkBox2.Text = "AutoStart";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 226);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(432, 22);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(138, 17);
			this.toolStripStatusLabel1.Text = "Network Status: OFFLINE";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(12, 191);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 24);
			this.label1.TabIndex = 8;
			this.label1.Text = "Ping: 0";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// disconnect
			// 
			this.disconnect.Enabled = false;
			this.disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.disconnect.Location = new System.Drawing.Point(197, 175);
			this.disconnect.Name = "disconnect";
			this.disconnect.Size = new System.Drawing.Size(118, 40);
			this.disconnect.TabIndex = 9;
			this.disconnect.Text = "Disconnect";
			this.disconnect.UseVisualStyleBackColor = true;
			this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(18, 68);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(101, 17);
			this.checkBox3.TabIndex = 10;
			this.checkBox3.Text = "AutoReconnect";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(432, 24);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puttyLocationToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
			this.toolStripMenuItem1.Text = "Menu";
			// 
			// puttyLocationToolStripMenuItem
			// 
			this.puttyLocationToolStripMenuItem.Name = "puttyLocationToolStripMenuItem";
			this.puttyLocationToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.puttyLocationToolStripMenuItem.Text = "Advanced Options";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.checkBox4);
			this.groupBox4.Controls.Add(this.checkBox3);
			this.groupBox4.Controls.Add(this.checkBox1);
			this.groupBox4.Controls.Add(this.checkBox2);
			this.groupBox4.Location = new System.Drawing.Point(276, 31);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(144, 116);
			this.groupBox4.TabIndex = 12;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Options";
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(18, 92);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(70, 17);
			this.checkBox4.TabIndex = 11;
			this.checkBox4.Text = "AutoHide";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "RED Putty";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(432, 248);
			this.Controls.Add(this.disconnect);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Connect);
			this.Controls.Add(this.groupBox4);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "RED Putty";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem puttyLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

    }
}

