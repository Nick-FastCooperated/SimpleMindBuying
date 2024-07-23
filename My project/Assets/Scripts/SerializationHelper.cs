using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class ItemData
{
    public string itemName;
    public string itemIcon;
    public string itemPath;
    public int itemPrice;
}
public class ItemDataList
{
    public List<ItemData> itemList;
}

public class SerializationHelper
{
    public static string SerializeData(ItemData item_data)
    {
        string json;
        json = JsonUtility.ToJson(item_data);

        if(json != null)
        {
            return json;
        }
        else return null;
    }
    public static ItemData DeserializeData(string json)
    {
        ItemData item_data = new ItemData();
        item_data  = JsonUtility.FromJson<ItemData>(json);
        return item_data;
    }
    public static string SerializeItemList(List<ItemData> item_data)
    {
        string json;
        json = JsonUtility.ToJson(item_data);

        if(json != null)
        {
            return json;
        }
        else return null;
    }
    public static ItemDataList DeserializeItemList(string json)
    {
        ItemDataList item_data = new ItemDataList();
        item_data  = JsonUtility.FromJson<ItemDataList>(json);
        return item_data;

    }    
}