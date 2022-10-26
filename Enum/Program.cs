namespace Arrays;

public class Arrays
{
    void calculate(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(Math.Pow(item,2));
        }
    }
    enum Employee
    {
        manager=1,
        officer,
        teacher,
        worker
    }

    enum WeekDays:byte
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

   
    //ENUM TYPE CANNOT BE STRING!
    static void Main()
    {
        //string[] result = Array.ConvertAll(arrName, arrItem => arrItem.toString());
        Console.WriteLine("Kullanıcı - Maaş Paneli");
        
        //15 elemanlı bir dizi elemanlarının küpü alınıyor.
        int[] example1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        Arrays app = new Arrays();
        //app.calculate(example1);
        
        //Enum
        Employee e;
        int res = (int)(Employee.worker);
        
        //Console.WriteLine(res);

        int result = Convert.ToInt32(Console.ReadLine());
        switch ((Employee)result)
        {
            case Employee.manager:
                Console.WriteLine("Meslek: {0} Maas:{1}",Employee.manager.ToString(),30000.ToString());
                break;
            case Employee.officer:
                Console.WriteLine("Meslek: {0} Maas:{1}",Employee.officer.ToString(),24000.ToString());
                break;
            case Employee.teacher:
                Console.WriteLine("Meslek: {0} Maas:{1}",Employee.teacher.ToString(),20000.ToString());
                break;
            case Employee.worker:
                Console.WriteLine("Meslek: {0} Maas:{1}",Employee.worker.ToString(),15000.ToString());
                break;
            default:
                Console.WriteLine("Invalid Profession!");
                break;
        }
        
      /*  Console.WriteLine(WeekDays.Monday.ToString());
        Console.WriteLine((int)WeekDays.Tuesday);//enum to value
        Console.WriteLine(WeekDays.Wednesday);
        Console.WriteLine(WeekDays.Tuesday);
        Console.WriteLine(WeekDays.Friday);
        Console.WriteLine(WeekDays.Saturday);
        Console.WriteLine(((WeekDays)7).ToString());//value to enum
        */
        
        
        /*
         * Important Functions
         * GetName()
         *
         * string m=Enum.GetName(typeof(weekDays,1))
         * string[]=Enum.GetNames(typeof(weekDays));
         */
        String specialItem = Enum.GetName(typeof(WeekDays), 1);
        //Console.WriteLine("here:"+specialItem);
    }
}