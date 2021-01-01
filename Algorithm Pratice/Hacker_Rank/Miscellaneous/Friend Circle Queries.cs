using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Friend_Circle_Queries
{

    // Complete the maxCircle function below.
    public static int[] maxCircle(int[][] queries)
    {
        int n = queries.Length;
        int[] result = new int[n];
        Hashtable arrHash = new Hashtable();
        Hashtable countHash = new Hashtable();
        List<List<int>> listCircles = new List<List<int>>();
        List<int> count = new List<int>(); 
        for(int i=0; i< n; i++)
        {
            int person1 = queries[i][0];
            int person2 = queries[i][1];
            int[] isPersent = PersentInCircle(arrHash, person1, person2);
            if(isPersent[0] == -1)
            {
                if (isPersent[1] == -1)
                {
                    // List<int> newCircle = new List<int>() {person1, person2 };
                    // listCircles.Add(newCircle);
                    
                    int number = arrHash.Count;
                    arrHash.Add(person1, number);
                    arrHash.Add(person2, number);
                    countHash.Add(number, 2);
                }
                else
                {
                    int index2 = isPersent[1];
                 //   listCircles[index2].Add(person1);
                    arrHash.Add(person1, index2);
                    countHash[index2] = Convert.ToInt32(countHash[index2]) + 1;
                }
            }
            else
            {
                if (isPersent[1] == -1)
                {
                    int index1 = isPersent[0];
                  //  listCircles[index1].Add(person2);
                    arrHash.Add(person2, index1);
                    countHash[index1] = Convert.ToInt32(countHash[index1]) + 1;
                }
                else
                {
                    int index1 = isPersent[0];
                    int index2 = isPersent[1];
                    if (index1 != index2)
                    {
                        for(int j =0; j < listCircles[index2].Count; j++)
                        {
                            arrHash[listCircles[index2][j]] = index1;
                        }
                        countHash[index2] = 0;
                        countHash[index1] = Convert.ToInt32(countHash[index2]) + Convert.ToInt32(countHash[index1]);

                        //  List<int> temp = listCircles[index2];
                        // listCircles[index1].InsertRange(listCircles[index1].Count - 1, temp);
                        //listCircles.RemoveAt(index2);
                    }
                }
            }

            //  int max = listCircles[0].Count;
            //  for(int j =0; j< listCircles.Count; j++)
            // {
            //     if(max< listCircles[j].Count)
            //     {
            //         max = listCircles[j].Count;
            //    }
            //  }
            //  result[i] = max;

            int max = 0;
            foreach (DictionaryEntry de in arrHash)
            {
                int temp = Convert.ToInt32(de.Value);
                if(max< temp)
                {
                    max = temp;
                }
            }
            result[i] = max;

        }



        return result;
        

    }

    static int[] PersentInCircle(Hashtable arrHash, int p1, int p2)
    {
        int[] result = new int[2] { -1, -1};
        bool isP1 = arrHash.ContainsKey(p1);
        bool isP2 = arrHash.ContainsKey(p2);
        if (isP1)
        {
            if (isP2)
            {
                result[0] = Convert.ToInt32(arrHash[p1]);
                result[1] = Convert.ToInt32(arrHash[p2]);
                return result;
            }
            else
            {
                result[0] = Convert.ToInt32(arrHash[p1]);
                return result;

            }
        }
        else
        {
            if (isP2)
            {
                result[1] = Convert.ToInt32(arrHash[p2]);
                return result;

            }
            else
            {
                return result;
            }

        }
    }

    /*
    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        int[][] queries = new int[q][];

        for (int i = 0; i < q; i++)
        {
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        int[] ans = maxCircle(queries);

        textWriter.WriteLine(string.Join("\n", ans));

        textWriter.Flush();
        textWriter.Close();
    }
    */
}
