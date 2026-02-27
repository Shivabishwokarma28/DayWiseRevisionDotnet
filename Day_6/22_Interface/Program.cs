/*Interface 

It is like an abstract class but it can only contain abstract Method
(Method with no body)
Used to Implement Multiple inheritance
Class or Struct Implementing the interface must override the method
abstract classes, interfaces cannot be used to create objects

 */
using System;
using System.Formats.Asn1;
public interface IMaths
{
     void ICalculation(int a,int b);
}
public interface IMathsDiv
{
      void IDivision(int x,int y);
    
}

class Mcalculation : IMaths,IMathsDiv//Multiple interface
{
    public void  ICalculation(int a, int b)
    {
        int sum=a+b;
        Console.WriteLine($"The sum of two number is:{sum}");
        
    }
    public void IDivision(int x,int y)
    {
        double Div=(double)x/y;
        Console.WriteLine($"The Division of {x}/{y} is:{Div}");
        
    }

}
class Program
{
    public static void Main(string [] args)
    {
    Mcalculation M1=new Mcalculation();
    M1.Calculation(12,22);
    M1.Division(44,3);
    }
}