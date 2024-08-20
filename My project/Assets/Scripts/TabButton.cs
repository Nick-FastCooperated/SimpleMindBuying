using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour, IPointerEnterHandler,
IPointerClickHandler, IPointerExitHandler
{
    public TabGroup tabGroup;

    public Image background;

    public UnityEvent onTabSelect;
    public UnityEvent onTabDeselect;
    

    public void OnPointerClick(PointerEventData eventData)
    {
        tabGroup.OnTabSelected(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tabGroup.OnTabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabGroup.OnTabExit(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<Image>();
        tabGroup.Subcribe(this);
    }

    public void Select()
    {
        if(onTabSelect != null)
        {
            onTabSelect.Invoke();
        }
    }
    public void Deselect()
    {
        if(onTabDeselect != null)
        {
            onTabDeselect.Invoke();
        }
    }
}
