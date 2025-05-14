class Animal  
  {
    public void animalSound()
    {
      Console.WriteLine("The animal makes a sound");
    }
  }

  class Pig : Animal  
  {
    
  }

  class Dog : Animal  
  {

  }

 class Polymorphism
  {
    public static void MyAnimal()
    {
      Animal myAnimal = new Animal();  
      Animal myPig = new Pig();  
      Animal myDog = new Dog();  
      
      myAnimal.animalSound();
      myPig.animalSound();
      myDog.animalSound();
    }
  }
