using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;  // Variable that determines the forward force
    public float sidewaysForce = 500f;  // Variable that determines the sideways force

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        // Add a forward force
        // Update is called once per frame, note we can use Update or FixedUpdate
        //We are using FixedUpdate instead because it is preffered by Unity for phsyics things
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //note: time.delta time adjusts the force so it will look the same
        //on all systems no matter what your framerate is
        //we adjust this forwardForce var inside of unity
        //Note: forcemode.velocity change is a parameter we don't need
        //but it helps the game feel more responsive
        if (Input.GetKey("d"))  // If the player is pressing the "d" key
        {
            // Add a force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))  // If the player is pressing the "a" key
        {
            // Add a force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
