using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemImage;

    public void SetItem(Sprite sprite)
    {
        Debug.Log($"[UISlot] SetItem 호출됨: {(sprite != null ? sprite.name : "null")}");

        if (sprite != null)
        {
            itemImage.sprite = sprite;
            itemImage.enabled = true;
        }
        else
        {
            itemImage.sprite = null;
            itemImage.enabled = false;
        }
    }

}