namespace Employee{

    class Program {

        static  void Main(String[] args){
            var employees = new List<Employees>();
            System.Console.WriteLine("Enter number of employees");
            var numbrofempl = int.Parse(Console.ReadLine()) ;

            while (numbrofempl != 0){
               
                Console.WriteLine("Enter Id: ") ;
                var Id = int.Parse(Console.ReadLine()) ;
                System.Console.WriteLine("name : ") ; 
                var name = Console.ReadLine() ;
                System.Console.WriteLine("Department Name: ") ;
                var departmentName = Console.ReadLine() ;
            
                if( name != null && departmentName != null){
                var sample = new Employees(Id,name,departmentName ) ;
                employees.Add(sample) ;  
                sample.ongetid += Events.ongetid;
                sample.ongetname += Events.ongetname;
                sample.ongetdepartmentname += Events.ongetdepartmentname ; 

                numbrofempl--;         
                    }            
            }

            foreach(var employee in employees){
                System.Console.WriteLine() ;
                System.Console.WriteLine($" Employee Id: {employee.GetId()}") ;
                System.Console.WriteLine($"Name:{employee.GetName()}") ;
                System.Console.WriteLine($"DepartmentName: {employee.GetDepartmentName()}") ;
                System.Console.WriteLine() ;
            }   
        }
    
     
    }
}