using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    [SerializeField] protected float velocidadeVertical;

    Vector3 posicaoInicial;
    Vector3 posicao;

    private void Start()
    {
        posicaoInicial = transform.position;
    }

    private void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        posicao = posicaoInicial + Vector3.right * Mathf.Sin(Time.time);
        if (velocidadeVertical > 0)
            velocidadeVertical -= 14 * Time.deltaTime;
        
        if (velocidadeVertical < 0)
            velocidadeVertical = 0;

        posicao.y = velocidadeVertical + posicao.y;
        
        transform.position = posicao;
    }

    protected abstract void Fala();

    protected virtual void Pula()
    {
        velocidadeVertical = 2.0f;
    }
}
