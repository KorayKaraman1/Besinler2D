using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterhar : MonoBehaviour
{
    Rigidbody2D rgb;
    Vector3 velocity;
    public Animator animator;
    
    
    public float speedamount = 9f;
    public float jumpamount = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
       
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * speedamount * Time.deltaTime;
        animator.SetFloat("speed",Mathf.Abs(Input.GetAxis("Horizontal")));

        if (Input.GetButtonDown("Jump") && Mathf.Approximately(rgb.velocity.y, 0))
        {
            rgb.AddForce(Vector3.up * jumpamount, ForceMode2D.Impulse);
            animator.SetBool("zıp", true);

        }
        if (animator.GetBool("zıp") && Mathf.Approximately(rgb.velocity.y, 0))
        {
            animator.SetBool("zıp", false);
        }

        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);

        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
}
