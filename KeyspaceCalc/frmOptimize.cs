using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KeyspaceCalc
{
    public partial class frmOptimize : Form
    {
        private readonly SynchronizationContext sync_ctx;
        private DateTime prevTime = DateTime.Now;
        private List<string> words;
        private string[] masks;
        private string outfilePath;
        private Dictionary<string, ulong> matchmasks;
        private List<string> matchwords;


        public frmOptimize()
        {
            InitializeComponent();
            sync_ctx = SynchronizationContext.Current;
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

        private void ConstructMasks()
        {
            matchmasks = new Dictionary<string, ulong>();
            matchwords = new List<string>();
            var line = txtStatus.Lines.Length;
            foreach (var w in words)
            {
                // construct mask from original word
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
                    matchwords.Add(w);
                    if (matchmasks.ContainsKey(wordmask))
                    {
                        matchmasks[wordmask]++;
                        //UpdateMaskStatus(wordmask, matchmasks[wordmask]);
                    }
                    else
                        matchmasks.Add(wordmask, 1);
                }
            }
        }

        private void UpdateMaskStatus(string mask, ulong count)
        {
            var timeNow = DateTime.Now;
            if ((DateTime.Now - prevTime).Milliseconds <= 5) return;

            sync_ctx.Post(new SendOrPostCallback(o =>
            {
                lblCurrentMask.Text = $"Current Mask: {mask} = {(ulong)o}";
            }), count);

            prevTime = timeNow;
        }

        private async void btnOptimize_Click(object sender, EventArgs e)
        {
            txtStatus.Clear();
            if (words?.LongCount() > 0 && masks?.Length > 0)
            {
                
                var minRemoved = words.RemoveAll(word => word.Length < numMinLen.Value);
                txtStatus.AppendText($"Removing all words with less than {numMinLen.Value} chars: {minRemoved}\r\n");
                txtStatus.AppendText($"Removing words that have matching masks in your mask file...\r\n");

                await Task.Run(() => ConstructMasks());
                var sortedMasks = matchmasks.OrderByDescending(_ => _.Value);
                foreach (var kv in sortedMasks)
                {
                    txtStatus.AppendText($"{kv.Key,-30}{kv.Value}\r\n");
                }
                var optlist = words.Except(matchwords);
                txtStatus.AppendText($"Total words removed: {matchwords.LongCount() + minRemoved}\r\nFinal wordlist size: {optlist.LongCount()}\r\n");
                File.WriteAllLines(outfilePath, optlist.ToArray());
                txtStatus.AppendText($"Output wordlist: {outfilePath}\r\n");
            }
            else
            {
                txtStatus.AppendText("You must load both a wordlist and a mask file to optimize.\r\n");
            }
        }
    }
}