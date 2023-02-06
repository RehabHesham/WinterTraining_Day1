// See https://aka.ms/new-console-template for more information
using WinterTraining_Day1;

Console.WriteLine("Hello, World!");

#region ExceptionHandling
//Exception
// Runtime Error

//try
//{
//    int x = 8;
//    int y = 0;
//    Console.WriteLine($"x / y = {x / y}");
//}
//catch (DivideByZeroException e)
//{
//    Console.WriteLine(e.Message);
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//    Write in file(log file)
//}

//Console.WriteLine("Continue working..");
#endregion

#region Constructor Chaining
//Employee employee = new Employee("Ali",2000);
#endregion

#region Custom Exception
//Product product = new Product(); ;
//try
//{
//    product.Price = 20;

//}
//catch(InvalidPriceException e)
//{
//    Console.WriteLine(e);
//    product.Price = 10;
//}
//catch (Exception e)
//{
//    Console.WriteLine(e);
//    // log file
//}
//Console.WriteLine(product.Print());
#endregion

#region Conversion

// Data Types
/*
    built in
        - primitive DT string, int, double, float
        - Complex DT built-in class, Array
    user defined => Class [Refrence DT], struct [Value DT]
 */

//Console.ReadLine();

/* Conversion
 * implicit conversion
 * explicit conversion
 * conversion using class helpers [parse - convert]
 * user defined conversion
 */

#region implicit casting
// small size DT to large size DT
// byte < short < int < long < float < double < decimal

//byte num1 = 10;
//int num2 = num1;
//Console.WriteLine(sizeof(long));

//long num = 1230;
//float xnum = num;
//Console.WriteLine(xnum);

//Person p = (Person)(new Employee());
#endregion
#region explicit casting
//int val = int.MaxValue;
//byte d = 0;
//try
//{
//    checked
//    {
//        // overflow
//        //d = (byte)val;
//        unchecked
//        {
//            val += 10;
//        }
//    }
//}catch(OverflowException e)
//{
//    Console.WriteLine(e.Message);
//    // another operation
//    d = (byte)val;
//}catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//Console.WriteLine(d);
//Console.WriteLine("Continue working...");

#endregion
#region Conversion using helper classes
//int num = (int)str; // not working

//Convert
//try
//{
//    string str = "20t";
//    double d = double.MaxValue;
//    //int num = Convert.ToInt32(str);  // FormatException
//    //int num = Convert.ToInt32(d);  // OverflowException
//    // Can handel null values
//    int num = Convert.ToInt32(null);
//    Console.WriteLine(num);
//}catch(FormatException e)
//{
//    Console.WriteLine(e.ToString());
//}catch(OverflowException e)
//{
//    Console.WriteLine(e.ToString());
//}

//Parse

//try
//{
//    string s = long.MaxValue.ToString();
//    //int n = int.Parse(null);
//    int n = int.Parse(s);
//    //double d = double.Parse(s);
//    Console.WriteLine(n);
//}catch(FormatException e)
//{
//    Console.WriteLine(e.ToString());
//}catch(OverflowException e)
//{
//    Console.WriteLine(e.ToString());
//}catch(ArgumentNullException e)
//{
//    Console.WriteLine(e.ToString());
//}

// TryParse
//double d = int.MaxValue;
//int num;
//bool isValid = int.TryParse(null,out num);

//if (isValid) Console.WriteLine(num);
//else Console.WriteLine("InvalidValue");

//Console.WriteLine("Enter Value:");
//string str = Console.ReadLine();
//int price = 0;
//bool isvalid = int.TryParse(str, out price);
//if (isvalid) Console.WriteLine(price);
//else Console.WriteLine("Invalid value");

int price;
bool isvalid;
//string stee;
do
{
    Console.WriteLine("Enter Value:");
    string str = Console.ReadLine();
    isvalid = int.TryParse(str, out price);
} while(!isvalid);
Console.WriteLine(price);
//Console.WriteLine(stee);
#endregion

#region class conversion
Person person = new Employee();  // implicit casting

//Employee employee = new Person(); // InvalidCastingException

Employee emp = (Employee)100;
Console.WriteLine(emp.GetData());

string name = (string)emp;
Console.WriteLine(name);
// user defined casting / conversion
#endregion
#endregion
