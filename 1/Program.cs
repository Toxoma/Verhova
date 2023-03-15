Gen gen1 = new Gen(new List<bool>(){true,false,true});
Gen gen2 = new Gen(new List<bool>(){false,false,true});
Chromosome chromosome1 = new Chromosome(new List<Gen>(){gen1, gen2});


Console.WriteLine(chromosome1.GetExons());