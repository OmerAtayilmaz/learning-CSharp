namespace Arrays;

public class Arrays
{
    static double getAverage(int[] arr)
    {
        int i;
        double avg;
        int sum = 0;
        for (i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        avg = (double)sum / arr.Length;
        return avg;
    }
    
    static void Main()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5 };
        double getAvg = getAverage(arr);
        Console.WriteLine("{0}",getAvg);
        
        
        /*Hazır Array Fonksiyonları*/
        int[] list = { 34, 72, 13, 44, 25, 30, 10 };
      //  int[] temp = list;
        Console.WriteLine("Original Array\n");
        foreach (int val in list)
        {
            Console.Write(val+" ");
        }
        Array.Reverse(list);
        Console.WriteLine("\nReversed Array\n");
        foreach (int val in list)
        {
            Console.Write(val+" ");
        }
        Console.WriteLine();
        Array.Sort(list);
        Console.WriteLine(list[list.Length-1]);
        Console.Write("Biggest Number is: {0} Square of it : {1} ",list[list.Length-1],Math.Pow(list[list.Length-1],2));

    }
}
