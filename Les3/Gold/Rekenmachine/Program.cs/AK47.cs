using System;
using System.Collections.Generic;
using System.Text;

namespace Program.cs
{
    class AK47 : Gun
    {
        public void Shoot()
        {
            rateOfFire = 10;
            damage = 2;
            int theDamageDone = rateOfFire * damage;
        }
    }
}
