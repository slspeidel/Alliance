public class Customer : Repo
{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public Address Cust_Address {get; set;}
    public int Id {get; set;}

    public Customer (string firstName, string lastName, Address address) {
        FirstName = firstName;
        LastName = lastName;
        Cust_Address = address;
    }

    public void Save () {
        Id = base.Cust_Save(this);
    }
}