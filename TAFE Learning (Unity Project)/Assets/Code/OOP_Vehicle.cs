using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOP_Vehicle : MonoBehaviour
{
    private void Start()
    {
        Vehicle vehicle;
        vehicle = new MotorBike(50);
        vehicle.PrintVehicle();
        vehicle = new Car(60);
        vehicle.PrintVehicle();
        vehicle = new Truck(70);
        vehicle.PrintVehicle();
    }
}

public abstract class Vehicle
{
    private int speed;
    public Vehicle(int _speed)
    {
        speed = _speed;
    }
    public virtual void Drive()
    {
        Debug.Log("Driving at " + speed + " KMH.");
    }

    public virtual void PrintVehicle()
    {
        Debug.Log("Speed: " + speed);
    }
}

public class MotorBike : Vehicle
{
    public MotorBike(int _speed) : base(_speed)
    {

    }

    public override void PrintVehicle()
    {
        Debug.Log("We be cruisin");
    }
}
public class Car : Vehicle
{
    public Car(int _speed) : base(_speed)
    {

    }
    public override void PrintVehicle()
    {
        Debug.Log("Car is driving");
    }
}
public class Truck : Vehicle
{
    public Truck(int _speed) : base(_speed)
    {

    }
    public override void PrintVehicle()
    {
        Debug.Log("You've been hit by TRUCK!");
    }
}