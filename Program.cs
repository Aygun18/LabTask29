namespace LabTask29
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("ZooShop");
			
				Console.WriteLine("Zehmet olmasa secim edin: ");
			    check:
				Console.WriteLine("1. Register");
				Console.WriteLine("2. Login");
				Console.WriteLine("3. Exit");
				List<User> users = new List<User>();
			    User user = new User();

			    string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						Console.WriteLine("Adinizi daxil edin: ");
						string name = Console.ReadLine();
						Console.WriteLine("Soyadinizi daxil edin: ");
						string surname = Console.ReadLine();
						Console.WriteLine("Emailinizi daxil edin:");
						string email = Console.ReadLine();
						Console.WriteLine("Shifrenizi daxil edin: ");
						string password = Console.ReadLine();
					   user.Register(name, surname, email, password, Role.Admin);
					goto check;
				case "2":
						Console.WriteLine("Emailinizi daxil edin: ");
						string email1 = Console.ReadLine();
						Console.WriteLine("Sifreni daxil edin: ");
						string password1 = Console.ReadLine();
						user.Login(email1, password1);
						break;
					case "3":
						Environment.Exit(0);
						//Console.WriteLine("Cixis etdiniz..");
						break;
					default:
						Console.WriteLine("Yanlis secim");
						break;
				}
			
		}
	}
}