using UnityEngine;
using System.Collections;

public class MCHashIDs : MonoBehaviour {

    public int idleState;
    public int startraceBool;
    public int movingState;
    public int frostBool;
    public int frostState;
    public int shovelState;
    public int shovelBool;
    public int webState;
    public int webBool;

	// Use this for initialization
	void Awake ()
    {
        idleState = Animator.StringToHash("Base Layer, Idle");
        startraceBool = Animator.StringToHash("StartRace");
        movingState = Animator.StringToHash("Base Layer, moving");
        frostBool = Animator.StringToHash("Frost");
        frostState = Animator.StringToHash("Base Layer, Frost");
        shovelState = Animator.StringToHash("Base Layer, Shovel");
        shovelBool = Animator.StringToHash("Shovel");
        webState = Animator.StringToHash("Base Layer, Web");
        webBool = Animator.StringToHash("Web");
    }
}
