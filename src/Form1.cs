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
using Microsoft.Win32;
using WindowsFormsApplication1.src;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the crack button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                RegistryEdit.crack();
                MessageBox.Show("It works!");
            }
            catch (Exception ex)
            {
                // Error occured.
                MessageBox.Show(ex.Message, "Error creating registry entry.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
        }

        /// <summary>
        /// Event handler for the download link.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.usa.canon.com/internet/portal/us/home/support/self-help-center/eos-utility");
        }

        /// <summary>
        /// Event Handler for the Logo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://tino1b2be.com");
        }
    }

}
