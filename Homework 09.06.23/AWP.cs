using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09._06._23
{
    internal class AWP : GUN, IZoom
    {
        public AWP(int totalBulletCount) : base(totalBulletCount)
        {

            if (totalBulletCount <= 10)
                this.TotalBulletCount = totalBulletCount;
            else
                throw new WrongTotalCountException("MAX BULLETS IS 10");


        }
        public override int TotalBulletCount { get; protected set; }

        public override int CurrentBulletCount { get; set; }

        public override void Reload()
        {
            CurrentBulletCount = TotalBulletCount;
            Console.WriteLine("AWP IS RELOADING");
            Console.WriteLine($"REMAINING BULLETS IS {CurrentBulletCount}");
        }

        public override void Shoot()
        {
            if (CurrentBulletCount > 0)

            {
                CurrentBulletCount -= 1;
                Console.WriteLine("AWP IS SHOOTING");
                Console.WriteLine($"REMAINING BULLETS IS {CurrentBulletCount}");
            }

            else
            {
                throw new InsufficientBulletCountExceptions1("Out of ammo");
            }

        }
        public void Zoom()
        {
            Console.WriteLine("AWP IS ZOOMING");
        }
    }
}
