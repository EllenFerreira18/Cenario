using UnityEngine;

public class Exercicio07 : MonoBehaviour
{
    [SerializeField] int faces;
    void Start()
    {
        faces = Random.Range(4, 20);
        print(faces);
        
    }

    void Update()
    {
        
    }
}
