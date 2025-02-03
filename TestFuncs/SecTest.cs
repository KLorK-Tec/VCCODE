
class Sec 
{
    static void Sece()
    {
        string inp = "aaaaaaaaabbbbboooopppp";
        char[] lis = (inp.ToUpper().ToCharArray());
        Array.Sort(lis);
        char o = ' ';
        int i = 1;
        foreach (char x in lis)
        {

            if (x.CompareTo(o) == 0)
            {
                i++;
            }
            else 
            {
                Console.Write(i + $"{o}");
                i = 1;
            }
            o = x;
            
        }
        Console.Write(i + $"{o}");
    }
}