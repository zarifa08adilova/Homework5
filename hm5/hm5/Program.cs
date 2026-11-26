class Program
{

    abstract class Pets
    {
        public string Nickname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Energy { get; set; }
        public float Price { get; set; }
        public float MealsQuantity { get; set; }

        protected Pets(string nickname, int age, string gender, int energy, float price, float mealsQuantity)
        {
            Nickname = nickname;
            Age = age;
            Gender = gender;
            Energy = energy;
            Price = price;
            MealsQuantity = mealsQuantity;
        }

        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Play(Pets pets);
        public override string ToString()

            => $@"Nickname: {Nickname}
Age: {Age}
Gender: {Gender}
Energy: {Energy}
Price: {Price}
Meal Quantity: {MealsQuantity}";
    }

    class Cats : Pets
    {
        public string Toys { get; set; }

        public Cats(string nickname, int age, string gender, int energy, float price, float mealsQuantity, string Toy) : base(nickname, age, gender, energy, price, mealsQuantity)
        {
            this.Toys = Toy;
        }

        public override void Eat()
        {
            Energy += 10;
            Price += 50;
            Console.WriteLine("Energy: " + Energy);
            Console.WriteLine("Price: " + Price);
        }

        public override void Play(Pets pets)
        {
            Energy -= 10;
            Console.WriteLine("Energy: " + Energy);

            if (Energy == 0)
            {
                pets.Sleep();
            }
        }

        public override void Sleep()
        {
            Energy = 100;
            Console.WriteLine("Energy: " + Energy);
        }
        public override string ToString()
        {
            return base.ToString() + $"\nToy: {Toys}";
        }
    }

    class Dogs : Pets
    {
        public string BallColor { get; set; }

        public Dogs(string nickname, int age, string gender, int energy, float price, float mealsQuantity, string ballColor) : base(nickname, age, gender, energy, price, mealsQuantity)
        {
            this.BallColor = ballColor;
        }

        public override void Eat()
        {
            Energy += 50;
            Price += 100;
            Console.WriteLine("Energy: " + Energy);
            Console.WriteLine("Price: " + Price);
        }

        public override void Play(Pets pets)
        {
            Energy -= 50;
            Console.WriteLine("Energy: " + Energy);

            if (Energy == 0)
            {
                pets.Sleep();
            }
        }

        public override void Sleep()
        {
            Energy = 100;
            Console.WriteLine("Energy: " + Energy);
        }
        public override string ToString()
        {
            return base.ToString() + $"\nBall Color: {BallColor}";
        }
    }

    class Birds : Pets
    {
        public bool HasEgg { get; set; }

        public Birds(string nickname, int age, string gender, int energy, float price, float mealsQuantity, bool hasEgg) : base(nickname, age, gender, energy, price, mealsQuantity)
        {
            this.HasEgg = hasEgg;
        }

        public override void Eat()
        {
            Energy += 5;
            Price += 10;
            Console.WriteLine("Energy: " + Energy);
            Console.WriteLine("Price: " + Price);
        }

        public override void Play(Pets pets)
        {
            Energy -= 5;
            Console.WriteLine("Energy: " + Energy);

            if (Energy == 0)
            {
                pets.Sleep();
            }
        }

        public override void Sleep()
        {
            Energy = 100;
            Console.WriteLine("Energy: " + Energy);
        }
        public override string ToString()
        {
            return base.ToString() + $"\nThe bird has eggs: {HasEgg}";
        }
    }

    class Fish : Pets
    {
        public string Species { get; set; }

        public Fish(string nickname, int age, string gender, int energy, float price, float mealsQuantity, string species) : base(nickname, age, gender, energy, price, mealsQuantity)
        {
            this.Species = species;
        }

        public override void Eat()
        {
            Energy++;
            Price += 5;
            Console.WriteLine("Energy: " + Energy);
            Console.WriteLine("Price: " + Price);
        }

        public override void Play(Pets pets)
        {
            Energy--;
            Console.WriteLine("Energy: " + Energy);

            if (Energy == 0)
            {
                pets.Sleep();
            }
        }

        public override void Sleep()
        {
            Energy = 100;
            Console.WriteLine("Energy: " + Energy);
        }
        public override string ToString()
        {
            return base.ToString() + $"\nSpecies: {Species}";
        }
    }

    class PetShop
    {
        List<Pets> pets = new List<Pets>();

        public PetShop() { }
        public PetShop(List<Pets> pets)
        {
            this.pets = pets;
        }

        public void AddPet(Pets pet)
        {
            pets.Add(pet);
        }

        public void RemoveByNickname(string nickname)
        {
            Pets pet = pets.Find(p => p.Nickname == nickname);

            if (pet != null)
            {
                pets.Remove(pet);
                Console.WriteLine("Pet Removed.");
            }
            else
            {
                Console.WriteLine("Pet not found.");
            }
        }

        public void ShowPets()
        {
            foreach (Pets pet in pets)
            {
                Console.WriteLine(pet);
                Console.WriteLine("----------------------------");
            }

        }
    }
    static void Main(string[] args)
    {
        PetShop petShop = new PetShop();
        Cats cat = new Cats("Meredith", 14, "Female", 100, 500f, 50f, "Mousy");
        cat.Eat();
        cat.Play(cat);
        cat.Sleep();
        Console.WriteLine(cat.ToString());
        Console.WriteLine();

        Dogs dog = new Dogs("Wendy", 3, "Female", 100, 1500f, 100f, "Red");
        dog.Eat();
        dog.Play(dog);
        dog.Sleep();
        Console.WriteLine(dog.ToString());
        Console.WriteLine();

        Birds bird = new Birds("Birdy", 5, "Female", 100, 100f, 30f, true);
        bird.Eat();
        bird.Play(bird);
        bird.Sleep();
        Console.WriteLine(bird.ToString());
        Console.WriteLine();

        Fish fish = new Fish("Nemo", 2, "Male", 100, 50f, 10f, "Koi");
        fish.Eat();
        fish.Play(fish);
        fish.Sleep();
        Console.WriteLine(fish.ToString());
        Console.WriteLine();

        petShop.AddPet(cat);
        petShop.AddPet(dog);
        petShop.AddPet(bird);
        petShop.AddPet(fish);

        petShop.ShowPets();
        petShop.RemoveByNickname("Birdy");

        petShop.ShowPets();
    }
}