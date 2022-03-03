using DIO_Series.Enum;
using System;

namespace DIO_Series
{
    class Program
    {
		static SerieRepository repository = new SerieRepository();
		static void Main(string[] args)
        {
			string userOption = getUserOption();

			while (userOption.ToUpper() != "X")
			{
				switch (userOption)
				{
					case "1":
						listSerie();
						break;
					case "2":
						InsertSerie();
						break;
					case "3":
						UpdateSerie();
						break;
					case "4":
						DeletSerie();
						break;
					case "5":
						ViewSerie();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				userOption = getUserOption();
			}

			Console.WriteLine("Thank you for using our services!");
			Console.ReadLine();
		}

		private static void DeletSerie()
		{
			Console.Write("Insert the serie Id: ");
			int serieIndex = int.Parse(Console.ReadLine());

			repository.Delet(serieIndex);
		}

		private static void ViewSerie()
		{
			Console.Write("Insert the serie Id: ");
			int serieIndex = int.Parse(Console.ReadLine());

			var serie = repository.ReturnForId(serieIndex);

			Console.WriteLine(serie);
		}

		private static void UpdateSerie()
		{
			Console.Write("Insert the serie Id: ");
			int serieIndex = int.Parse(Console.ReadLine());

			foreach (int i in Genre.GetValues(typeof(Genre)))
			{
				Console.WriteLine("{0}-{1}", i, Genre.GetName(typeof(Genre), i));
			}
			Console.Write("Enter the gender between the options: ");
			int setGenre = int.Parse(Console.ReadLine());

			Console.Write("Enter the series title: ");
			string setTitle = Console.ReadLine();

			Console.Write("Enter the Year of Production of the Series: ");
			int setYear = int.Parse(Console.ReadLine());

			Console.Write("Enter Series Description: ");
			string setDescription = Console.ReadLine();

            Serie updateSerie = new Serie(id: serieIndex,
										genre: (Genre)setGenre,
										title: setTitle,
										year: setYear,
										description: setDescription);

			repository.Update(serieIndex, updateSerie);
		}
		private static void listSerie()
		{
			Console.WriteLine("List Series");

			var lista = repository.List();

			if (lista.Count == 0)
			{
				Console.WriteLine("No series registered");
				return;
			}

			foreach (var serie in lista)
			{
				var excluido = serie.returnDeleted();

				Console.WriteLine("#ID {0}: - {1} {2}", serie.returnId(), serie.returnTitle(), (excluido ? "*Excluído*" : ""));
			}
		}

		private static void InsertSerie()
		{
			Console.WriteLine("Insert a new serie");

            foreach (int i in Genre.GetValues(typeof(Genre)))
			{
				Console.WriteLine("{0}-{1}", i, Genre.GetName(typeof(Genre), i));
			}
			Console.Write("Enter the gender between the options: ");
			int setGenre = int.Parse(Console.ReadLine());

			Console.Write("Enter the series title: ");
			string setTitle = Console.ReadLine();

			Console.Write("Enter the Year of Production of the Series: ");
			int setYear = int.Parse(Console.ReadLine());

			Console.Write("Enter Series Description: ");
			string setDescription = Console.ReadLine();

            Serie newSerie = new Serie(id: repository.NextId(),
										genre: (Genre)setGenre,
										title: setTitle,
										year: setYear,
										description: setDescription);

			repository.Insert(newSerie);
		}

		private static string getUserOption()
		{
			Console.WriteLine();
			Console.WriteLine("DIOflix at your service!!!");
			Console.WriteLine("choose an option:");

			Console.WriteLine("1 - List serie");
			Console.WriteLine("2 - Insert a new serie");
			Console.WriteLine("3 - Update Serie");
			Console.WriteLine("4 - Delet Serie");
			Console.WriteLine("5 - View Serie");
			Console.WriteLine("C - Clean");
			Console.WriteLine("X- Exit");
			Console.WriteLine();

			string userOption = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return userOption;
		}
	}
}

