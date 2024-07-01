class Program
{
    static void Main(string[] args)
    {
        ConvertRomeToArab();
    }
    static int RomeNums(char rm)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        dic.Add('I', 1);
        dic.Add('V', 5);
        dic.Add('X', 10);
        dic.Add('L', 50);
        dic.Add('C', 100);
        dic.Add('D', 500);
        dic.Add('M', 1000);
        int value;
        if (dic.TryGetValue(rm, out value))
        {
            return value;
        }
        else
        {
            return 0;
        }

    }

    static void ConvertRomeToArab()
    {
        string input = Console.ReadLine();
        char[] chr = input.ToCharArray();
        int sum = 0;
        for (int i = 0; i < chr.Length ; i++)
        {
                if (i + 1 < chr.Length && RomeNums(chr[i]) < RomeNums(chr[i + 1]))
                {
                    sum -= RomeNums(chr[i]);
                }else 
                    
                {
                    sum += RomeNums(chr[i]);
                }
        }

        Console.WriteLine(sum);
    }



}