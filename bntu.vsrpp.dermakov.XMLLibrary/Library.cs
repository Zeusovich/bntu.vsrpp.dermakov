// <copyright file="Library.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace bntu.vsrpp.dermakov.Core
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    /// <summary>
    /// Библиотека для работы с XML.
    /// </summary>
    public class Library
    {
        /// <summary>
        /// метод возвращает кол-во обьектов в файле.
        /// </summary>
        /// <param name="filePath"> Путь к файлу. </param>
        /// <returns> Кол-во элементов. </returns>
        public int GetNumberOfElements(string filePath)
        {
            int count = 0;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filePath);
            XmlElement xRoot = xDoc.DocumentElement;

            // выбор всех дочерних узлов
            XmlNodeList childnodes = xRoot.SelectNodes("Student");
            foreach (XmlNode n in childnodes)
            {
                count++;
            }

            return count;
        }

        /// <summary>
        /// Метод для поиска аттрибутов с интовым значением.
        /// </summary>
        /// <param name="filePath"> Путь к файлу. </param>
        /// <returns> лист интовых аттрибутов. </returns>
        public List<string> FindIntElements(string filePath)
        {
            List<XmlElement> objects = ReadDoc(filePath);
            List<string> names = new List<string>();

            foreach (XmlElement xmlNode in objects)
            {
                foreach (XmlElement childNode in xmlNode.ChildNodes)
                {
                    if (int.TryParse(childNode.InnerText, out _) && !names.Contains(childNode.Name))
                    {
                        names.Add(childNode.Name);
                        break;
                    }
                }
            }

            return names;
        }

        /// <summary>
        /// Метод для поиска аттрибутов со строковыми значениями.
        /// </summary>
        /// <param name="filePath"> Путь к файлу. </param>
        /// <returns> лист стринговых аттрибутов. </returns>
        public List<string> FindStringElements(string filePath)
        {
            List<XmlElement> objects = ReadDoc(filePath);
            List<string> names = new List<string>();

            foreach (XmlElement xmlNode in objects)
            {
                foreach (XmlElement childNode in xmlNode.ChildNodes)
                {
                    if (!int.TryParse(childNode.InnerText, out _) && !names.Contains(childNode.Name))
                    {
                        names.Add(childNode.Name);
                    }
                }
            }

            return names;
        }

        /// <summary>
        /// Метод возвращает наибольшее значение числовых характеристик обьекта.
        /// </summary>
        /// <param name="filePath"> Путь к файлу. </param>
        /// <param name="name"> Параметр обьекта. </param>
        /// <returns> Максимальное значение чисел.</returns>
        public int MaxNumbersValue(string filePath, string name)
        {
            List<XmlElement> objects = ReadDoc(filePath);
            int maxValue = 0;
            var elementValue = 0;

            foreach (XmlElement xmlNode in objects)
            {
                foreach (XmlNode childNode in xmlNode.ChildNodes)
                {
                    if (childNode.Name.Equals(name))
                    {
                        elementValue = Convert.ToInt32(childNode.InnerText);
                    }
                }

                if (maxValue < elementValue)
                {
                    maxValue = elementValue;
                }
            }

            return maxValue;
        }

        /// <summary>
        /// Метод возвращает наименьшее значение числовых характеристик обьекта.
        /// </summary>
        /// <param name="filePath"> Путь к файлу.</param>
        /// <param name="name"> Выбранный элемент. </param>
        /// <returns> минимальное значение. </returns>
        public int MinNumbersValue(string filePath, string name)
        {
            List<XmlElement> objects = ReadDoc(filePath);
            int minValue = 0;
            var elementValue = 0;

            foreach (XmlElement xmlNode in objects)
            {
                foreach (XmlNode childNode in xmlNode.ChildNodes)
                {
                    if (childNode.Name.Equals(name))
                    {
                        elementValue = Convert.ToInt32(childNode.InnerText);
                    }
                }

                if (minValue > elementValue)
                {
                    minValue = elementValue;
                }
            }

            return minValue;
        }

        /// <summary>
        /// Метод возвращает среднее значение всех числовых характеристик обьекта.
        /// </summary>
        /// <param name="filePath"> Путь к файлу. </param>
        /// <param name="name"> Выбранный элемент. </param>
        /// <returns> Среднее значение интовых элементов в документе. </returns>
        public int AverageNumbersValue(string filePath, string name)
        {
            List<XmlElement> objects = ReadDoc(filePath);
            int averageValue = 0;

            foreach (XmlElement xmlNode in objects)
            {
                foreach (XmlNode childNode in xmlNode.ChildNodes)
                {
                    if (childNode.Name.Equals(name))
                    {
                        averageValue += Convert.ToInt32(childNode.InnerText);
                    }
                }
            }

            return averageValue / this.GetNumberOfElements(filePath);
        }

        /// <summary>
        /// Метод возвращает максимальную длину выбранного элемента.
        /// </summary>
        /// <param name="filePath"> Путь к файлу. </param>
        /// <param name="name"> Выбранный элемент. </param>
        /// <returns> Максимальное значение длины элемента. </returns>
        public int MaxStringsValue(string filePath, string name)
        {
            List<XmlElement> objects = ReadDoc(filePath);
            int maxValue = 0;
            int elementValue = 0;

            foreach (XmlElement xmlNode in objects)
            {
                foreach (XmlNode childNode in xmlNode.ChildNodes)
                {
                    if (childNode.Name.Equals(name))
                    {
                        elementValue = childNode.InnerText.Length;
                    }
                }

                if (maxValue < elementValue)
                {
                    maxValue = elementValue;
                }
            }

            return maxValue;
        }

        /// <summary>
        /// Запись файла.
        /// </summary>
        /// <param name="saveFileName"> Путь к файлу.</param>
        /// <param name="filePath"> Имя сохраненного файла.</param>
        public void WriteDoc(string saveFileName, string filePath)
        {
            List<XmlElement> objects = ReadDoc(filePath);

            var xmlDoc = new XmlDocument();
            var xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDoc.AppendChild(xmlDeclaration);

            XmlNode rootNode = xmlDoc.CreateElement("Students");

            foreach (XmlElement xnode in objects)
            {
                var student = xmlDoc.CreateElement("Student");
                foreach (XmlElement child in xnode.ChildNodes)
                {
                    switch (child.Name)
                    {
                        case "FIO":
                        case "FullName":
                            string[] fio = child.InnerText.Split(' ');
                            AddChildElement("FirstName", fio[1], student, xmlDoc);
                            AddChildElement("LastName", fio[2], student, xmlDoc);
                            AddChildElement("Surname", fio[0], student, xmlDoc);
                            break;
                        case "LastName":
                            AddChildElement(child.Name, child.InnerText, student, xmlDoc);
                            AddChildElement("Surname", "N/A", student, xmlDoc);
                            break;
                        default:
                            AddChildElement(child.Name, child.InnerText, student, xmlDoc);
                            break;
                    }
                }

                rootNode.AppendChild(student);
            }

            xmlDoc.AppendChild(rootNode);

            xmlDoc.Save(saveFileName);
        }

        /// <summary>
        /// Метод возвращает минимальную длину выбранного элемента.
        /// </summary>
        /// <param name="filePath"> Путь к файлу .</param>
        /// <param name="name"> Выбранный элемент. </param>
        /// <returns> Минимальное значение длины элемента. </returns>
        public int MinStringsValue(string filePath, string name)
        {
            List<XmlElement> objects = ReadDoc(filePath);
            int minValue = 0;
            int elementValue = 0;

            foreach (XmlElement xmlNode in objects)
            {
                foreach (XmlNode childNode in xmlNode.ChildNodes)
                {
                    if (childNode.Name.Equals(name))
                    {
                        elementValue = childNode.InnerText.Length;
                    }
                }

                if (minValue > elementValue)
                {
                    minValue = elementValue;
                }
            }

            return minValue;
        }

        /// <summary>
        /// Метод возвращает среднюю длину выбранного элемента.
        /// </summary>
        /// <param name="filePath"> Путь к файлу. </param>
        /// <param name="name"> Выбранный элемент .</param>
        /// <returns> Среднее значение длины элемента. </returns>
        public int AverageStringsValue(string filePath, string name)
        {
            List<XmlElement> objects = ReadDoc(filePath);
            int averageValue = 0;

            foreach (XmlElement xmlNode in objects)
            {
                foreach (XmlNode childNode in xmlNode.ChildNodes)
                {
                    if (childNode.Name.Equals(name))
                    {
                        averageValue += childNode.InnerText.Length;
                    }
                }
            }

            return averageValue / this.GetNumberOfElements(filePath);
        }

        /// <summary>
        /// Метод для получения листа обьектов их XML-файла.
        /// </summary>
        /// <param name="filePath"> Путь к файлу.</param>
        /// <returns> List. <XmlElement>. </returns>
        public static List<XmlElement> ReadDoc(string filePath)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filePath);
            XmlElement xRoot = xDoc.DocumentElement;

            List<XmlElement> objects = new List<XmlElement>();

            foreach (XmlElement xnode in xRoot)
            {
                objects.Add(xnode);
            }

            return objects;
        }

        /// <summary>
        /// Метод создает дочерний элемент.
        /// </summary>
        /// <param name="childName"> Дочерний элемент.</param>
        /// <param name="childText"> Значение дочернего элемента. </param>
        /// <param name="parentElement"> Имя родительского элемента. </param>
        /// <param name="xmlDoc"> XML.</param>
        private static void AddChildElement(string childName, string childText, XmlElement parentElement, XmlDocument xmlDoc)
        {
            var child = xmlDoc.CreateElement(childName);
            child.InnerText = childText;
            parentElement.AppendChild(child);
        }
    }
}

