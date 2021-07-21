using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Coin2D : MonoBehaviour
{
    [SerializeField] private GameObject[] trekkingObj;
    private Collider2D coll;
    private void Start()
    {
        coll = GetComponent<Collider2D>();
        //coll.isTrigger = true;

        if (trekkingObj == null) Debug.Log("Trekking Objects not set.");// не работает?
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.GetComponent<Hamster>())
        foreach (GameObject obj in trekkingObj)
        {
            if (obj == collision.gameObject)
            {
                actionsAfterGetting();
                break;
            }
        }
    }


    public void actionsAfterGetting()
    {
        ScoreCounter.Instance.takeAway(1);
        print("Get Coin.");
        destroyMe();
    }



    public void destroyMe()
    {
        Destroy(gameObject);
    }
}
