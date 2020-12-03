using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KeyspaceCalc
{
    public partial class frmOptimize : Form
    {
        List<string> words;
        string[] masks;
        string outfilePath;

        public frmOptimize()
        {
            InitializeComponent();
        }

        private void btnLoadMask_Click(object sender, EventArgs e)
        {
            if (ofdLoad.ShowDialog() == DialogResult.OK)
            {
                masks = File.ReadAllLines(ofdLoad.FileName);
                txtStatus.AppendText($"Loaded {masks.Length} masks from file: {ofdLoad.FileName}\r\n");
            }
        }

        private void btnLoadWords_Click(object sender, EventArgs e)
        {
            if (ofdLoad.ShowDialog() == DialogResult.OK)
            {
                outfilePath = $"{ofdLoad.FileName}_optimized.txt";
                words = File.ReadAllLines(ofdLoad.FileName).ToList();
                txtStatus.AppendText($"Loaded {words.LongCount()} words from file: {ofdLoad.FileName}\r\n");
            }
        }

        private void btnOptimize_Click(object sender, EventArgs e)
        {
            if (words.LongCount() > 0 && masks.Length > 0)
            {
                var matches = 0;
                var matchlist = new List<string>();
                foreach (var w in words)
                {
                    // first, construct mask from original word
                    var wordmask = "";
                    foreach (var c in w)
                    {
                        switch (c)
                        {
                            case char ch when (ch >= 'a' && ch <= 'z'):
                                wordmask += "?l";
                                break;

                            case char ch when (ch >= 'A' && ch <= 'Z'):
                                wordmask += "?u";
                                break;

                            case char ch when (ch >= '0' && ch <= '9'):
                                wordmask += "?d";
                                break;

                            case char ch when (ch >= 32 && ch <= 47):
                            case char ch1 when (ch1 >= 58 && ch1 <= 64):
                            case char ch2 when (ch2 >= 91 && ch2 <= 96):
                            case char ch3 when (ch3 >= 123 && ch3 <= 126):
                                wordmask += "?s";
                                break;

                            case char ch when (ch >= 128 && ch <= 253):
                                wordmask += "?b";
                                break;
                        }
                    }

                    // now, see if the generated mask matches one in the list
                    if (masks.Contains(wordmask))
                    {
                        matchlist.Add(w);
                        ++matches;
                    }
                }

                var optlist = words.Except(matchlist);
                txtStatus.AppendText($"Words removed: {matches}\r\nOutput wordlist: {outfilePath}\r\n");
                
                File.WriteAllLines(outfilePath, optlist.ToArray());
            }
        }
    }
}