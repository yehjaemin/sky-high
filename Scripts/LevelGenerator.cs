using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] platformPrefabs;

    public int numberOfPlatforms;
    public float levelHeight = 3f;
    public float minX = 128f;   // min x value to add to new platform
    public float maxX = 640f;   // max x value to add to new platform

	// Use this for initialization
	void Start () {
        Vector3 spawnPosition = new Vector3();

		for (int i=0; i < numberOfPlatforms; i++)
        {
            spawnPosition.x += Random.Range(minX, maxX);
            spawnPosition.y = Random.Range(-levelHeight, levelHeight);
            Instantiate(platformPrefabs[Random.Range(0, 2)], spawnPosition, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
