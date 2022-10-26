namespace Arrays;

public class Arrays
{
    
    static void Main()
    {
        //
        int[] sayilar = new int[] {1,2,4,5,6,7,8,9,10};

        Array.Reverse(sayilar);
        foreach (int x in sayilar)
        {
            Console.Write(x.ToString());
        }

        Console.WriteLine("\n");
      
       var num=Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Your number is: {0}",sayilar[num].ToString());
       
    }
}