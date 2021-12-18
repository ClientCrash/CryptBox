using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CryptBox
{
    public partial class Form1 : Form
    {
        String[] args;
        public Form1(String[] args)
        {
            InitializeComponent();
            this.args = args;

        }

        private void issueButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/clientcrash/cryptbox/issue",
                UseShellExecute = true
            });
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (args.Length < 2)
            {
                MessageBox.Show("Check failed. No CMD arguments specified. For issues look at https://github.com/clientcrash/cryptbox.", "CryptBox");
                this.Close();
            }
            else
            {
                jobnamelabel.Text = args[1];
                bool success = CheckingUtils.checkAllFiles(args);
                if (!success)
                {
                    Environment.Exit(-1);
                }
                else
                {
                    Environment.Exit(0);
                }


            }

        }
    }
}
