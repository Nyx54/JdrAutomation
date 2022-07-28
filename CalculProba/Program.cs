using System.Linq;

int numberOfDices = 7;
int faces = 10;
int target = 40;

var res = dicesSum(numberOfDices, faces);

foreach (var kvp in res)
{
    Console.WriteLine($"{kvp.Key} : {Math.Round(kvp.Value * 100, 3)} %");
}

var x = res.Where(p => p.Key >= target).Sum(p => p.Value);
Console.WriteLine($"Probabilité de faire {target} ou plus : {Math.Round(x * 100, 3)}");

static Dictionary<int, double> dicesSum(int n, int faces)
{
    Dictionary<int, double> res = new Dictionary<int, double>();

    double[,] dp = new double[n + 1, faces * n + 1];

    // Précalculer la ligne 1
    for (int i = 1; i <= faces; i++)
    {
        dp[1, i] = 1 / (double)faces;
    }

    for (int i = 2; i <= n; i++)
    {
        for (int j = i - 1; j <= faces * (i - 1); j++)
        {
            for (int k = 1; k <= faces; k++)
            {
                dp[i, j + k] += (dp[i - 1, j] *
                                 dp[1, k]);
            }
        }
    }

    // On retourne uniquement la ligne n
    for (int i = n; i <= faces * n; i++)
    {
        res.Add(i, dp[n, i]);
    }

    return res;
}
