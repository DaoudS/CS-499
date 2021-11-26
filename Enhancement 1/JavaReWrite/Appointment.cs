using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaReWrite
{
	class Appointment {

		public const String Initialize = "";

		public String AppointmentID;
		private String _AppointmentID;

		public String Description;
		private string _Description;

		public DateTime appointmentDate; //new DateTime();
		private DateTime _appointmentDate = new DateTime(2022, 05, 01);
		

		public Appointment() {
			//DateTime todaysDate = new DateTime();
			this.AppointmentID = Initialize;
			this.Description = Initialize;
		}

		public Appointment(String appointmentID) {
			//DateTime todaysDate = new DateTime();
			this.AppointmentID = appointmentID;
			this.Description = Initialize;
		}

		public Appointment(String appointmentID,  DateTime Date, String Description) {

			this.AppointmentID = appointmentID;
			this.Description = Description;
			DateTime todaysDate = Date;

		}

		public String getDescription() {
			return Description;
		}
		
		public String getAppointmentID() {
			return AppointmentID;
		}

		public DateTime getDate() {
			return appointmentDate;
		}

		public void setAppointmentID() {
			_AppointmentID = AppointmentID;
			if (_AppointmentID == null) {
				throw new InvalidOperationException("Appointment ID cannot be empty");
			} else if (_AppointmentID.Length > 10) {
				throw new InvalidOperationException("Appointment id cannot be more than 10 characters");
			} else {
				this.AppointmentID = _AppointmentID;
			}
		}
		public void SetDescription() {
			_Description = Description;
			if (_Description == null) {
				throw new InvalidOperationException("Description cannot be empty");
			} else if (_Description.Length > 50) {
				throw new InvalidOperationException("Description cannot be more than 10 characters");
			} else {
				this.Description = _Description;
			}
		}
		public void setDate() {
			_appointmentDate = appointmentDate;
			if (_appointmentDate == null) {
				throw new InvalidOperationException("appointmentDate cannot be empty");
			} else if (_appointmentDate < new DateTime()) {
				throw new InvalidOperationException("appointmentDate cannot be before this date");
			} else {
				appointmentDate = _appointmentDate;
			}
		}
	}
}
