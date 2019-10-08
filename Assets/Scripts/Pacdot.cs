using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class Pacdot : MonoBehaviour {

    [DllImport("__Internal")]
    private static extern void ConsoleLog(string label ,int num);

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "pacman")
		{
			GameManager.score += 10;

			ConsoleLog("score", GameManager.score);

		    GameObject[] pacdots = GameObject.FindGameObjectsWithTag("pacdot");
            Destroy(gameObject);

		    if (pacdots.Length == 1)
		    {
		        GameObject.FindObjectOfType<GameGUINavigation>().LoadLevel();
		    }
		}
	}
}
