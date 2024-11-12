using UnityEngine;

public class Exercicio006 : MonoBehaviour
{
    void Start()
    {
        for(int i = 0; i < 10000; i++) 
        {
            if(i % 3 == 0 && i % 5 == 0) 
            {
                print("fizz buzz");
            }
            else if(i % 5 == 0)
            {
                print("buzz");
            }
            else if (i % 3 == 0)
            {
                print("fizz");
            }
            else
            {
                print(i);
            }

        }
    }
    void Update()
    {
        
    }
}
