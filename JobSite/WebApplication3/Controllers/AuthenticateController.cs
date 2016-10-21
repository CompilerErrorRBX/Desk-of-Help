using System;
using System.Web.Mvc;
using System.DirectoryServices;
using System.Diagnostics;

namespace WebApplication3.Controllers
{
    public class AuthenticateController : Controller
    {
        // GET: Authenticate
        public AuthenticateController Index()
        {
			//return View();
			return null;
        }

		[HttpPost]
		public void createAccount(string fname, string lname, string password, string email, string salt)
		{
			User u = new User();
			u.emailAddress = email;
			u.firstName = fname;
			u.lastName = lname;
			u.passwordHash = password;
			u.passwordSalt = salt;
			UsersController c = new UsersController();
			c.Create(u);
		}

    }
}