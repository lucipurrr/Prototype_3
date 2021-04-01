using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        
        var menu = new GenericMenu();

        Debug.Log("hueta");

        PinObject pinnedItems = null;
        Items item = null;
        if (!pinnedItems.Contains(item.id))
            menu.AddItem(new GUIContent("Pin"), false, () => pinnedItems.Add(item.id));
        else return;
    }
}

internal class Items
{
    public object id;
}

internal class PinObject
{
    public bool Contains(object id)
    {
        throw new System.NotImplementedException();
    }

    public void Add(object itemID)
    {
        throw new System.NotImplementedException();
    }
}
