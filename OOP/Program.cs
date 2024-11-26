namespace OOP;

public class Program
{
    public static void Main()
    {
        Customer toyota, honda;
        toyota = new Customer();
        honda = new Customer();

        toyota.customerId = 01;
        toyota.customerAddreess = "Cibitung";
        toyota.customerName = "Kijang Inova";

        honda.customerId = 02;
        honda.customerName = "Honda Brio";
        honda.customerAddreess = "Jakarta";
        
        Mahasiswa mahasiswa = new Mahasiswa();
        mahasiswa.id = 03;
        mahasiswa.name = "Rizwan Gustama";
        mahasiswa.status = "Active";
        mahasiswa.gender = "Female";
        mahasiswa.birthDate = new DateTime(1980, 11, 15);
        
        Console.WriteLine("Id : " + mahasiswa.id);
        Console.WriteLine("Name : " + mahasiswa.name);
        Console.WriteLine("Status : " + mahasiswa.status);
        Console.WriteLine("Gender : " + mahasiswa.gender);
        Console.WriteLine("BirthDate : " + mahasiswa.birthDate);
    }
}