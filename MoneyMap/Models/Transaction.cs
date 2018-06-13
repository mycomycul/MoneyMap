using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneyMap.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public enum Direction{Inbound,Outbound}
        public Decimal Amount { get; set; }
        public Client Client { get; set; }

    }

}