using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesGenerator : MonoBehaviour
{
    public static int ENEMIES_NUMBER = 7;
    public GameObject enemy;
    void Start()
    {
        for(int i=0; i< ENEMIES_NUMBER; i++){
            Instantiate(enemy, new Vector2(Random.Range(-2f, 2f), Random.Range(-1.5f, 4f)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
