using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemInventory: MonoBehaviour
{
    public List<ItemData> item_list = new List<ItemData>();

    public Transform item_content;
    public GameObject item_holder;

    public int TotalMoney()
    {
        int cost = 0;
        for(int i = 0; i < item_list.Count;i++)
        {
            cost += item_list[i].item_price;
        }
        return cost;
    }

    public void ListingItem()
    {
        foreach(var item in item_list)
        {
            GameObject obj = Instantiate(item_holder, item_content);
            var itemName = obj.transform.Find("item_name").GetComponent<Text>();
            var itemIcon = obj.transform.Find("item_sprite").GetComponent<Image>();

            itemName.text = item.item_name;
            itemIcon.sprite = item.item_sprite;
        }
    }
}

public class NPCList: MonoBehaviour
{
    public List<NPCData> npc_list = new List<NPCData>();

    public NPCData LoadNPC() // Randomly
    {
        int index = Random.Range(0,npc_list.Count);
        return npc_list[index];
    }
}
