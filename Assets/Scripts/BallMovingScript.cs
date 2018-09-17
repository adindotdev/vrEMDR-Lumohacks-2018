using UnityEngine;

public class BallMovingScript : MonoBehaviour
{
    private readonly int speed = 3;
    private readonly int boundary = 10;
    private bool isRight = true;
    private bool isBallMoving = false;

    private bool isPlayedRight = false;
    private bool isPlayedLeft = false;

    public AudioSource LeftMusicSource;
    public AudioSource RightMusicSource;
    public AudioClip LeftMusicClip;
    public AudioClip RightMusicClip;

    public void SetIsBallMoving(bool isBallMoving)
    {
        this.isBallMoving = isBallMoving;
    }

    public bool GetIsBallMoving()
    {
        return isBallMoving;
    }

    // Use this for initialization
    void Start()
    {
        LeftMusicSource.clip = LeftMusicClip;
        RightMusicSource.clip = RightMusicClip;
    }

    // Update is called once per frame
    protected void Update()
    {
        if (isBallMoving)
        {
            if (isRight)
            {
                if (transform.position.x >= boundary - 1 && !isPlayedRight)
                {
                    RightMusicSource.Play();
                    isPlayedRight = true;
                    isPlayedLeft = false;
                }
                transform.Translate(Vector2.right / speed);
                isRight &= transform.position.x < boundary;
            }
            else
            {
                if (transform.position.x <= -boundary + 1 && !isPlayedLeft)
                {
                    LeftMusicSource.Play();
                    isPlayedLeft = true;
                    isPlayedRight = false;
                }
                transform.Translate(Vector2.left / speed);
                isRight |= transform.position.x < -boundary;
            }
        }
        if (!isBallMoving && (transform.position.x > 0 ^ transform.position.x < 0))
        {
            if (transform.position.x < 0)
            {
                transform.Translate(Vector2.right / speed);
            }
            else if (transform.position.x > 0)
            {
                transform.Translate(Vector2.left / speed);
            }
            if (transform.position.x > -speed && transform.position.x < speed)
            {
                transform.position = new Vector3(0.0f, transform.position.y, transform.position.z);
            }
        }
    }
}