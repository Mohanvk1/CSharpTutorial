internal class Program
{


    private static void Main(string[] args)
    {
        
      Console.WriteLine("Hello World");
      int myNum=5;
      Console.WriteLine(myNum);

      double x=0.55;
      Console.WriteLine(x);

      float y=2.66f;
      int z=(int)y;
      Console.WriteLine(z);

      string userName="mohan";
      Console.WriteLine(userName);

Console.WriteLine("Enter a Name:");
 string? Name=Console.ReadLine();
      Console.WriteLine(Name);

int a=50+20;
Console.WriteLine(a);


int b=Math.Min(5,10);
Console.WriteLine(b);

string Greeting="Hello World!";
Console.WriteLine(Greeting);

int time=18;
if(time<10)
{
    Console.WriteLine("Good Moring");
}
else
{
    Console.WriteLine("Good Evening");
}

Console.WriteLine(10<9);

int time2=11;
switch(time2) 
{
  case 5:
    // code block
    Console.WriteLine("Good Morning");
    break;
  case 13:
    // code block
    Console.WriteLine("Good Afternoon");
    break;
    case 18:
    // code block
    Console.WriteLine("Good Evening");
    break;
    case 22:
    // code block
    Console.WriteLine("Good Night");
    break;
  default:
    // code block
    Console.WriteLine("Hi");
    break;
}

int i=0;


while(i<5)
{
Console.WriteLine(i);
i=i+1;
}

for (int c = 0; c < 5; c++) 
{
  Console.WriteLine(c);
} 

Console.WriteLine("Break statement");

for (int d = 0; d < 10; d++) 
{
  if (d == 4) 
  {
    break;
  }
  Console.WriteLine(d);
}

string [] cars={"volvo","BMW","ford"};
Console.WriteLine(cars[2]);

        // Console.WriteLine (C_Datatypes.X());
    }
}