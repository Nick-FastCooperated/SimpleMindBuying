using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class SaveLoad : MonoBehaviour
{
    string path = Application.dataPath + "/Data/";

    public ItemInventory items;
    public NPCList npcs;

    // Inventory data
    public void SaveToJson()
    {
        // Save item
        string json = JsonUtility.ToJson(items, true);
        File.WriteAllText(path + "/inventory.json",json);

        // Save npc
        json = JsonUtility.ToJson(npcs, true);
        File.WriteAllText(path + "/npcs.json",json);

        Debug.Log("Save complete");
    }
    public void LoadFromJson()
    {
        // Load items
        string json = File.ReadAllText(path + "/inventory.json");
        items = new ItemInventory();
        items = JsonUtility.FromJson<ItemInventory>(json);


        // Load npcs
        json = File.ReadAllText(path + "/npcs.json");
        npcs = new NPCList();
        npcs = JsonUtility.FromJson<NPCList>(json);

        Debug.Log("Load complete");  
    }

    private void Start() {
        LoadFromJson();
    }
}
