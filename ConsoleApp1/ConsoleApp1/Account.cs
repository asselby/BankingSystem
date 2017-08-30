using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Accounts
    {

        public int SelectionSum { get; set; }
        public double AvailabelAmount { get; set; }
        public string AccountNumber { get; set; }
        public string Sum { get; set; }
        public int GetMoney()
        {
            return SelectionSum;
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
