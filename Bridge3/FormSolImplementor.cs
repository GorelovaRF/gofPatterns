using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge3
{
    public abstract class Implementor
    {
        public abstract void create(string nombreForm);

        public abstract void show();
    }
}