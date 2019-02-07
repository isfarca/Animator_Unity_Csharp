using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    // Value types
    private float speed = 400f;

    // Reference types
    private Animator animator;
    private Rigidbody2D rigidbody2d;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));

        rigidbody2d.velocity = (Vector2.up * (Input.GetAxisRaw("Vertical") * speed * Time.deltaTime)) + (Vector2.right * (Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime));
	}
}
