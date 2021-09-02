using UnityEngine;

public class MovementControler : MonoBehaviour
{
    private Rigidbody2D plyr;

    public float jumpForce = 9f;

    // Start is called before the first frame update
    private void Start()
    {
        plyr = GetComponent<Rigidbody2D>();
    }

    // FixedUpdate is called once per frame
    private void FixedUpdate()
    {
        // here is the controls for the horizontal movements
        float dir = Input.GetAxisRaw("Horizontal");
        plyr.velocity = new Vector2(dir * 6f, 0);


        // here the player jumps
        if (Input.GetButtonDown("Jump"))
        {
            plyr.velocity = new Vector2(plyr.velocity.x, jumpForce);
        }
    }
}
