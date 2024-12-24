string pangram =
    "William who was a widower told his son he could believe he'd been taken in by the conmen";
Console.WriteLine(pangram);
string[] message = pangram.Split(' ');

string[] message2 = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    message2[i] = new string(letters);
}
string result = String.Join(" ", message2);
Console.WriteLine(result);
Console.ReadLine();
