using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class LogApplication
    {
        private ILogger _logger;

        public LogApplication(ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            bool run = true;
            while (run)

            {
                Console.Clear();
                Console.Write("1) Add message to log\n" +
                                  "2) Print log\n" + "\nChoice: ");

                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Add a message:");
                        _logger.Log(Console.ReadLine());
                        break;

                    case "2":
                        foreach (var post in _logger.LogPosts)
                        {
                            Console.WriteLine(post);
                        }
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
