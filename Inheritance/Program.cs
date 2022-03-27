using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var baseClass = new BaseClass();
            var derivedOverride = new DerivedOverride();
            var derivedNew = new DerivedNew();
            var derivedOverwrite = new DerivedOverwrite();

            baseClass.Name();
            derivedOverride.Name();
            derivedNew.Name();
            derivedOverwrite.Name();

            Console.ReadLine();
            baseClass.Name();
            derivedOverride.Name();
            ((BaseClass)derivedNew).Name();
            ((BaseClass)derivedOverride).Name();
            ((BaseClass)derivedOverwrite).Name();
            Console.ReadLine();

            var t1 = typeof(BaseClass);
            Console.WriteLine(t1.Name);
            Console.WriteLine(t1.Assembly);

//BaseClass
//DerivedOverride
//New
//Overwrite

//BaseClass
//DerivedOverride
//BaseClass
//DerivedOverride
//BaseClass

//BaseClass
//Inheritance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

            //// boxing convert a number to an object
            /// unboxing is to cast it back to int
            /// 

//generics class

            void Breakfast()
            {
                var bird = new Animal<Egg>();
                var pig = new Animal<Piglet>();
            }

        }
    }

    internal class BaseClass
    {
        // virtual can be overriden
        internal virtual void Name()
        {
            Console.WriteLine("BaseClass");
        }
    }

    internal class DerivedOverride : BaseClass
    {
        internal override void Name()
        {
            Console.WriteLine("DerivedOverride");
        }
    }

    internal class DerivedNew : BaseClass
    {
        // new complete replacement
        internal new void Name()
        {
            Console.WriteLine("New");
        }
    }

    internal class DerivedOverwrite : BaseClass
    {
        // hiding if no keyword

        // internal = accessible in the same asembly 
        internal void Name()
        {
            Console.WriteLine("Overwrite");
        }
    }

    //generic class

    public abstract class Offspring { }
    public class Egg : Offspring { }
    public class Piglet : Offspring { }

    public class Animal<T> where T : Offspring {
        public T Offspring { get; set; }
    }
}
