using System.ComponentModel.Design;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Desafio04 : MonoBehaviour
{
    public int lado_1 = 0;
    public int lado_2 = 0;
    public int lado_3 = 0;
    int soma_ang_tri;
    void Start()
    {
        soma_ang_tri = lado_1 + lado_2 + lado_3;

        if (soma_ang_tri == 180)
        {

            if (lado_1 == lado_2 && lado_1 == lado_3)
            {
                Debug.Log("tri�ngulo equil�tero");
            }
            else if (lado_1 == lado_2 || lado_2 == lado_3 || lado_1 == lado_3)
            {
                Debug.Log("tri�ngulo is�sceles");
            }
            else
            {
                Debug.Log("tri�ngulo escaleno");
            }

        }
        else
        {

            Debug.Log("N�o � um tri�ngulo");

        }
    }
            // Update is called once per frame
            void Update()
            {

            }
}
