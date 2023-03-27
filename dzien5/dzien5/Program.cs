int number = 34245;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
        counter0++;
    if (letter == '1')
        counter1++;
    if (letter == '2')
        counter2++;
    if (letter == '3')
        counter3++;
    if (letter == '4')
        counter4++;
    if (letter == '5')
        counter5++;
    if (letter == '6')
        counter6++;
    if (letter == '7')
        counter7++;
    if (letter == '8')
        counter8++;
    if (letter == '9')
        counter9++;
}
Console.WriteLine("Twoja liczba to: "+ (number));
Console.WriteLine("0 wystepuje: " + (counter0) + " razy");
Console.WriteLine("1 wystepuje: " + (counter1) + " razy");
Console.WriteLine("1 wystepuje: " + (counter2) + " razy");
Console.WriteLine("1 wystepuje: " + (counter3) + " razy");
Console.WriteLine("1 wystepuje: " + (counter4) + " razy");
Console.WriteLine("1 wystepuje: " + (counter5) + " razy");
Console.WriteLine("1 wystepuje: " + (counter6) + " razy");
Console.WriteLine("1 wystepuje: " + (counter7) + " razy");
Console.WriteLine("1 wystepuje: " + (counter8) + " razy");
Console.WriteLine("1 wystepuje: " + (counter9) + " razy");