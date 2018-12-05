using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public string levelSelect; //选择的
	//public string mainMenu; //界面

	private LevelManager theLevelManager; //level manager

	// Use this for initialization
	void Start () {
		theLevelManager = FindObjectOfType<LevelManager>(); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Restart()
	{
		PlayerPrefs.SetInt("coinCount", 0);
        PlayerPrefs.SetInt("scoreCount", 0);
        //PlayerPrefs.SetInt("PlayerLives", theLevelManager.startingLives);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //获取最新的场面
	}

	public void LevelSelect()
	{
		PlayerPrefs.SetInt("coinCount", 0);
        PlayerPrefs.SetInt("scoreCount", 0);
        //PlayerPrefs.SetInt("PlayerLives", theLevelManager.startingLives);

        SceneManager.LoadScene(levelSelect);
	}

	//public void QuitToMainMenu()
	//{
	//	SceneManager.LoadScene(mainMenu); //退回界面
	//}
}
