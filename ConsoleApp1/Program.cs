
namespace LengthCalculater
{
    public class program
    {
        static void Main()
        {
            LengthHelper objMyCal = new LengthHelper();
            int answer = objMyCal.findLength("naveena");
            Console.WriteLine("length=" + answer);
        }
    }
}
