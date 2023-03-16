Gen gen1 = new Gen(new List<bool>(){true,false,true});
Gen gen2 = new Gen(new List<bool>(){false,false,true});

Chromosome chromosome1 = new Chromosome(new List<Gen>(){gen1, gen2});
Chromosome chromosome2 = new Chromosome(new List<Gen>(){gen1, gen1});
Chromosome chromosome3 = new Chromosome(new List<Gen>(){gen2, gen1});
Chromosome chromosome4 = new Chromosome(new List<Gen>(){gen2, gen2});

Individual individual1 = new Individual(chromosome1);
individual1.mutationValue = .5;
Individual individual2 = new Individual(chromosome2);
Individual individual3 = new Individual(chromosome3);
Individual individual4 = new Individual(chromosome4);

Population population1 = new Population();
population1.NewIndividual(individual1);
population1.NewIndividual(individual2);
population1.NewIndividual(individual3);
population1.NewIndividual(individual4);

foreach (var item in population1.SelectPair())
{
    Console.WriteLine(item.GetExons());
}
