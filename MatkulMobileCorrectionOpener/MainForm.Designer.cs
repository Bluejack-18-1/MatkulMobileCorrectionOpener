namespace MatkulMobileCorrectionOpener
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.skipList = new System.Windows.Forms.ListBox();
            this.txtSkipName = new System.Windows.Forms.TextBox();
            this.btnAddFileToSkip = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtRoot = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.skipList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ignored Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // mainTab
            // 
            this.mainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTab.Location = new System.Drawing.Point(215, 28);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(593, 452);
            this.mainTab.TabIndex = 1;
            // 
            // skipList
            // 
            this.skipList.Dock = System.Windows.Forms.DockStyle.Top;
            this.skipList.FormattingEnabled = true;
            this.skipList.Items.AddRange(new object[] {
            ".gradle",
            ".idea",
            "gradle",
            "libs",
            "build",
            "test",
            "androidTest",
            "drawable",
            "mipmap",
            "values",
            "AndroidManifest.xml"});
            this.skipList.Location = new System.Drawing.Point(3, 16);
            this.skipList.Name = "skipList";
            this.skipList.Size = new System.Drawing.Size(209, 342);
            this.skipList.TabIndex = 2;
            // 
            // txtSkipName
            // 
            this.txtSkipName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSkipName.Location = new System.Drawing.Point(0, 0);
            this.txtSkipName.Name = "txtSkipName";
            this.txtSkipName.Size = new System.Drawing.Size(134, 20);
            this.txtSkipName.TabIndex = 3;
            // 
            // btnAddFileToSkip
            // 
            this.btnAddFileToSkip.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddFileToSkip.Location = new System.Drawing.Point(134, 0);
            this.btnAddFileToSkip.Name = "btnAddFileToSkip";
            this.btnAddFileToSkip.Size = new System.Drawing.Size(75, 20);
            this.btnAddFileToSkip.TabIndex = 4;
            this.btnAddFileToSkip.Text = "Add";
            this.btnAddFileToSkip.UseVisualStyleBackColor = true;
            this.btnAddFileToSkip.Click += new System.EventHandler(this.btnAddFileToSkip_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSkipName);
            this.panel1.Controls.Add(this.btnAddFileToSkip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 20);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "New File To Skip :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtRoot);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 28);
            this.panel2.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(808, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtRoot
            // 
            this.txtRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRoot.Location = new System.Drawing.Point(0, 0);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(808, 28);
            this.txtRoot.TabIndex = 0;
            this.txtRoot.Text = "___";
            this.txtRoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 502);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matkul Mobile Correction Opener";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.ListBox skipList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSkipName;
        private System.Windows.Forms.Button btnAddFileToSkip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtRoot;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

