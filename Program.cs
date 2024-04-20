namespace TodoApp
{
    internal class Program
    {
        class Constructor
        {
            public string ad { get; set; }
            public string olay { get; set; }
            public DateTime tarih { get; set; }


            public Constructor(string ad, string olay, DateTime tarih)
            {
                this.ad = ad;
                this.olay = olay;
                this.tarih = tarih;
            }

        }
        static void Main(string[] args)
        {

            List<Constructor> girdiler = new List<Constructor>();
            Console.WriteLine("Aşağıdaki veri girişlerini sağlayınız.");
            while (true)
            {
                Console.WriteLine("İsim giriniz:");
                string? ad = Console.ReadLine();

                Console.WriteLine("Olay giriniz:");
                string? olay = Console.ReadLine();

                DateTime tarih = DateTime.Now;

                Console.WriteLine("Çıkış yapmak için 'çıkış' yazınız:");
                string? cikis = Console.ReadLine();

                if (cikis?.ToLowerInvariant() == "çıkış")
                {
                    break;
                }

                if (ad != null && olay != null)
                {
                    Constructor constructor = new Constructor(ad, olay, tarih);
                    girdiler.Add(constructor);
                }

            }

            Console.WriteLine("\nGirilen veriler:");
            foreach (var girdi in girdiler)
            {
                Console.WriteLine("İsim: " + girdi.ad);
                Console.WriteLine("Olay: " + girdi.olay);
                Console.WriteLine("Tarih: " + girdi.tarih);
                Console.WriteLine();
            }
        }
    }
}
