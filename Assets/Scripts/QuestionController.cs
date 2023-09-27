using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionController : MonoBehaviour
{
    public Rigidbody2D questionRigidbody;
    public CoinController coinController;
    // Start is called before the first frame update
    void Start()
    {

    }

    void RegisterHit()
    {
        questionRigidbody.bodyType = RigidbodyType2D.Static;
        coinController.PlayCoinSound();
    }
}
