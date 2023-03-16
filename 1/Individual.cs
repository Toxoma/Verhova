public class Individual
{
    public double ruletkaMin {get; set;} = 0;
    public double ruletkaMax {get; set;} = 0;
    public double mutationValue {get; set;} = 1;
    public Chromosome Chromosome {get; set;}
    public Individual(Chromosome chromosome)
    {
        this.Chromosome = chromosome;
    }

    public void Mutation()
    {
        Random random = new Random();
        if(random.NextDouble() <= this.mutationValue){
            //хромасома состоит из нескольких генов, выбирается рандомно
            var r = random.Next(0, this.Chromosome.Gens.Count);
            this.Chromosome.Gens[r].Mutation();
        }
    }

    public double Fitness(){
        return Math.Pow(Convert.ToInt32(this.GetExons(), 2), 2);
    }

    public string GetExons(){
        return this.Chromosome.GetExons();
    }
}