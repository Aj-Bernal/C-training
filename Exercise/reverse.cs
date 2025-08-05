string message = "The quick brown fox jumps over the lazy dog.";
char[] Letters = message.ToCharArray();
//Reverse the character
Array.Reverse(Letters);
int x = 0;
// count the o's
foreach (char letter in Letters)
{
    if (letter == 'o')
    {
        x++;
    }
}
//Convert it back to a string
string convertToString = new String(Letters);
//print it out
System.Console.WriteLine(convertToString);
System.Console.WriteLine($"'o'appears {x} times.");
