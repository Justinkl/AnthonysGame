using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListOne : MonoBehaviour
{

    public List<GameObject> numHorses;
    public List<GameObject> nonHorses;

    // Use this for initialization
    void Start()
    {
        Delegate.FillHorse += AddToHorse;
        Delegate.RemovalOfNonHorseAnimalsFromThisZoo += RemoveNonHorses;

        Delegate.FillHorse(gameObject);
        Delegate.RemovalOfNonHorseAnimalsFromThisZoo(gameObject);
    }

    void AddToHorse(GameObject horse)
    {
        numHorses.Add(horse);
    }

    void RemoveNonHorses(GameObject nonhorse)
    {
        nonHorses.Remove(nonhorse);
    }
}
