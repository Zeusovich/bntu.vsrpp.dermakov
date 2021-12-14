using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bntu.vsrpp.dermakov.lab2;
using Newtonsoft.Json;

namespace bntu.vsrpp.dermakov.lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("https://www.nbrb.by/api/exrates/");

            request.Method = "POST";

            request.ContentType = "application/x-www-urlencoded";

            WebResponse response = await request.GetResponseAsync();

            string answer = string.Empty;

            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    answer = await reader.ReadToEndAsync();
                }
            }

            response.Close();

            richTextBox1.Text = answer;
        }

        //CurrencyResponse currencyResponse = JsonConvert.DeserializeObject<CurrencyResponse>(response);


        /*private void button1_Click(object sender, EventArgs e)
                {
                    textBox1.Text = Convert.ToString("Cur_ID");
                }*/
    }
}
