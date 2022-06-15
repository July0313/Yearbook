using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEnemy : MonoBehaviour
{
    private Transform tr;

    public GameObject player;
    public int speed = 1;

    private void Start()
    {
        tr = gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        tr.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x < player.transform.position.x - 1f)
        {
            Destroy(this.gameObject);
        }
    }
}
