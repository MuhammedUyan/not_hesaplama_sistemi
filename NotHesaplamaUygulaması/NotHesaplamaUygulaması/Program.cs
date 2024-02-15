
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
					Console.Clear();
					Console.Write("Dersin not sayısı (En düşün 2 en yüksek 5 olabilir!): ");
					int numberOfNotes = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine();
					Console.WriteLine("Dersi geçmek için gereken final notu: " + Score(numberOfNotes));
					Console.WriteLine();
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
		public static double Score(int numberOfNotes)
		{
			if (numberOfNotes == 2)
			{
				return CalculatePassingScore(numberOfNotes);
			}
			else if (numberOfNotes == 3)
			{
				return CalculatePassingScore(numberOfNotes);
			}
			else if (numberOfNotes == 4)
			{
				return CalculatePassingScore(numberOfNotes);
			}
			else if (numberOfNotes == 5)
			{
				return CalculatePassingScore(numberOfNotes);
			}
			else
			{
				return 0.0;
			}
		}

		// Geçme notu hesaplama fonksiyonu
		public static double CalculatePassingScore(int numberOfNotes)
		{
			double average = 50;
			double totalGrades = 0;
			double passingScore;
			int passingPercent = 100;
			double[] grades = new double[4];
			int[] percents = new int[4];

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
	}
}
