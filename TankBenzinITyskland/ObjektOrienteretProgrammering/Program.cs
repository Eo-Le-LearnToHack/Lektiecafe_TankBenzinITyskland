using ObjektOrienteretProgrammering;

Benzinomkostning minBenzinOmkostning = new();

Console.WriteLine($"Total omkostning: {minBenzinOmkostning.Totalomkostning(33.5, 14, 18.65, 14.35, 30):C2}");

Console.WriteLine($"Omkostning ved at tanke i Dk: {minBenzinOmkostning.OmkostningVedAtTankeIDanmark(30, 18.65):C2}");

minBenzinOmkostning.Difference();

Console.ReadLine();