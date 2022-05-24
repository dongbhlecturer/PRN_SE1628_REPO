namespace Prn.Se1628;
public class Student:IComparable<Student>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Mark { get; set; }
    public Student()
    {

    }

    public Student(int id, string name, double mark)
    {
        Id = id;
        Name = name;
        Mark = mark;
    }

    public override string? ToString() => $"[Id = {Id}, Name ={Name} and Mark = {Mark}]";

    public int CompareTo(Student? o)
    {
        //0: this vs o = nhau, 1 this > o else 
        int result = 0;
        if(o is not null)
        {
            result =  o.Mark.CompareTo(this.Mark);
            //neu trung nhau diem thi so sanh den ten
        }
        return result;
    }
}
