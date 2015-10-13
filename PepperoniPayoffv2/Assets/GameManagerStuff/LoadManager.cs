using UnityEngine;
using System.Collections;

public class LoadManager : MonoBehaviour {


    public GameObject gameManager;


    void Awake()
    {
        if (Manager.instance == null)
        {
            Instantiate(gameManager);
        }
    }


}
