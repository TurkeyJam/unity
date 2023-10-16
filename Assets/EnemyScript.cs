using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -5 || transform.position.y > 5 || transform.position.x > 13 || transform.position.x < -13)
        {
            Instantiate(enemy, new Vector3(Random.Range(12f, -12f), 5, 0), transform.rotation);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(enemy, new Vector3(Random.Range(12f, -12f), 5, 0), transform.rotation);
        Destroy(gameObject);
    }

    
}
