using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonHub : MonoBehaviour
{
    [SerializeField] private List<Person> people;

    public Person GetAvailablePerson()
    {
        foreach (var person in people)
        {
            if (person.IsWas == false)
            {
                return person;
            }
        }

        return null; //TODO ошибку
    }
}
