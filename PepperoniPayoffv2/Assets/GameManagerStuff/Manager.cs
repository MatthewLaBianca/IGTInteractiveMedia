using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
    public static Manager instance = null;
    private float balance = 130;
    // Use this for initialization
    void Awake()
    {
        
    }
    void Start () {
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
        DontDestroyOnLoad(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	
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
