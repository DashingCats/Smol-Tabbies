using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnerPrefab;
    [SerializeField]
    private GameObject spawnerPrefab2;

    private float spawnInterval = 6.5f;
    private float spawnInterval2 = 7.0f;
    private int civiliancount = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnRight(spawnInterval, spawnerPrefab));
        StartCoroutine(spawn2Right(spawnInterval, spawnerPrefab2));
        StartCoroutine(spawnLeft(spawnInterval2, spawnerPrefab));
        StartCoroutine(spawn2Left(spawnInterval, spawnerPrefab2));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnRight(float interval, GameObject civilian)
    {
        yield return new WaitForSeconds(interval);
        if (civiliancount > 10)
        {

        }
        else
        {
            GameObject newCitizen = Instantiate(civilian, new Vector3(Random.Range(1.94f, 8.25f), -3.6f, 1), Quaternion.identity);
            StartCoroutine(spawnRight(interval, civilian));
            civiliancount++;
        }
        

    }private IEnumerator spawn2Right(float interval, GameObject civilian)
    {
        yield return new WaitForSeconds(interval);
        if (civiliancount > 10)
        {

        }
        else
        {
            GameObject newCitizen = Instantiate(civilian, new Vector3(Random.Range(1.94f, 8.25f), -3.6f, 1), Quaternion.identity);
            StartCoroutine(spawnRight(interval, civilian));
            civiliancount++;
        }

    }
    private IEnumerator spawnLeft(float interval, GameObject civilian)
    {
        yield return new WaitForSeconds(interval);
        if (civiliancount > 10)
        {

        }
        else
        {
            GameObject newCitizen = Instantiate(civilian, new Vector3(Random.Range(-8.22f, -2.05f), -3.6f, 1), Quaternion.identity);
            StartCoroutine(spawnLeft(interval, civilian));
            civiliancount++;
        }

    }
    private IEnumerator spawn2Left(float interval, GameObject civilian)
    {
        yield return new WaitForSeconds(interval);
        if (civiliancount > 10)
        {

        }
        else
        {
            GameObject newCitizen = Instantiate(civilian, new Vector3(Random.Range(-8.22f, -2.05f), -3.6f, 1), Quaternion.identity);
            StartCoroutine(spawnLeft(interval, civilian));
            civiliancount++;
        }

    }
    
}
