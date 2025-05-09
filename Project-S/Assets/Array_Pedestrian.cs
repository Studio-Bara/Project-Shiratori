using UnityEngine;

public class Array_Pedestrian : MonoBehaviour
{
    public GameObject prefab;
    public int count = 5;
    public Vector3 localOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         for (int i = 0; i < count; i++)
        {
            Vector3 worldOffset = transform.TransformDirection(localOffset * i);
            Vector3 spawnPosition = transform.position + worldOffset;
            Instantiate(prefab, spawnPosition, transform.rotation, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
