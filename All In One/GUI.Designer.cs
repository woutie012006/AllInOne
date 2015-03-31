namespace All_In_One
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.openFolder1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFolder2 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBoxFileChanger1 = new System.Windows.Forms.TextBox();
            this.txtBoxFileChanger2 = new System.Windows.Forms.TextBox();
            this.txtBoxFileChanger3 = new System.Windows.Forms.TextBox();
            this.btnFileChanger1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBoxListChanger1 = new System.Windows.Forms.TextBox();
            this.txtBoxListChanger2 = new System.Windows.Forms.RichTextBox();
            this.btnListChanger1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFolder1
            // 
            this.openFolder1.SelectedPath = "C:\\Users\\%username%\\Desktop";
            // 
            // openFolder2
            // 
            this.openFolder2.SelectedPath = "C:\\Users\\%username%\\Desktop";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnFileChanger1);
            this.tabPage2.Controls.Add(this.txtBoxFileChanger3);
            this.tabPage2.Controls.Add(this.txtBoxFileChanger2);
            this.tabPage2.Controls.Add(this.txtBoxFileChanger1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(349, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File Changer";
            // 
            // txtBoxFileChanger1
            // 
            this.txtBoxFileChanger1.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxFileChanger1.Location = new System.Drawing.Point(86, 48);
            this.txtBoxFileChanger1.Name = "txtBoxFileChanger1";
            this.txtBoxFileChanger1.Size = new System.Drawing.Size(183, 20);
            this.txtBoxFileChanger1.TabIndex = 10;
            this.txtBoxFileChanger1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox3_MouseDown);
            // 
            // txtBoxFileChanger2
            // 
            this.txtBoxFileChanger2.Location = new System.Drawing.Point(86, 108);
            this.txtBoxFileChanger2.Name = "txtBoxFileChanger2";
            this.txtBoxFileChanger2.Size = new System.Drawing.Size(183, 20);
            this.txtBoxFileChanger2.TabIndex = 11;
            this.txtBoxFileChanger2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox4_MouseDown);
            // 
            // txtBoxFileChanger3
            // 
            this.txtBoxFileChanger3.Location = new System.Drawing.Point(86, 175);
            this.txtBoxFileChanger3.Name = "txtBoxFileChanger3";
            this.txtBoxFileChanger3.Size = new System.Drawing.Size(183, 20);
            this.txtBoxFileChanger3.TabIndex = 12;
            // 
            // btnFileChanger1
            // 
            this.btnFileChanger1.Location = new System.Drawing.Point(129, 219);
            this.btnFileChanger1.Name = "btnFileChanger1";
            this.btnFileChanger1.Size = new System.Drawing.Size(75, 23);
            this.btnFileChanger1.TabIndex = 13;
            this.btnFileChanger1.Text = "Go";
            this.btnFileChanger1.UseVisualStyleBackColor = true;
            this.btnFileChanger1.Click += new System.EventHandler(this.goButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Folder to searsch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Move to this folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "What to searsch for";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnListChanger1);
            this.tabPage1.Controls.Add(this.txtBoxListChanger2);
            this.tabPage1.Controls.Add(this.txtBoxListChanger1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(349, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List Changer";
            // 
            // txtBoxListChanger1
            // 
            this.txtBoxListChanger1.Location = new System.Drawing.Point(26, 35);
            this.txtBoxListChanger1.Name = "txtBoxListChanger1";
            this.txtBoxListChanger1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxListChanger1.TabIndex = 0;
            // 
            // txtBoxListChanger2
            // 
            this.txtBoxListChanger2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxListChanger2.Location = new System.Drawing.Point(10, 67);
            this.txtBoxListChanger2.Name = "txtBoxListChanger2";
            this.txtBoxListChanger2.Size = new System.Drawing.Size(330, 193);
            this.txtBoxListChanger2.TabIndex = 1;
            this.txtBoxListChanger2.Text = "";
            // 
            // btnListChanger1
            // 
            this.btnListChanger1.Location = new System.Drawing.Point(180, 6);
            this.btnListChanger1.Name = "btnListChanger1";
            this.btnListChanger1.Size = new System.Drawing.Size(150, 50);
            this.btnListChanger1.TabIndex = 2;
            this.btnListChanger1.Text = "Add tag";
            this.btnListChanger1.UseVisualStyleBackColor = true;
            this.btnListChanger1.Click += new System.EventHandler(this.buttonGo1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "<";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = ">";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tag you wish to add";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(357, 297);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(346, 288);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "All-in-One";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog openFolder1;
        private System.Windows.Forms.FolderBrowserDialog openFolder2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFileChanger1;
        private System.Windows.Forms.TextBox txtBoxFileChanger3;
        private System.Windows.Forms.TextBox txtBoxFileChanger2;
        private System.Windows.Forms.TextBox txtBoxFileChanger1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListChanger1;
        private System.Windows.Forms.RichTextBox txtBoxListChanger2;
        private System.Windows.Forms.TextBox txtBoxListChanger1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

