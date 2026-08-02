
public class UserProfile
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

     public void DisplayInfo()
    {
        System.Console.WriteLine("Name: {0}", Name);
        System.Console.WriteLine("Email: {0}", Email);
        System.Console.WriteLine("Address: {0}", Address);
        System.Console.WriteLine("Phone Number: {0}", PhoneNumber);
    
    
    }
    }