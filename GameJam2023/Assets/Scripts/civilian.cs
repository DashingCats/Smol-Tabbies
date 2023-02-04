using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class civilian : MonoBehaviour
{
    Vector3 target;
    Vector3 target1 = new Vector3(8.25f, -3.6f, 1f);
    Vector3 target2 = new Vector3(-8.22f, -3.6f, 1f);
    public float speed = 1.0f; 
    SpriteRenderer c_SpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        c_SpriteRenderer = GetComponent<SpriteRenderer>();
        System.Random random = new System.Random();
        int randomdirection = random.Next(2);

        speed = Random.Range(1.0F, 2.0F);
        if (randomdirection == 1)
        {
            target = target1;
            c_SpriteRenderer.flipX = true;

        }
        else
        {
            target = target2;
            c_SpriteRenderer.flipX = false;
            
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);





        if (Vector3.Distance(transform.position, target) < 0.001f)
        {
            if (target == target1)
            {
                target = target2;
                c_SpriteRenderer.flipX = false;

            }
            else
            {
                target = target1;
                c_SpriteRenderer.flipX = true;

            }
        }

    }

    

}
