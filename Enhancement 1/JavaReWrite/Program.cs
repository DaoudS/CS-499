using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaReWrite
{
	class Program
	{	static void Main(string[] args)
		{
			
			Appointment test = new Appointment("001");
			Task test1 = new Task("002");
			Contact test2 = new Contact("003", "Daoud", "Sogoba", "9105184698", "10 Normal Lane, USA");
			// Display the number of command line arguments.
			Console.WriteLine(test.AppointmentID + " "+ test.appointmentDate + " " + test.Description);
			Console.WriteLine(test1.taskID + " " + test1.taskName + " " + test1.description);
			Console.WriteLine(test2.contactID + " " + test2.firstName + " " + 
				test2.lastName + " " + test2.phoneNumber + " " + test2.address);
			Console.ReadLine();
		}
	}
}
