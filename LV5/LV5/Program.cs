using LV5.classes2;
using LV5.interfaces;

namespace LV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*
              
                string putanja = @"C:\Users\vilim\Desktop\dataset.csv";

                DataConsolePrinter printer = new DataConsolePrinter();

                Console.WriteLine("=== TESTIRANJE PRIMJERA 2.2 (Virtual Proxy) ===");
               
                IDataset virtualniProxy = new VirtualProxyDataset(putanja);

                printer.Display(virtualniProxy);


                Console.WriteLine("\n=== TESTIRANJE PRIMJERA 2.3 (Protection Proxy) ===");

                User korisnik1 = User.GenerateUser("Vilim");
                ProtectionProxyDataset protectionProxy1 = new ProtectionProxyDataset(korisnik1);

            
              
                Console.WriteLine($"Pokušaj pristupa za: {korisnik1.Name} (ID: {korisnik1.ID})");
                printer.Display(protectionProxy1);

              
                User korisnik2 = User.GenerateUser("Gost");
                ProtectionProxyDataset protectionProxy2 = new ProtectionProxyDataset(korisnik2);

                Console.WriteLine($"Pokušaj pristupa za: {korisnik2.Name} (ID: {korisnik2.ID})");
                printer.Display(protectionProxy2);

                Console.WriteLine("\nTestiranje završeno. Pritisnite bilo koju tipku.");
                Console.ReadKey();*/

                string putanja = @"C:\Users\vilim\Desktop\dataset.csv";

           
            IDataset realDataset = new Dataset(putanja);

        
            IDataset loggingProxy = new LoggingProxyDataset(realDataset);

          
            DataConsolePrinter printer = new DataConsolePrinter();

            Console.WriteLine("=== TESTIRANJE LOGGING PROXY-JA ===");
            printer.Display(loggingProxy);

            Console.WriteLine("\nPritisnite bilo koju tipku za kraj...");
            Console.ReadKey();

            
            }
        }
}
