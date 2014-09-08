using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ProcessMemory;

namespace RAMCorruptor
{
    public partial class MainForm : Form
    {
        private Process selProc = null;
        private Color btnColorOff, btnColorOn;
        private long min, max;
        private Random rng, seedGen;

        public MainForm()
        {
            InitializeComponent();
            btnColorOff = Color.FromArgb(255, 192, 192);
            btnColorOn = Color.FromArgb(192, 255, 192);
            seedGen = new Random();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //following line is for testing BinarySearch
            //MessageBox.Show(BinarySearch.FindFirstTrue(BinarySearch.TestingFunction, 5, 500, true).ToString());
            rangeSize.Minimum = Decimal.MinValue;
            rangeSize.Maximum = Decimal.MaxValue;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            Process proc = SelectProcessForm.SelectProcess();

            if (proc != null) {
                selProc = proc;
                procName.ForeColor = SystemColors.WindowText;
                procName.Text = String.Format("#{0} - {1}", proc.Id, proc.ProcessName);
                corruptBtn.Enabled = true;
                corruptBtn.Text = "Hold to corrupt";
                refine.Enabled = true;
                Invalidate();
            }
        }

        private void corruptBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) StartCorrupting();
        }

        private void corruptBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) StopCorrupting();
        }

        private void ParseTextFields()
        {
            // This function is mainly here as a remnant from before HexTextBox was written.
            min = rangeMin.Value;
            max = rangeMax.Value;
            timer.Interval = (int)interval.Value;
        }

        private void StartCorrupting()
        {
            if (rangeMin.Value > rangeMax.Value) {
                long temp = rangeMax.Value;
                rangeMax.Value = rangeMin.Value;
                rangeMin.Value = temp;
            }
            corruptBtn.BackColor = btnColorOn;
            corruptBtn.Text = "Corrupting...";

            if (useSeed.Checked) {
                rng = new Random((int)seedBox.Value);
            } else {
                int seed = seedGen.Next(Int32.MinValue, Int32.MaxValue);
                rng = new Random(seed);
                seedBox.Value = seed;
            }

            ParseTextFields();
            timer.Enabled = true;
        }

        private void StopCorrupting()
        {
            corruptBtn.BackColor = btnColorOff;
            corruptBtn.Text = "Hold to corrupt";
            timer.Enabled = false;
        }

        private void corruptBtn_Click(object sender, EventArgs e)
        {
            // You're probably looking for MouseDown or MouseUp.
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < byteCount.Value; i++) {
                long addr = RandUnsignedInRange(rng, min, max);
                try {
                    selProc.Write(addr, GetReplacementByte(selProc.ReadByte(addr)));
                } catch (InvalidOperationException) {
                    corruptBtn.BackColor = Color.FromArgb(255, 255, 192);
                    corruptBtn.Text = String.Format("Access violation at {0:X}", addr);
                } catch (Win32Exception ex) {
                    corruptBtn.BackColor = Color.FromArgb(255, 255, 192);
                    corruptBtn.Text = ex.Message;
                }
            }
        }

        private static long RandUnsignedInRange(Random rng, long min, long max)
        {
            byte[] bytes = new byte[8];
            rng.NextBytes(bytes);
            ulong value = BitConverter.ToUInt64(bytes, 0);
            ulong umin = BitConverter.ToUInt64(BitConverter.GetBytes(min), 0);
            ulong umax = BitConverter.ToUInt64(BitConverter.GetBytes(max), 0);
            return BitConverter.ToInt64(BitConverter.GetBytes(umin + value % (umax - umin + 1)), 0);
        }

        private void refine_Click(object sender, EventArgs e)
        {
            Func<long, bool> IsAddressValid = new Func<long, bool>(this.IsAddressValid);
            ParseTextFields();
            
            try {
                min = BinarySearch.FindFirstTrue(IsAddressValid, min, max);
            } catch (ArgumentException) {
                MessageBox.Show("No valid addresses were found in the given range.", "Error");
                return;
            }

            try {
                max = BinarySearch.FindFirstTrue(IsAddressValid, min, max, true) - 1;
            } catch (ArgumentException) {
                MessageBox.Show("This range is most likely entirely valid.", "Success");
                return;
            }

            rangeMin.Value = min;
            rangeMax.Value = max;
        }

        private bool IsAddressValid(long addr)
        {
            try {
                selProc.ReadByte(addr);
            } catch (InvalidOperationException) {
                return false;
            }
            return true;
        }

        private void shiftLeft_Click(object sender, EventArgs e)
        {
            rangeMin.Value -= shiftAmount.Value;
            rangeMax.Value -= shiftAmount.Value;
        }

        private void shiftRight_Click(object sender, EventArgs e)
        {
            rangeMin.Value += shiftAmount.Value;
            rangeMax.Value += shiftAmount.Value;
        }

        private void useRangeSize_CheckedChanged(object sender, EventArgs e)
        {
            rangeMax.Enabled = !useRangeSize.Checked;
            rangeSize.Enabled = useRangeSize.Checked;
            refine.Enabled = !useRangeSize.Checked;
        }

        private void UpdateRangeMaxOrSize()
        {
            if (useRangeSize.Checked) {
                rangeMax.Value = rangeMin.Value + (long)rangeSize.Value - 1;
            } else {
                rangeSize.Value = rangeMax.Value - rangeMin.Value + 1;
            }
        }

        private void rangeSize_ValueChanged(object sender, EventArgs e)
        {
            UpdateRangeMaxOrSize();
        }

        private void rangeMax_TextChanged(object sender, EventArgs e)
        {
            UpdateRangeMaxOrSize();
        }

        private void rangeMin_TextChanged(object sender, EventArgs e)
        {
            UpdateRangeMaxOrSize();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            if (selProc == null) {
                Rectangle rect = selectBtn.ClientRectangle;
                rect.Offset(selectBtn.Location);
                rect.Inflate(2, 2);
                e.Graphics.FillRectangle(Brushes.Lime, rect);
            }
        }

        private void useSeed_CheckedChanged(object sender, EventArgs e)
        {
            seedBox.Enabled = useSeed.Checked;
        }

        private void bctRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (bctRandom.Checked) {
                bctRandomMin.Enabled = true;
                bctRandomMax.Enabled = true;
                bctArithmeticParam.Enabled = false;
            } else {
                bctRandomMin.Enabled = false;
                bctRandomMax.Enabled = false;
                bctArithmeticParam.Enabled = true;
            }
        }

        private byte GetReplacementByte(byte oldByte)
        {
            // A random byte is drawn even if the replacement bytes aren't randomized.
            // This is to keep seeds consistent with different settings.
            byte[] b = new byte[1];
            rng.NextBytes(b);
            byte random = b[0];

            if (bctRandom.Checked) {
                return (byte)(random % 256 % (bctRandomMax.Value - bctRandomMin.Value + 1) + (byte)bctRandomMin.Value);
            } else if (bctAdd.Checked) {
                return (byte)((oldByte + (byte)bctArithmeticParam.Value) % 256);
            } else if (bctXor.Checked) {
                return (byte)(oldByte ^ (byte)bctArithmeticParam.Value);
            } else if (bctAnd.Checked) {
                return (byte)(oldByte & (byte)bctArithmeticParam.Value);
            } else if (bctOr.Checked) {
                return (byte)(oldByte | (byte)bctArithmeticParam.Value);
            } else {
                return 0; //should never happen
            }
        }

        private void copySeedBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(seedBox.Value.ToString());
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void rangeSizeRadix_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rangeSize.Hexadecimal = !rangeSize.Hexadecimal;
            rangeSizeRadix.Font = new Font(rangeSizeRadix.Font, rangeSize.Hexadecimal ? FontStyle.Regular : FontStyle.Strikeout);
            rangeSizeRadix.LinkVisited = !rangeSize.Hexadecimal;
        }
    }
}
