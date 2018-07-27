using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;
using Vlc.DotNet.Core.Interops;
namespace VLCapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var VlcLibDirectory = new DirectoryInfo(@"..\..\..\lib\x64\");
            vlcControl1.BeginInit();
            vlcControl1.VlcLibDirectory = VlcLibDirectory;
            vlcControl1.VlcMediaplayerOptions = new string[] { "--custom-aspect-ratios=15:2" };
            //vlcControl1.VlcMediaplayerOptions = new string[] { ":no-video" };
            vlcControl1.EndInit();
        }
        ToolTip Aciklama = new ToolTip();
        private void Form1_Load(object sender, EventArgs e)
        {

            Aciklama.SetToolTip(button4, "Kısayol:Numpad +");
            metroTrackBar1.Enabled = false;
            sesGoster(50);
            hizYazdir();
            metroTrackBar1.Value = 0;

        }

        public void PlayMedia(string dosya, float rate)
        {
            this.vlcControl1.SetMedia(new Uri(dosya), vlcControl1.VlcMediaplayerOptions);
            //MessageBox.Show(vlcControl1.GetCurrentMedia().Title);
            vlcControl1.Rate = rate;
            this.vlcControl1.Play();
            timer1.Start();

        }

        private void vlcControl1_Click(object sender, EventArgs e)
        {
        }

        private void vlcControl1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vlcControl1.Pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vlcControl1.Rate += (float)0.10;
            hizYazdir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dosya = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Dosya Aç";
            ofd.Filter = "MP4 |*.mp4";
            ofd.InitialDirectory = @"D:/BatuhanYedek/";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dosya = "" + ofd.FileName + "";
                metroTrackBar1.Value = 0;
                metroTrackBar1.Enabled = true;
                PlayMedia(dosya, 1.00F);

                timer1.Start();
            }

        }

        private void vlcControl1_VlcLibDirectoryNeeded(object sender, VlcLibDirectoryNeededEventArgs e)
        {
            if (IntPtr.Size == 4)
                e.VlcLibDirectory = new DirectoryInfo(@"..\..\..\lib\x86\");
            else
                e.VlcLibDirectory = new DirectoryInfo(@"..\..\..\lib\x64\");
        }

        private void vlcControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            vlcControl1.Rate -= (float)0.10;
            hizYazdir();
        }

        private void hizYazdir()
        {
            label1.Text = "Mevcut Hız:" + Math.Round(vlcControl1.Rate, 2).ToString() + "x";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vlcControl1.Play();
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            vlcControl1.Rate = 1.00F;
            hizYazdir();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            vlcControl1.Audio.Volume = (int)trackBar1.Value;
            sesGoster();
        }

        private void sesGoster()
        {
            vlcControl1.Audio.Volume = trackBar1.Value;
            lbl_ses.Text = "Ses: " + trackBar1.Value;
        }

        private void sesGoster(int ses)
        {
            trackBar1.Value = ses;
            vlcControl1.Audio.Volume = trackBar1.Value;
            lbl_ses.Text = "Ses: " + trackBar1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                int sure1 = (int)vlcControl1.VlcMediaPlayer.Time / 60000;
                int sure2 = (int)vlcControl1.VlcMediaPlayer.Time / 1000 % 60;
                int sure3 = (int)vlcControl1.GetCurrentMedia().Duration.TotalSeconds / 60;
                int sure4 = (int)vlcControl1.GetCurrentMedia().Duration.TotalSeconds % 60;
                label2.Text = sure1.ToString() + ": " + sure2.ToString() + " / " + sure3.ToString() + ": " + sure4.ToString();
                metroTrackBar1.Value = (int)vlcControl1.VlcMediaPlayer.Time / 1000;
                metroTrackBar1.Maximum = (int)vlcControl1.GetCurrentMedia().Duration.TotalSeconds;
            }
            catch (System.ArgumentOutOfRangeException f)
            {

            }
            catch (System.NullReferenceException g)
            {
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            vlcControl1.Pause();
        }



        private void vlcControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                MessageBox.Show("You have pressed '+'");
                vlcControl1.Rate += (float)0.10;
                hizYazdir();
            }
            else if (e.KeyCode == Keys.Space)
            {
                MessageBox.Show("You have pressed 'Space'");
                vlcControl1.Pause();
            }
            else if (e.KeyCode == Keys.Up)
            {
                MessageBox.Show("You have pressed 'Up'");
                int ses = trackBar1.Value;
                ses += 6;
                sesGoster(ses);
            }
            else if (e.KeyCode == Keys.Down)
            {
                MessageBox.Show("You have pressed 'Down'");
                int ses = trackBar1.Value;
                ses -= 6;
                sesGoster(ses);
            }
        }

        private void vlcControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                MessageBox.Show("You have pressed '-'");
                vlcControl1.Rate -= (float)0.10;
                hizYazdir();
            }
            else if (e.KeyChar == (char)Keys.Up)
            {
                MessageBox.Show("You have pressed 'Up'");
                int ses = trackBar1.Value;
                ses += 6;
                sesGoster(ses);
            }
            else if (e.KeyChar == (char)Keys.Down)
            {
                MessageBox.Show("You have pressed 'Down'");
                int ses = trackBar1.Value;
                ses -= 6;
                sesGoster(ses);
            }
        }

        private void vlcControl1_Stopped(object sender, Vlc.DotNet.Core.VlcMediaPlayerStoppedEventArgs e)
        {
            MessageBox.Show("Test");
            //aleleyyo
        }

        private void vlcControl1_EndReached(object sender, Vlc.DotNet.Core.VlcMediaPlayerEndReachedEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void vlcControl1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                MessageBox.Show("You have pressed '+'");
                vlcControl1.Rate += (float)0.10;
                hizYazdir();
            }
            else if (e.KeyCode == Keys.Space)
            {
                MessageBox.Show("You have pressed 'Space'");
                vlcControl1.Pause();
            }
            else if (e.KeyCode == Keys.Up)
            {
                MessageBox.Show("You have pressed 'Up'");
                int ses = trackBar1.Value;
                ses += 6;
                sesGoster(ses);
            }
            else if (e.KeyCode == Keys.Down)
            {
                MessageBox.Show("You have pressed 'Down'");
                int ses = trackBar1.Value;
                ses -= 6;
                sesGoster(ses);
            }
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            string media = vlcControl1.GetCurrentMedia().ToString();
            if (media != null)
            {
                vlcControl1.VlcMediaPlayer.Time = metroTrackBar1.Value * 1000;
            }
            else
            {
                metroTrackBar1.Enabled = false;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void vlcControl1_MediaChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerMediaChangedEventArgs e)
        {

        }

        private void vlcControl1_TitleChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerTitleChangedEventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            vlcControl1.SetMedia(new Uri("D:/BatuhanYedek/Videos/sdfgh.mp4"), vlcControl1.VlcMediaplayerOptions);
            vlcControl1.Play();
        }
    }
}
