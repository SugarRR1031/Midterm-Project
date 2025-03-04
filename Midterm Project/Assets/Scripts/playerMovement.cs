using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float speed = 0.5f;
    public float lookSpeed = 5f;
    public float jumpForce = 50f;
    public GameObject MainCamera;

    // Camera lock controls

    public float camLock = 90;

    // Public for debug purposes

    public bool jumped = false;
    public bool canJump = true;

    // Rigid Body

    Rigidbody myRB;
    Vector3 myLook;

    // Score 

    public int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        myLook = GetComponent<Vector3>();
        jumped = false;
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerLook = MainCamera.transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(transform.position, playerLook * 3f, Color.magenta);

       myLook += DeltaLook() * Time.deltaTime;

        if (myLook.y > camLock)
        {
            myLook.y = camLock;
        }
        else if (myLook.y < -camLock)
        {
            myLook.y = -camLock;
        }

        

        if (Input.GetKey(KeyCode.W))
        {
            
        }

        if (Input.GetKey(KeyCode.A))
        {

        }

        if (Input.GetKey(KeyCode.S))
        {

        }

        if (Input.GetKey(KeyCode.D))
        {

        }
    }

    private void FixedUpdate()
    {
        Vector3 DeltaLook()
        {
            Vector3 deltaLook = Vector3.zero;
            float rotY = Input.GetAxisRaw("Mouse Y") * lookSpeed;
            float rotX = Input.GetAxisRaw("Mouse X") * lookSpeed;

            deltaLook = new Vector3(rotX, rotY, 0);
            return deltaLook;
        }
    }
}
