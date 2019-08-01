using System.Collections.Generic;
using System;
namespace Test
{


    class Program
    {


        static void Main(string[] args)
        {
            var names = new List<String>();

            while(true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");

                var input = Console.ReadLine();
                if(String.IsNullOrEmpty(input))
                {
                    break;

                }
                names.Add(input);

            }

            if (names.Count == 1)
            {
                Console.WriteLine("{0} liked your post" , names[0]);
            }
            else if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} liked your post", names[0], names[1]);
            }
            else if (names.Count >2 )
            {
                Console.WriteLine("{0} and {1} and {2} liked your post", names[0], names[1], names.Count - 2);
            }
            else
            {
                Console.WriteLine("No one liked it");
            }
        }

    }

            


  }




    

    


               

           


