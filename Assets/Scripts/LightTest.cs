using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LightTest : MonoBehaviour {

	public Light lightIntensity;
	public Slider bSliderValue;
	public float lightLevel;

	// Use this for initialization
	void Start () {
		bSliderValue = GetComponent<Slider> ();

		lightLevel = PlayerPrefs.GetFloat ("CurInt");

		bSliderValue.value = lightLevel;

	}

	// Update is called once per frame
	void Update () 
	{
		lightIntensity.intensity = lightLevel;

		lightLevel = bSliderValue.value;

		PlayerPrefs.SetFloat ("CurInt", lightLevel);
		//Debug.Log (lightLevel);
		//Debug.Log (bSliderValue.value);
	}
}
