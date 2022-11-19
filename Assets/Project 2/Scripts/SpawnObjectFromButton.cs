using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectFromButton : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject objectToSpawn;
    public GameObject spawner;

    // Update is called once per frame
    void Update()
    {
        GameObject newObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        spawner.SetActive(false);
    }
}
