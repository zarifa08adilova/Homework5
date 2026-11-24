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

        public string V1 { get; }
        public int V2 { get; }
        public int V3 { get; }
        public float V4 { get; }
        public float V5 { get; }

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

    //class PetShop
    //{
    //    public Pets Cats { get; set; }
    //    public Pets Dogs { get; set; }
    //    public Pets Birds { get; set; }
    //    public Pets Fish { get; set; }
    //}

    static void Main(string[] args)
    {
        //Cats cat = new Cats("Meredith", 14, "Female", 100, 500f, 50f, "Mousy");
        //cat.Eat();
        //cat.Play(cat);
        //cat.Sleep();
        //Console.WriteLine(cat.ToString());

        //Dogs dog = new Dogs("Wendy", 3, "Female", 100, 1500f, 100f, "Red");
        //dog.Eat();
        //dog.Play(dog);
        //dog.Sleep();
        //Console.WriteLine(dog.ToString());

        //Birds bird = new Birds("Birdy", 5, "Female", 100, 100f, 30f, true);
        //bird.Eat();
        //bird.Play(bird);
        //bird.Sleep();
        //Console.WriteLine(bird.ToString());

        //Fish fish = new Fish("Nemo", 2, "Male", 100, 50f, 10f, "Koi");
        //fish.Eat();
        //fish.Play(fish);
        //fish.Sleep();
        //Console.WriteLine(fish.ToString());
    }
}