using UnityEngine;

public class MissDetector : MonoBehaviour
{
    public BucketGroup bucketGroup;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Detect when drops hit 
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);

        bucketGroup.RemoveBucket();
    }
}
