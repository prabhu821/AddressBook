namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System!");
            Contact contact = new Contact();
            AddressBookMain addressBookMain = new AddressBookMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter your choice \n1.Add Contacts \n2.View Contacts \n3.Edit Contacts \n4.Delete Contacts " +
                    "\n5.Add Multiple Person \n6.Exit");
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
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}