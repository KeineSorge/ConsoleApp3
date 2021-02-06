using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class MyDictionary<TCode, TCity>
    {
        TCode[] codes;
        TCity[] cities;

        public MyDictionary()
        {
            codes = new TCode[0];
            cities = new TCity[0];
        }

        public void Add(TCode code, TCity city)
        {
            TCode[] tempCode = codes;
            TCity[] tempCity = cities;

            codes = new TCode[codes.Length + 1];
            cities = new TCity[cities.Length + 1];

            for (int i = 0; i < tempCode.Length; i++)
            {
                codes[i] = tempCode[i];
            }

            codes[codes.Length - 1] = code;

            for (int i = 0; i < tempCity.Length; i++)
            {
                cities[i] = tempCity[i];
            }

            cities[cities.Length - 1] = city;

            Console.WriteLine("Plaka Kodu : {0} --- Şehir Adı : {1}", code, city);
        }

    }
}
