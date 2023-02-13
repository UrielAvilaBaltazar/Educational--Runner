
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    bool alive = true;

    public float speed = 5;
    [SerializeField] Rigidbody rb;

    float horizontalInput;
    [SerializeField] float horizontalMultiplier = 2;

    public float speedIncreasePerPoint = 0.1f;

    //para saltos
    [SerializeField] float jumpForce = 400f;
    [SerializeField] LayerMask groundMask;
    [SerializeField] GameObject panelGameOver;
    public bool Grounded = true;
    public float GroundedOffset = -0.14f;
    public float GroundedRadius = 0.28f;

    private void FixedUpdate()
    {
        if (!alive) return;

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {
        GroundedCheck();
        horizontalInput = Input.GetAxis("Horizontal");

        //salto
        if(Grounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }
        

        if(transform.position.y < -5)
        {
            Die();
        }
    }

    public void Die()
    {
        alive = false;
        //reiniciar el juego
        //SceneManager.LoadScene(SceneManager.GetActivateScene().name);
        Invoke("Restart", 2);
        
       // SceneManager.LoadScene(4);
    }

    void Restart()
    {
        panelGameOver.SetActive(true);
        //SceneManager.LoadScene(6);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //saltos
    void Jump()
    {
        //revisar que tan lejos esta el suelo
        float heigth = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (heigth / 2) + 0.1f, groundMask);

        //si es posible saltar
        rb.AddForce(Vector3.up * jumpForce);
    }
    private void GroundedCheck()
    {
        // set sphere position, with offset
        Vector3 spherePosition = new Vector3(transform.position.x, transform.position.y - GroundedOffset,
            transform.position.z);
        Grounded = Physics.CheckSphere(spherePosition, GroundedRadius, groundMask,
            QueryTriggerInteraction.Ignore);
    }
}
