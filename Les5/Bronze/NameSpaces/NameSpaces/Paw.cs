using System;
using System.Collections.Generic;
using System.Text;

namespace Paw
{
    class Paws
    {
        private bool isClean = false;

        public void Clean()
        {
            isClean = true;
        }

        public bool IsClean()
        {
            return isClean;
        }
    }
}