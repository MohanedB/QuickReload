using UnityEngine;

public class PowerUpFall : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D rb;
    [SerializeField]
    public float fallSpeed = -1f; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    void Update()
    {
        rb.velocity = new Vector2(0, fallSpeed);
    }
}
