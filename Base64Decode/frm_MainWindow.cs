using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64Decode
{
    public partial class frm_MainWindow : Form
    {
        public frm_MainWindow()
        {
            InitializeComponent();
        }


        private string DecodeBase64String(string input)
        {
            return Encoding.UTF8.GetString((byte[])Convert.FromBase64String(input));
        }

        private void btn_DecodeBase64Garbage_Click(object sender, EventArgs e)
        {
            if (this.rtb_Base64_Input.Text.Length > 0)
            { 
                try
                {
                    this.rtb_Base64_Output.Text = DecodeBase64String(this.rtb_Base64_Input.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Your input is not a valid Base64 string. Double check the format and try again.", "Fatal PEBKAC Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("You need to enter something into the input box before trying to decode.", "Fatal PEBKAC Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
