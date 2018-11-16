using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {

	public Button newGame;
	public Button inventory;
	public Button shop;
	public Button settings;
	public Button exit;

	void Start () 
	{
		Debug.Log("Menu Start");
		newGame.onClick.AddListener(newGameOnClick);
		inventory.onClick.AddListener(inventoryOnClick);
		shop.onClick.AddListener(shopOnClick);
		settings.onClick.AddListener(settingsOnClick);
		exit.onClick.AddListener(exitOnClick);
	}
	
	void Update () {
	
	}

	public void newGameOnClick() {
		Debug.Log("newGameOnClick");
		Application.LoadLevel("GameScene");
	}

	public void inventoryOnClick() {
		Debug.Log("inventoryOnClick");
		Application.LoadLevel("InventoryScene");
	}

	public void shopOnClick() {
		Debug.Log("shopOnClick");
		Application.LoadLevel("ShopScene");
	}

	public void settingsOnClick() {
		Debug.Log("settingsOnClick");
		Application.LoadLevel("SettingsScene");
	}

	public void exitOnClick() {
		Debug.Log("exitOnClick");
		Application.Quit();
	}
}