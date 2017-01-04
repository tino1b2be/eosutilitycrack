using System;
using System.Windows.Forms;
using System.Diagnostics;
using EOSUtilityCrack.src;

namespace EOSUtilityCrack
{
    public partial class CrackForm : Form
    {
        public CrackForm()
        {
            this.CenterToScreen();
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
                MessageBox.Show(
                    "Done! You can now install the Canon EOS Utility software.",
                    "Successfully Cracked",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            catch (Exception ex)
            {
                // Error occured.
                MessageBox.Show(
                    ex.Message,
                    "Error crack not successful.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
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
            Process.Start("https://tino1b2be.com/eosutilitycrack");
        }

    }

}
