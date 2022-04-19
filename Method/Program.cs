/*using System;


class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Start");
       // GetFullName("Raj", "Singh");

        Console.WriteLine(GetFullName("Raj", "Singh"));

        //GetFullName("Sonam", "Sahu");
        int message = GetBalance("123445566");
        Console.WriteLine(message);
        Console.WriteLine("end");

        Console.ReadLine();
    }
    public static string GetFullName(string Fname, string Lname)
    {
        return Fname + Lname;
    }
    public static int GetBalance(string account_no)
    {
        GetFullName("Sonu", "Sahu");

        return 6000;
    }



}
*/
/*using System;

class Program
{
    static void Main()//but static method we can not access throw the object 
    {
        Program obj= new Program();//memory me load hota hain 
        //sara method memory me load ho jayega
        obj.GetFullName("raj","singh");
        // GetBalance("11111111");//any static method we can call diectly 
        // Program.GetFullName("sach", "rai");//every class ka parent class hota hain object class
        Console.ReadLine();
        //we can access any method from anywhere 
    }
    public  string GetFullName(string Fname, String Lname)//non static method we can access throw object
        //in non static always clreate alway 
    {
        return Fname + Lname;
    }
    public  int GetBalance(string account_no)
        //this method is not run this is not call a
    {
        Main();
        GetFullName("Sonu", "Sahu");

        return 6000;
    }
}*/


/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter the Fname: ");
        string Fname= Console.ReadLine();
        Console.WriteLine("enter the Lname: ");
        string Lname = Console.ReadLine();
        Console.WriteLine("enter the Age: ");
        string Age = Console.ReadLine();
        Console.WriteLine("enter the Qualification: ");
        string Qualification = Console.ReadLine();
        string message= Program.PersoalDetails("Sonam", "Sahu", 23, "BE");
        Console.WriteLine(message);
        Console.ReadLine();
    }
    public static string PersoalDetails(string Fname, String Lname ,int Age, string Qualification )
    {
        return Fname+"_"+Age;
    }

}

*/
/*using System;

class Program
{
    static void Main()
    {
       string message= PersonalDetails("Sonam", "Sahu", 26, "BE", "TRUBA", "Vidisha", "M.P", 7411971451);

        Console.WriteLine(message);
        Console.WriteLine("Fname:" +"sonam");
        Console.WriteLine("Lname:" + "Sahu");
        Console.WriteLine("Age:" + 26);
        Console.WriteLine("Qualification:" + "BE");
        Console.WriteLine("Collage:" + "TRUBA");
        Console.WriteLine("State:" + "M.P");
        Console.WriteLine("MobileNo:" + "7411971451");
        Console.ReadLine();
    }
    public static string PersonalDetails(string Fname, String Lname, int Age, string Qualification, string collageName, string address, string state, long mobileNo )
    {

        return Fname + "" + Lname + "" + Age + "" + Qualification + "" + collageName + "" + address + "" + state + "" + mobileNo;
    }

}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter the user det ");

        Console.ReadLine();
    }
    public static string GetEmployeeDetails(byte employee_id)//type of parameter 
    {
        Console.WriteLine("(int employee_id)");
        return "101";
    }

}*/