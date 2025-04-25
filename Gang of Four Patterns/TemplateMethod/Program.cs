using TemplateMethod;

Console.Title = "Template Method";

ExchangeMailParser exchangeMailParser = new();
Console.WriteLine(exchangeMailParser.ParseMailBody("1234567890"));
Console.WriteLine("--------------------------------------------------");

ApacheMailParser apacheMailParser = new();
Console.WriteLine(apacheMailParser.ParseMailBody("0987654321"));
Console.WriteLine("--------------------------------------------------");

EudoraMailParser eudoraMailParser = new();
Console.WriteLine(eudoraMailParser.ParseMailBody("1122334455"));
Console.WriteLine("--------------------------------------------------");