using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09._06._23
{
    internal abstract class GUN
    {

        public GUN(int TotalBulletCount)
        {  if (TotalBulletCount >= 0)
                this.TotalBulletCount = TotalBulletCount;

            else
                throw new InvalidBulletCountException ("Bullets count cant be less than zero");
        }
        public abstract int TotalBulletCount { get; protected set; }   
        public abstract int CurrentBulletCount { get; set;}

        public abstract void Shoot();
        //shoot 1 buullet 

        public abstract void Reload();
        // TotalBulletCount =  CurrentBulletCount 


        

    }
}
