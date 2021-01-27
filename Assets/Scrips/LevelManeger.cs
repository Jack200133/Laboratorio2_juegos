using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManeger : MonoBehaviour
{
    public GameObject spawnPoint;
    public Object playerfab;
    GameObject currentP;

    // Start is called before the first frame update
    void Start()
    {
        currentP = Instantiate(playerfab, spawnPoint.transform.position, Quaternion.identity) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnPoint && playerfab && Input.GetKeyDown(KeyCode.Return))
            if(currentP == null)
                currentP =  Instantiate(playerfab, spawnPoint.transform.position, Quaternion.identity) as GameObject;
    }
}
