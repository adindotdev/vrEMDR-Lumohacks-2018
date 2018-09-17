using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCameraTherapist : MonoBehaviour
{
    public AudioSource TherapistAudioSource;
    public AudioClip TherapistAudioClip;

    private readonly int audioStartTime = 3;
    private readonly int startTime = 25;
    private readonly int endTime = 120;

    private BallMovingScript ballMovingScript;
    private bool hasPlayed = false;

    // Use this for initialization
    void Start()
    {
        ballMovingScript = GameObject.Find("Sphere").GetComponent<BallMovingScript>();
        TherapistAudioSource.clip = TherapistAudioClip;
        TherapistAudioSource.PlayDelayed(audioStartTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (TherapistAudioSource.time >= startTime && !ballMovingScript.GetIsBallMoving())
        {
            ballMovingScript.SetIsBallMoving(true);
        }
        if (TherapistAudioSource.time >= endTime && ballMovingScript.GetIsBallMoving())
        {
            ballMovingScript.SetIsBallMoving(false);
            hasPlayed = true;
        }
        if (!TherapistAudioSource.isPlaying && hasPlayed) {
            SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
        }
    }
}
