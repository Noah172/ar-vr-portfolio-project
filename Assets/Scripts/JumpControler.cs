using UnityEngine;

public class JumpControler : MonoBehaviour
{
    private Rigidbody2D plyr;

    public float jumpForce = 5f;

    // Start is called before the first frame update
    private void Start()
    {
        plyr = GetComponent<Rigidbody2D>();
    }

    // FixedUpdate is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            plyr.velocity = new Vector2(plyr.velocity.x, jumpForce);
        }
    }
}
