using System;
using System.Globalization;
using System.Numerics;
using System.Windows.Forms;

namespace KeyspaceCalc
{
    public partial class frmMain : Form
    {
        BigInteger keyspace;
        NumberFormatInfo NFI;

        public frmMain()
        {
            InitializeComponent();
            keyspace = BigInteger.Zero;
        }

        private void Kick()
        {
            var chars = txtMask.Text.ToCharArray();
            var customChars = txtCustom.Text.ToCharArray();
            ulong customMask = 0;
            var speed = numSpeed.Value;
            //var t = new TimeSpan();
            var time = BigInteger.Zero;
            string outputKeySpace = "1";
            string outputTime = "";
            keyspace = (BigInteger)numHashes.Value;

            switch (cmbUnit.SelectedIndex)
            {
                case 1:
                    speed *= 1000;
                    break;
                case 2:
                    speed *= 1000000;
                    break;
                case 3:
                    speed *= 1000000000;
                    break;
                case 4:
                    speed *= 1000000000000;
                    break;
            }

            // process custom mask
            for (var i = 0; i < customChars.Length; ++i)
            {
                if (customChars[i] == '?' && i < customChars.Length - 1)
                {
                    switch (customChars[i + 1])
                    {
                        case 'a':
                            customMask += 95;
                            break;

                        case 'l':
                        case 'u':
                            customMask += 26;
                            break;

                        case 's':
                            customMask += 33;
                            break;

                        case 'd':
                            customMask += 10;
                            break;

                        case 'b':
                            customMask += 256;
                            break;

                        case 'h':
                        case 'H':
                            customMask += 16;
                            break;
                    }
                }
            }

            lblCustom.Text = $"Custom Mask = {customMask}";

            // process main mask
            for (var i = 0; i < chars.Length; ++i)
            {
                if (chars[i] == '?' && i < chars.Length - 1)
                {
                    switch (chars[i + 1])
                    {
                        case 'a':
                            keyspace *= 95;
                            break;

                        case 'c':
                            keyspace *= customMask;
                            break;

                        case 'l':
                        case 'u':
                            keyspace *= 26;
                            break;

                        case 's':
                            keyspace *= 33;
                            break;

                        case 'd':
                            keyspace *= 10;
                            break;

                        case 'b':
                            keyspace *= 256;
                            break;

                        case 'h':
                        case 'H':
                            keyspace *= 16;
                            break;
                    }

                    outputKeySpace = keyspace.ToString("N0", NFI);
                    //t = TimeSpan.FromSeconds((double)(keyspace / speed));
                    time = BigInteger.Divide(keyspace, (BigInteger)speed);
                    var days = BigInteger.Divide(time, 86400);
                    BigInteger.DivRem(time, 86400, out time);
                    var hours = BigInteger.Divide(time, 3600);
                    BigInteger.DivRem(time, 3600, out time);
                    var minutes = BigInteger.Divide(time, 60);
                    BigInteger.DivRem(time, 60, out time);
                    
                    outputTime = $"{days} days, {hours} hrs, {minutes} min, {time} sec";
                }
            }

            lblKeyspace.Text = $"Keyspace = {outputKeySpace}";
            lblTime.Text = $"Exhaustion Time: {outputTime}";
            keyspace = 1;
        }

        private void txtMask_TextChanged(object sender, EventArgs e)
        {
            Kick();
        }

        private void numSpeed_ValueChanged(object sender, EventArgs e)
        {
            Kick();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbUnit.SelectedIndex = 0;
            NFI = new NumberFormatInfo();
            NFI.NumberGroupSeparator = " ";
        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kick();
        }

        private void btnOptimizer_Click(object sender, EventArgs e)
        {
            var frm = new frmOptimize();
            frm.ShowDialog();
        }

        private void numHashes_ValueChanged(object sender, EventArgs e)
        {
            Kick();
        }

        private void txtCustom_TextChanged(object sender, EventArgs e)
        {
            Kick();
        }
    }
}
