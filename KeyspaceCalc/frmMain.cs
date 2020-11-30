using System;
using System.Globalization;
using System.Windows.Forms;

namespace KeyspaceCalc
{
    public partial class frmMain : Form
    {
        ulong keyspace = 1;
        NumberFormatInfo NFI;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Kick()
        {
            var chars = txtMask.Text.ToCharArray();
            var speed = numSpeed.Value;
            var t = new TimeSpan();
            string outputKeySpace = "1";
            string outputTime = "";

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

            for (var i = 0; i < chars.Length; ++i)
            {
                if (chars[i] == '?' && i < chars.Length - 1)
                {
                    try
                    {
                        checked
                        {
                            switch (chars[i + 1])
                            {
                                case 'a':
                                    keyspace *= 95;
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
                        }

                        outputKeySpace = keyspace.ToString("N0", NFI);
                        t = TimeSpan.FromSeconds((double)(keyspace / speed));
                        outputTime = $"{t.Days} days, {t.Hours} hrs, {t.Minutes} min, {t.Seconds} sec";
                    }
                    catch (OverflowException ex)
                    {
                        if (ex.Message.Contains("TimeSpan"))
                            outputTime = "Fuck";

                        if (ex.Message.Contains("Arithmetic"))
                            outputKeySpace = "Fuck";
                    }
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
    }
}
