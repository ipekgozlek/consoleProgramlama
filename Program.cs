using System;
namespace consoleProgramlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str20 = " 20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); //çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);//çıktısı 40

            int int22 = int20 + int.Parse(str20); // çıktısı 40
            Console.WriteLine(int22);

            //datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string Hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(Hour);




        }
    }
}
