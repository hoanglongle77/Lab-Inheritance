// See https://aka.ms/new-console-template for more information
using Inheritance.Example;
using Inheritance.Problem;

MultipleInheritance();

static void SingleInheritance()
{
    Dog dog = new Dog();
    dog.Bark();
    dog.Bark();
}

static void MultipleInheritance()
{
    Puppy puppy = new Puppy();
    puppy.Eat();
    puppy.Bark();
    puppy.Weep();
}

static void HierarchicalInheritance()
{
    Dog dog = new Dog();
    dog.Eat();
    dog.Bark();

    Cat cat = new Cat();
    cat.Eat();
    cat.Meow();
}

static void RandomList()
{

}

static void StackofStrings()
{

}
