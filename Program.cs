using System; 
  
class Homework { 
      
    // Main Method 
    public static void Main() 
    { 
        // минимальная длина строк для фильтрации
        int max_length = 3;

        // исходные данные
        string[] stringarr = new string[] {"a", "aa", "aaa", "aaaa", "bb", "BBB", "BBBB"};  
      
        printArray("input", stringarr); 

        string[] short_strings = new string[stringarr.Length];

        int new_count = 0;

        for (int i = 0; i < stringarr.Length; ++i)
        {
            if (stringarr[i].Length <= max_length)
                short_strings[new_count++] = stringarr[i];
        }     

        string[] result = new string[new_count];

        Array.Copy(short_strings, 0, result, 0, new_count);

        printArray("result", result); 
    } 

    public static void printArray(string tag, string[] data)
    {
        Console.WriteLine(tag); 
        foreach (string value in data)
            Console.WriteLine(value); 
    }
} 
