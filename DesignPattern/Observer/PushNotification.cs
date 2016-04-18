using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
   public class PushNotification : IPushNotifiction
    {
        private readonly Phone _phone;
        private readonly string _name;
        private string _state;

        public PushNotification(string name, Phone phone)
        {
            _name = name;
            _phone = phone;
        }

        public void Update(string state)
        {
            _state = _phone.State;
            Console.WriteLine("Phone {0} tocmai a primit updatul de soft versiunea {1}",_name,_state);
        }
    }
}
