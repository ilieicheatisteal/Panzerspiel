using UnityEngine;
using TMPro;
using System;

public class KeybindGreenRight : MonoBehaviour
{
	public TextMeshProUGUI buttonLbl;

	public void Start()
	{
		buttonLbl.text = PlayerPrefs.GetString("CustomKey5");
	}

	public void Update()
	{
		if (buttonLbl.text == "Awaiting Input")
		{
			foreach (KeyCode keycode in Enum.GetValues(typeof(KeyCode)))
			{
				if (Input.GetKey(keycode))
				{
					buttonLbl.text = keycode.ToString();
					PlayerPrefs.SetString("CustomKey5", keycode.ToString());
					PlayerPrefs.Save();
				}
			}
		}
	}

	public void ChangeKey()
	{
		buttonLbl.text = "Awaiting Input";
	}
}
