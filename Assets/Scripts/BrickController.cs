using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    public AudioSource coinSound;
    public GameObject coinGameobject;
    // Start is called before the first frame update
    void Start()
    {

    }

    void RegisterHit()
    {
        if (coinGameobject)
        {
            coinSound.PlayOneShot(coinSound.clip);
            coinGameobject.SetActive(false);
        }
    }
}
