using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class Pacdot : MonoBehaviour {

    [DllImport("__Internal")]
    private static extern void ConsoleLog(string label ,int num);

	private PlayerController pacman;

	void Start(){

		this.pacman = GameObject.Find("pacman").GetComponent<PlayerController>();

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "pacman")
		{
			GameManager.score += 10;

			ConsoleLog("score", GameManager.score);

		    GameObject[] pacdots = GameObject.FindGameObjectsWithTag("pacdot");

			this.pacman.getDot();

            Destroy(gameObject);

		    if (pacdots.Length == 1)
		    {
		        GameObject.FindObjectOfType<GameGUINavigation>().LoadLevel();
		    }
		}
	}
}
