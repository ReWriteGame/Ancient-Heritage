using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Coin2D>())
            collision.gameObject.GetComponent<Coin2D>().actionsAfterGetting();

        if (ScoreCounter.Instance.Score <= 0)
            Finish.instance.winGame();
    }
}
