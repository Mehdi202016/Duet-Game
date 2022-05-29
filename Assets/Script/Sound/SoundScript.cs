using UnityEngine;


public class SoundScript : MonoBehaviour
{
    public static SoundScript instace;
    AudioSource AudioButtonClick;
    [SerializeField] AudioClip SoundButtons;

    private void Awake()
    {
        if (instace == null)
        { instace = this; }
    }
    private void Start()
    {
        AudioButtonClick = GetComponent<AudioSource>();
    }
    public void ButtonClickSound()
    {
        AudioButtonClick.clip = SoundButtons;
        AudioButtonClick.Play();
    }
}
