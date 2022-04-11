using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KR
{
    
    interface IpropertyObserver
    {
        void receive(string text);
    }
    internal class User: IpropertyObserver
    {
        Regex regex = new Regex(@"[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        protected string Name { get; set; }
        

        public string SGEmail
        {
            get { return Email; }
            set
            {
                if (regex.IsMatch(value))
                {
                    Email = value;
                }  }
        }

        protected string Email;
        
       protected string Phone { get; set; }

        public void receive(string text) { }
    }
}
