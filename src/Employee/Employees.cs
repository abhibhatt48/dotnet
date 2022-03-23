public class Employee
 {
     //variables
     private string name;
     private double Eid;
     private string Deptname;

     // delegate
     public delegate void IdInvokeEventHandler(object source, EventArgs args);
     public delegate void NameInvokeEventHandler(object source, EventArgs args);
     public delegate void DeptNameInvokeEventHandler(object source, EventArgs args);


    // event

    public event IdInvokeEventHandler IdInvoked;
    public event NameInvokeEventHandler NameInvoked;
    public event DeptNameInvokeEventHandler DeptNameInvoked;

    protected virtual void OnIdInvoked()
    {      
            IdInvoked(this, EventArgs.Empty);       
    }
    protected virtual void OnNameInvoked()
    {      
            NameInvoked(this, EventArgs.Empty);      
    }
    protected virtual void OnDeptNameInvoked()
    {      
            DeptNameInvoked(this, EventArgs.Empty);       
    }

    // constructor

    public Employee (string name , string Deptname, double Eid)
    {
        this.name = name;
        this.Deptname = Deptname;
        this.Eid = Eid;
    }

    public Employee(string name)
    {
        this.name = name;
    }
    public Employee()
    {

    }

    //methods

    public string GetName()
    {
        return name;
        OnNameInvoked();
    }
    public string GetName(string name)
    {
        this.name = name; 
        return name;
    }
    public string GetDepartmentName()
    {
        return Deptname;
        OnDeptNameInvoked();
    }
    public string GetDepartmentName(string Deptname)
    {
        this.Deptname = Deptname;
        return Deptname;
    }
    public double GetId()
    {
        return Eid;
        OnIdInvoked();
    }
    public double GetId(double Eid)
    {
        this.Eid = Eid;
        return Eid;
    }

} 