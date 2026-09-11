using UnityEngine;

public class Drop : MonoBehaviour
{
    public float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.down;
        
        if (transform.position.y <= -6)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        Destroy(gameObject); 
    }
}
