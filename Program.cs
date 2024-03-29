using System; 
  
class Homework { 
      
    // Main Method 
    public static void Main() 
    { 
        // исходные данные
        string[] stringarr = new string[] {"array", "ab", "ababa", "aaa", "bb20", "BBB", "BBBB"};  
        // минимальная длина строк для фильтрации
        int max_length = 3;

        printArray("input", stringarr); 

        string[] short_strings = new string[stringarr.Length];

        int new_count = 0;

        for (int i = 0; i < stringarr.Length; ++i)
        {
            if (stringarr[i].Length <= max_length)
                short_strings[new_count++] = stringarr[i];
        }     

        string[] result = filterShortStrings(stringarr, max_length);
        printArray("result", result); 
    } 

    // вывод массива строк в консоль
    public static void printArray(string tag, string[] data)
    {
        Console.WriteLine(tag); 

        if (data.Length == 0)
            Console.WriteLine("[empty array]");
        else
            foreach (string value in data)
                Console.WriteLine(value); 
    }

    // фильтрация коротких строк
    public static string[] filterShortStrings(string[] data, int max_len)
    {
        // сколько строк имеет длину не более max_len
        int count = 0;

        for (int i = 0; i < data.Length; ++i)
        {
            if (data[i].Length <= max_len)
                count++;
        }  

        string[] result = new string[count];

        for (int i = 0, j = 0; i < data.Length; ++i)
        {
            if (data[i].Length <= max_len)
                result[j++] = data[i];
        }

        return result;
    }
} 
