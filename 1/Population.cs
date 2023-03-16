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

    public void Crossingover()
    {

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