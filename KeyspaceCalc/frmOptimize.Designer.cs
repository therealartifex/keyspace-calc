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
            this.label69 = new System.Windows.Forms.Label();
            this.numMinLen = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLen)).BeginInit();
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
            this.btnLoadMask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadMask.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadMask.Location = new System.Drawing.Point(402, 12);
            this.btnLoadMask.Name = "btnLoadMask";
            this.btnLoadMask.Size = new System.Drawing.Size(270, 47);
            this.btnLoadMask.TabIndex = 1;
            this.btnLoadMask.Text = "Load Masklist";
            this.btnLoadMask.UseVisualStyleBackColor = true;
            this.btnLoadMask.Click += new System.EventHandler(this.btnLoadMask_Click);
            // 
            // btnOptimize
            // 
            this.btnOptimize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOptimize.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptimize.Location = new System.Drawing.Point(251, 362);
            this.btnOptimize.Name = "btnOptimize";
            this.btnOptimize.Size = new System.Drawing.Size(177, 77);
            this.btnOptimize.TabIndex = 2;
            this.btnOptimize.Text = "Optimize";
            this.btnOptimize.UseVisualStyleBackColor = true;
            this.btnOptimize.Click += new System.EventHandler(this.btnOptimize_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(12, 116);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(660, 240);
            this.txtStatus.TabIndex = 3;
            // 
            // ofdLoad
            // 
            this.ofdLoad.Filter = "All files|*.*";
            this.ofdLoad.Title = "Choose File";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(12, 86);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(332, 27);
            this.label69.TabIndex = 11;
            this.label69.Text = "Minimum Word Length:";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numMinLen
            // 
            this.numMinLen.Font = new System.Drawing.Font("Lucida Console", 18F);
            this.numMinLen.Location = new System.Drawing.Point(350, 82);
            this.numMinLen.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numMinLen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinLen.Name = "numMinLen";
            this.numMinLen.Size = new System.Drawing.Size(131, 31);
            this.numMinLen.TabIndex = 12;
            this.numMinLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMinLen.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // frmOptimize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 451);
            this.Controls.Add(this.numMinLen);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnOptimize);
            this.Controls.Add(this.btnLoadMask);
            this.Controls.Add(this.btnLoadWords);
            this.MinimumSize = new System.Drawing.Size(700, 490);
            this.Name = "frmOptimize";
            this.Text = "Wordlist Optimizer";
            ((System.ComponentModel.ISupportInitialize)(this.numMinLen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadWords;
        private System.Windows.Forms.Button btnLoadMask;
        private System.Windows.Forms.Button btnOptimize;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.OpenFileDialog ofdLoad;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.NumericUpDown numMinLen;
    }
}