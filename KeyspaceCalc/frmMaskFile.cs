using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyspaceCalc
{
    public partial class frmMaskFile : Form
    {
        string fileLocation;
        NumberFormatInfo NFI;

        private void Kick()
        {
            BigInteger keyspace, currentKeyspace = 1;
            var chars = txtMask.Text.ToCharArray();
            var speed = numSpeed.Value;
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

            // process main masks
            if (!File.Exists(fileLocation))
                return;
            string[] lines = File.ReadAllLines(fileLocation);
            int count = 0;
            int skip = Convert.ToInt32(numSkip.Value);
            foreach(string line in lines)
            {
                count++;
                if (count <= skip)
                    continue;
                chars = line.ToCharArray();
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
            keyspace--;
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
            lblKeyspace.Text = $"Keyspace = {outputKeySpace}";
            lblTime.Text = $"Exhaustion Time: {outputTime}";
            lblMaskCount.Text = $"Masks = {count.ToString()} Used = {(count-skip).ToString()}";
            keyspace = 1;
            
        }

        public frmMaskFile()
        {
            InitializeComponent();
        }

        private void btnMaskFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileBrowser = new OpenFileDialog();

            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                txtMask.Text = fileBrowser.FileName;
                fileLocation = fileBrowser.FileName;
                Kick();
            }
        }

        void dragAndDrop(object sender, DragEventArgs e) {
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
    }
}
