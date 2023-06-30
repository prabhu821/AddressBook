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
                Console.WriteLine("\nEnter your choice \n1.Add Contacts \n2.View Contacts \n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBookMain.AddContact();
                        break;
                    case 2:
                        addressBookMain.ViewDetail();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}