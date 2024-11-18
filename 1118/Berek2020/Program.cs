
using Berek2020;

List<Alkalmazott> alkalmazottak = new();
FileStream fs = new FileStream("berek2020.txt", FileMode.Open);
StreamReader sr = new StreamReader(fs);

sr.ReadLine();
while (!sr.EndOfStream)
{
    alkalmazottak.Add(new Alkalmazott(sr.ReadLine()));
}

sr.Close();
fs.Close();

Console.WriteLine("3. feladat");
Console.WriteLine(" A lista {0} alkalmazottat tartalmaz", alkalmazottak.Count);
Console.WriteLine("\n");

Console.WriteLine("4. feladat");
var atlag = alkalmazottak.Average(a => a.Fizetes);
Console.WriteLine("Az alkalmazottak átlag fizetése: {0:0.0}Eft", atlag/1000);
Console.WriteLine("\n");

Console.WriteLine("5. feladat");
Console.Write("Adja meg egy részleg nevét: ");
string keresett = Console.ReadLine();
Console.WriteLine(keresett);
Console.WriteLine("\n");

Console.WriteLine("6. feladat");
var max = alkalmazottak.Where(a => a.Reszleg == keresett).MaxBy(a => a.Fizetes);
if(max != null) { Console.WriteLine("A keresett részlegen legnagyobb fizetéssel rendelkező alkalmazott: {0}", max); }
else { Console.WriteLine("A keresett részleg nem létezik a cégnél"); }
Console.WriteLine("\n");

Console.WriteLine("7. feladat");
var reszlegek = alkalmazottak.GroupBy(a => a.Reszleg);
foreach(var a in reszlegek)
{
    Console.WriteLine("\t {0} - {1}", a.Key, a.Count());
}