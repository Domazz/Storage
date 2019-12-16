using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace final_assignment
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Maksimali lyginių ir nelyginių suma yra : {0}", func(0, 0));
            Console.ReadLine();
        }

        
        static public string NumTriangle()
        {
            const string x = @"  215
                                 192 124
                                 117 269 442
                                 218 836 347 235
                                 320 805 522 417 345
                                 229 601 728 835 133 124
                                 248 202 277 433 207 263 257
                                 359 464 504 528 516 716 871 182
                                 461 441 426 656 863 560 380 171 923
                                 381 348 573 533 448 632 387 176 975 449
                                 223 711 445 645 245 543 931 532 937 541 444
                                 330 131 333 928 376 733 017 778 839 168 197 197
                                 131 171 522 137 217 224 291 413 528 520 227 229 928
                                 223 626 034 683 839 052 627 310 713 999 629 817 410 121
                                 924 622 911 233 325 139 721 218 253 223 107 233 230 124 233 ";

            return x;
        }

   
        static public List<List<int>> ListToIntArr(string Str)
        {
            int a = 0;
           
            int Lines = 1;
            foreach (var item in Str)
            {
                if (item == '\n') Lines++;
            }
            
            string[] arr = Str.Split('\n');
            List<List<int>> zerarr = new List<List<int>>();
           
            while( a < Lines)
            {

                MatchCollection MC = Regex.Matches(arr[a], @"\d{3}");
                List<int> TableArray = new List<int>();
                foreach (Match item in MC)
                {
                    int y = int.Parse(item.Value);
                    TableArray.Add(y);
                }

                zerarr.Insert(a, TableArray);
                a++;
            }
            
            for (int i = 0; i < Lines; i++)
            {
                if (zerarr[i].Count <= Lines)
                {
                    for (int j = i + 1; j < Lines; j++)
                    {
                        zerarr[i].Add(0);
                    }

                }

            }

            return zerarr;
        }
        
        static public bool EvenChecker(int num)
        {
            if ((num & 1) == 0 )
            {
                return true;
            }
            else
            {
             
             return false;
                  
            }
        }

        static public bool OddChecker(int num)
        {
            if ((num & 1) != 0)
            {
                return true;
            }
            else
            {
  
            return false;
            }
        }
        private static int func(int a, int b)
        {
            List<List<int>> arrlist = ListToIntArr(NumTriangle());
            if (a >= arrlist.Count)
                return 0;
            int numarr = arrlist[a][b];
            if (EvenChecker(numarr) && (OddChecker(numarr)))
                return 0;
            else

                return numarr + Math.Max(func(a + 1, b), func(a + 1, b + 1));
        }



    }
}
