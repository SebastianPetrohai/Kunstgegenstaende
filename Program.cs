using Kunstgegenstaende;
Sammlung s1 = new Sammlung();

Kunstgegenstand mensch = new("Mensch");
s1.Add(mensch);

Kunstgegenstand tisch = new("Tisch", true);
tisch.SetPreis(50);
s1.Add(tisch);

Kunstgegenstand ball = new("Ball");
s1.Add(ball);

Kunstgegenstand tischGroß = new("Tisch groß",true);
tischGroß.SetPreis(150);
s1.Add(tischGroß);

Console.WriteLine("Anzahl der Kunstgegenstände"+);


