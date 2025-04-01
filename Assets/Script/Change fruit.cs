using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changefruit : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject orange;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fruit")
        {
            gameObject = Instantiate(orange);
        }
        Destroy(gameObject);
    }
}
