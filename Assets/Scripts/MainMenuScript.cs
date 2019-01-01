using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

	public void newGameOnClick() {
		SceneManager.LoadScene("GameScene");
	}

	public void inventoryOnClick() {
		SceneManager.LoadScene("InventoryScene");
	}

	public void shopOnClick() {
		SceneManager.LoadScene("ShopScene");
	}

	public void settingsOnClick() {
		SceneManager.LoadScene("SettingsScene");
	}

	public void exitOnClick() {
		Application.Quit();
	}
}