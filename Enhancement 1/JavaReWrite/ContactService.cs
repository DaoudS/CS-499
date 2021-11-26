using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JavaReWrite {
	public class ContactService {
		readonly private List<Contact> contacts = new List<Contact>();

		public List<Contact> GetContacts() {
			return contacts;
		}
		/// <summary>
		/// Generates contact ID between 1 and 99 and returns value in string
		/// </summary>
		/// <returns></returns>
		public string GenContactID() {
			var rand = new Random();
			string contactID = rand.Next(1, 99).ToString();
			Console.WriteLine(contactID);

			return contactID;
		}
		/// <summary>
		/// Creates a new contact and add it to contacts list
		/// </summary>
		public void AddContact() {
			Contact contact = new Contact(GenContactID());
			contacts.Add(contact);
		}
		/// <summary>
		/// Creates new contact with provided params and adds it to to contact list
		/// </summary>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="phoneNumber"></param>
		/// <param name="address"></param>
		public void AddContact(string firstName, string lastName, string phoneNumber, string address) {
			Contact contact = new Contact(GenContactID(), firstName, lastName, phoneNumber, address);
			contacts.Add(contact);
		}
		/// <summary>
		/// Searchs contacts list via provided contactID
		/// </summary>
		/// <param name="contactID"></param>
		/// <returns></returns>
		public Contact FindContact(string contactID) {
			int index = 0;
			while (index < contacts.Count) {
				if (contactID.Equals(contacts[index].contactID)) {
					return contacts[index];
				}
				index++;
			}
			throw new Exception("Contact does not exist");
		}
		/// <summary>
		/// Updates first name via provided values
		/// </summary>
		/// <param name="contactID"></param>
		/// <param name="firstName"></param>
		public void UpdateFName(string contactID, string firstName) {
			try {
				FindContact(contactID).firstName = firstName;
			} catch (Exception) {

				throw;
			}
		}
		/// <summary>
		/// Updates last name via provided values
		/// </summary>
		/// <param name="contactID"></param>
		/// <param name="lastName"></param>
		public void UpdateLName(string contactID, string lastName) {
			try {
				FindContact(contactID).lastName = lastName;
			} catch (Exception) {

				throw;
			}
		}
		/// <summary>
		/// Updates phone number via provided values
		/// </summary>
		/// <param name="contactID"></param>
		/// <param name="phoneNumber"></param>
		public void UpdatePhoneNumber(string contactID, string phoneNumber) {
			try {
				FindContact(contactID).phoneNumber = phoneNumber;
			} catch (Exception) {

				throw;
			}
		}
		/// <summary>
		/// Updates address via provided values
		/// </summary>
		/// <param name="contactID"></param>
		/// <param name="address"></param>
		public void UpdateAddress(string contactID, string address) {
			try {
				FindContact(contactID).address = address;
			} catch (Exception) {

				throw;
			}
		}
	}
}
