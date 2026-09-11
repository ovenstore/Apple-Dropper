using UnityEngine;

public class Dropper : MonoBehaviour
{
    private bool fromLeft; // True will be left side of the screen, False will be right side
    private Vector2 direction;
    public float speed;
    public GameObject drop;

    private float leftBound = -12f;
    private float rightBound = 12f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= leftBound || transform.position.x >= rightBound) // if offscreen
        {
            fromLeft = Random.value < 0.5f;

            if (fromLeft)
            {
                transform.position = new Vector2(-11.5f, transform.position.y);
                direction = Vector2.right;
            }
            else
            {
                transform.position = new Vector2(11.5f, transform.position.y);
                direction = Vector2.left;
            }   
        } 
        else if (transform.position.x >= -9 && transform.position.x <= 9 && Random.value < 0.05f) // only if onscreen
        {
            Instantiate(drop, transform.position, Quaternion.identity);
        }
        
        transform.position = (Vector2) transform.position + speed * Time.deltaTime * direction; 
    }

}
