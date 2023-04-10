using System;
namespace Inheritance
{
	public class Reptile : Animal_class
	{
	   public Reptile()
	   {
		  public bool BreathesAir = true;
		  public int legs = 4;
		  public bool HasTail = true;
		  public bool CanSwim = false;
		 public bool IsColdBlooded = true;
	   }

	    public bool IsColdBlooded { get; set; } = true;

	     public bool Movement { get; set;}

	     public bool HasScales { get; set;}

	     public bool HasForkedTongue { get; set;}

		

	 

		


		public void PrintDetails()
		{
		    Console.WriteLine($"{GetType().Name}");
			Console.WriteLine($"Name: {Name}");
			Console.WriteLine($"Is Cold-Blooded:{IsColdBlooded}");
			Console.WriteLine($"Movement: {Movement}");
		    Console.WriteLine($"Forked Tongue: {HasForkedTongue}");

		}


	}

}