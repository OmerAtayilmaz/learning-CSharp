namespace week4;

public class Calculator
{

    public int CalcFactorial(int num)
    {
        int result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }

        return result;
    }
    
    //call by value - SWAP OLMAZ! - 

    public void Swap(int x,int y)
    {
        int temp;
        temp = x;
        x = y;
        y = temp;
    }
    //call by ref
     public void SwapRef(ref int x, ref int y)
    {
        Console.WriteLine("New X: {0} New Y:{1}",x,y);
        int temp;
        temp = x;
        x = y;
        y = temp;
        Console.WriteLine("New X: {0} New Y:{1}",x,y);
    }
    
     //Out - sınavda var
     public void getValue(out int x)
     {
         int temp = 15;
         x = temp;
     }

     public void initializeVars(out int n1, out int n2)
     {
         n1=Convert.ToInt32(Console.ReadLine());
         n2 = Convert.ToInt32(Console.ReadLine());
     }

     public void toplaCarp( int s1, int s2, out int top, out int carpim)
     {
         top = s1 + s2;
         carpim = s1 * s2;
     }
}