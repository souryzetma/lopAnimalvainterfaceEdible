namespace LopAnimalVainterfaceEdible
{
    class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken : Cluck-CLUCK!";
        }
        
        public string HowToEat()
        {
            return "could be fried";
        }
       
    }
}