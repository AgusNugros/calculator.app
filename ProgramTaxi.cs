using System;
namespace LatihanClassDanObject
{
	class Program
	{
		static void Main(string[] args)
		{
			Taxi taxi = new Taxi();
			taxi.DriverName = "Kang Taxi";
			taxi.OnDuty = true;
			taxi.NumPassenger = 10;

			taxi.TaxiInfo();
			taxi.PickupPassenger();
			taxi.DropOffPassenger();

			Console.ReadKey();
		}

	}
}