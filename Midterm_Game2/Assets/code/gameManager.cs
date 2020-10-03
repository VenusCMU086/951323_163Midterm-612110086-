using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    static public gameManager Instance{
        get{
            if(_instance == null){
                _instance = GameObject.FindObjectOfType<gameManager>();
                GameObject container = new GameObject("gameManager");
                _instance = container.AddComponent<gameManager>();
            }
            return _instance;
        }
    }
static protected gameManager _instance =null;

void awake(){
    if(_instance == null){
        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    else {
        if(this != _instance){
            Destroy(this.gameObject);
        }
    }
}

public bool MusicPlay{get;set;}
public bool SFXPlay{get;set;}
public bool OptionActivate {get;set;}
protected bool _OptionActivate = false;
    

    
}
