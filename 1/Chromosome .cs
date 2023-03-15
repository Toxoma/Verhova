public class Chromosome
{
    public List<Gen> Gens {get; private set;} = new List<Gen>();

    public Chromosome(List<Gen> gens){
        this.Gens = gens;
    }

    public string GetExons(){
        string result = "";
        foreach (var item in this.Gens)
        {
            result+=item.Value;
        }
        return result;
    }

}