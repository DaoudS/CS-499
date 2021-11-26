using Microsoft.VisualStudio.TestTools.UnitTesting;
using JavaReWrite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaReWrite.Tests {
	[TestClass()]
	public class ContactTests {
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
		string addressFail = "1000 Ferry Road, Newton, Illinois, 
		United State of America, Norht America, Planet Eart";
		*/

		[TestMethod()]
		public void ContactTest() {
			Contact contact = new Contact();
			Assert.IsNull(contact.GetContactID());
			Assert.IsNull(contact.GetFirstName());
			Assert.IsNull(contact.GetLastName());
			Assert.IsNull(contact.GetPhoneNumber());
			Assert.IsNull(contact.GetAddress());
		}
		[TestMethod()]
		public void ContactTeststring() {
			string contactIDPasses = "001";

			Contact contact = new Contact(contactIDPasses);
			
			Assert.AreEqual(contactIDPasses, contact.GetContactID());

			Assert.IsNull(contact.GetFirstName());
			Assert.IsNull(contact.GetLastName());
			Assert.IsNull(contact.GetPhoneNumber());
			Assert.IsNull(contact.GetAddress());
		}
		[TestMethod()]
		public void ContactTeststringX5() {
			string firstNamePasses = "Daoud";
			string lastNamePasses = "Sogoba";
			string contactIDPasses = "001";
			string phoneNumberPassses = "9105869548";
			string addressPasses = "1000 Ferry Road, Newton, State";

			Contact contact = new Contact(contactIDPasses, firstNamePasses, 
				lastNamePasses, phoneNumberPassses, addressPasses);

			Assert.AreEqual(contactIDPasses, contact.contactID);
			Assert.AreEqual(firstNamePasses, contact.firstName);
			Assert.AreEqual(lastNamePasses, contact.lastName);
			Assert.AreEqual(phoneNumberPassses, contact.phoneNumber);
			Assert.AreEqual(addressPasses, contact.address);
		}

		[TestMethod()]
		public void SetContactIDTest() {
			string contactIDPasses = "001";
			string contactIDFail = "S000848949848941";
			Contact contact = new Contact();
			contact.SetContactID(contactIDPasses);

			Assert.AreEqual(contactIDPasses, contact.GetContactID());
			Assert.ThrowsException<InvalidOperationException>(() => contact.SetContactID(null));
			Assert.ThrowsException<InvalidOperationException>(() => contact.SetContactID(contactIDFail));
		}
		[TestMethod()]

		public void SetFirstNameTest() {
			string firstNamePasses = "Daoud";
			string firstNameFail = "ABCDEFGHIJK";

			Contact contact = new Contact();
			contact.SetFirstName(firstNamePasses);

			Assert.AreEqual(firstNamePasses, contact.GetFirstName());
			Assert.ThrowsException<InvalidOperationException>(() => contact.SetFirstName(null));
			Assert.ThrowsException<InvalidOperationException>(() => contact.SetFirstName(firstNameFail));
		}
		[TestMethod()]

		public void SetLastNameTest() {
			string lastNamePasses = "Sogoba";
			string lastNameFail = "KJIHGFEDCBA";

			Contact contact = new Contact();
			contact.SetLastName(lastNamePasses);

			Assert.AreEqual(lastNamePasses, contact.GetLastName());
			Assert.ThrowsException<InvalidOperationException>(() => contact.SetLastName(null));
			Assert.ThrowsException<InvalidOperationException>(() => contact.SetLastName(lastNameFail));
		}
		[TestMethod()]

		public void SetPhoneNumberTest() {
			string phoneNumberPassses = "9105869548";
			string phoneNumberFail = "1234567891234567891234567891234";
			string phoneNumberFail2 = "23";

			Contact contact = new Contact();
			contact.SetPhoneNumber(phoneNumberPassses);

			Assert.AreEqual(phoneNumberPassses, contact.GetPhoneNumber());
			Assert.ThrowsException<InvalidOperationException>(() => contact.SetPhoneNumber(null));
			Assert.ThrowsException<InvalidOperationException>(() => contact.SetPhoneNumber(phoneNumberFail));
			Assert.ThrowsException<InvalidOperationException>(() => contact.SetPhoneNumber(phoneNumberFail2));
		}
		[TestMethod()]

		public void SetAddressTest() {
			string addressPasses = "1000 Ferry Road, Newton, State";
			string addressFail = "1000 Ferry Road, Newton, Illinois, United State of America, Norht America, Planet Eart";

			Contact contact = new Contact();
			contact.SetAddress(addressPasses);

			Assert.AreEqual(addressPasses, contact.GetAddress());
			Assert.ThrowsException<InvalidOperationException>(() => contact.SetAddress(null));
			Assert.ThrowsException<InvalidOperationException>(() => contact.SetAddress(addressFail));
		}
	}
}

