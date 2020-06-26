using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] tetrisObject;
    // Start is called before the first frame update
    void Start()
    {
        SpawnRandom();
    }

   public void SpawnRandom()
   {
        int index = Random.Range(0, tetrisObject.Length);
         ///Instantiate(tetrisObject[index],transform.position,Quaternion.identity);

       GameObject tetrisPrefab = Instantiate(tetrisObject[index],transform.position,Quaternion.identity);
        Vector3 temp = transform.position;
        temp.z = 0.3f;
         
        

        tetrisPrefab.transform.position = temp;
   }
}
