
class Exception
{

    public static void Filename()
    {

        try
        {
            int[] myNumbers={1,2,3,4};
            Console.WriteLine(myNumbers[10]);
        }
        catch{
            Console.WriteLine("wrong");
        }
    }

}