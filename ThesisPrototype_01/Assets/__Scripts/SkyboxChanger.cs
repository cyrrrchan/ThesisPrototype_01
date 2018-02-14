using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChanger : MonoBehaviour {

	private Skybox skybox;

	public Color colorStart = Color.blue;
	public Color colorEnd = Color.red;
	public float duration = 1.0f;

	public float step = 0.0f;

	// Use this for initialization
	void Start () {
		skybox = GetComponent<Skybox> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			RenderSettings.skybox.SetColor ("_Tint", Color.Lerp (colorStart, colorEnd, step));
			step += Time.deltaTime / duration;
		}
	}
}
