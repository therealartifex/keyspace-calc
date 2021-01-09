using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Windows.Forms;

namespace KeyspaceCalc
{
    public partial class frmMaskFile : Form
    {
        string fileLocation;
        NumberFormatInfo NFI;

        // Calculate keyspace and push statistics to lbls
        // TODO: Optimise to not process mask file every kick,
        // however, semi-modern hardware shouldn't have an issue
        private void Kick()
        {
            BigInteger keyspace, currentKeyspace = 1;
            var chars = txtMask.Text.ToCharArray();
            var speed = numSpeed.Value;
            var time = BigInteger.Zero;
            string outputKeySpace = "1";
            string outputTime = "";
            keyspace = (BigInteger)numHashes.Value;

            // Multipliers for (K/M/G/T)H/s
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

            if (!File.Exists(fileLocation))
                return;

            //Read file into memory
            string[] lines = File.ReadAllLines(fileLocation);
            int count = 0;
            int skip = Convert.ToInt32(numSkip.Value);
            foreach(string line in lines)
            {
                count++;
                // Skip masks
                if (count <= skip)
                    continue;
                chars = line.ToCharArray();

                // Calculate keyspace per mask
                for (var i = 0; i < chars.Length; ++i)
                {
                    if (chars[i] == '?' && i < chars.Length - 1)
                    {
                        switch (chars[i + 1])
                        {
                            case 'a':
                                currentKeyspace *= 95;
                                break;

                            case 'l':
                            case 'u':
                                currentKeyspace *= 26;
                                break;

                            case 's':
                                currentKeyspace *= 33;
                                break;

                            case 'd':
                                currentKeyspace *= 10;
                                break;

                            case 'b':
                                currentKeyspace *= 256;
                                break;

                            case 'h':
                            case 'H':
                                currentKeyspace *= 16;
                                break;
                        }
                    }

                }
                keyspace += currentKeyspace;
                currentKeyspace = 1;
            }
            // Calculate keyspace and subdivide into time units
            keyspace--;
            outputKeySpace = keyspace.ToString("N0", NFI);
            time = BigInteger.Divide(keyspace, (BigInteger)speed);
            var days = BigInteger.Divide(time, 86400);
            BigInteger.DivRem(time, 86400, out time);
            var hours = BigInteger.Divide(time, 3600);
            BigInteger.DivRem(time, 3600, out time);
            var minutes = BigInteger.Divide(time, 60);
            BigInteger.DivRem(time, 60, out time);

            // Update lbls
            outputTime = $"{days} days, {hours} hrs, {minutes} min, {time} sec";
            lblKeyspace.Text = $"Keyspace = {outputKeySpace}";
            lblTime.Text = $"Exhaustion Time: {outputTime}";
            lblMaskCount.Text = $"Masks = {count.ToString()} Used = {(count-skip).ToString()}";
            keyspace = 1;
            
        }

        private void btnMaskFile_Click(object sender, EventArgs e)
        {
            // Open [Browse] file explorer
            OpenFileDialog fileBrowser = new OpenFileDialog();

            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                txtMask.Text = fileBrowser.FileName;
                fileLocation = fileBrowser.FileName;
                Kick();
            }
        }

        void dragAndDrop(object sender, DragEventArgs e) {
            // Grab file location from drag-and-dropped files
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                txtMask.Text = files[0];
                fileLocation = files[0];
                Kick();
            }

        }

        private void txtMask_TextChanged(object sender, EventArgs e)
        {
            Kick();
        }
        private void numHashes_ValueChanged(object sender, EventArgs e)
        {
            Kick();
        }

        private void numSpeed_ValueChanged(object sender, EventArgs e)
        {
            Kick();
        }

        private void frmMaskFile_Load(object sender, EventArgs e)
        {
            cmbUnit.SelectedIndex = 0;
        }

        private void numSkip_ValueChanged(object sender, EventArgs e)
        {
            Kick();
        }

        public frmMaskFile()
        {
            InitializeComponent();
        }
    }
}
