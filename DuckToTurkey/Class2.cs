using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckToTurkey
{
    public class VolarConAlas : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("Volando con alas");
        }
    }

    public class NoVolar : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("No puedo volar");
        }
    }
    class Mallard : Pato
    {
        public Mallard() :
            base(new Quack(), new VolarConAlas())
        {
        }

        public override void Mostrar()
        {
            Console.WriteLine("Soy un Mallard");
        }
    }

    class Rubber : Pato
    {
        public Rubber() :
                base(new Squeze(), new NoVolar())
        {
        }


        public override void Mostrar()
        {
            Console.WriteLine("Soy un Rubber");
        }
    }

    class DuckDecoy : Pato
    {
        public DuckDecoy() :
            base(new Mute(), new NoVolar())
        {

        }


        public override void Mostrar()
        {
            Console.WriteLine("Soy un Decoy");
        }
    }

    class RedHead : Pato
    {
        public RedHead() :
            base(new Quack(), new VolarConAlas())
        {

        }


        public override void Mostrar()
        {
            Console.WriteLine("Soy un RedHead");
        }
    }
}
