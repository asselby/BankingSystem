using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UsersBase
    {
        User user = new User()
        {

        };

        public void Dump()
        {

            user = new User();

            Card card = new Card();
            card.IdentificationNUmber = "1234 4567 7890 0123";

            user.Cards.Add(card);
        }
    }
}
