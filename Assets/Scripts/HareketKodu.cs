using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKodu : MonoBehaviour
{
    // Oyuncuya gerekli �eyler
    // Ate� etmek
    // Oyuncu bi tu�a bast��� anda, bir mermi olu�turucaz ve her zaman ileriye gidicek
    // Yer �ekimi 

    public Rigidbody2D rb;
    public float hiz;

    public GameObject mermi;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector2.left * hiz;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector2.right * hiz;
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = Vector2.up * hiz;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = Vector2.down * hiz;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(mermi, this.transform.position, Quaternion.identity);
        }
    }
}
