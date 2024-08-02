using UnityEngine;

public class LevelComplete : MonoBehaviour
{

    public gameManger GM;

    public AudioSource mc;
    void OnTriggerEnter()
    {
        GM.completedLevel();

        stopAudio();

    }

    public void stopAudio()
    {
        mc.Stop();
    }
}
