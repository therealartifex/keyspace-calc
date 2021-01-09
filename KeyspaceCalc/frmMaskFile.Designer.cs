namespace KeyspaceCalc
{
    partial class frmMaskFile
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
            this.numHashes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.btnMaskFile = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblKeyspace = new System.Windows.Forms.Label();
            this.numSkip = new System.Windows.Forms.NumericUpDown();
            this.lblSkipMask = new System.Windows.Forms.Label();
            this.lblMaskCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHashes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkip)).BeginInit();
            this.SuspendLayout();
            // 
            // numHashes
            // 
            this.numHashes.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHashes.Location = new System.Drawing.Point(259, 83);
            this.numHashes.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.numHashes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHashes.Name = "numHashes";
            this.numHashes.Size = new System.Drawing.Size(617, 39);
            this.numHashes.TabIndex = 10;
            this.numHashes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numHashes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHashes.ValueChanged += new System.EventHandler(this.numHashes_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Unique salts";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.Items.AddRange(new object[] {
            "H/s",
            "KH/s",
            "MH/s",
            "GH/s",
            "TH/s"});
            this.cmbUnit.Location = new System.Drawing.Point(882, 134);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(108, 40);
            this.cmbUnit.TabIndex = 12;
            // 
            // numSpeed
            // 
            this.numSpeed.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSpeed.Location = new System.Drawing.Point(126, 135);
            this.numSpeed.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.numSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(750, 39);
            this.numSpeed.TabIndex = 11;
            this.numSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpeed.ValueChanged += new System.EventHandler(this.numSpeed_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Speed";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "File Location";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMask
            // 
            this.txtMask.AllowDrop = true;
            this.txtMask.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMask.Location = new System.Drawing.Point(280, 12);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(575, 44);
            this.txtMask.TabIndex = 9;
            this.txtMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMask.TextChanged += new System.EventHandler(this.txtMask_TextChanged);
            this.txtMask.DragOver += new System.Windows.Forms.DragEventHandler(this.dragAndDrop);
            // 
            // btnMaskFile
            // 
            this.btnMaskFile.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaskFile.Location = new System.Drawing.Point(861, 12);
            this.btnMaskFile.Name = "btnMaskFile";
            this.btnMaskFile.Size = new System.Drawing.Size(139, 44);
            this.btnMaskFile.TabIndex = 16;
            this.btnMaskFile.Text = "Browse";
            this.btnMaskFile.UseVisualStyleBackColor = true;
            this.btnMaskFile.Click += new System.EventHandler(this.btnMaskFile_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(11, 336);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(284, 27);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "Exhaustion Time: ";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeyspace
            // 
            this.lblKeyspace.AutoSize = true;
            this.lblKeyspace.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyspace.Location = new System.Drawing.Point(13, 292);
            this.lblKeyspace.Name = "lblKeyspace";
            this.lblKeyspace.Size = new System.Drawing.Size(188, 27);
            this.lblKeyspace.TabIndex = 17;
            this.lblKeyspace.Text = "Keyspace = ";
            this.lblKeyspace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numSkip
            // 
            this.numSkip.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSkip.Location = new System.Drawing.Point(126, 187);
            this.numSkip.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.numSkip.Name = "numSkip";
            this.numSkip.Size = new System.Drawing.Size(750, 39);
            this.numSkip.TabIndex = 19;
            this.numSkip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSkip.ValueChanged += new System.EventHandler(this.numSkip_ValueChanged);
            // 
            // lblSkipMask
            // 
            this.lblSkipMask.AutoSize = true;
            this.lblSkipMask.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkipMask.Location = new System.Drawing.Point(10, 194);
            this.lblSkipMask.Name = "lblSkipMask";
            this.lblSkipMask.Size = new System.Drawing.Size(91, 32);
            this.lblSkipMask.TabIndex = 20;
            this.lblSkipMask.Text = "Skip";
            this.lblSkipMask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaskCount
            // 
            this.lblMaskCount.AutoSize = true;
            this.lblMaskCount.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaskCount.Location = new System.Drawing.Point(13, 249);
            this.lblMaskCount.Name = "lblMaskCount";
            this.lblMaskCount.Size = new System.Drawing.Size(140, 27);
            this.lblMaskCount.TabIndex = 21;
            this.lblMaskCount.Text = "Masks = ";
            this.lblMaskCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMaskFile
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 370);
            this.Controls.Add(this.lblMaskCount);
            this.Controls.Add(this.numSkip);
            this.Controls.Add(this.lblSkipMask);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblKeyspace);
            this.Controls.Add(this.btnMaskFile);
            this.Controls.Add(this.numHashes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.numSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMask);
            this.Name = "frmMaskFile";
            this.Text = "Mask Files";
            this.Load += new System.EventHandler(this.frmMaskFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHashes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numHashes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.Button btnMaskFile;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblKeyspace;
        private System.Windows.Forms.NumericUpDown numSkip;
        private System.Windows.Forms.Label lblSkipMask;
        private System.Windows.Forms.Label lblMaskCount;
    }
}