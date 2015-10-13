using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuProfileManager : MonoBehaviour {


    public Text balance;
    private int bal;
    public GameObject gameManager;
    private Manager managerScript;

    // Use this for initialization
    void Start () {
        managerScript = gameManager.GetComponent<Manager>();

    }

    // Update is called once per frame
    void Update () {
        balance.text = "$" + managerScript.GetBalance().ToString();

        if (Input.GetKeyDown(KeyCode.T))
        {
            managerScript.ChangeBalanceBy(-10);
           // balance.text = "Balance: $" + managerScript.GetBalance().ToString();
        }    
    }

    public void ResetBalance()
    {
        managerScript.ResetBalance();
    }

}
