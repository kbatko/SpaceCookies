using UnityEngine;

public class ExplosionController : MonoBehaviour {
    public int hit_player = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.gameObject.tag;
        gameObject.GetComponent<Animator>().enabled = true;
        if ( tag == "Player1" || tag == "Player2" || tag == "Player3" || tag == "Player4")
        {
            //Destroy player
            Destroy(collision.gameObject, 0.5f);
        }
        //Destroy asteroid
        Destroy(gameObject, 0.5f);
    }
}
