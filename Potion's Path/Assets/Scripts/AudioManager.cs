using UnityEngine;
//Tutorial: https://www.youtube.com/watch?v=N8whM1GjH4w

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source:")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio Clip:")]
    public AudioClip level1Background;

    private void Start()
    {
        musicSource.clip = level1Background;
        musicSource.Play();
    }
}
