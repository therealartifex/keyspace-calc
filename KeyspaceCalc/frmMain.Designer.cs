namespace KeyspaceCalc
{
    partial class frmMain
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
            this.txtMask = new System.Windows.Forms.TextBox();
            this.lblKeyspace = new System.Windows.Forms.Label();
            this.lblMask = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.btnOptimizer = new System.Windows.Forms.Button();
            this.numHashes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.lblCustom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHashes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMask
            // 
            this.txtMask.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMask.Location = new System.Drawing.Point(180, 126);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(812, 44);
            this.txtMask.TabIndex = 0;
            this.txtMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMask.TextChanged += new System.EventHandler(this.txtMask_TextChanged);
            // 
            // lblKeyspace
            // 
            this.lblKeyspace.AutoSize = true;
            this.lblKeyspace.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyspace.Location = new System.Drawing.Point(12, 306);
            this.lblKeyspace.Name = "lblKeyspace";
            this.lblKeyspace.Size = new System.Drawing.Size(188, 27);
            this.lblKeyspace.TabIndex = 9;
            this.lblKeyspace.Text = "Keyspace = ";
            this.lblKeyspace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.BackColor = System.Drawing.Color.Transparent;
            this.lblMask.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMask.Location = new System.Drawing.Point(12, 131);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(166, 32);
            this.lblMask.TabIndex = 6;
            this.lblMask.Text = "Mask(01)";
            this.lblMask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Speed";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numSpeed
            // 
            this.numSpeed.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSpeed.Location = new System.Drawing.Point(128, 233);
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
            this.numSpeed.TabIndex = 2;
            this.numSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpeed.ValueChanged += new System.EventHandler(this.numSpeed_ValueChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 364);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(284, 27);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Exhaustion Time: ";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cmbUnit.Location = new System.Drawing.Point(884, 232);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(108, 40);
            this.cmbUnit.TabIndex = 3;
            this.cmbUnit.SelectedIndexChanged += new System.EventHandler(this.cmbUnit_SelectedIndexChanged);
            // 
            // btnOptimizer
            // 
            this.btnOptimizer.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptimizer.Location = new System.Drawing.Point(12, 12);
            this.btnOptimizer.Name = "btnOptimizer";
            this.btnOptimizer.Size = new System.Drawing.Size(202, 80);
            this.btnOptimizer.TabIndex = 5;
            this.btnOptimizer.Text = "Wordlist Optimizer";
            this.btnOptimizer.UseVisualStyleBackColor = true;
            this.btnOptimizer.Click += new System.EventHandler(this.btnOptimizer_Click);
            // 
            // numHashes
            // 
            this.numHashes.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHashes.Location = new System.Drawing.Point(261, 181);
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
            this.numHashes.TabIndex = 1;
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
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unique salts";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Custom Mask (?c)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustom
            // 
            this.txtCustom.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustom.Location = new System.Drawing.Point(599, 31);
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(393, 44);
            this.txtCustom.TabIndex = 4;
            this.txtCustom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustom.TextChanged += new System.EventHandler(this.txtCustom_TextChanged);
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustom.Location = new System.Drawing.Point(594, 78);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(236, 27);
            this.lblCustom.TabIndex = 12;
            this.lblCustom.Text = "Custom Mask = ";
            this.lblCustom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.lblCustom);
            this.Controls.Add(this.txtCustom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numHashes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOptimizer);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.numSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.lblKeyspace);
            this.Controls.Add(this.txtMask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Keyspace Calculator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHashes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.Label lblKeyspace;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Button btnOptimizer;
        private System.Windows.Forms.NumericUpDown numHashes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.Label lblCustom;
    }
}

