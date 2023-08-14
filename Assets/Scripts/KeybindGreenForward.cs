using UnityEngine;
using TMPro;
using System;


public class KeybindGreenForward : MonoBehaviour
{
	public TextMeshProUGUI buttonLbl;

	public void Start()
	{
		buttonLbl.text = PlayerPrefs.GetString("CustomKey6");
	}

	public void Update()
	{
		if (buttonLbl.text == "Awaiting Input")
		{
			foreach (KeyCode keycode1 in Enum.GetValues(typeof(KeyCode)))
			{
				if (Input.GetKey(keycode1))
				{
					buttonLbl.text = keycode1.ToString();
					PlayerPrefs.SetString("CustomKey6", keycode1.ToString());
					PlayerPrefs.Save();
					Debug.Log(keycode1);
				}
			}
		}
	}

	public void ChangeKey()
	{
		buttonLbl.text = "Awaiting Input";
	}
}