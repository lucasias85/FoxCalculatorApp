using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxCalculatorApp.AppCode.Models
{
    public class TaxasModel
    {
        [PrimaryKey, AutoIncrement]
        public int IdTaxa { get; set; }
        public double Parcela01 { get; set; }
        public double Parcela02 { get; set; }
        public double Parcela03 { get; set; }
        public double Parcela04 { get; set; }
        public double Parcela05 { get; set; }
        public double Parcela06 { get; set; }
        public double Parcela07 { get; set; }
        public double Parcela08 { get; set; }
        public double Parcela09 { get; set; }
        public double Parcela10 { get; set; }
        public double Parcela11 { get; set; }
        public double Parcela12 { get; set; }

    }
}
