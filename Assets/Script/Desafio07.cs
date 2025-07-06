using UnityEngine;

public class Desafio07 : MonoBehaviour
{

    int arm_re = 0;
    int adi_re = 1;
        public void AddRecurso()
    {
       
        arm_re = arm_re + adi_re;

        Debug.Log(arm_re);

    }

    public void Up(int cust_up)
    {
        if (arm_re >= cust_up)
        {
            arm_re = arm_re - cust_up;
            adi_re = adi_re + (cust_up / 10);
        }
        else
        {
            Debug.Log("Você não tem recursos");
        }


    }

}
