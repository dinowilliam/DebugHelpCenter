namespace DebugHelpCenter
{
    partial class frmDebugHelpCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebugHelpCenter));
            this.tbcDebugHelpCenter = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddFileReplacer = new System.Windows.Forms.Button();
            this.lstFileReplacer = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.prcDebugHelpCenter = new System.Diagnostics.PerformanceCounter();
            this.tbcDebugHelpCenter.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prcDebugHelpCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcDebugHelpCenter
            // 
            this.tbcDebugHelpCenter.Controls.Add(this.tabPage1);
            this.tbcDebugHelpCenter.Controls.Add(this.tabPage2);
            this.tbcDebugHelpCenter.Controls.Add(this.tabPage3);
            this.tbcDebugHelpCenter.Controls.Add(this.tabPage4);
            this.tbcDebugHelpCenter.Controls.Add(this.tabPage5);
            this.tbcDebugHelpCenter.Location = new System.Drawing.Point(12, 27);
            this.tbcDebugHelpCenter.Name = "tbcDebugHelpCenter";
            this.tbcDebugHelpCenter.SelectedIndex = 0;
            this.tbcDebugHelpCenter.Size = new System.Drawing.Size(764, 398);
            this.tbcDebugHelpCenter.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddFileReplacer);
            this.tabPage2.Controls.Add(this.lstFileReplacer);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File Replacer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddFileReplacer
            // 
            this.btnAddFileReplacer.Location = new System.Drawing.Point(675, 8);
            this.btnAddFileReplacer.Name = "btnAddFileReplacer";
            this.btnAddFileReplacer.Size = new System.Drawing.Size(75, 23);
            this.btnAddFileReplacer.TabIndex = 1;
            this.btnAddFileReplacer.Text = "Add";
            this.btnAddFileReplacer.UseVisualStyleBackColor = true;
            // 
            // lstFileReplacer
            // 
            this.lstFileReplacer.FormattingEnabled = true;
            this.lstFileReplacer.Location = new System.Drawing.Point(6, 37);
            this.lstFileReplacer.Name = "lstFileReplacer";
            this.lstFileReplacer.Size = new System.Drawing.Size(744, 329);
            this.lstFileReplacer.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(756, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(756, 372);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Check Log";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(756, 372);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Process Control";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // frmDebugHelpCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 432);
            this.Controls.Add(this.tbcDebugHelpCenter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDebugHelpCenter";
            this.Text = "Debug Help Center";
            this.tbcDebugHelpCenter.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.prcDebugHelpCenter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDebugHelpCenter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Diagnostics.PerformanceCounter prcDebugHelpCenter;
        private System.Windows.Forms.Button btnAddFileReplacer;
        private System.Windows.Forms.ListBox lstFileReplacer;
    }
}

