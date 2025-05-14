interface IDevice
{
    void StartDevice(); 

}

class SmartPhone : IDevice
{
    public void StartDevice()
    {
        Console.WriteLine("Smartphone is starting up...");
    }
}

class Interface
{
   public static void Mobile()
    {
        SmartPhone myPhone = new SmartPhone();  // Create a SmartPhone object
        myPhone.StartDevice();
    }
}