using meowmeow;

List<Versenyzo> versenyzok = new List<Versenyzo>();
FileStream fs = new FileStream("forras.txt", FileMode.Open);
StreamReader sr = new StreamReader(fs);
while (!sr.EndOfStream)
{
    Versenyzo v = new Versenyzo(sr.ReadLine());
    versenyzok.Add(v);
}
sr.Close();
fs.Close();

#region 1. versenyzők száma 'elit' kategóriában

int elitSzam = versenyzok.Count(v => v.Kategoria == "elit");
Console.WriteLine(elitSzam);

#endregion
#region női versenyzők átlagéletkora

var noiAtlagkor = versenyzok
    .Where(v => v.Nem == "n")
    .Average(v=>v.Eletkor);
Console.WriteLine(noiAtlagkor);

#endregion
#region a versenyzők kerékpározással töltött összideje órában. 2tj-ig kerekítve



#endregion
#region - átlagos úszási idő elit junior kategóriában



#endregion
#region férfi győztes (legrövidebb összidő)



#endregion
#region korkategóriánként a versenyt befejezők száma

var korkat = versenyzok
    .Select(v => v.Kategoria)
    .Distinct()
    .Order();
foreach (var k in korkat)
{
    Console.WriteLine($"\t{k}");
}

#endregion