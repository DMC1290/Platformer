using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
 
public class ItemManager : MonoBehaviour
{
    [SerializeField] private UIManager uIManager;

    [SerializeField] private UnityEvent allItemsPickedUp;
    
    //Fill the list with Editor
    private List<Item> _items = new List<Item>();
    
    // Start is called before the first frame update
    void Start()
    {   //LINQ
        Item[] itemsArray = FindObjectsByType<Item>(FindObjectsSortMode.None);
        _items = new List<Item>(itemsArray);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("On a gagné!!!");
        //LoadItems();
        allItemsPickedUp?.Invoke(); 
    }

    private void LoadItems()
    {
        
    }
    
}
