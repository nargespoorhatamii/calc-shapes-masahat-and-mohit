using System;
namespace Tamrin
{
	class calc
	{
		private double r_max;
		private double r_min;
		double pi = 3.14;
		public double Max
		{
			get{ return r_max;}
			set {if (value > 0)
				{ r_max = value; }
			}
		}

		public double Min
		{
			get { return r_min;}
			set { if (value > 0)
				{ r_min =value; } }
			
		}
		public calc() { } //mokhareb function
		public calc(double Max, double Min)
		{
			r_max = Max;
			r_min = Min;
		}//sazande function
		public double calculate()
		{
			return pi * r_max * r_min;
		}
	}
	class main
	{
		public static void Main()
		{  
			calc c = new calc(10, 5);
			Console.WriteLine(c.calculate());
		}
	}
}



 