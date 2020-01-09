using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
	public float jumpSpeed = 1f;
	
	public string CurrentColor;
	
	public Color[] color = new Color[4];
	
	private Rigidbody2D BallBody;
	private SpriteRenderer sr;
	private AudioSource JumpAudio;
	private AudioSource ColorSwitchAudio;
	
	void Awake()
	{
		BallBody = GetComponent<Rigidbody2D>();
		sr = GetComponent<SpriteRenderer>();
		JumpAudio = GetComponent<AudioSource>();
		ColorSwitchAudio = GameObject.FindGameObjectWithTag("ColorChangerAudio").GetComponent<AudioSource>();
	}
	// Use this for initialization
	void Start ()
	{
		SetRandomColor();
	}
	
	// Update is called once per frame
	void Update ()
	{
		BallJump();
	}
	
	void OnTriggerEnter2D(Collider2D color)
	{
		if(color.tag == "ColorChanger")
		{
			SetRandomColor();
			ColorSwitchAudio.Play();
			//destroys the current color changer
			Destroy(color.gameObject);
			return;
		}
	}
	
	void BallJump()
	{
		if(Input.GetKeyDown("space"))
		{
			BallBody.velocity = Vector2.up * jumpSpeed;
			JumpAudio.Play();
		}
	}
	
	void SetRandomColor()
	{
		int color_code = Random.Range(0, 3);
		
		switch(color_code)
		{
			case 0:
				CurrentColor = "Purple";
				sr.color = color[color_code];
			break;
			case 1:
				CurrentColor = "Yellow";
				sr.color = color[color_code];
			break;
			case 2:
				CurrentColor = "Cyan";
				sr.color = color[color_code];
			break;
			case 3:
				CurrentColor = "Magenta";
				sr.color = color[color_code];
			break;
		}
	}
}
