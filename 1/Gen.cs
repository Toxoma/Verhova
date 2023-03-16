public class Gen : ICloneable
{
    public string Value {get; set;} = "";
    private List<bool> Exons = new List<bool>();

    public Gen(List<bool> list)
    {
        this.Exons = list;
        this.SetValue(list);
    }

    public void SetValue(List<bool> list)
    {
        this.Value = "";
        foreach (var item in list)
        {
            if (item)
                this.Value += 1;
            else
                this.Value += 0;
        }
    }
    public void SetValue(double value)
    {
        this.Value = ""+value;
    }

    public void SetValue(string value)
    {
        this.Value = value;
    }

    public void Mutation()
    {
        Random random = new Random();
        var r = random.Next(0, this.Exons.Count);
        this.Exons[r] = !this.Exons[r];
        this.SetValue(this.Exons);
    }

    public object Clone()
    {
        return new Gen(this.Exons);
    }
}