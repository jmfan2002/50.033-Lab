using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public Animator blockAnimator;
    public AudioSource coinAudio;
    // Start is called before the first frame update
    void Start()
    {
        coinAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // update animator state
        blockAnimator.SetTrigger("hit");
    }

    public void PlayCoinSound()
    {
        coinAudio.PlayOneShot(coinAudio.clip);
    }
}
