using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	

	public PlayerMovement movement;     // A reference to our PlayerMovement script


	// This function runs when we hit another object.
	// We get information about the collision and call it "collisionInfo".
	void OnCollisionEnter (Collision collisionInfo)
	{

		Debug.Log("We hit something:" + collisionInfo.collider.name);

        if (collisionInfo.collider.name == "Obstacle")
        {
            Debug.Log("We hit an obstacle!");
        }

        //if we collide with an object with tage obstacle, stop moving
		//note that movement comes from our playermovement class
		// We check if the object we collided with has a tag called "Obstacle".
		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;   // Disable the players movement.
			  //note this code does the exact same thing as the enable above
            //the difference is in one we are creating an instance of an object to edit it
            //but here we are saying, unity find it for me and let me edit it
            //GetComponent<PlayerMovement>().enabled = false;

            //this gets the gamemanager object for us, without us making an object to ref it
			FindObjectOfType<GameManager>().EndGame();
		}
	}

}
