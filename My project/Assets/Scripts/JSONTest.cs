using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONTest : MonoBehaviour
{
    public string json;
    // Start is called before the first frame update
    void Start()
    {
        ItemData data;
        data = SerializationHelper.DeserializeData(json);

        if(data!=null)
        {
            Debug.Log($"Load complete");
        }
        else{
            Debug.Log($"Load error");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
