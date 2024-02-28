using Newtonsoft.Json;
using Questao2;
using System.Net;

public class Program
{
    private static readonly HttpClient client = new HttpClient();
    public static void Main()
    {
        string teamName = "Paris Saint-Germain";
        int year = 2013;
        int totalGoals = getTotalScoredGoals(teamName, year);

        Console.WriteLine("Team "+ teamName +" scored "+ totalGoals.ToString() + " goals in "+ year);

        teamName = "Chelsea";
        year = 2014;
        totalGoals = getTotalScoredGoals(teamName, year);

        Console.WriteLine("Team " + teamName + " scored " + totalGoals.ToString() + " goals in " + year);

        // Output expected:
        // Team Paris Saint - Germain scored 109 goals in 2013
        // Team Chelsea scored 92 goals in 2014
    }

    public static int getTotalScoredGoals(string team, int year)
    {
        var gols = 0;

        int time1 = QuantidadeGols(team, year, 1);
        int time2 = QuantidadeGols(team, year, 2);

        gols = time1 + time2;

        return gols;
    }

    public static async Task<Dados> GetAsync(string url)
    {        
        var resultado = await client.GetAsync(url);
        
        if (resultado.StatusCode != HttpStatusCode.OK)
            throw new HttpRequestException($"{resultado.StatusCode}-{resultado.RequestMessage}");

        var retorno = await resultado.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<Dados>(retorno);
    }    

    public static int QuantidadeGols(string team, int year, int time)
    {
        var url = "https://jsonmock.hackerrank.com/api/football_matches";
        int totalPaginas = 1;
        int gols = 0;

        for (int i = 1; i <= totalPaginas; i++)
        {
            var parametros = string.Format("?year={0}&team{1}={2}&page={3}", year, time, team, i);
            var retorno = GetAsync(url + parametros).Result;

            foreach (var item in retorno.data)
            {
                if(time == 1)
                {
                    gols += int.Parse(item.team1goals);
                }
                else
                {
                    gols += int.Parse(item.team2goals);
                }
            }

            totalPaginas = retorno.total_pages;
        }
        return gols;
    }

}