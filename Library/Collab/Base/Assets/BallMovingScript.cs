using UnityEngine;

public class BallMovingScript : MonoBehaviour
{
    private bool isRight = true;
    private int speed = 5;
    private int boundary = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isRight)
        {
            transform.Translate(Vector2.right / speed);
            isRight &= transform.position.x <= boundary;
        }
        else
        {
            transform.Translate(Vector2.left / speed);
            isRight |= transform.position.x < -boundary;
        }
    }
}
