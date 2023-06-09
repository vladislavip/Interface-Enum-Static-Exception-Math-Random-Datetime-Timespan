using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09._06._23
{
    internal class P92 : GUN, IZoom
    {
        public P92(int totalBulletCount) : base(totalBulletCount)
        {

            if (totalBulletCount <= 60)
                this.TotalBulletCount = totalBulletCount;
            else
                throw new WrongTotalCountException("MAX BULLETS IS 60");


        }
        public override int TotalBulletCount { get; protected set; } = 60;

        public override int CurrentBulletCount { get; set; }

        public override void Reload()
        {
            CurrentBulletCount = TotalBulletCount;
            Console.WriteLine("P92 IS RELOADING");
            Console.WriteLine($"REMAINING BULLETS IS {CurrentBulletCount}");
        }

        public override void Shoot()
        {
            if (CurrentBulletCount > 0)

            {
                CurrentBulletCount -= 1;
                Console.WriteLine("P92 IS SHOOTING");
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
