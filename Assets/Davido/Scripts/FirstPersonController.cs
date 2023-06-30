using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
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
    public float speed = 1.0f;
    public float walkingSpeed = 1.0f;
    public float cameraSpeed = 1.0f;
    public Transform cam;
    public float rayDistance;
    public bool canMove = true;

    public GameObject eToInteract;

    public AudioSource footStep;

    private float steptime;
    public float stepTimeDelay;

    public int heartPiece;
    public int jesusObject;


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

       

        rotateCam.x = mouseY;
        rotateBody.y = mouseX;

        cam.Rotate(-rotateCam * Time.deltaTime * cameraSpeed);

        transform.Rotate(rotateBody * Time.deltaTime * cameraSpeed);

        if (Input.GetKeyDown(KeyCode.E) && canMove)
        {
            
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
            if(hit.collider.GetComponent<InteractableObject>() && hit.collider.GetComponent<InteractableObject>().canInteract)
            {
                interactableObject = hit.collider.GetComponent<InteractableObject>();
                eToInteract.SetActive(true);
            }
            else
            {
                eToInteract.SetActive(false);
                interactableObject = null;

            }
        }
        else
        {
            eToInteract.SetActive(false);
            interactableObject = null;
            
        }

        if (v != 0 || h != 0)
        {
            if(steptime <= 0)
            {

              
                footStep.Play();
                print("walkingsound");
                steptime = stepTimeDelay;

                footStep.pitch = Random.Range(0.4f, 1f);


            }

            else
            {
                steptime -= Time.fixedDeltaTime;
            }
           
        }
        else if (steptime > 0)
        {
           // footStep.Play();
            steptime = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    void start()
    {
        
    }
}
