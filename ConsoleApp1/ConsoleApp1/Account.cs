using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Account
    {
        public delegate void AccountStateHandler(string message);
        AccountStateHandler del;






        public double AvailabelAmount { get; set; }
        public string AccountNumber { get; set; }
        public void Check(double x)
        {
            x = AvailabelAmount;

            Console.WriteLine("Вашем счете хранится {0} ", x);
        }
        public void PutMoney(double x)
        {
            Console.WriteLine("Вы пополнили счет на сумму {0}", x);
        }
        public void ShowAmountMoney(double x)
        {
            AvailabelAmount = AvailabelAmount + x;
            Console.WriteLine("Сумма на вашем счете состовляет {0}", AvailabelAmount);
        }
    }
}
