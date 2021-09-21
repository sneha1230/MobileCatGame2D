using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnPool : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.Range(0,100) < 5)
        {
            GameObject bt = Pool.instance.Get("Enemy");
            if(bt!=null)
            {
                bt.transform.position = this.transform.position + new Vector3(Random.Range(-2.5f,2.5f),5.5f,0);
                bt.SetActive(true);
            }
        }
    }
}
