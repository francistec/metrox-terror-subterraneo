using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float jumpForce;

    [SerializeField]
    bool isGrounded = false;

    Rigidbody2D RB;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space)) {
        if(isGrounded == true){
            RB.AddForce(Vector2.up * jumpForce);
            isGrounded = false;
        }
       }
    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground")){
            isGrounded = true;
        }
    }
}
