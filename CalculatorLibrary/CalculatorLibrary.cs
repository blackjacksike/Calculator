using System;
using System.IO;
using System.Diagnostics;

namespace CalculatorLibrary
{
	public class Arithmetics
	{
		public Arithmetics() 
		{
			try
			{
				StreamWriter logFile = File.CreateText("calculator.log");
				Trace.Listeners.Add(new TextWriterTraceListener(logFile));
				Trace.AutoFlush = true;
				Trace.WriteLine(String.Format("LOG START ON {0}", System.DateTime.Now.ToString()));
			}

			catch(Exception e) 
			{
				Console.WriteLine(e.Message);
				Trace.WriteLine(e.Message);
			}
		}
		
		private double result;
		public double Result
		{
			get { return result; }
			set { result = value; }
		}

		public double Addition(double number1, double number2)
		{
			result = number1 + number2;
			Console.WriteLine("{0} + {1} = {2}", number1, number2, result);
			Trace.WriteLine(String.Format("{0} + {1} = {2}", number1, number2, result));
			return result;
		}

		public double Subtraction(double number1, double number2)
		{
			result = number1 - number2;
			Console.WriteLine("{0} - {1} = {2}", number1, number2, result);
			Trace.WriteLine(String.Format("{0} - {1} = {2}", number1, number2, result));
			return result;
		}

		public double Multiplication(double number1, double number2)
		{
			result = number1 * number2;
			Console.WriteLine("{0} * {1} = {2}", number1, number2, result);
			Trace.WriteLine(String.Format("{0} * {1} = {2}", number1, number2, result));
			return result;
		}

		public double Division(double number1, double number2)
		{
			result = number1 / number2;
			Console.WriteLine("{0} / {1} = {2}", number1, number2, result);
			Trace.WriteLine(String.Format("{0} / {1} = {2}", number1, number2, result));
			return result;
		}

		public double Modulus(double number1, double number2)
		{
			result = number1 % number2;
			Console.WriteLine("{0} % {1} = {2}", number1, number2, result);
			Trace.WriteLine(String.Format("{0} % {1} = {2}", number1, number2, result));
			return result;
		}
	}
}
