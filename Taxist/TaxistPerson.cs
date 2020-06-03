using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    [Serializable]
    public class TaxistPerson : Person
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
        public Car car;
        public bool IsWorking;
        public TaxistPerson() : base()
        {
            Nickname = "";
            Password = "";
            car = null;
            IsWorking = false;
        }
        public TaxistPerson(string name, string surname,bool isWorking) : base(name, surname) { car = null; IsWorking = isWorking; }
    }
}
