using UnityEngine;

public class FPS : MonoBehaviour
{
    public float walkSpeed;
    public float runSpeed;
    public float gravity;

    private float speed;

    private float vSpeed;

    private Rigidbody rb;
    public bool isJumping;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        walkSpeed = 3;
        runSpeed = walkSpeed * 2;
        speed = walkSpeed;
        vSpeed = 0;
        isJumping = false;
        isGrounded = false;
        Cursor.visible = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    private void OnTriggerStay(Collider other)
    {
        /*Debug.Log("essou");
        if (other.tag == "Terrain" && !isJumping)
        {
            Debug.Log("La Chanklaaa");
            isGrounded = true;
        }
        else
        {
            //isGrounded = false;
        }*/

        if (other.tag != "Gate" && !isJumping)
        {
            isGrounded = true;
        }
    }

    void FixedUpdate()
    {
        isJumping = false;
        Cursor.lockState = CursorLockMode.Locked;
        //vSpeed += gravity;

        if (Input.GetKey("left shift"))
        {
            speed = runSpeed;
        }
        else
        {
            speed = walkSpeed;
        }
        
        if (Input.GetKey("z"))
        {
            transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        }
        else if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.forward * (-walkSpeed * Time.deltaTime));
        }

        if (Input.GetKey(("d")))
        {
            transform.Translate(Vector3.right * (walkSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(("q")))
        {
            transform.Translate(Vector3.right * (-walkSpeed * Time.deltaTime));
        }

        if (Input.GetKeyDown("space") && isGrounded)
        {
            rb.AddForce(transform.up * 300.0f);
            isGrounded = false;
            isJumping = true;
        }
        
        
        //////////////////////////////
        if (Input.GetAxisRaw("Mouse X") != 0)
        {
            transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X") * Time.deltaTime*100);
        }

        transform.Translate(Vector3.down * (vSpeed * Time.deltaTime));
    }
}

