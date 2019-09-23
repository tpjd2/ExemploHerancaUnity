using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gato : Animal
{
    protected override void Fala()
    {
        Debug.Log("miau ... miau");
    }
}
