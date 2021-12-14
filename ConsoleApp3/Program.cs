using System;
static class test
{
    static string Change(string s)
    {
        string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            res += s[i];
            if (s[i] == '.') res += '.';
        }
        return res;
    }
    static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine(Change(s));
    }
}