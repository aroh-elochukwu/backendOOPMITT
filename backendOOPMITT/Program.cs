//create a new enum representing some kind of trait that all your animals will have but with different values that you restrict
// provide a property to the parent Animal class
// inherit Animal in your subclasses and give it a value in the constructor

OldWorldSparrow franco = new OldWorldSparrow("Franco");
Cat bernice = new Cat("Bernice");
Console.WriteLine(franco.Fly());
Console.WriteLine(franco.EatGrass());
Console.WriteLine(bernice.RunFast());
Console.WriteLine(bernice.AnimalClass);
Console.WriteLine(bernice.NumOfLeg);





interface IamHerbivorous
{
    string EatGrass();
}

interface IRunfast
{
    string RunFast();
}

interface IFly
{
    string Fly();
}


class Animal
{
    
    public LegNumber NumOfLeg { get; set; }
    public AnimalClassification AnimalClass{ get; set; }

}

class Cat: Animal, IRunfast
{
    public string Name { get; set; }
    
    public Cat(string name)
    {
        NumOfLeg = LegNumber.Four;
        AnimalClass = AnimalClassification.Mammals;
        Name = name;
         
    }

    public string  RunFast()
    {
        return $"{Name} speeds off!! ";
    }
}

class OldWorldSparrow: Animal, IamHerbivorous, IFly    
{
    public string Name { get; set; }
    public OldWorldSparrow(string name)
    {
        AnimalClass = AnimalClassification.Birds;
        NumOfLeg = LegNumber.Two;
        Name = name;
    }
    public string EatGrass()
    {
        return $"{Name} is eating grass";
    }

    public string Fly()
    {
        return $"{Name} flies away";
    }
}
enum LegNumber
{
    None,
    Two,
    Four

}

enum AnimalClassification
{
    Fish,
    Amphibians,
    Reptiles,
    Mammals,
    Birds
}

