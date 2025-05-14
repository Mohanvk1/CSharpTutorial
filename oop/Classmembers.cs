internal class Motorbike
{
    public string color="blue";
    public int max=120;
}
internal static class Classmembers
{
    public static void myclassobject()
    {
        Motorbike myobj1 = new Motorbike();
        Motorbike myobj2 = new Motorbike();

        Console.WriteLine(myobj1.color);
        Console.WriteLine(myobj2.max);
    }


}