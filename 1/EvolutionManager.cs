public class EvolutionManager 
{
    public List<Population> Populations = new List<Population>();
    public Random Random = new Random();
    public static double MUTATION = new Random().Next(9, 100)/100;
    public void InitPopulation(int populationCount){
        Population population = new Population();
        this.Populations.Add(population);

        for (int i = 0; i < populationCount; i++)
        {
            Gen gen1 = this.randomGen();
            Gen gen2 = this.randomGen();
            Chromosome chromosome = new Chromosome(new List<Gen>(){gen1, gen2});
            Individual individual = new Individual(chromosome);
            individual.mutationValue = MUTATION;
            population.NewIndividual(individual);
            // Console.WriteLine(individual.GetExons());
        }

    }

    private Gen randomGen(int size = 6) {
        bool[] mas = new bool[size];
        for (int i = 0; i < size; i++)
        {
            mas[i] = Convert.ToBoolean( this.Random.Next(0,2) );
        }
        return new Gen(new List<bool>(mas));
    }

    public void CreateNewGeneration(){
        Population population = new Population();
        this.Populations.Add(population);
        foreach (var item in this.Populations[0].Crossingover())
        {
            population.NewIndividual(item);
        }
        this.RemovePopulation();
    }

    private void RemovePopulation(){
        this.Populations.RemoveAt(0);
    }
}