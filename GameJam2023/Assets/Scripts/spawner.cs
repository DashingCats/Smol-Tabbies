using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnerPrefab;
    private float spawnInterval = 6.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnRight(spawnInterval, spawnerPrefab));
        StartCoroutine(spawnLeft(spawnInterval, spawnerPrefab));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnRight(float interval, GameObject civilian)
    {
        yield return new WaitForSeconds(interval);
        GameObject newCitizen = Instantiate(civilian, new Vector3(Random.Range(1.94f, 7.65f), -3.04f,  1), Quaternion.identity);
        StartCoroutine(spawnRight(interval, civilian));


    }
    private IEnumerator spawnLeft(float interval, GameObject civilian)
    {
        yield return new WaitForSeconds(interval);
        GameObject newCitizen = Instantiate(civilian, new Vector3(Random.Range(-7.64f, -2.05f), -3.04f,  1), Quaternion.identity);
        StartCoroutine(spawnLeft(interval, civilian));


    }
}
