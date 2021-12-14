using System;
using System.Xml;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using bntu.vsrpp.dermakov.lab1;
using bntu.vsrpp.dermakov.Core;

namespace bntu.vsrpp.dermakov
{
    public partial class Form1 : Form
    {
        public string filePath = "lab1_example1.xm";
        public Library xLib = new Library();
        public List<XmlElement> objects = new List<XmlElement>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия кнопки,позволяющий открыть определенный файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "E:\\";
                openFileDialog.Filter = "XML files (*.xm|*.xm|All files (*.*)|*.*)";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            textBoxNumberOfElements.Text = Convert.ToString(xLib.GetNumberOfElements(filePath));
            if (checkBoxMaxNumber.Checked == true)
                textBoxMaxNumber.Text = Convert.ToString(xLib.MaxNumbersValue(filePath, Statement.name));
            if (checkBoxMinNumber.Checked == true)
                textBoxMinNumber.Text = Convert.ToString(xLib.MinNumbersValue(filePath, Statement.name));
            if (checkBoxAverageNumber.Checked == true)
                textBoxAverageNumber.Text = Convert.ToString(xLib.AverageNumbersValue(filePath, Statement.name));
            if (checkBoxMaxLength.Checked == true)
                textBoxMaxLength.Text = Convert.ToString(xLib.MaxStringsValue(filePath, Statement.name));
            if (checkBoxMinLength.Checked == true)
                textBoxMinLength.Text = Convert.ToString(xLib.MinStringsValue(filePath, Statement.name));
            if (checkBoxAverageLength.Checked == true)
                textBoxAverageLength.Text = Convert.ToString(xLib.AverageStringsValue(filePath, Statement.name));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            xLib.WriteDoc("lab1_example1_output.xml", filePath);
            MessageBox.Show("Все прошло успешно! Файл сохранен!", "Сохранение файла прошло успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonListNumbers_Click(object sender, EventArgs e)
        {
            ListForm listForm = new(xLib.FindIntElements(filePath), this);
            listForm.ShowDialog();
        }

        private void buttonListStrings_Click(object sender, EventArgs e)
        {
            ListForm listForm = new(xLib.FindStringElements(filePath), this);
            listForm.ShowDialog();
        }
    }
}
