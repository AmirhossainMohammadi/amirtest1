using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work_with_RestApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
           string respons= GetImageInsta();
            txtResponse.Text = respons;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string respons= GetStatusFace();
            txtResponse.Text = respons;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string respons = GetTwitt();
            txtResponse.Text = respons;
        }


        private string GetStatusFace()
        {
            RestClient Rclient2 = new RestClient();
            Rclient2.endpoint = "https://graph.facebook.com/v3.3/100035782685622/statuses?access_token=EAAPs2xRSIzkBAMFZALJkZBWXZAwjAZCwQCrYaiwBh7dt0eVIWSISH1RcZApUmQOVZBqpbzMpZAe9qBCZBlIGuwMIsZCrVEpv5KMgcLFMWZBX6ZBTsLAZB04Kuyw8hLGaAtn8Cc1tXTPp3hL03f9HQ3xf8LeIkXjXVPPEjlsIgluAEmbDQvHucuMvLRBsbpmHeVFziZBMZD";
            string strRespons = Rclient2.MakeRequest();
            return strRespons;
        }


        private string GetImageInsta()
        {
            RestClient Rclient1 = new RestClient();
            Rclient1.endpoint =
                "https://api.instagram.com/v1/users/self/media/recent/?access_token=3933892251.2082283.c66bbbf2bda148c6983a7fbfc20c8121";
            string strRespons = Rclient1.MakeRequest();

            return strRespons;
        }

        public string GetTwitt()
        {
            RestClient Rclient3 = new RestClient();
            Rclient3.endpoint = "https://api.twitter.com/1.1/statuses/home_timeline.json";
            string strRespons = Rclient3.MakeRequest();

            return strRespons ;
        }


    }
}
