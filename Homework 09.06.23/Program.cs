namespace Homework_09._06._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AK47 aK47 = new AK47(32);

            aK47.Reload();

            for (int i = 0; i < 32; i++) 
            {
                aK47.Shoot();

                if (i==31)
                { aK47.Reload(); 
                }
            }
        }
    }
}