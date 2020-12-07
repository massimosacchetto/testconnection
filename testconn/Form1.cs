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
using System.Windows.Forms.DataVisualization.Charting;

namespace testconn
{
    public partial class Form1 : Form
        
    {
        const int PINGVETT = 30; 
        //public int pingDeth = 20;
        public int[] chartMainSeries = new int[PINGVETT];
        public int[] chartSeries1 = new int[PINGVETT];
        public int[] chartSeries2 = new int[PINGVETT];
        public int pingDeth = PINGVETT;

        public Form1()
        {
            InitializeComponent();
            Console.Out.WriteLine("Program started");
            //chartSeries1[1] = 80; //Cambiare questo parametro se si vuole dare una scala massima
            //chartSeries2[1] = 80; //Cambiare questo parametro se si vuole dare una scala massima
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
            //ping 1
            if (!string.IsNullOrEmpty(host_a))
            {
                int maxvett = pingDeth - 1;
                //Console.Out.WriteLine(hostping(host_a));
                for (int i = 0; i < maxvett; i++)
                {
                    chartSeries1[i] = chartSeries1[i + 1];
                }
                chartSeries1[maxvett] = hostping(host_a);

                scrivioutput_a(host_a + " - " + Convert.ToString(chartSeries1[maxvett]));
                generagrafico1();
                

            }

            //ping 2
            if (!string.IsNullOrEmpty(host_b))
            {
                int maxvett = pingDeth - 1;
                //.Out.WriteLine(hostping(host_b));
                for (int i = 0; i < maxvett; i++)
                {
                    chartSeries2[i] = chartSeries2[i + 1];
                }
                chartSeries2[maxvett] = hostping(host_b);

                scrivioutput_b(host_b + " - " + Convert.ToString(chartSeries2[maxvett]));
                generagrafico2();

            }

        }

        private void generagrafico1()
        {
            //inizializzazione grafico1
            chart1.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "ms",
                Color = System.Drawing.Color.Blue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            };

            chart1.Series.Add(series1);
            for (int i = 0; i < pingDeth; i++)
            {
                // Add series.
                series1.Points.AddXY(i, chartSeries1[i]);
            }
            chart1.ChartAreas[0].RecalculateAxesScale();
        }
        private void generagrafico2()
        {
            //inizializzazione grafico2
            chart2.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "ms",
                Color = System.Drawing.Color.Red,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            };

            chart2.Series.Add(series1);
            for (int i = 0; i < pingDeth; i++)
            {
                // Add series.
                series1.Points.AddXY(i, chartSeries2[i]);
            }
            chart2.ChartAreas[0].RecalculateAxesScale();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
