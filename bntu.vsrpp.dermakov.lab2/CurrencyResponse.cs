using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bntu.vsrpp.dermakov.lab2
{
    public class CurrencyResponse
    {
        public char[] Cur_ID { get; set; } // внутренний код
        public float Cur_ParentID { get; set; } // этот код используется для связи, при изменениях наименования, количества единиц к которому устанавливается курс белорусского рубля, буквенного, цифрового кодов и т.д.фактически одной и той же валюты*.
        public float Cur_Code { get; set; }// цифровой код
        public string Cur_Abbreviation { get; set; }// буквенный код
        public int Cur_Name { get; set; } // наименование валюты на русском языке
        public int Cur_Name_Bel { get; set; }// наименование на белорусском языке
        public string Cur_Name_Eng { get; set; }// наименование на английском языке
        public string Cur_QuotName { get; set; }// наименование валюты на русском языке, содержащее количество единиц
        public string Cur_QuotName_Bel { get; set; }// наименование на белорусском языке, содержащее количество единиц
        public string Cur_QuotName_Eng { get; set; }//– наименование на английском языке, содержащее количество единиц
        public string Cur_NameMulti { get; set; }// наименование валюты на русском языке во множественном числе
        public string Cur_Name_BelMulti { get; set; }// наименование валюты на белорусском языке во множественном числе*
        public string Cur_Name_EngMulti { get; set; }// наименование на английском языке во множественном числе*
        public float Cur_Scale { get; set; }// количество единиц иностранной валюты
    }
}
