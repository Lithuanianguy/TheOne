using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public float v;
    public float h;
    public float mouseX;
    public float mouseY;
    public Vector3 move;
    public Vector3 rotateCam;
    public Vector3 rotateBody;
    public bool isRunning = false;
    public float speed = 1.0f;
    public float runningSpeed = 1.0f;
    public float walkingSpeed = 1.0f;
    public float cameraSpeed = 1.0f;
    public Transform cam;
    public float rayDistance;

    public bool canMove = true;

    [Header("Interaction")]
    [SerializeField] private LayerMask interactionLayer;
    [SerializeField] private float interactionRange;
    [SerializeField] private InteractableObject interactableObject;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            v = Input.GetAxis("Vertical");
            h = Input.GetAxis("Horizontal");

            mouseX = Input.GetAxis("Mouse X");
            mouseY = Input.GetAxis("Mouse Y");
        }

        move.x = h;
        move.z = v;

        transform.Translate(move * Time.deltaTime * speed);

        if(Input.GetKey(KeyCode.LeftShift))
        {
            isRunning = true;
            speed = runningSpeed;
        }else
        {
            isRunning = false;
            speed = walkingSpeed;
        }

        rotateCam.x = mouseY;
        rotateBody.y = mouseX;

        cam.Rotate(-rotateCam * Time.deltaTime * cameraSpeed);

        transform.Rotate(rotateBody * Time.deltaTime * cameraSpeed);

        if (Input.GetButtonDown("Fire1") && canMove)
        {
            //if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, rayDistance))
            //{
            //    if (hit.collider.gameObject.tag == "Heart")
            //    {
            //        Destroy(hit.collider.gameObject);
            //    }
               
            //}
            if (interactableObject)
            {
                interactableObject.OnInteract(this);
            }
        }
    }
    private void FixedUpdate()
    {
        if (Physics.Raycast(cam.position, cam.forward, out RaycastHit hit, interactionRange, interactionLayer))
        {
            interactableObject = hit.collider.GetComponent<InteractableObject>();

        }
        else
        {
            interactableObject = null;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
