string text = "    Code Academy";
string text2 = "w";

if (text.Contains(text2))
{
    Console.WriteLine($"Text contains {text2}");
}
else
{
    Console.Write("Text doesnt contain text2");
}

if (text.EndsWith(text2))
{
    Console.WriteLine($"Text ends with {text2}");
}
else
{
    Console.WriteLine("Text doesn't end with text2");
}

if (text.StartsWith(text2))
{
    Console.WriteLine($"Text starts with {text2}");
}
else
{
    Console.WriteLine("Text doesn't start with text2");
}

if(text == text2)
{
    Console.WriteLine("Texts are equal");
}
else
{
    Console.WriteLine("Texts are not equal");
}

int indexOf = text.IndexOf(text2);
Console.WriteLine($"Index of text2: {indexOf}");

Console.WriteLine($"Text to upper: {text.ToUpper()}");
Console.WriteLine($"Text to lower: {text.ToLower()}");

int lastIndexOf = text.LastIndexOf(text2);
Console.WriteLine($"Last index of text2: {lastIndexOf}");

int stringLegth = text.Length;
Console.WriteLine($"Text length: {stringLegth}");

char symbol = 'q';
int text2RepeatCount = text.Count(x => x == symbol);
Console.WriteLine($"Symbol {symbol} repeated {text2RepeatCount}");

Console.WriteLine(text.Remove(0,4));

string old = "Aca";
string newString = "Roj";
Console.WriteLine($"Text replaced by text2: {text.Replace(old, newString)}");

string[] textArray = text.Split(" ");
Console.WriteLine(textArray[0]);
Console.WriteLine(textArray[1]);

Console.WriteLine(text.Substring(1, 5));

Console.WriteLine(text.Trim());