using System.ComponentModel;
using System.Linq.Expressions;
using Microsoft.VisualBasic;

namespace Exam1;

public class Q1_Add{
    public int x;
    public int y;
    public Q1_Add(int x1, int y1){
        x=x1;
        y=y1;
    }
    public static int Add(int a, int b){
        return a+b;
    }

}
public class Basics{
    
    public static void Q2MultiplyAndReset(ref int a,ref int b){
        a=a*b;
        b=1;
    }
    public static void Q5TryCatchFinally(bool x, string[] list, bool y ){
        if(x&&y){
            try{
                throw new Exception();
            
            }
            catch(Exception e)
            { 

            }
        }
        
    }
}

public struct Type1{
    public int Count;
}

public class Type2{
    public int Count;
}

public class Q4Person{
    public string Name;
    public int Age;
    public Q4Person(string name, int age){
        Name=name;
        Age=age;
    }
    public string Introduce(){
        if(Name==""){
            return $"Hello, my name is  and I am {this.Age} years old." ;
        }
        return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
    }
}

public class Q6Temperature 
{

    private double _fahrenheit;
    private double _celsius;
    public double Fahrenheit{
        get{
            if(((_celsius*1.8+32)*0.999999)<_fahrenheit &&  _fahrenheit<((_celsius*1.8+32)*1.000001)  ){
                return _fahrenheit;
            }
            return 0;
        }
        set{ if(((_celsius*1.8+32)*0.999999)<_fahrenheit &&  _fahrenheit<((_celsius*1.8+32)*1.000001)  )

            _fahrenheit=value;
            
        }
        
    }
    public double Celsius
    {
        get{
            if((_fahrenheit-32)*5/9*0.999999<_celsius && (_celsius<(_fahrenheit-32)*5/9*1.000001) ){
                return _celsius;
            } 
            return 0;
              
            }
        set{
            if((_fahrenheit-32)*5/9*0.999999<_celsius && (_celsius<(_fahrenheit-32)*5/9*1.000001) )
            _celsius=value;
        }
    }

}
public interface IShape{
    public double GetArea();
    public double GetPerimeter();
}
public class  Q7Circle: IShape
{
    public double radius;
    public  Q7Circle(double r){
        radius=r;
    }

    public double GetArea()
    {
        return Math.PI*radius*radius;
    }

    public double GetPerimeter()
    {
        return Math.PI*radius*2;
    }
}
public class Q7Rectangle : IShape
{
    public double width;
    public double height;
    public Q7Rectangle(double w, double h){
        width=w;
        height=h;
    }
    public double GetArea()
    {
        return width*height;
    }

    public double GetPerimeter()
    {
        return 2*(width+height);
    }
}
public class ShapeUtils{
    public static double Q7TotalArea(IShape[] shapes){
        double sum=0;
        foreach(var shape in shapes){
            sum+=shape.GetArea();
        }
        return sum;
    }
}