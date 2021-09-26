using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiKodu : MonoBehaviour
{
    public float hiz;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * hiz);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Meteor")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
