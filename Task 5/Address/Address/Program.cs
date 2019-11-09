using System;

namespace Address
{
    class Program
    {
        static void Main(string[] args)
        {
            Address myAddress = new Address("Belarus", "Minsk", "Machulskogo", 24, 220078, 119);

            myAddress.Show();
        }
    }
}
