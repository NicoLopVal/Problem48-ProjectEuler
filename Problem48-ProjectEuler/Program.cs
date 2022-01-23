using System.Numerics;

BigInteger bigResult = 0;
int topLimit = 1000;
int totalLastNumbersToCheck = 10;

for(int i = 1; i <= topLimit; i++)
{
    bigResult = bigResult + BigPow(i);
}

string strResult = bigResult.ToString().Substring(bigResult.ToString().Length - totalLastNumbersToCheck);
Console.WriteLine("The last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000 is: " + strResult);

BigInteger BigPow(int value)
{
    BigInteger result = 1;
    for(int i = 0; i < value; i++)
    {
        result = result * value;
    }
    return result;
}