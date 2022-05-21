using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadWin : MonoBehaviour
{
    GameObject[] bosses;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bosses = GameObject.FindGameObjectsWithTag("Enemy");
        Debug.Log(bosses.Length);
        if (bosses.Length == 0)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
