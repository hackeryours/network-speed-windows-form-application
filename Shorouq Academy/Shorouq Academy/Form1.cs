using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace Shorouq_Academy
{
    public partial class Form1 : Form
    {
        private Timer tmr;

        public Form1()
        {
            InitializeComponent();
            closebtn.FlatAppearance.BorderSize = 0;
            closebtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            closebtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static double Speed(string url)
        {
            //class used to download data
            WebClient wc = new WebClient();
            //date before downloading data from the url
            DateTime dt1 = DateTime.Now;
            byte[] data = wc.DownloadData(url);
            //date after downloading data
            DateTime dt2 = DateTime.Now;
            ///getting internet speed byt diving data on the delta of the after and before dates
            return (data.Length * 8) / (dt2 - dt1).TotalSeconds;
        }
        private void tmr_Tick(object sender, EventArgs e)
        {
            double speed = Speed("https://www.google.com");
            speed = Math.Round(speed, 2) / 1000;
            speedtxt.Text = speed.ToString("F2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Interval = 1000; // in miliseconds;
            tmr.Start();
            
        }
    }
}
