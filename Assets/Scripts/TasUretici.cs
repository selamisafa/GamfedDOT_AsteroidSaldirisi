using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasUretici : MonoBehaviour
{
    public List<GameObject> konumlar;
    public GameObject meteor;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MeteorAt", 2, 1);
    }

    void MeteorAt()
    {
        int rasgele = Random.Range(0, konumlar.Count);

        Instantiate(meteor, konumlar[rasgele].transform.position, Quaternion.identity);
    }
}
