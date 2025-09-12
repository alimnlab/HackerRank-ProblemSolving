//Solve Me First -1
int SolveMeFirst(int a, int b)
{
    return a + b;
}

//Simple Array  -2
int SimpleArraySum(List<int> ar)
{
    int sum = 0;
    for (int i = 0; i < ar.Count; i++)
    {
        sum += ar[i];
    }
    return sum;
}

//Compare the Triplets -3
List<int> CompareTriplets(List<int> a, List<int> b)
{
    int aliceCount = 0;
int bobCount = 0;
for (int i = 0; i < b.Count && i < a.Count; i++)
{
    if (a[i] > b[i])
    {
        aliceCount++;
    }
    else if (a[i] < b[i])
    {
        bobCount++;
    }
}
return new List<int> { aliceCount, bobCount };
}

//A Very Big Sum - 4
long AVeryBigSum(List<long> ar)
{
    long bigCount = 0;
    for (int i = 0; i < ar.Count; i++)
    {
        bigCount += ar[i];
    }
    return bigCount;
}

//Diagonal Difference - 5
int DiagonalDifference(List<List<int>> arr)
{
    int n = arr.Count;
    int primary = 0;
    int secondary = 0;
    for (int i = 0; i < n; i++)
    {
        primary += arr[i][i];
        secondary += arr[i][n - i - 1];
    }
    return Math.Abs(primary - secondary);
}

//Plus Minus - 6
void PlusMinus(List<int> arr)
{
    int n = arr.Count;
    int negativCount = 0;
    int positiveCount = 0;
    int zeroCount = 0;
    for (int i = 0; i < n; i++)
    {
        if (arr[i] > 0)
        {
            positiveCount++;
        }
        else if (arr[i] < 0)
        {
            negativCount++;
        }
        else
        {
            zeroCount++;
        }
    }
    Console.WriteLine(((double)positiveCount / n).ToString("F6"));
    Console.WriteLine(((double)negativCount / n).ToString("F6"));
    Console.WriteLine(((double)zeroCount / n).ToString("F6"));
}

//Staircase - 7
void Staircase(int n)
{
    for (int i = 1; i <= n; i++)
    {
        string str = new string(' ', n - i);
        string hash = new string('#', i);
        Console.WriteLine(str + hash);
    }
}
