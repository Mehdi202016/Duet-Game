using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Sprite[] SpriteMute;
    [SerializeField] Image IMG;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Update()
    {
        if (PlayerPrefs.GetInt("isMuted") == 1)
        {
            audioSource.mute = true;
            IMG.sprite = SpriteMute[0];

        }
        else if (PlayerPrefs.GetInt("isMuted") == 0)
        {
            audioSource.mute = false;
            IMG.sprite = SpriteMute[1];

        }
    }
    public void Muting()
    {
        if (PlayerPrefs.GetInt("isMuted") == 1)
        {
            PlayerPrefs.SetInt("isMuted", 0);

        }
        else if (PlayerPrefs.GetInt("isMuted") == 0)
        {
            PlayerPrefs.SetInt("isMuted", 1);

        }
    }
}
