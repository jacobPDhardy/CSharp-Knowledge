using HtmlAgilityPack;

string url = "https://en.wikipedia.org/wiki/List_of_SpongeBob_SquarePants_episodes";

var web = new HtmlWeb();

var document = web.Load(url);

Console.WriteLine(document.ToString); 