using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curency_course_1._0
{
    public class Currency
    {
        public string baseCurrency { get; set; }

        public string  date { get; set; }

        public string Bank { get; set; }

        public string baseCurrencyLit { get;set;}

        public List<exchangeRate> exchangeRate { get; set; }
    }
}
