// See https://aka.ms/new-console-template for more information
using CoursCsharp.BanApi.Api;
using CoursCsharp.BanApi.Api.Model;

Console.WriteLine("Hello, World!");


BanApi banApi = new BanApi();

Console.WriteLine("Saisir un terme de requête");
string query = Console.ReadLine();

BanResult result = banApi.Search(query);

result.Features.ForEach(feature => Console.WriteLine(feature.ToString()));

Console.ReadKey();

