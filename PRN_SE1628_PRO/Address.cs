namespace FPTEDU.PRN.SE1628;
//POJO class 
public class Address
{
    private string _area;
    public int No { get; set; }
    public string Street { get; set; }
    public string Ward { get; set; }
    public string District { get; set; }
    public string City { get; set; }
    public string Area { get => _area; set => _area = value; }

    public Address()
    {
    }
    public Address(int no, string street, string ward, string district, string city)
    {
        No = no;
        Street = street;
        Ward = ward;
        District = district;
        City = city;
    }

    public override string? ToString()
    {
        return $"[No = {No}, Street = {this.Street}, Ward ={Ward}], District = {District}, City = {City}]";
    }
}