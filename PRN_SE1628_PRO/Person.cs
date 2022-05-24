namespace FPTEDU.PRN.SE1628;
public class Person
{
    public string Name { get; set; }
    public Address Address { get; set; }
    public DateOnly Dob { get; set; }   

    public Person()
    {

    }

    public Person(string name, Address address, DateOnly dob)
    {
        Name = name;
        Address = address;
        Dob = dob;
    }
}