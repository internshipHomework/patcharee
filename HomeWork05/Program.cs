using System;

public interface IHomework1
{
    string DisplayLEDOnScreen(string ledNo);
}
class Program
{
    static void Main(string[] args)
    {
        LEDclass Led = new LEDclass();
        Led.DisplayLEDOnScreen(" ");
        Console.ReadLine();
    }
}
class LEDclass : IHomework1
{
    public string DisplayLEDOnScreen(string ledNo)
    {
        string DisplayLEDOnScreen;
        DisplayLEDOnScreen = ledNo;
        string[] array01 = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
        string[] array02= new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
        int count = 1;
        while(count <= 200){
            Console.WriteLine(string.Join(" ", array02 ) );
            Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
            count ++ ;
            Console.WriteLine("Please choose LED to turn On/Off : ");

            string ledno = Console.ReadLine();
            for (int i = 0; i < array01.Length; i++) {
                if (array01[i] == ledno & array02[i] == "[ ]"){
                    array02[i] = "[!]"; 
                }
                else if (array01[i] == ledno & array02[i] == "[!]"){
                    array02[i] = "[ ]" ;
                }
            }

        }
        return ledNo;
    }
}















