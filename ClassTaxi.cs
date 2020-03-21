using System;
namespace LatihanClassDanObject
{
	public class Taxi
	{
		// Properties
		public string DriverName { get; set; }
		public bool OnDuty = true;
		public int NumPassenger { get; set; }

		// method
		public void TaxiInfo()
		{
			Console.WriteLine("Driver Name: {0}", DriverName);
			Console.Write("On Duty: ");
			Console.WriteLine(OnDuty ? "Yes" : "No");
			Console.WriteLine("Num of Passenger: {0}", NumPassenger);
			
		}

		public void PickupPassenger()
		{
			Console.WriteLine("{0} sedang menjemput penumpang ", DriverName);
		}

		public void DropOffPassenger()
		{
			Console.WriteLine("{0} selesai mengantar penumpang ", DriverName);
		}

	}
}