namespace BakeryManagementSystem.Models
{
    public class StoreLocation
    {
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

        public StoreLocation(string branch, string address, string contact, string email)
        {
            BranchName = branch;
            Address = address;
            ContactNumber = contact;
            Email = email;
        }

        public void DisplayStoreInfo()
        {
            Console.WriteLine($"\n📍 {BranchName}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone: {ContactNumber}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
