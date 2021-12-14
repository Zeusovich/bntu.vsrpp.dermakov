// <copyright file="Currency.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace bntu.vsrpp.dermakov.lab2
{
    /// <summary>
    /// Описание класса валют.
    /// </summary>
    internal class Currency
    {
        /// <summary>
        /// Gets or sets внутренний код.
        /// </summary>
        public int Cur_ID { get; set; } // внутренний код

        /// <summary>
        /// Gets or sets цифровой код.
        /// </summary>
        public int Cur_Code { get; set; } // цифровой код

        /// <summary>
        /// Gets or sets буквенный код.
        /// </summary>
        public string Cur_Abbreviation { get; set; } // буквенный код

        /// <summary>
        /// Gets or sets наименование валюты на русском языке.
        /// </summary>
        public string Cur_Name { get; set; } // наименование валюты на русском языке

        /// <summary>
        /// Gets or sets наименование валюты на русском языке, содержащее количество единиц.
        /// </summary>
        public string Cur_QuotName { get; set; } // наименование валюты на русском языке, содержащее количество единиц

        /// <summary>
        /// Gets or sets количество единиц иностранной валюты.
        /// </summary>
        public float Cur_Scale { get; set; }// количество единиц иностранной валюты
    }
}
