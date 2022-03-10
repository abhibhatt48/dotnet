
string vame = "Abhi";
string dname = "promact";
double ed = 1;
//event call
    var idMail = new IdMail();
    var idName = new IdName();
    var idDeptName = new IdDeptName();
    var x = new Employee();

//event connection
    x.IdInvoked += idMail.OnIdInvoked;
    x.NameInvoked += idName.OnNameInvoked;
    x.DeptNameInvoked += idDeptName.OnDeptNameInvoked;

//overloaded method
    x.GetId(ed);
    x.GetName(vame);
    x.GetDepartmentName(dname);

//input of the data and related calls to the methods 
while (true)
{
    Console.Write("ENTER NEW NAME: ");
    string name = Console.ReadLine();
    Console.Write("ENTER NEW  DEPT. NAME: ");
    string Deptname = Console.ReadLine();
    Console.Write("ENTER ID IN NUMBER: ");
    double Eid = Convert.ToDouble(Console.ReadLine());
    //condition for multiple inputs at once
    if (name == ""  || Deptname == "")
    {
        Console.WriteLine("any of the feild is empty ");
        break;
    }
    
    //cunst. call
    Employee e = new Employee(name, Deptname, Eid);
    
    Console.WriteLine("id is : " + e.GetId());
    Console.WriteLine("name is : " + e.GetName());
    Console.WriteLine("dept. is : " + e.GetDepartmentName());
}

//event classes
public class IdMail
{
    public void OnIdInvoked(object source, EventArgs x)
    {
        Console.WriteLine("GetId method is called...");
    }
}
public class IdName
{
    public void OnNameInvoked(object source, EventArgs y)
    {
        Console.WriteLine("GetName method is called...");
    }
}
public class IdDeptName
{
    public void OnDeptNameInvoked(object source, EventArgs z)
    {
        Console.WriteLine("GetDeptName method is called...");
    }
}







