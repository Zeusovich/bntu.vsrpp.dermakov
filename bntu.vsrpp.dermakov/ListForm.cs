using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bntu.vsrpp.dermakov.lab1
{
    public partial class ListForm : Form
    {
        private Form1 form1;
        //public string Name { get; set; }
        public ListForm(List<string> names, Form1 form1)
        {
            InitializeComponent();
            foreach (string name in names)
                listBox1.Items.Add(name);
            this.form1 = form1;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string name = "";
            if (listBox1.SelectedIndex > -1)
                name = listBox1.Items[listBox1.SelectedIndex].ToString();
            Statement.name = name;
            this.Close();
        }

    }
}
