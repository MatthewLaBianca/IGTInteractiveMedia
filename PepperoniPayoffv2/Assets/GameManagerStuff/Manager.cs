using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
    public static Manager instance = null;
    private float balance = 130;

    void Start () {
		//this is just to enforce our singleton..
		//if there is no instance of the GameManager, than set it to this instance
		//if there is an instance of the GameManager already, then destroy this one.
        if (instance == null)
        {
            instance = this;
            Debug.Log("NULL");
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            Debug.Log("NOT NULL");

        }
        DontDestroyOnLoad(gameObject); //this allows this script to carry throughout every "scene"
    }
	

    public float GetBalance()
    {
        return balance;
    }
    public void ChangeBalanceBy(float amnt)
    {
        balance += amnt;
    }
    public void SubtractBalanceBy(float amnt)
    {
        balance -= amnt;
    }
    public void ResetBalance()
    {
        balance = 130;
    }
}
