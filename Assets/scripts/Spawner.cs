using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject[] block;
    public  int Timer;
    void Start()
    {
        SpawnFloor();
        InvokeRepeating("SpawnFloor", 0, Timer);
    }

    public void SpawnFloor()
    {
        int randomIndex = Random.Range(0, block.Length);
        GameObject floor = Instantiate(block[randomIndex], transform.position, Quaternion.identity);
        floor.transform.SetParent(transform);
    }
}
