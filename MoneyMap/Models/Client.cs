using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneyMap.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public enum Type {Income,Car,House,Grocery,Purchase,Recreation,Gas}
    }



}