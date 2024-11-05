using System.Runtime.ConstrainedExecution;

namespace patika_w7_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region UZUN UZUN YAZDIM :)
            List<int> randomNumbers = new List<int>(); // random sayıları tutacağımız liste
            Random random = new Random();   // random üretilecek sayı nesnesi

            for (int i = 0; i < 10; i++)  // 10 adet sayı için döngü
            {
                randomNumbers.Add(random.Next(-50, 51));  // negatif sayıları da kapsaması için -50 ile 50 arasında sayılar üret ve listeye ekle
            }

            Console.WriteLine("----- ÜRETİLEN SAYILAR -----");
            foreach (var randomNumber in randomNumbers)  // üretilen sayıları foreach ile ekrana yazdır
            {
                Console.WriteLine(randomNumber);
            }

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("----- ÇİFT SAYILAR -----");// Where ile filtreleme yapıyoruz
            var evenNumbers = randomNumbers.Where(num => num % 2 == 0);  // randomNumbers listesindeki her sayıyı kontrol ederek ÇİFT sayıları seç.
            foreach (var evenNumber in evenNumbers) // çift sayıları ekrana yazdır
            {
                Console.WriteLine(evenNumber);
            }

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("----- TEK SAYILAR -----");// Where ile filtreleme yapıyoruz
            var oddNumbers = randomNumbers.Where(num => num % 2 != 0); // randomNumbers listesindeki her sayıyı kontrol ederek TEK sayıları seç.
            foreach (var oddNumber in oddNumbers)
            {
                Console.WriteLine(oddNumber);
            }

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("----- NEGATİF SAYILAR -----"); // Where ile filtreleme yapıyoruz
            var negativeNumbers = randomNumbers.Where(num => num < 0); // randomNumbers listesindeki her sayıyı kontrol ederek NEGATİF sayıları seç.
            foreach (var negativeNumber in negativeNumbers)
            {
                Console.WriteLine(negativeNumber);
            }

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("----- POZİTİF SAYILAR -----");// Where ile filtreleme yapıyoruz
            var positiveNumbers = randomNumbers.Where(num => num > 0);// randomNumbers listesindeki her sayıyı kontrol ederek POZİTİF sayıları seç.
            foreach (var positiveNumber in positiveNumbers)
            {
                Console.WriteLine(positiveNumber);
            }

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("----- 15'DEN BÜYÜK 22'DEN KÜÇÜK -----");
            var numbers = randomNumbers.Where(num => (num > 15) && (num < 22)); // Where ile filtrele neyi? 15 den büyük 22'den küçük sayıları
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("----- SAYILARIN KARESİ -----");
            var squaredNumbers = randomNumbers.Select(num => num * num); // Select ile her bir sayının karesini alıyoruz ve hsaplıyoruz
            foreach (var squaredNumber in squaredNumbers)
            {
                Console.WriteLine(squaredNumber);
            }
            #endregion

            #region DAHA KULLANIŞLI GELDİ 

            List<int> randomNumbers2 = new List<int>(); // Lİste oluştur
            Random random2 = new Random(); //Random sayı nesnesi

            for (int i = 0; i < 10; i++)  // 10 adet sayı üreteceğimiz döngü
            {
                randomNumbers2.Add(random2.Next(-50, 51));  // Sayıları üret ve listeye ekle
            }
            Console.WriteLine("----- ÜRETİLEN SAYILAR -----");
            randomNumbers2.ForEach(number => Console.WriteLine(number));  // her sayıyı ekrana yazdıracağımız ForEach methodu


            Console.WriteLine("----- ÇİFT SAYILAR -----");
            // randomNumbers2 listesindeki çift sayıları filtrelemek için Where metodunu kullanıyoruz
            var evenNumbers2 = randomNumbers2.Where(num => num %2 == 0).ToList(); // Çift sayıları seçiyoruz ve listeye çeviriyoruz
            evenNumbers2.ForEach(num => Console.WriteLine(num)); // Filtrelenmiş çift sayıları konsol ekranına yazdırmak için ForEach metodunu kullanıyoruz

            Console.WriteLine("----- TEK SAYILAR -----");
            var oddNumbers2 = randomNumbers2.Where(num => num % 2 != 0).ToList();
            oddNumbers2.ForEach(num => Console.WriteLine(num));

            Console.WriteLine("----- NEGATİF SAYILAR -----");
            var negativeNumbers2 = randomNumbers2.Where(num => num < 0).ToList();
            negativeNumbers2.ForEach(num => Console.WriteLine(num));

            Console.WriteLine("----- POZİTİF SAYILAR -----");
            var positiveNumbers2 = randomNumbers2.Where(num => num > 0).ToList();
            positiveNumbers2.ForEach(num => Console.WriteLine(num));

            Console.WriteLine("----- 15 İLE 22 ARASINDAKİ SAYILAR -----");
            var filteredNumbers = randomNumbers2.Where(num => (num > 15) && (num < 22)).ToList();
            filteredNumbers.ForEach(num => Console.WriteLine(num));

            Console.WriteLine("----- SAYILARIN KARESİ -----");
            var squaredNumbers2 = randomNumbers2.Select(num => num * num).ToList();
            squaredNumbers2.ForEach(num => Console.WriteLine(num));

            #endregion
        }
    }
}
