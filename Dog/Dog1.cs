using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    public class Trainer
    {
        void Operate()
        {
            // subscribe to event
            var dog = new Poodle();
            dog.HasSpoken += dog_HasSpoken;
        }

        private void dog_HasSpoken(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    public partial class Dog
    {
        // tab twice auto property
        public string Name { get; set; }

        private string _name;

        public string Name1
        {
            get { return _name; }
            set { _name = value; }
        }

        public int MyProperty { get; private set; }

        // event is a class/obj talking back to me
        public event EventHandler HasSpoken;

        public void Speak(string what ="bark")
        {
            // todo
            if(HasSpoken != null)
                HasSpoken(this, EventArgs.Empty);
        }

        public void Speak(int times, string what = "bark", bool sit = true)
        {
            // todo
        }


        //only by this class
        private void Foo() { }
        // only this and derived classes
        protected void Barp() { }
        // only in this assembly
        internal void Bar() { }
    }

    class Poodle: Dog
    {
        void x()
        {
            this.Speak(2, "woof");
            this.Speak(3);
            this.Speak(4,sit:false);
        }
    }
}
