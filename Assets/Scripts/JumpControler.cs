using UnityEngine;

public class JumpControler : MonoBehaviour
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
        
    }
}
