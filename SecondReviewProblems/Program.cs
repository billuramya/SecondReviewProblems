using RegularExpresions;
using System;
class Program
{
    public void Main(string[] args)
    {
        Student student = new Student();
        student.getStudentDetails();
        Products products = new Products();
        products.getProductDetalis();
        GetSollution getSollution = new GetSollution();
        getSollution.calculations();
    }
}