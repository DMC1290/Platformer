using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class UIManager : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI _goodGameText;
    
    // Start is called before the first frame update
    void Start() => HideGoodGame();
    public void HideGoodGame() => _goodGameText.enabled = false;

    public void ShowGoodGame() => _goodGameText.enabled = true;
    
}
