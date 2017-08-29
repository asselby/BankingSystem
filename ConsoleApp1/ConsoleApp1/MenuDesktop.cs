using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MenuDesktop
    {
        public void Handler()
        {
            Console.WriteLine("Введите карточку");
            User user = new User();
            Card card = new Card();
            string strWrittedPassword;
            int writtedPassword;

            for (;;)
            {
                Console.Clear();
                Console.WriteLine("Введите PIN");
                strWrittedPassword = Console.ReadLine();

                if(Int32.TryParse(strWrittedPassword,out writtedPassword))
                {
                    var cardControll = user.Cards.Where(c => c.PIN == writtedPassword);
                }

                

            }
        }
    }
}
