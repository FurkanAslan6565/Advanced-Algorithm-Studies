using System;
using System.Collections;
using System.Collections.Generic; 

namespace Apps
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new DataStructures
                .Array
                .Array<int>();
            arr.Add(23);
            arr.Add(55);
            arr.Add(44);
            Console.WriteLine($"{arr.Count} / {arr.Capacity}");






           /* // Array 
            char[] arrChar = new char[3];
            // arrayList
            //List < T >
            var arrInt = new List<int>(); // int değer olduğu için strşng değer eklenemez 
            arrInt.Add(10); // Eklemek  
            arrInt.AddRange(new int[] {1,2,3}) ;
            // arrInt.RemoveAt(0) ; // 0 elemanı çıkar  
            // Kodu yazdırma 
            foreach (var item in arrInt)
            {
                Console.WriteLine(item); 

            }*/
            Console.ReadKey();
                
            
        }
    }
}