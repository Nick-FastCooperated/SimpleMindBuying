using System.Collections.Generic;
using UnityEngine;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabBtn;
    public Sprite tabIdle;
    public Sprite tabHover;
    public Sprite tabActive;
    public TabButton selectedTab;

    public List<GameObject> objects;

    public void Subcribe(TabButton btn)
    {
        if(tabBtn == null)
        {
            tabBtn = new List<TabButton>();
        }

        tabBtn.Add(btn);
    }

    public void OnTabEnter(TabButton btn)
    {
        ResetTabs();
        if(selectedTab == null || btn != selectedTab)
        { 
            btn.background.sprite = tabHover;
        }
    }

    public void OnTabExit(TabButton btn)
    {
        ResetTabs();
    }

    public void OnTabSelected(TabButton btn)
    {
        if(selectedTab != null)
        {
            selectedTab.Deselect();
        }

        selectedTab = btn;
        
        selectedTab.Select();

        ResetTabs();
        btn.background.sprite = tabActive;
        int index = btn.transform.GetSiblingIndex();
        for(int i = 0; i < objects.Count; i++)
        {
            if(i == index)
            {
                objects[i].SetActive(true);
            }
            else
            {
                objects[i].SetActive(false);
            }
        }
    }
    
    public void ResetTabs()
    {
        foreach(TabButton btn in tabBtn)
        {
            if(selectedTab!=null && btn == selectedTab) {continue;}
            btn.background.sprite = tabIdle;
        }
    }

    void Start()
    {
        OnTabSelected(selectedTab);
    }

}
