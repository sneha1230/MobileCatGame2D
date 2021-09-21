using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PoolItems
{
    public GameObject prefab;
    public int amount;
}
public class Pool : MonoBehaviour
{
    public static Pool instance;
    public List<PoolItems> items;
    public List<GameObject> pooledItems;

    private void Awake()
    {
        if(instance = null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        pooledItems = new List<GameObject>();
        foreach(PoolItems item in items)
        {
            for(int i=0; i< item.amount; i++)
            {
                GameObject obj = Instantiate(item.prefab);
                obj.SetActive(false);
                pooledItems.Add(obj);
            }
        }
    }

    public GameObject Get(string tag)
    {
        for(int i=0; i<pooledItems.Count;i++)
        {
            if(!pooledItems[i].activeInHierarchy && pooledItems[i].tag == tag)
            {
                return pooledItems[i];
            }
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
