using UnityEngine;
public class FOX : MonoBehaviour
{
    [Header("移動速度"), Range(0.1f, 9.9f)]
    public float speed = 0.1f;
    public Transform fox;
    
    public Rigidbody2D rb2D;

    public SpriteRenderer sr;
    private float flipX;

    private void Start()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
        transform.position = new Vector2(-5,0);
        
    }

    private void Update()
    {
        float pos = Input.GetAxisRaw("Horizontal")*Time.deltaTime;
        if (pos < 0)
        {
            fox.Translate(-speed , 0 ,0);
            sr.flipX = true;
           
        }
        else if (pos > 0)
        {
            fox.Translate(speed , 0 , 0);
            sr.flipX = false;

        }
        
    }

    private void FixedUpdate()
    {
        rb2D.AddForce(transform.up * speed);
    }
}
