using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Phone
    {
        private readonly IList<IPushNotifiction> _pushsNotifictions;
        private string _state ;

        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Notify();
            }
        }

        public Phone()
        {
            _pushsNotifictions=new List<IPushNotifiction>();
        }

        public void Attach(IPushNotifiction pushNotifiction)
        {
            if (!_pushsNotifictions.Contains(pushNotifiction))
            {
                _pushsNotifictions.Add(pushNotifiction);
            }
        }

        public void Detach(IPushNotifiction pushNotifiction)
        {
            if (_pushsNotifictions.Contains(pushNotifiction))
            {
                _pushsNotifictions.Remove(pushNotifiction);
            }
        }

        private void Notify()
            {
                foreach (var pushsNotifiction in _pushsNotifictions)
                {
                    pushsNotifiction.Update(State);
                }
            }
        
    }
}
