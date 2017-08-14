using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _14thAug
{
    class setQuestionPaper
    {
       
     
        public void setPaper()
        {

            Dictionary<String, String[]> ht = new Dictionary<string, string[]>();
            string ak = "A";
            ht[ak] = new string[3] { "a1", "a2", "a3"};
            ht["B"] = new string[2] { "b1", "b2" };
            ht["C"] = new string[10] { "c1", "c2", "c3", "c4", "c5", "c6", "c7", "c8", "c9", "c10" };
            ht["D"] = new string[4] { "d1", "d2", "d3", "d4" };

            ArrayList qSetCount=new ArrayList();

            //ArrayList qSet = new ArrayList();
            Object[] qset = new Object[20];

            var watch = System.Diagnostics.Stopwatch.StartNew();

            foreach (var item in ht.Keys)
            {
               qSetCount.Add(ht[item].Length);

            
            }

            qSetCount.Sort();
           

            int k = 0,i,j;
            foreach (var len in qSetCount)
            {
                // Console.WriteLine(item);
                
                foreach (var item in ht.Keys)
                {
                    if (len.Equals(ht[item].Length))
                    {

                        if (len.Equals(10))
                        {
                            for (i = 0, j = 1; i < ht[item].Length; i++, j += 2)
                            {
                                // Console.WriteLine(ht[item].GetValue(i));
                                //qSet.Add(2, ht[item].GetValue(i));
                                qset[j] = ht[item].GetValue(i);

                            }
                        }
                        else
                        {
                            for (i = 0, j = k; i < ht[item].Length; i++, j += 2)
                            {
                                // Console.WriteLine(ht[item].GetValue(i));
                                //qSet.Add(2, ht[item].GetValue(i));
                                qset[j] = ht[item].GetValue(i);
                                k += 2;
                            }
                        }
                           
                        

                           
                        
                           
                          
                            
                        
                          
                            
                        
                       
                    }
                }

               // Console.WriteLine("Value of k"+k);
            }

            watch.Stop();

            foreach (var item in qset)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Time taken : " + watch.Elapsed);








        }



    }
}
