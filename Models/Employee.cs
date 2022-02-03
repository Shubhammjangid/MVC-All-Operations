namespace WebApplication1.Models
{
    public class Employee
    {
        public string Name { get; set; }

        public int Age { get; set; }    

        public string City { get; set; }    
    }

    public enum Accounts
    {
        Github,
        Hackerrank,
        Linkedin,
        Gmail
    }


}
