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

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue300, Primary.Blue300, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler
                    (bgw_RunWorkerCompleted);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.notifyIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.notifyIcon.ContextMenuStrip.Items.Add("Open", null, this.MenuOpen_Click);
            this.notifyIcon.ContextMenuStrip.Items.Add("Exit", null, this.MenuExit_Click);
        }

        void MenuOpen_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            TimeToWait = sliderTime.Value;
            sliderTime.Text = "Countdown";
            sliderTime.UseAccentColor = false;
            sliderTime.Enabled = false;

            bgw.RunWorkerAsync();
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = sliderTime.Value; i > 0; i--)
            {
                System.Threading.Thread.Sleep(1000); // aspetto 1 secondo
                sliderTime.Value = i-1; // cambio il value di SliderTime col numero di secondi rimanenti per usarlo come un countdown
            }
        }

        void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SendKeys.Send(textBoxText.Text);

            sliderTime.Value = TimeToWait; // reimposto il value di SliderTime a quello impostato in precedenza
            sliderTime.Text = "wait time";
            sliderTime.UseAccentColor = true;
            sliderTime.Enabled = true;
        }

        private void btnHideShow_Click(object sender, EventArgs e)
        {
            if (textBoxText.Password)
            {
                textBoxText.Password = false;
                btnHideShow.Icon = TextReplicator.Properties.Resources.eye_off_outline_1_;
            }
            else
            {
                textBoxText.Password = true;
                btnHideShow.Icon = TextReplicator.Properties.Resources.eye_outline;
            }
        }

        private void textBoxText_TextChanged(object sender, EventArgs e)
        {
            if (textBoxText.Text.Length != 0)
            {
                btnGo.Enabled = true;
            }
            else
            {
                btnGo.Enabled = false;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                this.Hide();
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void btnAIO_Click(object sender, EventArgs e)
        {
            TimeToWait = sliderTime.Value;
            sliderTime.Text = "Countdown";
            sliderTime.UseAccentColor = false;
            sliderTime.Enabled = false;

            textBoxText.Text = Clipboard.GetText();
            bgw.RunWorkerAsync();
        }
    }
}