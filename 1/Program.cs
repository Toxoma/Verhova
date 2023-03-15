Gen gen = new Gen(new List<bool>(){true,false,true});
Console.WriteLine(gen.Value);
gen.Mutation();
Console.WriteLine(gen.Value);