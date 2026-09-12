using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class BucketGroup : MonoBehaviour
{
    private Vector2 mousePos;

    private int buckets = 3;

    public int score = 0;

    public GameObject bucket1;
    public GameObject bucket2;
    public GameObject bucket3;

    public GameObject gameOverPanel;
    public TextMeshProUGUI finalScoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(mousePos.x, transform.position.y);
    }

    void OnMouseMove(InputValue value)
    {
        mousePos = value.Get<Vector2>();
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
    }

    public void RemoveBucket()
    {
        if (buckets == 3)
        {
            Destroy(bucket3);
        } 
        else if (buckets == 2)
        {
            Destroy(bucket2);
        }
        else if (buckets == 1)
        {
            Destroy(bucket1);

            // end the game
            GameOver();
        } 

        buckets--;
    }

    // Detect drops
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        score++;
    }

    void GameOver()
    {
        gameOverPanel.SetActive(true);
        finalScoreText.text = "Final Score: " + score;
    }
}


