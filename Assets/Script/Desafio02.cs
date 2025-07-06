using UnityEngine;

public class Desafio02 : MonoBehaviour
{

    public int numero_1 = 0;

    public int numero_2 = 0;

    public int numero_3 = 0;

    int numero_maior = 0;

    void Start()
    {

        if (numero_1 > numero_2)
        {
            numero_maior = numero_1;
        }
        else
        {
            numero_maior = numero_2;
        }

        if (numero_3 > numero_maior)
        {
            numero_maior = numero_3;
        }

            Debug.Log(numero_maior);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
