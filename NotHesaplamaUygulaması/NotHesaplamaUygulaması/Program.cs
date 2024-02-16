
namespace NotHesaplamaUygulaması
{

	internal class Program
	{
		static void Main(string[] args)
		{
			HomePage();
			
		}

		// Ana ekran fonksiyonu
		public static void HomePage()
		{
			Console.Clear();
			Console.WriteLine("### NOT HESAPLAMA UYGULAMASI ###");
			Console.WriteLine("");
			Console.WriteLine("[1] - Geçmek için yeterli final notu hesaplama.");
			Console.WriteLine("[2] - Dönemin ortalamasını hesaplama");
			Console.WriteLine("[3] - Çıkış");
			Console.WriteLine();
			Console.Write("Yapmak istediğiniz işlem: ");
			int choice = Convert.ToInt32(Console.ReadLine());

			switch (choice)
			{
				case 1:
					Score();
					Console.WriteLine("Ana menüye dönmek için enter'a basın...");
					Console.ReadLine();
					HomePage();
					return;
				case 2:
					SemesterAverage();
					Console.WriteLine("Ana menüye dönmek için enter'a basın...");
					Console.ReadLine();
					HomePage();
					return;
				case 3:
					Console.WriteLine("Çıkılıyor...");
					break;
				default:
					Console.WriteLine("Geçersiz işlem!");
					Console.ReadLine();
					HomePage();
					return;
			}
;
		}


		// Geçme notu gösterme fonksiyonu
		public static void Score()
		{
			Console.Clear();
			Console.Write("Dersin not sayısı (En düşün 2 en yüksek 5 olabilir!): ");
			int numberOfNotes = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			if (numberOfNotes == 2)
			{
				Console.WriteLine("Dersi geçmek için gereken final notu: " + CalculatePassingScore(numberOfNotes));
			}
			else if (numberOfNotes == 3)
			{
				Console.WriteLine("Dersi geçmek için gereken final notu: " + CalculatePassingScore(numberOfNotes));
			}
			else if (numberOfNotes == 4)
			{
				Console.WriteLine("Dersi geçmek için gereken final notu: " + CalculatePassingScore(numberOfNotes));
			}
			else if (numberOfNotes == 5)
			{
				Console.WriteLine("Dersi geçmek için gereken final notu: " + CalculatePassingScore(numberOfNotes));
			}
			else
			{
				Console.WriteLine("Geçersiz not sayısı!!!");
				Score();
			}
		}

		// Geçme notu hesaplama fonksiyonu
		public static double CalculatePassingScore(int numberOfNotes)
		{
			double average = 50;
			double totalGrades = 0;
			double passingScore;
			int passingPercent = 100;
			double[] grades = new double[numberOfNotes];
			int[] percents = new int[numberOfNotes];

			for (int i = 0; i < (numberOfNotes - 1); i++)
			{
				Console.Write(i + 1 + "." + " notu giriniz: ");
				grades[i] = GradeControl(grades[i]);
				Console.Write(i + 1 + "." + " notun yüzdesini giriniz: ");
				percents[i] = PercentControl(percents[i]);
				passingPercent -= percents[i];
				totalGrades += (percents[i] * grades[i]);
			}
			if (passingPercent <= 100 && passingPercent >= 0)
			{
				passingScore = ((100 * average) - totalGrades) / passingPercent;
				return passingScore;
			}
			else
			{
				Console.WriteLine("Yanlış yüzde girdiniz not hesaplanamadı!!!");
				return 0.0;
			}

		}

		// Not yüzdesi kontrol fonksiyonu
		public static int PercentControl(int percent)
		{
			percent = Convert.ToInt32(Console.ReadLine());
			while (percent >= 100 || percent <= 0)
			{
				Console.WriteLine("Lütfen 0 ile 100 arasında bir sayı giriniz!");
				Console.WriteLine("Notun yüzdesini giriniz: ");
				percent = Convert.ToInt32(Console.ReadLine());
				if (percent <= 100 && percent >= 0)
				{
					break;
				}
			}
			return percent;
		}

		// Not kontrol fonksiyonu
		public static double GradeControl(double grade)
		{
			grade = Convert.ToDouble(Console.ReadLine());
			while (grade >= 100 || grade <= 0)
			{
				Console.WriteLine("Lütfen 0 ile 100 arasında bir sayı giriniz!");
				Console.WriteLine("Notu giriniz: ");
				grade = Convert.ToDouble(Console.ReadLine());
				if (grade <= 100 && grade >= 0)
				{
					break;
				}
			}
			return grade;
		}

		// Dönem ortalaması gösterme fonksiyonu
		public static void SemesterAverage()
		{
			Console.Clear();
			Console.WriteLine("Notların Katsayı Değerleri");
			Console.WriteLine("[90,00 – 100,00 ] - AA -> 4.00");
			Console.WriteLine("[85,00 - 89,99  ] - BA -> 3.50");
			Console.WriteLine("[80,00 - 84,99  ] - BB -> 3.00");
			Console.WriteLine("[75,00 - 79,99  ] - CB -> 2.50");
			Console.WriteLine("[65,00 - 74,99  ] - CC -> 2.00");
			Console.WriteLine("[58,00 - 64,99  ] - DC -> 1.50");
			Console.WriteLine("[50,00 - 57,99  ] - DD -> 1.00");
			Console.WriteLine("[40,00 - 49,99  ] - FD -> 0.50");
			Console.WriteLine("[0     - 39,99  ] - FF -> 0.00");
			Console.WriteLine();
			Console.Write("Alınan ders sayısını giriniz[5-8]: ");
			int lessonCount = Convert.ToInt32(Console.ReadLine());

			if( lessonCount == 5 )
			{
				SemesterAverageCalculate(lessonCount);
			}
			else if (lessonCount == 6)
			{
				SemesterAverageCalculate(lessonCount);
			}
			else if(lessonCount == 7)
			{
				SemesterAverageCalculate(lessonCount);
			}
			else if (lessonCount == 8)
			{
				SemesterAverageCalculate(lessonCount);
			}
			else 
			{
				Console.WriteLine("Lütfen geçerli ders sayısı girin!!!");
				SemesterAverage();
			}
		}

		// Dönem ortalaması hesaplama fonksiyonu
		public static double SemesterAverageCalculate(int lessonCount)
		{
			double average = 0.0;
			int totalAkts = 0;
			double[] grades = new double[lessonCount];
			int[] akts = new int[lessonCount];
			
			for (int i = 0; i < lessonCount; i++)
			{
				Console.Write(i + 1 + "." + " notun katsayı değerini giriniz giriniz: ");
				double factor = Convert.ToDouble(Console.ReadLine());
				while(factor <= 0 || factor >= 4)
				{
					Console.WriteLine("Yanlış değer girdiniz!!! [0-4]");
					Console.Write(i + 1 + "." + " notun katsayı değerini giriniz giriniz: ");
					factor = Convert.ToDouble(Console.ReadLine());
				}
				grades[i] = factor;
				Console.Write(i + 1 + "." + " notun AKTS değerini giriniz: ");
				int aktsValue = Convert.ToInt32(Console.ReadLine());
				while (aktsValue <= 0 || aktsValue >= 10)
				{
					Console.WriteLine("Yanlış değer girdiniz!!! [0-10]");
					Console.Write(i + 1 + "." + " notun AKTS değerini giriniz: ");
					aktsValue = Convert.ToInt32(Console.ReadLine());
				}
				akts[i] = aktsValue;
				average += (grades[i] * akts[i]);
				totalAkts += akts[i];
			}
			return (average / totalAkts);
		}
	}
}
