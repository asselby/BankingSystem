using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class UsersBase
    {

        List<User> users;
        public UsersBase()
        {
            users = new List<User>();
        }

        public void Dump()
        {

            Account account = new Account()
            {
                AccountNumber = ,
                AvailabelAmount = ,
                          
            }


            User Elnar = new User()
            {
                IIN = "950419359295",
                FirstName = "Уважанов",
                MiddleName = "Ельнар",
                LastName = "Ерланулы",
                IdCardNumber = "123456789",
                TelephoneNumber = "87055851520",

                Language = new Language()
                {
                    nameOfLanguage = "Russian"
                }
              
            };
            
            
           
        }
    }
}
