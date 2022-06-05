using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

    BallGame bgm;

    private void Awake()
    {
        bgm = GameObject.Find("GameManager").GetComponent<BallGame>();
    }

    private void Update()
    {
        transform.Rotate(new Vector3(15, 30, 40) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            bgm.score = bgm.score + 10;
            Destroy(gameObject);
        }

    }
}
