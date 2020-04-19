using System;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            var userRepository = new UserRepository();
            var program = new UserProgram(userRepository);
            program.CreateUser("001", "ymiyamoto");
        }
    }
}
