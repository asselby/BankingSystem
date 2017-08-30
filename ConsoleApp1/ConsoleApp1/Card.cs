using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Card
    {
        public string IdentificationNUmber { get; set; }
        public bool IsValid { get; set; }
        public int SecurityNumber { get; set; }
        private int PIN { get; set; }

        public bool isBlocked { get; set; }

    }
}
