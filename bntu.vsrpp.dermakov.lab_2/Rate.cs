// <copyright file="Rate.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace bntu.vsrpp.dermakov.lab2
{
    using System;

    /// <summary>
    /// Описание класса Rate.
    /// </summary>
    public class Rate
    {
        /// <summary>
        /// Gets or sets внутренний код.
        /// </summary>
        public int Cur_ID { get; set; } // внутренний код

        /// <summary>
        /// Gets or sets дата, на которую запрашивается курс.
        /// </summary>
        public DateTime Date { get; set; } // дата, на которую запрашивается курс

        /// <summary>
        /// Gets or sets буквенный код.
        /// </summary>
        public string Cur_Abbreviation { get; set; } // буквенный код

        /// <summary>
        /// Gets or sets количество единиц иностранной валюты.
        /// </summary>
        public int Cur_Scale { get; set; } // количество единиц иностранной валюты

        /// <summary>
        /// Gets or sets name of currency.
        /// </summary>
        public string Cur_Name { get; set; } // наименование валюты на русском языке во множественном, либо в единственном числе, в зависимости от количества единиц

        /// <summary>
        /// Gets or sets официальный курс.
        /// </summary>
        public double Cur_OfficialRate { get; set; } // курс*

        /// <summary>
        /// Initializes a new instance of the <see cref="Rate"/> class.
        /// Конструктор.
        /// </summary>
        /// <param name="cur_Abbreviation"> Аббр.</param>
        /// <param name="cur_Scale">Кол-во единиц валюты.</param>
        /// <param name="cur_Name"> Имя валюты.</param>
        /// <param name="cur_OfficialRate">Официальный курс.</param>
        public Rate(string cur_Abbreviation, int cur_Scale, string cur_Name, double cur_OfficialRate)
        {
            this.Cur_Abbreviation = cur_Abbreviation;
            this.Cur_Scale = cur_Scale;
            this.Cur_Name = cur_Name;
            this.Cur_OfficialRate = cur_OfficialRate;
        }
    }
}
