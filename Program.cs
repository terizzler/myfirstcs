// See https://aka.ms/new-console-template for more information

using System;

namespace Louied
{
  class Program
  {
        static void Main(string[] args){

            int rows = 5;

                for(int i = 1; i <= rows; i++){
                    for(int j = 1; j <= i; j++){
                        Console.Write("*");
                    }
                            Console.WriteLine(" ");
                }

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                string firstName = "Mark louie ";
                string lastName = "Tagalog";
                string name = firstName + lastName;
                Console.WriteLine(name);
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                    int x = 10;
                    int y = 20;
                    int z = x + y;
                    Console.WriteLine(z);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");

                    String a = "10", b = "20", c = a + b;
                    Console.WriteLine(c);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");


                    String sname = "Louie";
                    double english = 1.00, science = 1.00, math = 1.00, average = (english+science+math)/3;
                    bool passed = average<=2.00;
                    Console.WriteLine("student " + sname + " with a gpa of: " + average + " did pass?: " + passed);
        }
  }
}


