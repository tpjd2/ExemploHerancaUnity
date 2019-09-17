using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passaro : Animal
{
    [SerializeField] string nome;
    public Passaro()
    {
        velocidadeVertical = 5f;
    }

    protected override void Fala()
    {
        base.Fala();
        Debug.Log("Pássaro: piu-piu");
    }

    protected override void Move()
    {
        base.Move();
        transform.position += Vector3.up * Mathf.Sin(Time.time);
    }
}
