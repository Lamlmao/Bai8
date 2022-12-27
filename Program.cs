using System.Security.Principal;
using bai8;
internal class Program
{
    private static void Main(string[] args)
    {
        
        Student student = new Student("Hoang Lam", "Hai Ba Trung", "Male",new DateTime(2002,6,23),"12345",10.0f,"lamnh2362002@gmail.com" );
        student.CheckHoBo() ;
        student.OutputStudent();
    }
}
