using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour {

	public Text play;
	public bool isPlayingAnim = false;
	public bool isDecreasing = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

//	public void Play(){
//		isPlayingAnim = true;
//		if (isPlayingAnim) {

//		}
//	}



	public void startGame()
	{
		SceneManager.LoadScene ("testscene");
	}

	void IncreaseTextAnim(){
		for(float i = play.transform.localScale.y; i < 1.5f; i += 0.02f){
			play.transform.localScale = new Vector3 (play.transform.localScale.x, i, play.transform.localScale.z) * Time.deltaTime;
		}
	}

	void DecreaseTextAnim(){
		for (float y = play.transform.localScale.y; y > 1; y -= 0.02f) {
			play.transform.localScale = new Vector3 (play.transform.localScale.x, y, play.transform.localScale.z) * Time.deltaTime;
		}
	}


	public void Menu(){
		Application.LoadLevel ("CubeSelect");
	}
}
