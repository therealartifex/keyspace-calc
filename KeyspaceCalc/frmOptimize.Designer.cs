namespace KeyspaceCalc
{
    partial class frmOptimize
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
            this.btnLoadWords = new System.Windows.Forms.Button();
            this.btnLoadMask = new System.Windows.Forms.Button();
            this.btnOptimize = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.ofdLoad = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnLoadWords
            // 
            this.btnLoadWords.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadWords.Location = new System.Drawing.Point(12, 12);
            this.btnLoadWords.Name = "btnLoadWords";
            this.btnLoadWords.Size = new System.Drawing.Size(270, 47);
            this.btnLoadWords.TabIndex = 0;
            this.btnLoadWords.Text = "Load Wordlist";
            this.btnLoadWords.UseVisualStyleBackColor = true;
            this.btnLoadWords.Click += new System.EventHandler(this.btnLoadWords_Click);
            // 
            // btnLoadMask
            // 
            this.btnLoadMask.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadMask.Location = new System.Drawing.Point(403, 12);
            this.btnLoadMask.Name = "btnLoadMask";
            this.btnLoadMask.Size = new System.Drawing.Size(270, 47);
            this.btnLoadMask.TabIndex = 1;
            this.btnLoadMask.Text = "Load Masklist";
            this.btnLoadMask.UseVisualStyleBackColor = true;
            this.btnLoadMask.Click += new System.EventHandler(this.btnLoadMask_Click);
            // 
            // btnOptimize
            // 
            this.btnOptimize.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptimize.Location = new System.Drawing.Point(251, 361);
            this.btnOptimize.Name = "btnOptimize";
            this.btnOptimize.Size = new System.Drawing.Size(177, 77);
            this.btnOptimize.TabIndex = 2;
            this.btnOptimize.Text = "Optimize";
            this.btnOptimize.UseVisualStyleBackColor = true;
            this.btnOptimize.Click += new System.EventHandler(this.btnOptimize_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(12, 65);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(661, 290);
            this.txtStatus.TabIndex = 3;
            // 
            // ofdLoad
            // 
            this.ofdLoad.Filter = "All files|*.*";
            this.ofdLoad.Title = "Choose File";
            // 
            // frmOptimize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnOptimize);
            this.Controls.Add(this.btnLoadMask);
            this.Controls.Add(this.btnLoadWords);
            this.Name = "frmOptimize";
            this.Text = "Wordlist Optimizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadWords;
        private System.Windows.Forms.Button btnLoadMask;
        private System.Windows.Forms.Button btnOptimize;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.OpenFileDialog ofdLoad;
    }
}