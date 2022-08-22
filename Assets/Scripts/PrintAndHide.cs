using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i, j;
    public Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        j = Random.Range(200, 251);
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.tag == "Blue" && i == j)
        {
            rend.enabled = false;
        }
    }
}
