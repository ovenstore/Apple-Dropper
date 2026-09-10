using UnityEngine;

public class Dropper : MonoBehaviour
{
    private bool fromLeft = Random.value < 0.5f; // True will be left side of the screen, False will be right side

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // fromLeft = Random.value < 0.5f;

        if (fromLeft)
        {
            transform.position = new Vector2(-11.5f, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(11.5f, transform.position.y);
        }
    }
}
