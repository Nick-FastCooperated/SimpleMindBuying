using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class NPCData: ScriptableObject
{
    public string npc_name;
    public Sprite npc_sprite;
    public string npc_desc;
    public List<string> npc_tag;
    public List<string> npc_info;
}

[CreateAssetMenu]
public class ItemData: ScriptableObject
{
    public string item_name;
    public Sprite item_sprite;
    public string item_desc;
    public string item_tag;
    public int item_price;
    public int item_count;
}