// <copyright file="CurrencyController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace bntu.vsrpp.dermakov.lab2
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using Newtonsoft.Json;

    /// <summary>
    /// Класс для работы с валютой.
    /// </summary>
    public class CurrencyController
    {
        /// <summary>
        /// Метод возвращает все возможные кодировки валют.
        /// </summary>
        /// <returns> Список кодировок валют. </returns>
        static List<Currency> GetAllCur()
        {
            WebRequest request = WebRequest.Create("https://www.nbrb.by/api/exrates/currencies");
            request.Method = "GET";
            request.ContentType = "application/x-www-urlencoded";

            WebResponse response = request.GetResponse();

            string json = string.Empty;

            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    json = reader.ReadToEnd();
                }
            }

            response.Close();

            List<Currency> currencies = JsonConvert.DeserializeObject<List<Currency>>(json);

            return currencies;
        }

        /// <summary>
        /// Метод возвращает список доступных ID валют.
        /// </summary>
        /// <returns> Список доступных ID. </returns>
        public List<string> GetCurID()
        {
            var allCur = GetAllCur();
            var curID = new List<string>();

            foreach (var currency in allCur)
            {
                if (currency.Cur_ID >= 371)
                {
                    curID.Add(currency.Cur_ID.ToString());
                }
            }

            return curID;
        }

        /// <summary>
        /// Метод возвращает курс валют(наименования, кол-во и др.)
        /// </summary>
        /// <returns> Курс валют.</returns>
        public List<Rate> GetRates()
        {
            var rates = new List<Rate>();
            Rate rate;
            var rateByn = new Rate("BYN", 1, "Белорусский рубль", 1);
            rates.Add(rateByn);

            foreach (var id in this.GetCurID())
            {
                WebRequest rateRequest = WebRequest.Create("https://www.nbrb.by/api/exrates/rates/" + id);
                rateRequest.Method = "GET";
                WebResponse rateResponse;

                rateResponse = rateRequest.GetResponse();

                string json = string.Empty;

                using (Stream s = rateResponse.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(s))
                    {
                        json = reader.ReadToEnd();
                    }
                }

                rateResponse.Close();

                rate = JsonConvert.DeserializeObject<Rate>(json);
                rates.Add(rate);
            }

            return rates;
        }

        /// <summary>
        /// Метод возвращает список наименований валют.
        /// </summary>
        /// <returns> Список наименований валют. </returns>
        public List<string> GetNamesOfRates()
        {
            List<string> ratesNames = new List<string>();

            List<Rate> rates = this.GetRates();

            foreach (var rate in rates)
            {
                ratesNames.Add(rate.Cur_Name);
            }

            return ratesNames;
        }

        /// <summary>
        /// Метод получает курс по имени.
        /// </summary>
        /// <param name="name"> Имя валюты. </param>
        /// <param name="allRates"> Лист с обьектами Rate. </param>
        /// <returns> курс по имени. </returns>
        public double GetRateByName(string name, List<Rate> allRates)
        {
            double rateByName = 0;

            foreach (var rate in allRates)
            {
                if (rate.Cur_Name == name)
                {
                    rateByName = rate.Cur_OfficialRate;
                }
            }

            return rateByName;
        }

        /// <summary>
        /// Метод получает кол-во единиц валюты по имени.
        /// </summary>
        /// <param name="name"> Имя валюты. </param>
        /// <param name="allRates"> Лист с обьектами Rate. </param>
        /// <returns> Кол-во единиц валюты по имени. </returns>
        public int GetScaleByName(string name, List<Rate> allRates)
        {
            int scaleByName = 0;

            foreach (var rate in allRates)
            {
                if (rate.Cur_Name == name)
                {
                    scaleByName = rate.Cur_Scale;
                }
            }

            return scaleByName;
        }

        /// <summary>
        /// Возвращает id по имени.
        /// </summary>
        /// <param name="name"> Наименование валюты. </param>
        /// <param name="allRates"> Список валют. </param>
        /// <returns> Id по имени. </returns>
        public int GetIdByName(string name, List<Rate> allRates)
        {
            int id = 0;

            foreach (var rate in allRates)
            {
                if (rate.Cur_Name == name)
                {
                    id = rate.Cur_ID;
                }
            }

            return id;
        }

        /// <summary>
        /// Метод конвертирует белорусский рубль в валюту.
        /// </summary>
        /// <param name="byn"> Кол-во белорусских рублей. </param>
        /// <param name="curRate"> Курс валюты,в которую конвертируем. </param>
        /// /// <param name="scale"> Кол-во единиц валюты. </param>
        /// <returns> Валюта.</returns>
        public double ConverBynInCur(string byn, double curRate, int scale)
        {
            double cur = 0;
            cur = Convert.ToDouble(byn) * scale / curRate;
            return cur;
        }

        /// <summary>
        /// Метод конвертирует валюту в белорусский рубль.
        /// </summary>
        /// <param name="cur"> Кол-во единиц валюты. </param>
        /// <param name="curRate"> Курс валюты, из которой переводим. </param>
        /// <param name="scale"> Кол-во единиц валюты . </param>
        /// <returns> Кол-во белорусских рублей. </returns>
        public double ConverCurInByn(string cur, double curRate, int scale)
        {
            double byn = 0;
            byn = Convert.ToDouble(cur) * curRate / scale;
            return byn;
        }

        /// <summary>
        /// Метод конвертирует валюту в валюту(через белорусский рубль).
        /// </summary>
        /// <param name="cur1"> Кол-во единиц начальной валюты. </param>
        /// <param name="curRate1"> Курс начальной валюты. </param>
        /// <param name="curRate2"> Курс конечной валюты. </param>
        /// <param name="scale1"> Кол-во единиц валюты. </param>
        /// <param name="scale2"> Кол-во единиц валюты2. </param>
        /// <returns> Кол-во единиц конечной валюты. </returns>
        public double ConverCurInCur(string cur1, double curRate1, double curRate2, int scale1, int scale2)
        {
            double resultCur = 0;
            double byn = 0;
            byn = Convert.ToDouble(cur1) * curRate1 / scale1;
            resultCur = (byn / curRate2) * scale2;
            return resultCur;
        }

        /// <summary>
        /// Метод возвращает массив курса валют по выбранной дате.
        /// </summary>
        /// <param name="days"> Кол-во дней в промежутке. </param>
        /// <param name="currencyName"> Наименование валюты. </param>
        /// <param name="firstTime"> День начала отсчета. </param>
        /// <returns> Массив курса валют по выбранной дате. </returns>
        public double[] GetRateOnDate(int days, string currencyName, DateTime firstTime)
        {
            var allRates = this.GetRates();
            double[] rates = new double[days];
            DateTime time = firstTime;

            int i = 0;

            while (i <= days - 1)
            {
                string year = time.ToString("yyyy");
                string month = time.ToString("MM");
                string day = time.ToString("dd");

                int idOfRate = this.GetIdByName(currencyName, allRates);

                WebRequest rateRequest = WebRequest.Create("https://www.nbrb.by/api/exrates/rates/" + idOfRate + "?ondate=" + year + "-" + month + "-" + day);
                rateRequest.Method = "GET";
                WebResponse rateResponse;

                rateResponse = rateRequest.GetResponse();

                string json = string.Empty;

                using (Stream s = rateResponse.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(s))
                    {
                        json = reader.ReadToEnd();
                    }
                }

                rateResponse.Close();

                Rate rate = JsonConvert.DeserializeObject<Rate>(json);
                rates[i] = rate.Cur_OfficialRate;
                time = time.AddDays(1);
                i++;
            }

            return rates;
        }
    }
}
