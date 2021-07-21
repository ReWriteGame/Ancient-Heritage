using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Exit2D : MonoBehaviour
{
    [SerializeField] private GameObject[] trekkingObj;
    private Collider2D coll;
    private void Start()
    {
        coll = GetComponent<Collider2D>();
        coll.isTrigger = true;

        if (trekkingObj == null) Debug.Log("Trekking Objects not set.");// не работает?
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Coin2D>())
                actionsAfterGetting();        
    }


    public void actionsAfterGetting()
    {
        Finish.instance.loseGame();
        print("Exit.");
    }



    public void destroyMe()
    {
        Destroy(gameObject);
    }
}
