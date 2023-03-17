public class Population
{
    public List<Individual> Individuals {get; private set;} = new List<Individual>();

    public void NewIndividual(Individual individual)
    {
        this.Individuals.Add(individual);
    }

    public void Clean()
    {
        this.Individuals.Clear();
    }

    public List<Individual> SelectPair()
    {
        var mas = new List<Individual>(this.Individuals);
        return new List<Individual>(){this.Ruletka(mas), this.Ruletka(mas)};
    }

    public List<Individual> Crossingover()
    {
        var mas = this.SelectPair();
        Console.WriteLine("Old population");
        List<Individual> newPopulationList = new List<Individual>();
        foreach (var item in this.Individuals)
        {
            Console.WriteLine(item.GetExons());
            if (item.Equals(mas[0]) || item.Equals(mas[1]))
            {
                continue;
            }
            newPopulationList.Add(item);
        }

        Console.WriteLine("Crossingover");

        Random random = new Random();
        var start = random.Next(1, mas[0].GetExons().Length - 2);
        var end = random.Next(start + 2, mas[0].GetExons().Length);
        Console.WriteLine($"{start}/{end}");
        var temp1 = mas[0].GetExons().Substring(start+1, end - start - 1);
        var temp2 = mas[1].GetExons().Substring(start+1, end - start - 1);

        foreach (var item in mas)
        {
            Console.WriteLine($"Old: {item.GetExons()}");
        }

        this.change(mas[0], temp2, start, end);
        this.change(mas[1], temp1, start, end);

        foreach (var item in mas)
        {
            item.Mutation();
            newPopulationList.Add(item);
        }

        foreach (var item in mas)
        {
            Console.WriteLine($"New: {item.GetExons()}");
        }

        Console.WriteLine("New population");
        foreach (var item in newPopulationList)
        {
            Console.WriteLine(item.GetExons());
        }
        Console.WriteLine("Insert");
        return newPopulationList;
    }
 
    private void change(Individual individual, string part, int start, int end){
        var str = individual.GetExons();
        var newstr = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (i>start && i<end)
            {
                newstr+=part;
                i = end-1;
            }else{
                newstr+=str[i];
            }
        }
        
        var gens = individual.Chromosome.Gens;
        var half = newstr.Length / gens.Count;
        for (int i = 0; i < gens.Count; i++)
        {
            gens[i].SetValue(newstr.Substring(i*half, half));
        }
    }

    private Individual Ruletka(List<Individual> mas)
    {
        double max = 0;
        foreach (var item in mas)
        {
            item.ruletkaMin = max;
            max += item.Fitness();
            item.ruletkaMax = max;
        }
        Random random = new Random();
        var r = random.Next(0, (int) max);
        Individual temp = mas[0];
        for (int i = 0; i < mas.Count; i++)
        {
            if(r >= mas[i].ruletkaMin && r < mas[i].ruletkaMax){
                temp = mas[i];
                mas.RemoveAt(i);
                break;
            }
        }
        return temp;
    }
}