namespace FPTEDU.PRN.SE1628;
public class Student:Person
{
    public int Id { get; set; }    
    public double MarkAvg { get;init; } 

    /*Constructors*/
    public Student()
    {

    }
    public Student(int id, double markAvg)
    {
        
        this.Id = id;
        this.MarkAvg = markAvg;
    }
    public Student(int id, double markAvg, string name, Address address, DateOnly dob):base(name,address,dob)
    {
  
        this.Id = id;
        this.MarkAvg = markAvg;
    }




    /*Lam gi*/
    public double IncreseMarkAvg()
    {
        return MarkAvg * 0.1;
    }

    public override string? ToString()
    {
        return $"[Id = {Id}, Name = {base.Name}, MarkAvg ={MarkAvg}], Address = {base.Address}], Dob = {base.Dob}";
    }
}
