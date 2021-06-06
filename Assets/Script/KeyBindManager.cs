using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class KeyBindManager : MonoBehaviour
{
	private static KeyBindManager instance;

	public static KeyBindManager MyInstance
	{
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType<KeyBindManager>();
			}
			return instance;
		}
	}

	public Dictionary<string, KeyCode> Keybinds { get; private set; }
	public Dictionary<string, KeyCode> Actionsbinds { get; private set; }
	private string BindName;
	// Start is called before the first frame update
	void Start()
    {
		Keybinds = new Dictionary<string, KeyCode>();
		Actionsbinds = new Dictionary<string, KeyCode>();
		BindKey("UP", KeyCode.W);
		BindKey("DOWN", KeyCode.S);
		BindKey("LEFT", KeyCode.A);
		BindKey("RIGHT", KeyCode.D);
	}

	public void BindKey(string key, KeyCode keybind)
	{
		Dictionary<string, KeyCode> curDict = Keybinds;
		if (key.Contains("ACT"))
		{
			curDict = Actionsbinds;
		}
		if (!curDict.ContainsKey(key))
		{
			curDict.Add(key, keybind);
		}
		else if (curDict.ContainsValue(keybind))
		{
			string mkey = curDict.FirstOrDefault(x => x.Value == keybind).Key;
			curDict[mkey] = KeyCode.None;
		}
		curDict[key] = keybind;
		BindName = string.Empty;
	}
}
