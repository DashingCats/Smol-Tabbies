using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class civilian : MonoBehaviour
{
    Vector3 target;
    Vector3 target1 = new Vector3(7.65f, -3.04f, 1f);
    Vector3 target2 = new Vector3(-7.64f, -3.04f, 1f);
    public float speed = 1.0f; 

    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        int randomdirection = random.Next(2);
        Debug.Log(randomdirection);

        if (randomdirection == 1)
            target = target1;
        else
            target = target2;
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
        if (Vector3.Distance(transform.position, target) < 0.001f)
        {
            if (target == target1)
                target = target2;
            else
                target = target1;
        }
    }

    private void Awake()
    {
        
    }
}
