using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed);

        //Makes sure player model doesn't leave bounds
        if (transform.position.x < -15.646)
        {
            transform.position = new Vector3((float)-15.646, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 15.92642)
        {
            transform.position = new Vector3((float)15.92642, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

}
