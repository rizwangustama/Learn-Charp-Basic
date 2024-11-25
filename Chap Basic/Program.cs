namespace Chap_Basic
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // Variabel and Type Data
            int numberInt = int.MaxValue;
            double numberDouble = double.MaxValue;
            decimal numberDecimal = decimal.MaxValue;
            string numberString = "Rizwan Gustama";
            
            // Printer
            Console.WriteLine(numberInt);
            Console.WriteLine(numberDouble);
            Console.WriteLine(numberDecimal);
            Console.WriteLine(numberString);
            
            
            // Variabel
            string name, address, city, country;
            int age, year, month, day;

            name = "Rizwan Gustama";
            address = "Kebon Jeruk - Jakarta Barat";
            city = "Jakarta Barat";
            country = "Indonesia";
            age = 20;
            year = 2024;
            month = 12;
            day = 1;
            
            // Output Variabel
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Address :" + address);
            Console.WriteLine("City:" + city);
            Console.WriteLine("Country:" + country);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Year:" + year);
            Console.WriteLine("Month:" + month);
            Console.WriteLine("Day:" + day);
            
            
            // Aritmatika
            int Bilangan1, Bilangan2, Perkalian, Penjumlahan, Pengurangan;
            
            // Variabel
            Bilangan1 = 10;
            Bilangan2 = 2;
            
            // Penjumlahan
            Penjumlahan = Bilangan1 + Bilangan2;
            
            // Pengurangan
            Pengurangan = Bilangan1 - Bilangan2;
            
            // Perkalian 
            Perkalian = Penjumlahan * Penjumlahan;
            Console.WriteLine("============ * Aritmatika * ============");
            Console.WriteLine("Penjumlahan : " + Penjumlahan);
            Console.WriteLine("Pengurangan : " + Pengurangan);
            Console.WriteLine("Perkalian : " + Perkalian);
            
            
            
            // Condition
            int Condition1, Condition2;
            Condition1 = 10;
            Condition2 = 5;
            bool isChecked = false;
            
            if (Condition1 == Condition2) 
            {
                isChecked = true;
            }
            else
            {
                isChecked = false;
            }
            
            Console.WriteLine($"Is Checked : {isChecked}");

            int variableLooping = 5;

            for (int i = 0; i < variableLooping; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = variableLooping; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}