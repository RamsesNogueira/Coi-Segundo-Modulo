using Unity.Mathematics;
using UnityEngine;

public class Desafio06 : MonoBehaviour
{
    public int x;
    public int y;
    public int z;
    bool verd;
    
    void Start()
    {

        Debug.Log(MaiorQueMil(x, y, z, true));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    bool MaiorQueMil(int x1, int y2, int z1, bool verd1)
    {
        int resultado;

        resultado = (x1 + y2) * z1;

        if (resultado > 1000)
        {
            verd = true;
        }
        else
        {
            verd = false;
        }

            return verd;
    }
}
