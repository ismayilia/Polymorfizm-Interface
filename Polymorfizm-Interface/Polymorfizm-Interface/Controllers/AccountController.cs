using Polymorfizm_Interface.Helpers.ResponseMessages;
using Polymorfizm_Interface.Services;
using Polymorfizm_Interface.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfizm_Interface.Controllers
{
    internal class AccountController
    {
        private readonly IAccountService _accountService;


        public AccountController()
        {
            _accountService = new AccountService();
        }


        //public void Login()
        //{
        //    Console.WriteLine("Add email: ");
        //    string email = Console.ReadLine();

        //    Console.WriteLine("Add password: ");
        //    string password = Console.ReadLine();


        //    string result=_accountService.Login(email, password);

        //    Console.WriteLine(result);
        //}

        public void Login()
        {
            Console.WriteLine("Add email: ");
            Email:  string email = Console.ReadLine();

            Console.WriteLine("Add password: ");
            string password = Console.ReadLine();


            bool isLogin = _accountService.Login(email, password);

            if (isLogin)
            {
                Console.WriteLine(AccountMessages.LoginSuccess);
                Console.WriteLine("Welcome" + email);
            }
            else
            {
                Console.WriteLine(AccountMessages.LoginFailed);


                goto Email;
            }
            
        }









    }

    





}
