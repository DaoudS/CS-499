using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaReWrite {
	public class Contact {

		public const string Initialize = "";

		public string contactID;
		public string firstName;
		public string lastName;
		public string phoneNumber;
		public string address;

		private string _contactID;
		private string _firstName;
		private string _lastName;
		private string _phoneNumber;
		private string _address;

		public Contact() {

		}

		public Contact(string contactID) {
			this.contactID = contactID;

		}
		/// <summary>
		/// Creates new contact object with the supplied params
		/// </summary>
		/// <param name="contactID"></param>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="phoneNumber"></param>
		/// <param name="address"></param>
		public Contact(string contactID, string firstName, string lastName, 
			string phoneNumber, string address) {
			this.contactID = contactID;
			this.firstName = firstName;
			this.lastName = lastName;
			this.phoneNumber = phoneNumber;
			this.address = address;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns>contactID</returns>
		public string GetContactID() {
			return contactID;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns>firstName</returns>
		public string GetFirstName() {
			return firstName;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns>lastName</returns>
		public string GetLastName() {
			return lastName;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns>phoneNumber</returns>
		public string GetPhoneNumber() {
			return phoneNumber;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns>address</returns>
		public string GetAddress() {
			return address;
		}
		/// <summary>
		/// Sets contact ID to provided var. Var len cannot be  =<0 or >10
		/// </summary>
		/// <param name="contactID"></param>
		public void SetContactID(string contactID) {
			_contactID = contactID;
			if (_contactID == null) {
				throw new InvalidOperationException("Contact ID cannot be emtpy");
			} else if (_contactID.Length > 10) {
				throw new InvalidOperationException("Contact ID cannot be longer than 10 chracters");
			} else {
				this.contactID = _contactID;
			}
		}
		/// <summary>
		/// Sets first name to provided var. Var len cannot be  =<0 or >10
		/// </summary>
		/// <param name="firstName"></param>
		public void SetFirstName(string firstName) {
			_firstName = firstName;
			if (_firstName == null) {
				throw new InvalidOperationException("First name cannot be emtpy");
			} else if (_firstName.Length > 10) {
				throw new InvalidOperationException("First name cannot be longer than 10 chracters");
			} else {
				this.firstName = _firstName;
			}
		}
		/// <summary>
		/// Sets last name to provided var. Var len cannot be  =<0 or >10
		/// </summary>
		/// <param name="lastName"></param>
		public void SetLastName(string lastName) {
			_lastName = lastName;
			if (_lastName == null) {
				throw new InvalidOperationException("Last name cannot be emtpy");
			} else if (_lastName.Length > 10) {
				throw new InvalidOperationException("Last name cannot be longer than 10 chracters");
			} else {
				this.lastName = _lastName;
			}
		}
		/// <summary>
		/// Sets phonenumber to provided var. Var len cannot be  =<0 or > 10
		/// </summary>
		/// <param name="phoneNumber"></param>
		public void SetPhoneNumber(string phoneNumber) {
			_phoneNumber = phoneNumber;
			if (_phoneNumber == null) {
				throw new InvalidOperationException("Phone Number cannot be emtpy");
			} else if (_phoneNumber.Length != 10) {
				throw new InvalidOperationException("Phone Number  must be 10 integers");
			} else {
				this.phoneNumber = _phoneNumber;
			}
		}
		/// <summary>
		/// Sets address to provided var. Var len cannot be =<0 or >30
		/// </summary>
		/// <param name="address"></param>
		public void SetAddress(string address) {
			_address = address;
			if (_address == null) {
				throw new InvalidOperationException("Address cannot be emtpy");
			} else if (_address.Length > 30) {
				throw new InvalidOperationException("Address cannot be longer than 30 chracters");
			} else {
				this.address = _address;
			}
		}
	}
}
