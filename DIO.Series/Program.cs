using System;

namespace DIO.Series
{
    class Program
    {
        static SeriesRepository Repository = new SeriesRepository();
        static void Main(string[] args)
        {
            
            string userOption = "";
            do 
            {
                userOption = getUserOptions();
                switch (userOption)
				{
					case "1":
						getSerieList();
						break;
					case "2":
						AddSerie();
						break;
					case "3":
						UpdateSerie();
						break;
					case "4":
						DeleteSerie();
						break;
					case "5":
						ShowSerieInformarion();
						break;
					case "C":
						Console.Clear();
						break;
                    case "X":
                        Console.WriteLine("Exiting.");
                        break;
					default:
						throw new ArgumentOutOfRangeException();
				}
            }while (userOption.ToUpper() != "X");

			Console.WriteLine("Thank you for using the program.");
			Console.ReadLine();
        }
        private static void UpdateSerie()
        {
            Console.Write("Enter the serie Id: ");
			int inputId = int.Parse(Console.ReadLine());

            GetUserSerieInformation(out int intputGenre, out string inputTitle,
                                                    out int inputYear, out string inputDescription);

			Series updatedSerie = new Series(id: inputId,
										genre: (Genres)intputGenre,
										title: inputTitle,
										year: inputYear,
										description: inputDescription);

			Repository.Update(inputId, updatedSerie);
        }
        private static void AddSerie()
        {
            Console.WriteLine("Insert a new serie");

            GetUserSerieInformation(out int intputGenre, out string inputTitle,
                                                    out int inputYear, out string inputDescription);

			Series newSerie = new Series(id: Repository.nextId(),
										genre: (Genres)intputGenre,
										title: inputTitle,
										year: inputYear,
										description: inputDescription);

			Repository.Insert(newSerie);
        }
        private static void getSerieList()
        {
            var list = Repository.GetList();

            if (list.Count == 0)
            {
                Console.WriteLine("No serie has been registred.");
            }
            else
            {
                foreach (Series serie in list)
                {
                    Console.WriteLine($"ID {serie.getId()}: {serie.getTitle()}{(serie.getDelete() ? " - Deleted." : ".")}");
                }
            }

        }
        private static void ShowSerieInformarion()
		{
			Console.Write("Enter the serie Id: ");
			int inputId = int.Parse(Console.ReadLine());

			var serie = Repository.ReturnById(inputId);

			Console.WriteLine(serie);
		}
        private static void DeleteSerie()
        {
			Console.Write("Enter the serie Id: ");

			int inputId = int.Parse(Console.ReadLine());

			Repository.Delete(inputId);
        }
        private static string getUserOptions()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Series program");
			Console.WriteLine("Select the option:");

			Console.WriteLine("1- List of series on the program");
			Console.WriteLine("2- Insert a new serie");
			Console.WriteLine("3- Update serie");
			Console.WriteLine("4- Delete serie");
			Console.WriteLine("5- Get serie information");
			Console.WriteLine("C- Clean the window");
			Console.WriteLine("X- Exit");
			Console.WriteLine();

			string userOption = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return userOption;
		}
        private static void GetUserSerieInformation(out int inputGenre, out string inputTitle,
                                                    out int inputYear, out string inputDescription)
        {
            foreach (int i in Enum.GetValues(typeof(Genres)))
			{
				Console.WriteLine($"{i}-{Enum.GetName(typeof(Genres), i)}");
			}
			Console.Write("Select the genre: ");
			inputGenre = int.Parse(Console.ReadLine());

			Console.Write("Enter the serie title: ");
			inputTitle = Console.ReadLine();

			Console.Write("Enter the released serie year: ");
			inputYear = int.Parse(Console.ReadLine());

			Console.Write("Enter the serie Description: ");
			inputDescription = Console.ReadLine();
        }
    }
}
