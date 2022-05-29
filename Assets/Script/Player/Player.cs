using UnityEngine;
public class Player : MonoBehaviour
{
    [Header("Stars")]
    public static int StarsCount;

    [Header("Coins")]
    [SerializeField] GameObject Number1;
    [SerializeField] GameObject Number5;
    int CountCoins = 0;
    public static float CountCoinsEndlessLevel;

    [Header("Player")]
    [SerializeField] float speed;
    public static float Test;
    [SerializeField] float rotationSpeed;
    Rigidbody2D rb;
    AudioSource audioSource;

    //private void Awake()
    //{
    //    Test = 2;
    //}
    void Start()
    {
        Test = 2;
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        StarsCount = 0;
        MoveUp();       
    }

    #region Move
    private void FixedUpdate()
    {
        //if (!GameManager.Instance.isGameOver)
        //{
            if (Input.GetKey(KeyCode.RightArrow))
                MoveRight();

            else if (Input.GetKey(KeyCode.LeftArrow))
                MoveLeft();

            if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
                StopMove();
        //}
        Debug.Log(StarsCount);
    }

    void MoveUp()
    {
        rb.velocity = Vector2.up * speed;
    }
    public void MoveLeft()
    {
        rb.angularVelocity = rotationSpeed;
    }
    public void MoveRight()
    {
        rb.angularVelocity = -rotationSpeed;
    }
    public void StopMove()
    {
        rb.angularVelocity = 0;
    }
    #endregion

    private void Update()
    {
        CountCoinsEndlessLevel = CountCoins;
        //Debug.Log("speed : " + Test);
        if (Test == 0)
        {
            rb.bodyType = RigidbodyType2D.Static;
        }
        else if (Test == 2)
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("coin"))
        {
            CountCoins += 1;
            audioSource.Play();
            Destroy(other.gameObject);
            //shop
            GameDataManager.AddCoin(10);
            Destroy(Instantiate(Number1, other.transform.position, Quaternion.identity), 1f);
        }

        else if (other.CompareTag("Star"))
        {
            CountCoins += 5;
            audioSource.Play();
            //shop
            GameDataManager.AddCoin(50);
            Destroy(other.gameObject);
            StarsCount++;
            Destroy(Instantiate(Number5, other.transform.position, Quaternion.identity), 1f);
        }
    }
}
