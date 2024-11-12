using UnityEngine;

public class Exercicio09 : MonoBehaviour
{
    [SerializeField] int timeA;
    [SerializeField] int timeB;
    void Start()
    {
        if(timeA > timeB)
        {
            print("Vitória para o time A!");
        }
        else if(timeA < timeB) {
            print("Vitória para o time B!");         
        }
        else {
            if(timeA > 3 && timeB > 3) {
                print("Empate");
             }
            else {
                print("Foi um empate");
             }
    }
      }

    void Update()
    {
        
    }
}
