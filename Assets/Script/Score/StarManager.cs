using UnityEngine;
using UnityEngine.UI;

public class StarManager : MonoBehaviour
{
    [Header("star")]
    [SerializeField] Image[] Stars;
    [SerializeField] Sprite yellow;
    [SerializeField] Button ButtonNextLevel;
    [SerializeField] Sprite Buttongrey;
    [SerializeField] Sprite ButtonGreen;
    [SerializeField] Sprite StarGrey;

    void Update()
    {
        switch (Player.StarsCount)
        {
            case 1:
                Stars[0].sprite = yellow;
                ButtonNextLevel.image.sprite = ButtonGreen;
                ButtonNextLevel.interactable = true;
                break;
            case 2:
                Stars[0].sprite = yellow;
                Stars[1].sprite = yellow;
                ButtonNextLevel.image.sprite = ButtonGreen;
                ButtonNextLevel.interactable = true;
                break;
            case 3:
                Stars[0].sprite = yellow;
                Stars[1].sprite = yellow;
                Stars[2].sprite = yellow;
                ButtonNextLevel.image.sprite = ButtonGreen;
                ButtonNextLevel.interactable = true;
                break;
            default:
                ButtonNextLevel.image.sprite = Buttongrey;
                ButtonNextLevel.interactable = false;
                Stars[0].sprite = StarGrey;
                Stars[1].sprite = StarGrey;
                Stars[2].sprite = StarGrey;
                break;
        }
    }
}
