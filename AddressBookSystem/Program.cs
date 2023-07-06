namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string personsContact = @"C:\Users\91789\Desktop\New folder\Bridgelabz\AddressBook\AddressBookSystem\PersonsContact.txt";
            Console.WriteLine("Address Book System!");
            Contact contact = new Contact();
            AddressBookMain addressBookMain = new AddressBookMain();
            PersonsContactUsingFileIO fileIO = new PersonsContactUsingFileIO();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter your choice \n1.Add Contacts \n2.View Contacts \n3.Edit Contacts \n4.Delete Contacts " +
                    "\n5.Add Multiple Person \n6.Add Multiple AddressBook using Dictionary \n7.Display List of Dictionary " +
                    "\n8.Check for Duplicate Contacts \n9.Searc person by city or state \n10.View person by city or state " +
                    "\n11.Count person by city or state \n12.Sort contacts by name \n13.Sort entries by city,state or zip code " +
                    "\n14.File Exit or Not \n15.Read Person File \n16.Write Person File \n17.Person Contact as CSV file \n18.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBookMain.AddContact();
                        break;
                    case 2:
                        addressBookMain.ViewDetail();
                        break;
                    case 3:
                        addressBookMain.EditContact();
                        break;
                    case 4:
                        addressBookMain.DeleteContact();
                        break;
                    case 5:
                        addressBookMain.AddMultiplePerson();
                        break;
                    case 6:
                        addressBookMain.CreateDictionary();
                        break;
                    case 7:
                        addressBookMain.DisplayDicttionaryList();
                        break;
                    case 8:
                        addressBookMain.DuplicateContact();
                        break;
                    case 9:
                        addressBookMain.SearchPersonByCityOrState();
                        break;
                    case 10:
                        addressBookMain.ViewPersonByCityOrState();
                        break;
                    case 11:
                        addressBookMain.CountPerson();
                        break;
                    case 12:
                        addressBookMain.SortContactByName();
                        break;
                    case 13:
                        addressBookMain.SortContactByCity_State_ZipCode();
                        break;
                    case 14:
                        fileIO.CheckPersonsContactsFileExists(personsContact);
                        break;
                    case 15:
                        fileIO.ReaderPersonsContactsFile(personsContact);
                        break;
                    case 16:
                        fileIO.WriterPersonsContactsFile(personsContact);
                        break;
                    case 17:
                        PersonsContactsAsCSVFile.ReadCSVWriteCSV();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}