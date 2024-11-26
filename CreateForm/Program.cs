namespace CreateForm
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("**************** Gustama Bank ****************");

            // Deklarasi Variable 
            string? userName = null;
            string? password = null;

            // Read Keyboard
            Console.Write("Username : ");
            userName = Console.ReadLine();

            Console.Write("Password : ");
            password = Console.ReadLine();
            
            string verificationUsername = "Admin";
            string verificationPassword = "admin";
            
            if (verificationUsername != userName)
            {
                Console.WriteLine("Tidak Sama Dengan Username !");
            }

            if (verificationPassword != password)
            {
                Console.WriteLine("Tidak Sama Dengan Password !");
            }

            if (verificationUsername == userName && verificationPassword == password) 
            {
                Console.WriteLine("**** Success ***");
                Console.WriteLine($"Username : {userName}");
                Console.WriteLine($"Password : {password}");
                
                Console.WriteLine("===== Menu =====");
                Console.WriteLine("1. List Bank");
                Console.WriteLine("2. List Transaksi");
                Console.WriteLine("3. List E-Wallet");

                string menuChange = null;
                
                Console.WriteLine("Masukan Menu Yang Ingin Ditampilkan :");
                menuChange = Console.ReadLine();
                switch (menuChange)
                {
                    case "1": 
                        Console.WriteLine("Ini adalah list Bank");
                        break;
                    case "2":
                        Console.WriteLine("List Transaksi");
                        myTransaksi();
                        break;
                    case "3":
                        Console.WriteLine("List E-Wallter");
                        break;
                    default:
                        Console.WriteLine("Tidak Ada yang sama di List Menu Atas");
                        Console.WriteLine("=====================================");
                        Console.Write("Apakah anda Akan Keluar y/n : ");
                        string response = Console.ReadLine();
                        
                        if (response != "y")
                        {
                            Main();
                        }
                        break;
                }
            }
        }

        static void myTransaksi()
        {
            Console.WriteLine("******* Selamat Anda Di transaksi *******");
            Console.Write("Masukan Nama Barang : ");
            string namaBarang = Console.ReadLine();
            
            Console.Write("Masukan Harga Barang : Rp. ");
            int hargaBarang = int.Parse(Console.ReadLine() ?? string.Empty);
            
            Console.Write("Masukan Jumlah Barang : ");
            int jumlahBarang = int.Parse(Console.ReadLine() ?? string.Empty);


            if (hargaBarang != null && jumlahBarang != null && namaBarang != null)
            {
                int hargaDiscount = ((hargaBarang * jumlahBarang) * 10 ) / 100;
                int jumlahTotal = hargaBarang * jumlahBarang;
                int jumlahSudahDidiscount = jumlahTotal - hargaDiscount;
                Console.WriteLine("================================================");
                Console.WriteLine($"Discount : Rp. {hargaDiscount}");
                Console.WriteLine($"Total : Rp. {jumlahSudahDidiscount}");
                Console.WriteLine("================================================");
                Console.WriteLine();
                Console.WriteLine("Apakah Anda Ingin Keluar y/n");
                string getExit = Console.ReadLine();
                exit(getExit);
            }
            else
            {
                Console.WriteLine("Apakah Anda Ingin Keluar y/n");
                string getExit = Console.ReadLine();
                 exit(getExit);
            }
        }

        public static void exit(string value)
        {
            if (value != "y")
            {
                myTransaksi();
            }
        }
    }
}