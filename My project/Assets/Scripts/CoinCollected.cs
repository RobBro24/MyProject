using UnityEngine;

public class CoinCollected : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip audioClip;

    public void playAudio()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
