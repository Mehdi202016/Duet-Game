using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{
    [Header("Level Close")]
    [Space(20)]
    [SerializeField] GameObject locked;
    [SerializeField] GameObject Cloud;

    [Header("Level Open")]
    [Space(20)]
    [SerializeField] GameObject Stars;
    [SerializeField] Image Background;
    [SerializeField] Sprite close;
    [SerializeField] Sprite open;

    [Space(20)]
    [SerializeField] Text LevelText;


    [SerializeField] Image[] Star;
    [SerializeField] Sprite SpriteYellow;
    [SerializeField] int LevelIndex;

    Button btn ;


    private void Start()
    {
        btn = GetComponent<Button>();
    }
    public void ChangeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    private void Update()
    {
        if (btn.interactable == true)
        {
            locked.SetActive(false);
            Cloud.SetActive(false);
            Stars.SetActive(true);
            LevelText.gameObject.SetActive(true);
            Background.sprite = open;
            for (int i = 0; i < PlayerPrefs.GetInt("Lve" + LevelIndex); i++)
            {
                Star[i].sprite = SpriteYellow;
            }
        }
    }
}
