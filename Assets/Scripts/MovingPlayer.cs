using UnityEngine;


public class MovingPlayer : MonoBehaviour
{
    [SerializeField] KeyCode MovingForward;
    [SerializeField] KeyCode MovingBack;
    [SerializeField] Vector3 MovingDirectionForwardBack;
    [SerializeField] KeyCode MovingRight;
    [SerializeField] KeyCode MovingLeft;
    [SerializeField] Vector3 MovingDirectionRightLeft;


    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey(MovingForward))
        {
            GetComponent<Rigidbody>().velocity -= MovingDirectionForwardBack;
        }
        if (Input.GetKey(MovingBack))
        {
            GetComponent<Rigidbody>().velocity += MovingDirectionForwardBack;
        }
        if (Input.GetKey(MovingRight))
        {
            GetComponent<Rigidbody>().velocity += MovingDirectionRightLeft;
        }
        if (Input.GetKey(MovingLeft))
        {
            GetComponent<Rigidbody>().velocity -= MovingDirectionRightLeft;
        }
    }
}
