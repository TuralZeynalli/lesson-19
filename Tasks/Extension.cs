using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tasks
{
   public static class Extension
    {
        #region Sentences
        public static void Sentences(this string input, string sentences)
        {
            
             int count = 0;

            string[] words = sentences.Split(' ');

            foreach (var word in words)
            {

                foreach (var sameWord in words)
                {
                    if (sameWord.ToLower() == word.ToLower())
                    {
                        count++;
                    }
                }

                if (count > 1)
                {
                    Console.WriteLine($"there is {word} word appointed {count} times");
                    break;
                }
                else
                {
                    Console.WriteLine("there is no same words appointed");
                }
            }
        }

        #endregion

        #region SeasonMonth
        public static Month[] ShowSeasonOfMonth(this Season season)
        {
            switch (season)
            {
                case Season.Winter:

                    return new Month[] { Month.December, Month.February, Month.January };
                case Season.Spring:

                    return new Month[] { Month.March, Month.April, Month.May };

                case Season.Summer:
                    return new Month[] { Month.June, Month.July, Month.August };

                case Season.Autumn:
                    return new Month[] { Month.September, Month.October, Month.November };

                default:
                    return null;
            }
        }
        #endregion
    }    
}   
