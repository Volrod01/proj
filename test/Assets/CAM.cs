using UnityEngine;

public class CAM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (true) //(transform.rotation.x > -.7f && transform.rotation.x < .7f)
        {
            Debug.Log(transform.rotation.x);
            transform.Rotate(Vector3.right * -Input.GetAxisRaw("Mouse Y") * Time.deltaTime*100);
        }
    }
}
