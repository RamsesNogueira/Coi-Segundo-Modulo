using UnityEngine;

public class Desafio01 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int X = 5;
    public int y = 7;

    void Start()
    {

        int resultado = X + y;
        Debug.Log("A soma de " + X + " + " + y + " é igual a " + resultado);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
