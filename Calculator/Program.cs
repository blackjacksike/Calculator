using System;
using CalculatorLibrary;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			double? num1, num2;
			num1 = null;
			num2 = null;

			Arithmetics arithmetics = new Arithmetics();

			while (true)
			{
				Console.WriteLine("This is a calculator. Type 'list' to see all possible operations.");
				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":

						Console.WriteLine("You have chosen 'Addition'.");
						/*The user has to enter the numbers first, then the code will take care of the operation.
						If the user has not cleared the previous result, they won't have to enter the first number.*/

						try
						{
							Console.WriteLine("Please enter the first number if necessary...");
							num1 ??= Convert.ToDouble(Console.ReadLine()); // if num1 has been cleared, enter the number. Otherwise, keep the same value.

							Console.WriteLine("Now, please enter the second number...");
							num2 = Convert.ToDouble(Console.ReadLine());
						}
						catch (Exception e) 
						{
							Console.WriteLine(e.Message);
							continue;
						}

						arithmetics.Addition((double)num1, (double)num2);
						num1 = arithmetics.Result;

						continue;

					case "2":

						Console.WriteLine("You have chosen 'Subtraction'.");

						try
						{
							Console.WriteLine("Please enter the first number if necessary...");
							num1 ??= Convert.ToDouble(Console.ReadLine()); // if num1 has been cleared, enter the number. Otherwise, keep the same value.

							Console.WriteLine("Now, please enter the second number...");
							num2 = Convert.ToDouble(Console.ReadLine());
						}
						catch (Exception e)
						{
							Console.WriteLine(e.Message);
							continue;
						}

						arithmetics.Subtraction((double)num1, (double)num2);
						num1 = arithmetics.Result;

						continue;

					case "3":

						Console.WriteLine("You have chosen 'Multiplication'.");

						try
						{
							Console.WriteLine("Please enter the first number if necessary...");
							num1 ??= Convert.ToDouble(Console.ReadLine()); // if num1 has been cleared, enter the number. Otherwise, keep the same value.

							Console.WriteLine("Now, please enter the second number...");
							num2 = Convert.ToDouble(Console.ReadLine());
						}
						catch (Exception e)
						{
							Console.WriteLine(e.Message);
							continue;
						}

						arithmetics.Multiplication((double)num1, (double)num2);
						num1 = arithmetics.Result;

						continue;

					case "4":

						Console.WriteLine("You have chosen 'Division'.");

						try
						{
							Console.WriteLine("Please enter the first number if necessary...");
							num1 ??= Convert.ToDouble(Console.ReadLine()); // if num1 has been cleared, enter the number. Otherwise, keep the same value.

							Console.WriteLine("Now, please enter the second number...");
							num2 = Convert.ToDouble(Console.ReadLine());
						}
						catch (Exception e)
						{
							Console.WriteLine(e.Message);
							continue;
						}

						arithmetics.Division((double)num1, (double)num2);
						num1 = arithmetics.Result;

						continue;

					case "5":

						Console.WriteLine("You have chosen 'Modulus'.");

						try
						{
							Console.WriteLine("Please enter the first number if necessary...");
							num1 ??= Convert.ToDouble(Console.ReadLine()); // if num1 has been cleared, enter the number. Otherwise, keep the same value.

							Console.WriteLine("Now, please enter the second number...");
							num2 = Convert.ToDouble(Console.ReadLine());
						}
						catch (Exception e)
						{
							Console.WriteLine(e.Message);
							continue;
						}

						arithmetics.Modulus((double)num1, (double)num2);
						num1 = arithmetics.Result;

						continue;

					case "list":
						Console.WriteLine(" 1-Addition \n 2-Subtraction \n 3-Multiplication \n 4-Division \n 5-Modulus: Find the remainder of a division. \n clear-Clear the previous result. \n exit-Exit the program.");
						continue;

					case "clear":
						num1 = null;
						Console.WriteLine("The result has been cleared.");
						continue;

					case "exit":
						Console.WriteLine("Please press <Enter> to exit...");
						Console.ReadKey();
						break;

					default:
						Console.WriteLine("Wrong input. Please enter a valid input.");
						continue;
				}
				break;
			}
		}
	}
}
