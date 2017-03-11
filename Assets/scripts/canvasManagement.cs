﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canvasManagement : MonoBehaviour {

	public Canvas win,lose;

	public void showWin()
	{
		Time.timeScale=0.0f;
		win.enabled=true;
	}

	public void hideWin()
	{
		Time.timeScale=1.0f;
		win.enabled=false;
	}

	public void showLose()
	{
		Time.timeScale=0.0f;
		lose.enabled=true;
	}

	public void hideLose()
	{
		Time.timeScale=1.0f;
		lose.enabled=false;
	}

	public void restart()
	{
		lose.enabled=false;
		win.enabled= false;
		Time.timeScale= 1.0f;
		SceneManager.LoadScene(1);

	}
	

}
