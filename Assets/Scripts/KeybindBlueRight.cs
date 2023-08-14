using UnityEngine;
using TMPro;
using System;

public class KeybindBlueRight : MonoBehaviour
{
	public TextMeshProUGUI buttonLbl;

	public void Start()
	{
		buttonLbl.text = PlayerPrefs.GetString("CustomKey11");
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
					PlayerPrefs.SetString("CustomKey11", keycode.ToString());
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
