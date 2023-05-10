using System.Text.RegularExpressions;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите IP - адрес: ");
            string input = Console.ReadLine();

            string patternIPv4 = @"^(0|[1-9]\d{0,1}|1\d{2}|2[0-4]\d|25[0-5])\.(0|[1-9]\d{0,1}|1\d{2}|2[0-4]\d|25[0-5])\.(0|[1-9]\d{0,1}|1\d{2}|2[0-4]\d|25[0-5])\.(0|[1-9]\d{0,1}|1\d{2}|2[0-4]\d|25[0-5])$";
            string patternIPv6 = @"^([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$|" + "^([0-9a-fA-F]{1,4}:){1,7}:$|" + "^([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}$|" + "^([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}$|" + "^([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}$|" + "^([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}$|" + "^([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}$|" + "^[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})$|" + "^(:(((:([0-9a-fA-F]){1,4}){1,7})|:))$";

            Regex regexIPv4 = new Regex(patternIPv4);
            Regex regexIPv6 = new Regex(patternIPv6);

            Match matchIPv4 = regexIPv4.Match(input);
            Match matchIPv6 = regexIPv6.Match(input);

            if (matchIPv4.Success)
            {
                Console.WriteLine("Найден IP-адрес версии 4: " + matchIPv4.Value);
            }
            else if (matchIPv6.Success)
            {
                Console.WriteLine("Найден IP-адрес версии 6: " + matchIPv6.Value);
            }
            else
            {
                Console.WriteLine("IP-адрес не найден");
            }
        }
    }
}