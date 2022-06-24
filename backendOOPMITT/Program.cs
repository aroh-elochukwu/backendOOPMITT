//create a new enum representing some kind of trait that all your animals will have but with different values that you restrict
// provide a property to the parent Animal class
// inherit Animal in your subclasses and give it a value in the constructor

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
    
    public DentitionType Teeth { get; set; }
    public string AnimalClassification { get; set; }

}

class 

enum DentitionType
{
    incisors,
    canines,
    premolars,
    molars,
    thirdsMolars

}

enum AnimalClassification
{
    fish,
    amphibians,
    reptiles,
    mammals,
    birds
}

