using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace TextReplicator
{
    public partial class Form1 : MaterialForm
    {
        BackgroundWorker bgw;
        int TimeToWait;

        public Form1()
        {
            InitializeComponent();

            // stuff for materialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue300, Primary.Blue300, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            // declare a new BackgroundWorker
            bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler
                    (bgw_RunWorkerCompleted);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.notifyIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(); // add a ContextMenuStrip to the notifyIcon
            this.notifyIcon.ContextMenuStrip.Items.Add("Open", null, this.MenuOpen_Click); // add an "Open" option to the CMS
            this.notifyIcon.ContextMenuStrip.Items.Add("Exit", null, this.MenuExit_Click); // add an "Exit" option to the CMS
        }

        void MenuOpen_Click(object sender, EventArgs e)
        {
            Show(); // make the window visible again
            this.WindowState = FormWindowState.Normal; // restore the window state
        }

        void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // close the application
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            TimeToWait = sliderTime.Value; // temporarily store the Value of sliderTime to reset it once we're done
            sliderTime.Text = "Countdown"; // replace the sliderTime text with "Countdown" to use it as a countdown
            sliderTime.UseAccentColor = false; // change the colors a little bit
            sliderTime.Enabled = false; // disable user interaction with the countdown

            bgw.RunWorkerAsync(); // fire up the bgw
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = sliderTime.Value; i > 0; i--)
            {
                System.Threading.Thread.Sleep(1000); // wait 1 second
                sliderTime.Value = i-1; // change the value of SliderTime with the number of remaining seconds, to use it as a countdown
            }
        }

        void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SendKeys.Send(textBoxText.Text); // write the textBox contents

            if (checkBoxENTER.Checked)
                SendKeys.Send("{Enter}");

            sliderTime.Value = TimeToWait; // restore the sliderTime value back to the one that was set before
            sliderTime.Text = "wait time"; // restore the sliderTime text
            sliderTime.UseAccentColor = true; // restore its colors
            sliderTime.Enabled = true; // re-enable user interaction

            this.Hide();
        }

        private void btnHideShow_Click(object sender, EventArgs e)
        {
            if (textBoxText.Password) // if textBoxText contents are hidden
            {
                textBoxText.Password = false; // make them visible
                btnHideShow.Icon = TextReplicator.Properties.Resources.eye_off_outline_1_; // change the button icon accordingly
            }
            else // otherwise, if textBoxText contents are visible
            {
                textBoxText.Password = true; // hide them
                btnHideShow.Icon = TextReplicator.Properties.Resources.eye_outline; // change the button icon accordingly
            }
        }

        private void textBoxText_TextChanged(object sender, EventArgs e)
        {
            if (textBoxText.Text.Length != 0) // if there's anything in the textBox
            {
                btnGo.Enabled = true; // enable the GO buttonr
            }
            else // if there's nothing
            {
                btnGo.Enabled = false; // disable the button
            }
        }

        private void Form1_Resize(object sender, EventArgs e) // this is fired up everythime the window is resized (i.e. when the form is minimized)
        {
            if (WindowState == FormWindowState.Minimized) // if the form is getting minimized
            {
                this.Hide(); // hide its icon from the taskbar
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) // when the notifyIcon is double clicked
        {
            Show(); // make the window visible again
            this.WindowState = FormWindowState.Normal; // restore the window state
        }

        private void btnAIO_Click(object sender, EventArgs e) // this button gets the text that's currently in the clipboard and uses it without manual pasting
        {
            TimeToWait = sliderTime.Value; // temporarily store the Value of sliderTime to reset it once we're done
            sliderTime.Text = "Countdown"; // replace the sliderTime text with "Countdown" to use it as a countdown
            sliderTime.UseAccentColor = false; // change the colors a little bit
            sliderTime.Enabled = false; // disable user interaction with the countdown

            textBoxText.Text = Clipboard.GetText(); // place the clipboard contents into the TextBox
            bgw.RunWorkerAsync(); // fire up the bgw
        }
    }
}