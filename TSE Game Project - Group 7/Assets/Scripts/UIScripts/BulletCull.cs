using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCull : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Walls")
        {
            Destroy(this.gameObject);
        }
    }
}
