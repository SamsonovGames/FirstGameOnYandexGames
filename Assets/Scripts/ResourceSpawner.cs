using System.Collections;
using UnityEngine;

public class ResourceSpawner : MonoBehaviour
{
    [SerializeField]
    float delay = 0.5f;
    [SerializeField]
    GameObject[] prefabs;
    [SerializeField]
    Transform spawnPoint;
    void Start()
    {

    }


    void Update()
    {

    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            Instantiate(prefabs[0],spawnPoint.position,Quaternion.identity);
        }
    }
}
