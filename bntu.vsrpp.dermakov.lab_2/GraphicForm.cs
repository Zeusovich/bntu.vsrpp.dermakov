// <copyright file="GraphicForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace bntu.vsrpp.dermakov.lab2
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using bntu.vsrpp.dermakov.lab_2;
    using OxyPlot;
    using OxyPlot.Series;
    using OxyPlot.WindowsForms;

    /// <summary>
    /// Graphic form.
    /// </summary>
    public partial class GraphicForm : Form
    {
        private DateTime date1;
        private DateTime date2;

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphicForm"/> class.
        /// </summary>
        public GraphicForm()
        {
            this.InitializeComponent();

            var currencyController = new CurrencyController();
            var allRates = currencyController.GetRates();
            allRates.RemoveAt(0);

            foreach (var name in allRates)
            {
                this.comboBox1.Items.Add(name.Cur_Name);
            }
        }

        private void ButtonGraphic_Click(object sender, EventArgs e)
        {
            var currencyController = new CurrencyController();
            OxyPlot.WindowsForms.PlotView pv = new PlotView
            {
                Location = new Point(0, 0),
                Size = new Size(400, 400),
            };
            this.Controls.Add(pv);
            pv.Model = new PlotModel { Title = "Graphic" };

            FunctionSeries fs = new FunctionSeries();
            this.date1 = this.dateTimePicker1.Value;
            this.date2 = this.dateTimePicker2.Value;

            TimeSpan differDate = this.date2.Subtract(this.date1);
            int days = 0;
            days = differDate.Days;

            double[] rates = currencyController.GetRateOnDate(days, this.comboBox1.Items[this.comboBox1.SelectedIndex].ToString(), this.date1);

            for (int i = 0; i < days; i++)
            {
                fs.Points.Add(new DataPoint(i, rates[i]));
            }

            pv.Model.Series.Add(fs);
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.date1 = this.dateTimePicker1.Value;
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.date2 = this.dateTimePicker2.Value;
        }
    }
}
