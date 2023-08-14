using UnityEngine;
using TMPro;
using System;
public class KeybindGreenCannon : MonoBehaviour
{
	public TextMeshProUGUI buttonLbl;

	public void Start()
	{
		buttonLbl.text = PlayerPrefs.GetString("CustomKey2");
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
					PlayerPrefs.SetString("CustomKey2", keycode.ToString());
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
