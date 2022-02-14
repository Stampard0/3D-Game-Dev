using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOP : MonoBehaviour
{
    private void Start()
    {
        Fish fish;
        fish = new Fish("Fred", 5);
        fish.PrintAnimal();
    }
}
//Abstract classes can only be inherited from, not instantiated
public abstract class Animal
{
    //encapsulated data can only be changed from within the class
    private string name;
    private int age;

    public Animal(string _name, int _age) //class constructor for instantiating the object
    {
        name = _name;
        age = _age;
    }
    //Abstract method must be implemented in all derived (child) classes
    public abstract void Eat();
    public abstract void Eat(string food);
    //Virtual method may have implemented overriden
    public virtual void PrintAnimal()
    {
        Debug.Log("Name: " + name);
        Debug.Log("Age: " + age);
    }
}

public class Fish : Animal //Fish class inherits the animal class
{
    //Fish constructor
    //Passes parameters to base class constructor
    public Fish(string _name, int _age) : base(_name, _age)
    {

    }
    //Override versions of Animal's Eat method
    public override void Eat()
    {
        Debug.Log("Fish is eating.");
    }
    public override void Eat(string food)
    {
        Debug.Log("Fish has eaten " + food);
    }

    //Extened version of Animal's PrintAnimal method
    public override void PrintAnimal()
    {
        base.PrintAnimal();
        Debug.Log("This is a Fish");
    }
}