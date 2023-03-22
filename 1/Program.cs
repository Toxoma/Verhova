EvolutionManager evolutionManager = new EvolutionManager();
DateTime startTime = DateTime.Now;
var populationsCounter = 100;
var populationsCounterAverage = 200;
var populationsCounterMax = 500;

var IndividualsCounter = 20;
Population.KASTIL = 1;
// EvolutionManager.MUTATION = 0.99;

// ___________________________________________

Console.WriteLine("minimum...");
startTime = DateTime.Now;
evolutionManager.InitPopulation(IndividualsCounter);

for (int i = 0; i < populationsCounter; i++)
{
    evolutionManager.CreateNewGeneration();
}

Console.WriteLine($"Best-fitness: {Population.BEST_FITNESS}");
Console.WriteLine($"Best-individual: {Population.BEST_INDIVIDUAL}");
Console.WriteLine($"Затраченное время: {(DateTime.Now - startTime).ToString(@"hh\:mm\:ss\.fff")}");
Console.WriteLine("________");
Console.WriteLine();

// ___________________________________________

Console.WriteLine("average...");
startTime = DateTime.Now;
evolutionManager.InitPopulation(IndividualsCounter);

for (int i = 0; i < populationsCounterAverage; i++)
{
    evolutionManager.CreateNewGeneration();
}

Console.WriteLine($"Best-fitness: {Population.BEST_FITNESS}");
Console.WriteLine($"Best-individual: {Population.BEST_INDIVIDUAL}");
Console.WriteLine($"Затраченное время: {(DateTime.Now - startTime).ToString(@"hh\:mm\:ss\.fff")}");
Console.WriteLine("________");
Console.WriteLine();

// ___________________________________________

Console.WriteLine("maximum...");
startTime = DateTime.Now;
evolutionManager.InitPopulation(IndividualsCounter);

for (int i = 0; i < populationsCounterMax; i++)
{
    evolutionManager.CreateNewGeneration();
}

Console.WriteLine($"Best-fitness: {Population.BEST_FITNESS}");
Console.WriteLine($"Best-individual: {Population.BEST_INDIVIDUAL}");
Console.WriteLine($"Затраченное время: {(DateTime.Now - startTime).ToString(@"hh\:mm\:ss\.fff")}");
Console.WriteLine("________");
Console.WriteLine();