using Microsoft.VisualStudio.TestTools.UnitTesting;
using JavaReWrite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaReWrite.Tests {
	[TestClass()]

	/*
	string firstNamePasses = "Daoud";
	string firstNameFail = "ABCDEFGHIJK";
	string lastNamePasses = "Sogoba";
	string lastNameFail = "KJIHGFEDCBA";
	string contactIDPasses = "001";
	string contactIDFail = "S000848949848941";
	string phoneNumberPassses = "9105869548";
	string phoneNumberFail = "1234567891234567891234567891234";
	string addressPasses = "1000 Ferry Road, Newton, State";
	string addressFail = "1000 Ferry Road, Newton, Illinois, United State of America, Norht America, Planet Eart";
	*/

	public class ContactServiceTests {
		[TestMethod()]
		public void AddContactTest() {
			ContactService cs = new ContactService();
			List<Contact> contacts = cs.GetContacts();
			cs.AddContact();

			Assert.IsNotNull(contacts[0].GetContactID());
			Assert.AreEqual(null, contacts[0].GetFirstName());
			Assert.AreEqual(null, contacts[0].GetLastName());
			Assert.AreEqual(null, contacts[0].GetPhoneNumber());
			Assert.AreEqual(null, contacts[0].GetAddress());

		}

		[TestMethod()]
		public void AddContactStringX4Test() {

			string firstNamePasses = "Daoud";
			string lastNamePasses = "Sogoba";

			string phoneNumberPassses = "9105869548";
			string addressPasses = "1000 Ferry Road, Newton, State";

			ContactService cs = new ContactService();
			List<Contact> contacts = cs.GetContacts();

			cs.AddContact(firstNamePasses, lastNamePasses, phoneNumberPassses, addressPasses);

			Assert.IsNotNull(contacts[0].GetContactID());
			Assert.AreEqual(firstNamePasses, contacts[0].GetFirstName());
			Assert.AreEqual(lastNamePasses, contacts[0].GetLastName());
			Assert.AreEqual(phoneNumberPassses, contacts[0].GetPhoneNumber());
			Assert.AreEqual(addressPasses, contacts[0].GetAddress());

		}

		[TestMethod()]
		public void UpdateContactLastNameTest() {
			string lastNamePasses = "Sogoba";

			ContactService cs = new ContactService();
			List<Contact> contacts = cs.GetContacts();
			cs.AddContact();
			contacts[0].lastName = lastNamePasses;

			Assert.AreEqual(lastNamePasses, contacts[0].GetLastName());
		}  
		
		[TestMethod()]
		public void UpdateContactFirstNameTest() {
			string firstNamePasses = "Daoud";

			ContactService cs = new ContactService();
			List<Contact> contacts = cs.GetContacts();
			cs.AddContact();
			contacts[0].firstName = firstNamePasses;

			Assert.AreEqual(firstNamePasses, contacts[0].GetFirstName());
		}
		[TestMethod()]
		public void UpdatePhoneNumber() {
			string phoneNumberPasses = "6179546985";

			ContactService cs = new ContactService();
			List<Contact> contacts = cs.GetContacts();
			cs.AddContact();
			contacts[0].phoneNumber = phoneNumberPasses;

			Assert.AreEqual(phoneNumberPasses, contacts[0].GetPhoneNumber());
		}
		[TestMethod()]
		public void UpdateAddress() {
			string addressPasses = "1000 Ferry Road, Newton, State";

			ContactService cs = new ContactService();
			List<Contact> contacts = cs.GetContacts();
			cs.AddContact();
			contacts[0].address = addressPasses;

			Assert.AreEqual(addressPasses, contacts[0].GetAddress());

		}

	}
}