using System;

namespace Lesson26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Виведення задіяної пам'яті.
            Console.WriteLine(GC.GetTotalMemory(false));

            for (int i = 0; i < 10000; ++i)
            {
                var obj = (object)i;
                int j = (int)obj;
            }
            Console.WriteLine(GC.GetTotalMemory(false));
            //Очищення пам'яті. (перегрузки (вибір очистки по рівню)).
            GC.Collect();
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.ReadLine();
        }
    }
}
