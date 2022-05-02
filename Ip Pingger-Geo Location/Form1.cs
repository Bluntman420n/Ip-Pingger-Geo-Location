using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using Ip_Pigger_Geo_Location.Func;

namespace Ip_Pigger_Geo_Location
{
    public partial class Form1 : Form
    {
        bool NonStop = false;
        int Timesran = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(NonStop == true)
            {
                IpPingernonstop();
            }
            else
            {
                if(TimesToRun.Value == 0)
                {
                    MessageBox.Show("Please Put A Ammount In The Times To Run Or Check Non Stop.", "Ip Pingger Geo Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    IpPingerWithtimes();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            NonStop = checkBox1.Enabled;
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "")
            {
                MessageBox.Show("Please use valid IP or web address!!");
            }
        }

        private void Geo_btn_Click(object sender, EventArgs e)
        {
            var Ip_Api_Url = "http://ip-api.com/json/" + textBox1.Text;
            // Use HttpClient to get the details from the Json response
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                // Pass API address to get the Geolocation details 
                httpClient.BaseAddress = new Uri(Ip_Api_Url);
                HttpResponseMessage httpResponse = httpClient.GetAsync(Ip_Api_Url).GetAwaiter().GetResult();
                // If API is success and receive the response, then get the location details
                if (httpResponse.IsSuccessStatusCode)
                {
                    var geolocationInfo = httpResponse.Content.ReadAsAsync<LocationDetails_IpApi>().GetAwaiter().GetResult();
                    if (geolocationInfo != null)
                    {
                        IP_Lab.Text = "IP: " + geolocationInfo.query;
                        ISP_Lab.Text = "ISP: " + geolocationInfo.isp;
                        Lat_Lab.Text = "Latitude: " + geolocationInfo.lat;
                        Long_Lab.Text = "Longitude: " + geolocationInfo.lon;
                        County_Lab.Text = "Country: " + geolocationInfo.country;
                        Region_Lab.Text = "Region: " + geolocationInfo.regionName;
                        City_Lab.Text = "City: " + geolocationInfo.city;
                        Zip_Lab.Text = "Zip: " + geolocationInfo.zip;
                        TimeZone_Lab.Text = "TimeZone: " + geolocationInfo.timezone;
                    }
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           if(textBox1.Text == "")
            {

            }
           else
            {
                if (NonStop == true)
                {
                    NonStop = false;
                    Going.Stop();
                }
                else
                {
                    if (Timesran == TimesToRun.Value)
                    {

                    }
                    else
                    {
                        Timesran = Convert.ToInt32(TimesToRun.Value);
                    }
                }
            }
        }

        public void IpPingernonstop()
        {
          if(NonStop == true)
            {
                Going.Start();
            }
        }

        public void IpPingerWithtimes()
        {
            try
            {
                if (Timesran == TimesToRun.Value)
                {

                }
                else
                {
                    Ping p = new Ping();
                    PingReply r;
                    string s;
                    s = textBox1.Text;
                    r = p.Send(s);

                    if (r.Status == IPStatus.Success)
                    {
                        if (lblResult.Lines.Count() == 20)
                        {
                            lblResult.Clear();
                            if (r.Status == IPStatus.Success)
                            {
                                lblResult.Text += "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Successful"
                                   + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n";
                            }
                            else
                            {
                                lblResult.Text += "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Failed"
                                + "\n" + "That Hoe Got Smacked!";
                            }
                        }
                        else
                        {
                            if (r.Status == IPStatus.Success)
                            {
                                lblResult.Text += "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Successful"
                                   + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n";
                            }
                            else
                            {
                                lblResult.Text += "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Failed"
                                + "\n" + "That Hoe Got Smacked!";
                            }
                        }
                    }
                    else
                    {
                        if (lblResult.Lines.Count() == 20)
                        {
                            lblResult.Clear();
                            lblResult.Text += "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Failed"
                                + "\n" + "That Hoe Got Smacked!";
                        }
                        else
                        {
                            lblResult.Text += "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Failed"
                                + "\n" + "That Hoe Got Smacked!";
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void Going_Tick(object sender, EventArgs e)
        {
            try
            {

                Ping p = new Ping();
                PingReply r;
                string s;
                s = textBox1.Text;
                r = p.Send(s);
                if (r.Status == IPStatus.Success)
                {
                    if (lblResult.Lines.Count() == 20)
                    {
                        lblResult.Clear();
                        if (r.Status == IPStatus.Success)
                        {
                            lblResult.Text += "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Successful"
                               + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n";
                        }
                        else
                        {
                            lblResult.Text += "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Failed"
                            + "\n" + "That Hoe Got Smacked!";
                        }
                    }
                    else
                    {
                        if (r.Status == IPStatus.Success)
                        {
                            lblResult.Text += "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Successful"
                               + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n";
                        }
                        else
                        {
                            lblResult.Text += "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Failed"
                            + "\n" + "That Hoe Got Smacked!";
                        }
                    }
                }
            }
            catch
            {
                Going.Stop();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Zip_Lab_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }

  
}
