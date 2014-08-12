using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.DesktopFacebook
{
    public partial class FormSlideShow : Form
    {
        public MyPictureBoxGeneral PictureBoxToSet { get; set; }

        public Timer Timer { get; set; }

        public FormSlideShow()
        {
            this.InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = true;
            buttonStart.Enabled = false;
            Timer.Enabled = true;
            //Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.PictureBoxToSet != null)
            {
                this.PictureBoxToSet = this.PictureBoxToSet.HandleRequest(this.pictureBoxSlideShow);
            }
            else
            {
                this.stopTimer();
                MessageBox.Show("slide show is over", string.Empty, MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.stopTimer();
            buttonStart.Text = "Continue";
            buttonStart.Enabled = true;
        }

        private void stopTimer()
        {
            buttonStop.Enabled = false;
            Timer.Enabled = false;
            Timer.Stop();
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            int interval = int.MinValue;
            if (int.TryParse(textBoxInterval.Text, out interval) == true)
            {
                if (interval < 0)
                {
                    MessageBox.Show("You have entered a negative number, changing automatically to positive ", string.Empty, MessageBoxButtons.OK);
                    interval = Math.Abs(interval);
                    textBoxInterval.Text = string.Format("{0}", interval);
                }

                buttonApprove.Visible = false;
                textBoxInterval.Visible = false;
                buttonStart.Enabled = true;
                Timer = new Timer();
                this.Timer.Tick += new EventHandler(this.Timer_Tick);
                Timer.Interval = interval * 1000;
            }
            else
            {
                MessageBox.Show("Invalid input", string.Empty, MessageBoxButtons.OK);
                buttonStart.Enabled = false;
            }
        }

        private void FormSlideShow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Timer.Enabled = false;
            Timer.Stop();
        }
    }
}