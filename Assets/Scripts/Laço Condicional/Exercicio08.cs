using UnityEngine;

public class Exercicio08 : MonoBehaviour
{
    [SerializeField] int horas;
    [SerializeField] int dias;
    [SerializeField] float segundos;
    void Start()
    {

        
    }

    void Update()
    {
        segundos += Time.deltaTime;

        if (segundos >= 10f) {
            horas++;
            segundos = 0;
            if(horas == 4)
            {
                dias++;
                horas = 0;
                print(dias);
            }
         }
        
    
    }
      
}
