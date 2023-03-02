using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckToTurkey
{
    class Turkey
    {

        private readonly IGraznar gluglu;
        private readonly IVolar fly;
        protected Turkey(IGraznar gluglu, IVolar fly)
        {
            this.gluglu = gluglu;
            this.fly = fly;
        }

    }
}
