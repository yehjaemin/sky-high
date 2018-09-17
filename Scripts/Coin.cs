using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coin;
    public GameObject getPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(coin);
        Vector3 getPosition = new Vector3(coin.transform.position.x - 1.05f, coin.transform.position.y + 2f, coin.transform.position.z);
        GameObject get = (GameObject)Instantiate(getPrefab, getPosition, Quaternion.identity);
        Destroy(get, 1f);
    }
}
