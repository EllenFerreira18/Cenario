using UnityEngine;

public class Exercicio002 : MonoBehaviour
{
    [SerializeField] int dano = 30;
    void Start()
    {
        for(int i = 0; i <= 5; i++)
        {
            print("Ataque " + i + ": Dano" + dano);
            dano += 2;
        }
        
    }

    void Update()
    {
        
    }
}
