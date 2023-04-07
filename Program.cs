using Struct.Helper;

namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "elnurqasumov592gmail.com";
            email.CheckMail();
            string sentece = "Salam Kamran necesen Kamran";
            sentece.MatchCount("Kamran");

            int num = 292;
            num.CheckPolimor();
        }
    }
}