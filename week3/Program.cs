
namespace week5
{
    class Week5
    {
        static void Main(String[] args)
        {
            var i =10;
            Console.WriteLine("type of i:{0}",i.GetType().ToString());
            int[] arr={1,2,3,4,5,6,7,8,9,0,10,11,12,13,14,15,16,17,18};
            for(int x=0;x<arr.Length;x++){
                Console.WriteLine("Array Value is: {0} Type of Value is: {1}",x,x.GetType().ToString());
            }
            int[] marks=new int[5]{1,2,3,4,5};
            //eger butun elemanlar belirtildiyse, size boş verilebilir
            int[] marks2=new int[]{1,2,3,4,5};
            int[] ages = new int[10];
            for(int a=0;a<10;a++)
            {
                ages[a] = i+100;
            }
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}",j,ages[j]);
            }
            
            
            
        }
    }
}
