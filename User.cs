using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LabTask29
{
	internal class User
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public Role Role { get; set; }
		public static List<User> users { get; set; } = new();
        
        public void Register(string name, string surname, string email, string password, Role role)
		{
			bool checkEmail = IsValidEmail(email);
			bool checkPassword = IsValidPassword(password);
			if (!checkEmail)
			{
				Console.WriteLine("Emailin formati duzgun deyil..");
			}
			if (!checkPassword)
			{
				Console.WriteLine("Sifrenin formati duzgun deyil..");
			}
			if (!checkPassword || !checkEmail)
			{
				return;
			}
			users.Add(new User {Name= name,Surname= surname, Email=email, Password=password });
            Console.WriteLine("Qeydiyyatdan kecdiniz..");
        }
		public bool IsValidPassword(string password)
		{
			bool checkIsUpper = false;
			bool checkIsLower = false;

			if (password.Length >= 8)
			{	
				foreach (var p in password)
				{
					if (char.IsUpper(p))
					{
						checkIsUpper = true;
					}
					if (char.IsLower(p))
					{
						checkIsLower = true;
					}
					
				}
			}
			return checkIsLower && checkIsUpper;
		}
		public bool IsValidEmail(string email)
		{
			return email.Contains("gmail.com");
		}
		public void Login(string email,string password)
		{
			if (users == null)
			{
                Console.WriteLine("Bele user yoxdur");
				return;
            }
			foreach (var user in users)
			{
				if (user.Email.Equals(email) && user.Password.Equals(password))
				{
					Console.WriteLine("Giris ugurlu oldu..");
				}
				else
				{
					Console.WriteLine("Email ve ya sifre duzgun deyil. Yeniden cehd edin");
				}
			}
			
		}
	}
}
