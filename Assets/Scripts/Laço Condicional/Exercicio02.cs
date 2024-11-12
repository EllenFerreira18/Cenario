using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    [SerializeField] bool powerup;
    void Start()
    {
        if (powerup == true)
         {
            print("Powerup coletado");
        }
        else
        {
            print("Nenhum powerup encontrado");
        }


        print(powerup ? "Powerup Coletado" : "Nenhum powerup encontrado");



    }

    void Update()
    {
        
    }
}
