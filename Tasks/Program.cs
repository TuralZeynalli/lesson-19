using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            string task = null;

            task.Sentences("Qarabag zeferimiz Qarabag qururumuzdur Qarabag oz yurdumuzdur Qarabag can Azerbaycandir");

            //////////////////////////////////////////////////////////////////////////////////

            Season season = Season.Summer;

            Month[] month = season.ShowSeasonOfMonth();

            foreach (var item in month)
            {
                Console.WriteLine(item);
            }

        }
    }
}
