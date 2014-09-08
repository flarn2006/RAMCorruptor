using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace RAMCorruptor.UserControls
{
    public class HexTextBox : TextBox
    {
        private long hexValue, defaultVal;
        private bool autoFallback = true;

        public HexTextBox()
        {
            Text = "0";
            hexValue = 0;
            defaultVal = 0;
        }

        private bool UpdateValue()
        {
            if (Int64.TryParse(Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out hexValue)) {
                BackColor = SystemColors.Window;
                return true;
            } else {
                BackColor = Color.FromArgb(255, 192, 192);
                System.Media.SystemSounds.Beep.Play();
                hexValue = defaultVal;
                return false;
            }
        }

        [DefaultValue(0L)]
        [RefreshProperties(RefreshProperties.All)]
        public long Value
        {
            get { return hexValue; }
            set
            {
                hexValue = value;
                Text = hexValue.ToString("X");
            }
        }

        [DefaultValue(0L)]
        [Description("Gets or sets the value to use if an invalid hex number is entered.")]
        public long FallbackValue
        {
            get { return defaultVal; }
            set
            {
                defaultVal = value;
                UpdateValue();
            }
        }

        [DefaultValue(true)]
        [Description("Determines whether or not to automatically set the fallback value to the last valid value contained.")]
        public bool AutoFallback
        {
            get { return autoFallback; }
            set { autoFallback = value; }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (AutoFallback && UpdateValue()) {
                FallbackValue = Value;
            }
            base.OnTextChanged(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Value = Value; //doesn't do nothing; Value is a property.
        }

        [DefaultValue("0")]
        [RefreshProperties(RefreshProperties.All)]
        public override string Text { get { return base.Text; } set { base.Text = value; } }
    }
}
