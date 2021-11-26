using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaReWrite
{
	class AppointmentService {
		//private ArrayList appointments = new ArrayList();
		readonly private List<Appointment> appointments = new List<Appointment>();

		public List<Appointment> GetAppointments() {
			return appointments;
		}

		public String genAppointmentID() {
			var rand = new Random();
			String AppointmentID = rand.Next(1, 99).ToString();
			Console.WriteLine(AppointmentID);

			return AppointmentID;
		}

		public void AddAppointment() {
			Appointment appointment = new Appointment(genAppointmentID());
			appointments.Add(appointment);
		}

		public void AddAppointment(String appointmentID, DateTime date, String description) {
			Appointment appointment = new Appointment(genAppointmentID(), date, description);
			appointments.Add(appointment);
		}

		public void RemoveAppointment(String appointmentID) {
			try {
				appointments.Remove(findAppointment(appointmentID));
			} catch (ArgumentNullException) {
				throw;
			}
		}

		public Appointment findAppointment(String appointmentID) {
			int index = 0;

			while (index < appointments.Count) {
				if (appointmentID.Equals(appointments[index].AppointmentID)) {
					return appointments[index];
				}
				index++;
			}
			throw new Exception("Appointment does not exist");
		}
		public void UpdateDate(String appointmentID, DateTime date, String description) {
			try {
				findAppointment(appointmentID).appointmentDate = date;
			} catch (Exception) {

				throw;
			}
		}

		public void UpdateDescripton(String appointmentID, String description) {
			try {
				findAppointment(appointmentID).Description = description;
			} catch (Exception) {

				throw;
			}
		}
	}
}
