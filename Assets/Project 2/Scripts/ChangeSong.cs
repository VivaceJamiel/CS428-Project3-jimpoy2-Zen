using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSong : MonoBehaviour
{
    public AudioSource source;
    public AudioClip one;
    public AudioClip two;

    private int counter = 1;

    // Start is called before the first frame update
    void Start()
    {
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        changeSong();
    }

    void changeSong()
    {
        if (counter == 1)
        {
            source.clip = one;
            counter++;
        } else
        {
            source.clip = two;
            counter--;
        }
        source.Play();
    }
}
