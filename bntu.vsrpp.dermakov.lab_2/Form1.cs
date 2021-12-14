// <copyright file="Form1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace bntu.vsrpp.dermakov.lab_2
{
    using System;
    using System.Windows.Forms;
    using bntu.vsrpp.dermakov.lab2;

    /// <summary>
    /// Form.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var currencyController = new CurrencyController();

            var allRates = currencyController.GetRates();

            foreach (var id in allRates)
            {
                this.listBox1.Items.Add($" {id.Cur_Abbreviation} - {id.Cur_Name} кол-во {id.Cur_Scale} = {id.Cur_OfficialRate} BYN ({id.Cur_ID})");
            }

            foreach (var name in allRates)
            {
                this.comboBox1.Items.Add(name.Cur_Name);
                this.comboBox2.Items.Add(name.Cur_Name);
            }
        }

        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            var currencyController = new CurrencyController();
            var allRates = currencyController.GetRates();
            double curRate1 = 0;
            double curRate2 = 0;
            int curScale1 = 0;
            int curScale2 = 0;

            if (this.comboBox1.SelectedIndex > -1)
            {
                var rate1 = currencyController.GetRateByName(this.comboBox1.Items[this.comboBox1.SelectedIndex].ToString(), allRates);
                var scale1 = currencyController.GetScaleByName(this.comboBox1.Items[this.comboBox1.SelectedIndex].ToString(), allRates);
                curRate1 = rate1;
                curScale1 = scale1;
            }

            if (this.comboBox2.SelectedIndex > -1)
            {
                var rate2 = currencyController.GetRateByName(this.comboBox2.Items[this.comboBox2.SelectedIndex].ToString(), allRates);
                var scale2 = currencyController.GetScaleByName(this.comboBox2.Items[this.comboBox2.SelectedIndex].ToString(), allRates);
                curRate2 = rate2;
                curScale2 = scale2;
            }

            if (this.comboBox1.SelectedIndex > -1 && this.comboBox2.SelectedIndex > -1 && this.comboBox1.Text == "Белорусский рубль")
            {
                this.textBox2.Text = Convert.ToString(currencyController.ConverBynInCur(this.textBox1.Text, curRate2, curScale2));
            }
            else if (this.comboBox1.SelectedIndex > -1 && this.comboBox2.SelectedIndex > -1 && this.comboBox2.Text == "Белорусский рубль")
            {
                this.textBox2.Text = Convert.ToString(currencyController.ConverCurInByn(this.textBox1.Text, curRate1, curScale1));
            }
            else if (this.comboBox1.SelectedIndex > -1 && this.comboBox2.SelectedIndex > -1)
            {
                this.textBox2.Text = Convert.ToString(currencyController.ConverCurInCur(this.textBox1.Text, curRate1, curRate2, curScale1, curScale2));
            }
            else
            {
                this.textBox2.Text = "Выберите валюты!!!!!!";
            }
        }

        private void ButtonGraphics_Click(object sender, EventArgs e)
        {
            GraphicForm graphicForm = new();
            graphicForm.ShowDialog();
        }
    }
}
