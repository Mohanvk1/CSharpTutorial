

class Person 
{
    private string name=string.Empty;
    public string Name 
    {
  get { return name; }
        set { name = value; }

    
    }

    
}

internal class Encapsulation
{
    public static void ShowName()
    { 
        Person p = new ();
        p.Name ="Laim";
        Console.WriteLine("p.Name");

    }
}




  

 
 
 
 
 

