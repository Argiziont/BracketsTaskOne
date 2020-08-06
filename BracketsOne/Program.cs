using System;
using System.Linq;

namespace BracketsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string bracketstring = Console.ReadLine();
            int bracketcount = bracketstring.Count(x => x == '(');
            if (bracketstring.Count(x => x == ')')== bracketcount)//If number of brackets isn't even=> skip all logic
            {
                for (int i = 0; i < bracketcount; i++)
                {
                    int tmpfirst = bracketstring.IndexOf("(");
                    int tmpsecond = bracketstring.IndexOf(")");
                    if (tmpsecond > tmpfirst)// If close-bracket goes after open-one=> delete both of them
                    {
                        if (tmpfirst != -1)
                        {
                            if ((tmpsecond != -1))
                            {
                                bracketstring = bracketstring.Remove(tmpfirst, 1).Remove(tmpsecond - 1, 1);
                            }
                        }
                    }
                    else
                        break;
                }
            }
            if (bracketstring.IndexOfAny("()".ToCharArray()) == -1)//if we dont find any bracket then this string is right 
                Console.WriteLine("FineLine");
            else
                Console.WriteLine("WrongLine");

        }
    }
}
