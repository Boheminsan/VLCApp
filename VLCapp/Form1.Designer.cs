namespace VLCapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ses = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vlcControl1);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 429);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.ForeColor = System.Drawing.Color.FloralWhite;
            this.vlcControl1.Location = new System.Drawing.Point(274, 0);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(570, 426);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 5;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = null;
            this.vlcControl1.VlcMediaplayerOptions = new string[] {
        "--video-title-timeout=5000"};
            this.vlcControl1.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl1_VlcLibDirectoryNeeded);
            this.vlcControl1.EndReached += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerEndReachedEventArgs>(this.vlcControl1_EndReached);
            this.vlcControl1.MediaChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerMediaChangedEventArgs>(this.vlcControl1_MediaChanged);
            this.vlcControl1.TitleChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerTitleChangedEventArgs>(this.vlcControl1_TitleChanged);
            this.vlcControl1.Stopped += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerStoppedEventArgs>(this.vlcControl1_Stopped);
            this.vlcControl1.Click += new System.EventHandler(this.vlcControl1_Click);
            this.vlcControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyDown);
            this.vlcControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vlcControl1_KeyPress);
            this.vlcControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.metroTrackBar1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_ses);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(5, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 138);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(222, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.metroTrackBar1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.metroTrackBar1.Location = new System.Drawing.Point(4, 89);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(1088, 23);
            this.metroTrackBar1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTrackBar1.TabIndex = 15;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTrackBar1.UseCustomBackColor = true;
            this.metroTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            this.metroTrackBar1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyDown);
            this.metroTrackBar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vlcControl1_KeyPress);
            this.metroTrackBar1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "00:00 / 00:00";
            // 
            // lbl_ses
            // 
            this.lbl_ses.AutoSize = true;
            this.lbl_ses.Location = new System.Drawing.Point(983, 17);
            this.lbl_ses.Name = "lbl_ses";
            this.lbl_ses.Size = new System.Drawing.Size(25, 13);
            this.lbl_ses.TabIndex = 12;
            this.lbl_ses.Text = "Ses";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(961, 41);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(118, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyDown);
            this.trackBar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vlcControl1_KeyPress);
            this.trackBar1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyUp);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(543, 41);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 35);
            this.button7.TabIndex = 11;
            this.button7.Text = "Normal Hız";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyDown);
            this.button7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vlcControl1_KeyPress);
            this.button7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyUp);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(235, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 35);
            this.button6.TabIndex = 10;
            this.button6.Text = "Play";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyDown);
            this.button6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vlcControl1_KeyPress);
            this.button6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mevcut Hız:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(468, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 35);
            this.button5.TabIndex = 8;
            this.button5.Text = "Hızı Azalt";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyDown);
            this.button5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vlcControl1_KeyPress);
            this.button5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyUp);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(618, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "Hızı Arttır";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyDown);
            this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vlcControl1_KeyPress);
            this.button4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyUp);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Durdur";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyDown);
            this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vlcControl1_KeyPress);
            this.button3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dosya Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyDown);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vlcControl1_KeyPress);
            this.button2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyDown);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vlcControl1_KeyPress);
            this.button1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "VLC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vlcControl1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vlcControl1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbl_ses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button8;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
    }
}

