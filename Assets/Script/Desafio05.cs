using UnityEngine;

public class Desafio05 : MonoBehaviour
{
    public string jogador_1;

    public string jogador_2;

    public int mao_jogador_1;

    public int mao_jogador_2;

    int resultado;

    public bool par_jogador_1;

    void Start()
    {
        resultado = mao_jogador_1 + mao_jogador_2;

        if (par_jogador_1 == true)
        {
            if (resultado % 2 == 0)
            {
                Debug.Log(resultado + " é par: " + jogador_1 + " Venceu!!!");
            }
            else
            {
                Debug.Log(resultado + " é impar: " + jogador_2 + " Venceu!!!");
            }
        }
        else if (par_jogador_1 == false)
        {
            if (resultado % 2 == 0)
            {
                Debug.Log(resultado + " é par: " + jogador_2 + " Venceu!!!");
            }
            else
            {
                Debug.Log(resultado + " é impar: " + jogador_1 + " Venceu!!!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
