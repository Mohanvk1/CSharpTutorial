class Vehicle  
{
  public string brand = "KTM";  
  public void honk()             
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}

class Bike : Vehicle 
{
  public string modelName = "KTMXS"; 
}

class Inheritance
{
 public static void MyMethod()
  {
    
    Bike myBike = new Bike();


    myBike.honk();


    Console.WriteLine(myBike.brand + " " + myBike.modelName);
  }
}
 

