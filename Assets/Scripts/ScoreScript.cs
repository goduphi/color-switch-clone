﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
	public GameObject Star;
	public GameObject StarExplode;
	private AudioSource ScoreAudio;
	
	private int TotalScore;
	private Text ScoreText;
	
	void Awake()
	{
		ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();
		ScoreAudio = GameObject.FindGameObjectWithTag("Score").GetComponent<AudioSource>();
	}
	
	void OnTriggerEnter2D(Collider2D target)
	{
		if(target.tag == "Star")
		{
			IncrementScore();
			Instantiate(StarExplode, Star.transform.position, Quaternion.identity);
			Destroy(target.gameObject);
		}
	}
	
	void IncrementScore()
	{
		TotalScore++;
		ScoreText.text = "" + TotalScore;
		ScoreAudio.Play();
	}
}
