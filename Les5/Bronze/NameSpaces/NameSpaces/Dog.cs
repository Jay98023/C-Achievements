using System;
using System.Collections.Generic;
using System.Text;

namespace Dog
{
    class Dogs
    {
        private Paw.Paws paw;

        public Dogs()
        {
            paw = new Paw.Paws();
        }

        public Paw.Paws GetPaw()
        {
            return paw;
        }
    }
}
