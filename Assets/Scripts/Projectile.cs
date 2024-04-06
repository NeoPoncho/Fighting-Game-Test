using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosionObj;
    private Rigidbody2D rb;
    public float velocityX = 2.0f;
    public static int damage = 10;
    public static string direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocityX, 0);

        if (velocityX < 0)
            direction = "left";
        else direction = "right";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            //explosionObj.transform.localScale = new Vector3(10, 10, 0);
            GameObject objClone = Instantiate(explosionObj, transform.position, Quaternion.identity);
            Destroy(objClone, 0.45f);
            Destroy(gameObject);
        }

        if (collision.CompareTag("EnemyProjectile"))
        {
            //projectileExplosion.transform.localScale = new Vector3(8, 8, 0);
            GameObject objClone = Instantiate(explosionObj, transform.position, Quaternion.identity);
            Destroy(objClone, 0.45f);
            Destroy(gameObject);
        }
    }
}
