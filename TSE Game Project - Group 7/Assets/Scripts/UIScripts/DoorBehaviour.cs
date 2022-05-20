using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DoorBehaviour : MonoBehaviour
{
    BoxCollider2D doorCollider;
    GameObject[] enemiesInScene;
    // Start is called before the first frame update
    void Start()
    {
        doorCollider = gameObject.GetComponent<BoxCollider2D>();
        doorCollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        enemiesInScene = GameObject.FindGameObjectsWithTag("Enemy");
        Debug.Log(enemiesInScene.Length);
        if (enemiesInScene.Length == 0) doorCollider.isTrigger = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
