using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLinkedLists.Util
{
    class Arguments
    {
        public static List<int> getArgument(string data, string FirstString, string LastString)
        {
            string result = "";
            List<int> finalResult = new List<int>();
            int firstPosition = data.IndexOf(FirstString) + FirstString.Length;
            int secondPosition = data.IndexOf(LastString);
            result = data.Substring(firstPosition, secondPosition - firstPosition);
            if (result != "")
            {
                string[] commaStrings = result.Split(",");
                for (int i = 0; i < commaStrings.Length; i++)
                {
                    int number = Int32.Parse(commaStrings[i]);
                    finalResult.Add(number);
                }
            }
            return finalResult;
        }
    }
}
