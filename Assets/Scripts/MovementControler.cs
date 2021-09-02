using UnityEngine;

public class MovementControler : MonoBehaviour
{
    private Rigidbody2D plyr;

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
        if (dir != 0)
            plyr.velocity = new Vector2(dir * 6f, 0);
    }
}
