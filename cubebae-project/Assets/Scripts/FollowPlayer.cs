using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    //Reference to the player
    public Transform player;    // A variable that stores a reference to our Player
                                //lets us choose an offset for the camera, x,y,z
    public Vector3 offset;      // A variable that allows us to offset the position (x, y, z)

    // Update is called once per frame
    void Update()
    {
        // Set our position to the players position and offset it
        //Debug.Log(player.position);
        //by using a noncapital t in transform this means we are referring to our current object
        //set our current object(the camera) to the same position as the player
        //note without the offset, this will put the camera inside the player 
        //(not what we want unless we want to play a first person type game)
        transform.position = player.position + offset;
    }
}
