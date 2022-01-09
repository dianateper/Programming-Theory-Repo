using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    [SerializeField] Text username;
    
    // Start is called before the first frame update
    void Start()
    {
        username.text = GameManager.Instance.username;
    }
}
