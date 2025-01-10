using System;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private GameObject _pickable;
    [SerializeField] private GameObject _picked;

    private event Action OnPicked;
    
    // Start is called before the first frame update
    void Start()
    {
        _pickable.SetActive(true);
        _picked.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        _pickable.SetActive(false);
        _picked.SetActive(true);
    }
}
