using Simulator;

// obj 1
Montagne everest = new Montagne("Everest", 8848, "Népal");
Console.WriteLine(everest.Hauteur);
everest.ChangerMeteoNeige();
everest.Hauteur = 200;
Console.WriteLine(everest.Hauteur);

// obj 2
Montagne montBlanc = new Montagne("Mont Blanc", 4809, "France");
montBlanc.ChangerMeteoNeige();
montBlanc.ChangerMeteoNeige();
montBlanc.ChangerMeteoNeige();
montBlanc.ChangerMeteoNeige();
montBlanc.ChangerMeteoNeige();
Console.WriteLine(montBlanc.Hauteur);

