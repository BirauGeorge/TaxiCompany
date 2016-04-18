using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTools
{
    public interface IDecComponents
    {
        void AddComponent();
    }

    public class NewCar : IDecComponents
    {
        public void AddComponent()
        {
            Console.WriteLine("New Standar Car ready for tunning!.");
        }
    }

    public abstract class Parts : IDecComponents
    {
        protected IDecComponents Input;

        protected Parts(IDecComponents i)
        {
            Input = i;
        }

        public abstract void AddComponent();
    }

    public class AudioSistem : Parts, IDecComponents
    {
        public AudioSistem(IDecComponents i)
            : base(i)
        {

        }

        public override void AddComponent()
        {
            Input.AddComponent();
            Console.WriteLine("Audio sistem added");
        }
    }
    public class PanoramicRoof : Parts, IDecComponents
    {
        public PanoramicRoof(IDecComponents i)
            : base(i)
        {

        }

        public override void AddComponent()
        {
            Input.AddComponent();
            Console.WriteLine("Panoramic roof added");
        }
    }
    public class SportKit : Parts, IDecComponents
    {
        public SportKit(IDecComponents i)
            : base(i)
        {
            
        }

        public override void AddComponent()
        {
            Input.AddComponent();
            Console.WriteLine("Sport kit added");
        }
    }
    class Decorator
    {
    }
}
