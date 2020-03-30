using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array01 = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
            string[] array02= new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
            int count = 1;
            while(count <= 200){
                Console.WriteLine("Please choose LED to turn On/Off : ");
                string LED = Console.ReadLine();
                for (int i = 0; i < array01.Length; i++) {
                    if (array01[i] == LED & array02[i] == "[ ]"){
                        array02[i] = "[!]"; 
                    }
                    else if (array01[i] == LED & array02[i] == "[!]"){
                        array02[i] = "[ ]" ;
                    }
                }
                Console.WriteLine(string.Join(" ", array02 ) );
                Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
                count ++ ;
            

            }
        }  
    }
}

