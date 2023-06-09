using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09._06._23
{
    internal class AK47 : GUN
    {

        public AK47(int totalBulletCount) : base(totalBulletCount)
        {
            if (totalBulletCount <= 32)
            this.TotalBulletCount = totalBulletCount;
            else
                throw new WrongTotalCountException ("MAX BULLETS IS 32");


        }

        public override int TotalBulletCount { get; protected set; } 
      
        public override int CurrentBulletCount { get; set; }

        public override void Reload()
        {
            CurrentBulletCount = TotalBulletCount;
            Console.WriteLine("AK47 IS RELOADING");
            Console.WriteLine($"REMAINING BULLETS IS {CurrentBulletCount}");
        }

        public override void Shoot()
        {
            if (CurrentBulletCount > 0)

            {
                CurrentBulletCount -= 1;
                Console.WriteLine("AK47 IS SHOOTING");
                Console.WriteLine($"REMAINING BULLETS IS {CurrentBulletCount}");
            }

            else
            {
                throw new InsufficientBulletCountExceptions1("Out of ammo");
            }


        }




    }
}
    

