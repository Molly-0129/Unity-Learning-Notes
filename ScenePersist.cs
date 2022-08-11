using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePersist : MonoBehaviour
{
    void Awake() 
    {
        int numScenePersist=FindObjectsOfType<ScenePersist>().Length;
        //we only need 1 scenepersist;
        if(numScenePersist>1)
        {
            Destroy(gameObject);
        }
        //persist all the objects we need while scene load;
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ResetScenePersist()
    {
        Destroy(gameObject);
    }
}
