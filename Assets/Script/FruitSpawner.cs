using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public float fruitspawnerCooldown = 1f;
    public GameObject cherryPrefab;
    public Transform spawner;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if(fruitspawnerCooldown > 0)
            {
                var cherry = Instantiate(cherryPrefab, spawner);
            }
        }
    }
}
