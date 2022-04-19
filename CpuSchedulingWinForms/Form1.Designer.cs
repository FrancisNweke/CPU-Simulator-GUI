namespace CpuSchedulingWinForms
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
            this.labelProcess = new System.Windows.Forms.Label();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.fcfs = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPriority = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(80, 62);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(108, 13);
            this.labelProcess.TabIndex = 0;
            this.labelProcess.Text = "Number of Processes";
            // 
            // txtProcess
            // 
            this.txtProcess.Location = new System.Drawing.Point(217, 51);
            this.txtProcess.Multiline = true;
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(132, 33);
            this.txtProcess.TabIndex = 1;
            this.txtProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProcess.TextChanged += new System.EventHandler(this.txtProcess_TextChanged);
            // 
            // fcfs
            // 
            this.fcfs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fcfs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fcfs.Location = new System.Drawing.Point(12, 138);
            this.fcfs.Name = "fcfs";
            this.fcfs.Size = new System.Drawing.Size(129, 55);
            this.fcfs.TabIndex = 2;
            this.fcfs.Text = "FCFS";
            this.fcfs.UseVisualStyleBackColor = true;
            this.fcfs.Click += new System.EventHandler(this.fcfs_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(159, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "SHORTEST JOB FIRST";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPriority
            // 
            this.btnPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriority.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPriority.Location = new System.Drawing.Point(310, 138);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(137, 55);
            this.btnPriority.TabIndex = 4;
            this.btnPriority.Text = "PRIORITY";
            this.btnPriority.UseVisualStyleBackColor = true;
            this.btnPriority.Click += new System.EventHandler(this.btnPriority_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(353, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Restart Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 228);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPriority);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fcfs);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.labelProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU SCHEDULING";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.Button fcfs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPriority;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtProcess;
    }
}

