abstract class WashingMachine
  {

    public abstract void StartWash();

    public void Poweron()
    {
      Console.WriteLine("Washing machine is now ON ");
    }
  }
  

  class LGWashingMachine : WashingMachine
  {
    public override void StartWash()
    {
      
      Console.WriteLine("Starting wash cycle LG Washing Machine");
    }
  }

  class Abstraction
  {
   public static void Appliance()
    {
      WashingMachine mywasher = new LGWashingMachine();  
      mywasher.StartWash();
      mywasher.Poweron();
    }
  }