using System;

public class GarageEnumerator<T>:IEnumerator<T>
{
    T[] theGarage; 

	public GarageEnumerator(int capacity)
	{
        theGarage = new T[capacity];
	}
}
