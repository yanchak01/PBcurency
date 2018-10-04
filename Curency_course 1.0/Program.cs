using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;


namespace Curency_course_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = DateTime.Today.ToString("dd.MM.yyyy");
            string url1 = "https://api.privatbank.ua/p24api/exchange_rates?json&date=";
            string url = url1 + date;

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            Currency currency = JsonConvert.DeserializeObject<Currency>(response);

            Console.WriteLine(currency.baseCurrency + " " + currency.date+" ");
            for (int i = 0; i < currency.exchangeRate.Count; i++)
            {
                Console.WriteLine(currency.exchangeRate[i].saleRateNB+" "+ currency.exchangeRate[i].currency);
            }
            Console.ReadLine();
        }
    }
}
