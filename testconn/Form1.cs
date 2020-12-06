using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace testconn
{
    public partial class Form1 : Form
        
    {
        public Form1()
        {
            InitializeComponent();
            Console.Out.WriteLine("Program started");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerPing.Enabled = true;
            this.IP1.Enabled = false;
            this.IP2.Enabled = false;
        }

        public void scrivioutput_a(string messaggio)
        {
            output_a.Items.Add(messaggio);
            int maxitems = output_a.Items.Count;
            output_a.SelectedIndex = maxitems-1;
        }

        public void scrivioutput_b(string messaggio)
        {
            output_b.Items.Add(messaggio);
            int maxitems = output_b.Items.Count;
            output_b.SelectedIndex = maxitems - 1;
        }

        public int hostping(string hosttoping)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = pingSender.Send(hosttoping, timeout, buffer, options);
            int returnvalue = timeout;
            if (reply.Status == IPStatus.Success)
            {
                //Console.WriteLine("Address: {0}", reply.Address.ToString());
                //Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                //Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                //Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                //Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
                returnvalue = Convert.ToInt32(reply.RoundtripTime);
            }
            return returnvalue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("stopbit received");
        }

        public void start_ping_Click(object sender, EventArgs e)
        {
            timerPing.Enabled = false;
            this.IP1.Enabled = true;
            this.IP2.Enabled = true;
        }

        private void timerPing_Tick(object sender, EventArgs e)
        {
            string host_a = Convert.ToString(this.IP1.Text);
            string host_b = Convert.ToString(this.IP2.Text);
            if (!string.IsNullOrEmpty(host_a))
            {
                Console.Out.WriteLine(hostping(host_a));
                scrivioutput_a(host_a + " - " + Convert.ToString(hostping(host_a)));
            }
            if (!string.IsNullOrEmpty(host_b))
            {
                Console.Out.WriteLine(hostping(host_b));
                scrivioutput_b(host_b + " - " + Convert.ToString(hostping(host_b)));
            }

        }
    }
}
