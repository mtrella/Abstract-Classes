using System.Security.Cryptography;
using System.Net.Http;
using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Ford ford = new Ford();
            ford.Start();
            ford.Drive();

            Dodge dodge = new Dodge();
            dodge.Start();
            dodge.Drive();

        }
    }
}
