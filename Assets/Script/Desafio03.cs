using UnityEngine;

public class Desafio03 : MonoBehaviour
{
    public string letra;
    
    void Start()
    {
        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u" || letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
        {
            Debug.Log("� uma vogal");
        }
        else
        {
            Debug.Log("� uma consoante");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
