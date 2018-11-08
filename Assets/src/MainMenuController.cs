using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

	public Button newGame;

	void Start () 
	{
		Debug.Log("Menu Start");
		newGame.onClick.AddListener(onClickNewGame);
	}
	
	void Update () {
	
	}

	void onClickNewGame() {
		Debug.Log("NewGame CLick");
		Application.LoadLevel("LevelsListScene");
	}
}