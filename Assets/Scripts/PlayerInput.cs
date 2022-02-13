using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public string playerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadName(string s)
    {
        playerName = s;
        Debug.Log("Welcome! " + playerName);
        GameDataManager.Instance.playerName = playerName;
    }
}
