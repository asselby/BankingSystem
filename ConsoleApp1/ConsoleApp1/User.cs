﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class User
    {
        public int Id { get; set; }
        public string IIN { get; set; }
        public string FirstName { get; set; }

        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string IdCardNumber { get; set; }

        public string TelephoneNumber { get; set; }
    
        public Language Language { get; set; }

        public List<Account> Accounts { get; set; }

        public List<Card> Cards { get; set; }


    }
}
