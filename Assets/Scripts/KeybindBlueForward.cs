using UnityEngine;
using TMPro;
using System;

public class KeybindBlueForward : MonoBehaviour
{
	public TextMeshProUGUI buttonLbl;

	public void Start()
	{
		buttonLbl.text = PlayerPrefs.GetString("CustomKey9");
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
					PlayerPrefs.SetString("CustomKey9", keycode.ToString());
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