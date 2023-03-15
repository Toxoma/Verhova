Gen gen1 = new Gen(new List<bool>(){true,false,true});
Gen gen2 = new Gen(new List<bool>(){false,false,true});
Chromosome chromosome1 = new Chromosome(new List<Gen>(){gen1, gen2});
Individual individual1 = new Individual(chromosome1);
individual1.mutationValue = .5;
Console.WriteLine(individual1.GetExons());
individual1.Mutation();
Console.WriteLine(individual1.GetExons());
Console.WriteLine(individual1.Fitness());
