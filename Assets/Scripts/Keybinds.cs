using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// must be attached to a game object so saved keybinds can be loaded.
public class Keybinds : MonoBehaviour 
{
	class Keybind
	{
		public string Action;
		public KeyCode Key;

		public Keybind()
		{
		}

		public Keybind(string action, string defaultKey)
		{
			Action = action;
			Key = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(Action, defaultKey));
		}

		public Keybind(string action)
		{
			Action = action;
		}

		public void Save()
		{
			PlayerPrefs.SetString (Action, Key.ToString());
		}
	}

	static List<Keybind> KeybindsList = new List<Keybind>();
	static bool KeyWasChanged = false;

    void Start()
    {
        LoadKeybinds();
    }

    private static void ChangeKeybind(string action, KeyCode key)
	{
		int GetIndex = GetKeybindIndex (action);
		if (GetIndex != -1)
		{
            Debug.Log("New keybind received, action: " + action + " keycode: " + key.ToString());
			KeybindsList[GetIndex].Key = key;
            KeybindsList[GetIndex].Save();
			KeyWasChanged = true;
		}
	}

	static int GetKeybindIndex(string action)
	{
		int numOfBinds = KeybindsList.Count;
		for (int i = 0; i != numOfBinds; i++)
        {
			if (KeybindsList[i].Action == action)
			{
				return i;
			}
		}

		return -1;
	}

// retrieves the current key a keybind is assigned to
// useful for displaying the assigned keybind
    public static KeyCode GetKeybind(string action)
	{
		int GetIndex = GetKeybindIndex (action);
		if (GetIndex != -1)
		{
			return KeybindsList[GetIndex].Key;
		}
		return KeyCode.Joystick8Button15; // this is default as we cannot return a null keybind
	}

// call this when waiting for a new keybind
	public static bool PollForNewKeybind(string action)
	{
		KeyWasChanged = false;

// alphabet
		if (Input.GetKeyDown(KeyCode.A))		{ ChangeKeybind(action, KeyCode.A); }
		else if (Input.GetKeyDown(KeyCode.B))	{ ChangeKeybind(action, KeyCode.B); }
		else if (Input.GetKeyDown(KeyCode.C)) 	{ ChangeKeybind(action, KeyCode.C); }
		else if (Input.GetKeyDown(KeyCode.D)) 	{ ChangeKeybind(action, KeyCode.D); }
		else if (Input.GetKeyDown(KeyCode.E))	{ ChangeKeybind(action, KeyCode.E); }
		else if (Input.GetKeyDown(KeyCode.F))	{ ChangeKeybind(action, KeyCode.F); }
		else if (Input.GetKeyDown(KeyCode.G))	{ ChangeKeybind(action, KeyCode.G); }
		else if (Input.GetKeyDown(KeyCode.H))	{ ChangeKeybind(action, KeyCode.H); }
		else if (Input.GetKeyDown(KeyCode.I))	{ ChangeKeybind(action, KeyCode.I); }
		else if (Input.GetKeyDown(KeyCode.J))	{ ChangeKeybind(action, KeyCode.J); }
		else if (Input.GetKeyDown(KeyCode.K))	{ ChangeKeybind(action, KeyCode.K); }
		else if (Input.GetKeyDown(KeyCode.L))	{ ChangeKeybind(action, KeyCode.L); }
		else if (Input.GetKeyDown(KeyCode.M))	{ ChangeKeybind(action, KeyCode.M); }
		else if (Input.GetKeyDown(KeyCode.N))	{ ChangeKeybind(action, KeyCode.N); }
		else if (Input.GetKeyDown(KeyCode.O))	{ ChangeKeybind(action, KeyCode.O); }
		else if (Input.GetKeyDown(KeyCode.P))	{ ChangeKeybind(action, KeyCode.P); }
		else if (Input.GetKeyDown(KeyCode.Q))	{ ChangeKeybind(action, KeyCode.Q); }
		else if (Input.GetKeyDown(KeyCode.R))	{ ChangeKeybind(action, KeyCode.R); }
		else if (Input.GetKeyDown(KeyCode.S))	{ ChangeKeybind(action, KeyCode.S); }
		else if (Input.GetKeyDown(KeyCode.T))	{ ChangeKeybind(action, KeyCode.T); }
		else if (Input.GetKeyDown(KeyCode.U))	{ ChangeKeybind(action, KeyCode.U); }
		else if (Input.GetKeyDown(KeyCode.V))	{ ChangeKeybind(action, KeyCode.V); }
		else if (Input.GetKeyDown(KeyCode.W))	{ ChangeKeybind(action, KeyCode.W); }
		else if (Input.GetKeyDown(KeyCode.X))	{ ChangeKeybind(action, KeyCode.X); }
		else if (Input.GetKeyDown(KeyCode.Y))	{ ChangeKeybind(action, KeyCode.Y); }
		else if (Input.GetKeyDown(KeyCode.Z))	{ ChangeKeybind(action, KeyCode.Z); }

// arrows
		else if (Input.GetKeyDown(KeyCode.UpArrow)) 	{ ChangeKeybind(action, KeyCode.UpArrow); }
		else if (Input.GetKeyDown(KeyCode.LeftArrow)) 	{ ChangeKeybind(action, KeyCode.LeftArrow); }
		else if (Input.GetKeyDown(KeyCode.RightArrow)) 	{ ChangeKeybind(action, KeyCode.RightArrow); }
		else if (Input.GetKeyDown(KeyCode.DownArrow)) 	{ ChangeKeybind(action, KeyCode.DownArrow); }

		
		else if (Input.GetKeyDown(KeyCode.Space)) {	ChangeKeybind(action, KeyCode.Space); }

// number pad		
		else if (Input.GetKeyDown(KeyCode.Keypad0))			{ ChangeKeybind(action, KeyCode.Keypad0); }
		else if (Input.GetKeyDown(KeyCode.Keypad1))			{ ChangeKeybind(action, KeyCode.Keypad1); }
		else if (Input.GetKeyDown(KeyCode.Keypad2))			{ ChangeKeybind(action, KeyCode.Keypad2); }
		else if (Input.GetKeyDown(KeyCode.Keypad3))			{ ChangeKeybind(action, KeyCode.Keypad3); }
		else if (Input.GetKeyDown(KeyCode.Keypad4))			{ ChangeKeybind(action, KeyCode.Keypad4); }
		else if (Input.GetKeyDown(KeyCode.Keypad5))			{ ChangeKeybind(action, KeyCode.Keypad5); }
		else if (Input.GetKeyDown(KeyCode.Keypad6))			{ ChangeKeybind(action, KeyCode.Keypad6); }
		else if (Input.GetKeyDown(KeyCode.Keypad7))			{ ChangeKeybind(action, KeyCode.Keypad7); }
		else if (Input.GetKeyDown(KeyCode.Keypad8))			{ ChangeKeybind(action, KeyCode.Keypad8); }
		else if (Input.GetKeyDown(KeyCode.Keypad9))			{ ChangeKeybind(action, KeyCode.Keypad9); }
		else if (Input.GetKeyDown(KeyCode.KeypadDivide)) 	{ ChangeKeybind(action, KeyCode.KeypadDivide); }
		else if (Input.GetKeyDown(KeyCode.KeypadEnter)) 	{ ChangeKeybind(action, KeyCode.KeypadEnter); }
		else if (Input.GetKeyDown(KeyCode.KeypadEquals)) 	{ ChangeKeybind(action, KeyCode.KeypadEquals); }
		else if (Input.GetKeyDown(KeyCode.KeypadMinus)) 	{ ChangeKeybind(action, KeyCode.KeypadMinus); }
		else if (Input.GetKeyDown(KeyCode.KeypadMultiply)) 	{ ChangeKeybind(action, KeyCode.KeypadMultiply); }
		else if (Input.GetKeyDown(KeyCode.KeypadPeriod)) 	{ ChangeKeybind(action, KeyCode.KeypadPeriod); }
		else if (Input.GetKeyDown(KeyCode.KeypadPlus)) 		{ ChangeKeybind(action, KeyCode.KeypadPlus); }
		else if (Input.GetKeyDown(KeyCode.Numlock)) 		{ ChangeKeybind(action, KeyCode.Numlock); }

// number keys (at top of keyboard)
		else if (Input.GetKeyDown(KeyCode.Alpha0)) { ChangeKeybind(action, KeyCode.Alpha0); }
		else if (Input.GetKeyDown(KeyCode.Alpha1)) { ChangeKeybind(action, KeyCode.Alpha1); }
		else if (Input.GetKeyDown(KeyCode.Alpha2)) { ChangeKeybind(action, KeyCode.Alpha2); }
		else if (Input.GetKeyDown(KeyCode.Alpha3)) { ChangeKeybind(action, KeyCode.Alpha3); }
		else if (Input.GetKeyDown(KeyCode.Alpha4)) { ChangeKeybind(action, KeyCode.Alpha4); }
		else if (Input.GetKeyDown(KeyCode.Alpha5)) { ChangeKeybind(action, KeyCode.Alpha5); }
		else if (Input.GetKeyDown(KeyCode.Alpha6)) { ChangeKeybind(action, KeyCode.Alpha6); }
		else if (Input.GetKeyDown(KeyCode.Alpha7)) { ChangeKeybind(action, KeyCode.Alpha7); }
		else if (Input.GetKeyDown(KeyCode.Alpha8)) { ChangeKeybind(action, KeyCode.Alpha8); }
		else if (Input.GetKeyDown(KeyCode.Alpha9)) { ChangeKeybind(action, KeyCode.Alpha9); }

// punctuation keys, starting from topleft "'" or backquote key
		else if (Input.GetKeyDown(KeyCode.BackQuote)) 		{ ChangeKeybind(action, KeyCode.BackQuote); }
		else if (Input.GetKeyDown(KeyCode.Tab)) 			{ ChangeKeybind(action, KeyCode.Tab); }
		else if (Input.GetKeyDown(KeyCode.CapsLock)) 		{ ChangeKeybind(action, KeyCode.CapsLock); }
		else if (Input.GetKeyDown(KeyCode.LeftShift)) 		{ ChangeKeybind(action, KeyCode.LeftShift); }
		else if (Input.GetKeyDown(KeyCode.LeftControl)) 	{ ChangeKeybind(action, KeyCode.LeftControl); }
		else if (Input.GetKeyDown(KeyCode.LeftWindows)) 	{ ChangeKeybind(action, KeyCode.LeftWindows); }
		else if (Input.GetKeyDown(KeyCode.LeftApple)) 		{ ChangeKeybind(action, KeyCode.LeftApple); }
		else if (Input.GetKeyDown(KeyCode.LeftAlt)) 		{ ChangeKeybind(action, KeyCode.LeftAlt); }
		else if (Input.GetKeyDown(KeyCode.RightAlt)) 		{ ChangeKeybind(action, KeyCode.RightAlt); }
		else if (Input.GetKeyDown(KeyCode.RightControl)) 	{ ChangeKeybind(action, KeyCode.RightControl); }
		else if (Input.GetKeyDown(KeyCode.RightShift)) 		{ ChangeKeybind(action, KeyCode.RightShift); }
		else if (Input.GetKeyDown(KeyCode.Return)) 			{ ChangeKeybind(action, KeyCode.Return); }
		else if (Input.GetKeyDown(KeyCode.Backspace)) 		{ ChangeKeybind(action, KeyCode.Backspace); }
		else if (Input.GetKeyDown(KeyCode.Equals)) 			{ ChangeKeybind(action, KeyCode.Equals); }
		else if (Input.GetKeyDown(KeyCode.Minus)) 			{ ChangeKeybind(action, KeyCode.Minus); }
		else if (Input.GetKeyDown(KeyCode.LeftBracket)) 	{ ChangeKeybind(action, KeyCode.LeftBracket); }
		else if (Input.GetKeyDown(KeyCode.RightBracket)) 	{ ChangeKeybind(action, KeyCode.RightBracket); }
		else if (Input.GetKeyDown(KeyCode.Colon)) 			{ ChangeKeybind(action, KeyCode.Colon); }
		else if (Input.GetKeyDown(KeyCode.At)) 				{ ChangeKeybind(action, KeyCode.At); }
		else if (Input.GetKeyDown(KeyCode.Hash)) 			{ ChangeKeybind(action, KeyCode.Hash); }
		else if (Input.GetKeyDown(KeyCode.Comma)) 			{ ChangeKeybind(action, KeyCode.Comma); }
		else if (Input.GetKeyDown(KeyCode.Period))			{ ChangeKeybind(action, KeyCode.Period); }
		else if (Input.GetKeyDown(KeyCode.Slash)) 			{ ChangeKeybind(action, KeyCode.Slash); }
		else if (Input.GetKeyDown(KeyCode.Backslash)) 		{ ChangeKeybind(action, KeyCode.Backslash); }
		else if (Input.GetKeyDown(KeyCode.RightWindows)) 	{ ChangeKeybind(action, KeyCode.RightWindows); }
		else if (Input.GetKeyDown(KeyCode.RightApple)) 		{ ChangeKeybind(action, KeyCode.RightApple); }

// keys above arrow keys
		else if (Input.GetKeyDown(KeyCode.Insert)) 		{ ChangeKeybind(action, KeyCode.Insert); }
		else if (Input.GetKeyDown(KeyCode.Print)) 		{ ChangeKeybind(action, KeyCode.Print); }
		else if (Input.GetKeyDown(KeyCode.Pause)) 		{ ChangeKeybind(action, KeyCode.Pause); }
		else if (Input.GetKeyDown(KeyCode.Delete)) 		{ ChangeKeybind(action, KeyCode.Delete); }
		else if (Input.GetKeyDown(KeyCode.Home)) 		{ ChangeKeybind(action, KeyCode.Home); }
		else if (Input.GetKeyDown(KeyCode.End)) 		{ ChangeKeybind(action, KeyCode.End); }
		else if (Input.GetKeyDown(KeyCode.PageUp)) 		{ ChangeKeybind(action, KeyCode.PageUp); }
		else if (Input.GetKeyDown(KeyCode.PageDown)) 	{ ChangeKeybind(action, KeyCode.PageDown); }

// Function Keys
		else if (Input.GetKeyDown(KeyCode.BackQuote))	{ ChangeKeybind(action, KeyCode.BackQuote); }
		else if (Input.GetKeyDown(KeyCode.F1))			{ ChangeKeybind(action, KeyCode.F1); }
		else if (Input.GetKeyDown(KeyCode.F2))			{ ChangeKeybind(action, KeyCode.F2); }
		else if (Input.GetKeyDown(KeyCode.F3))			{ ChangeKeybind(action, KeyCode.F3); }
		else if (Input.GetKeyDown(KeyCode.F4))			{ ChangeKeybind(action, KeyCode.F4); }
		else if (Input.GetKeyDown(KeyCode.F5))			{ ChangeKeybind(action, KeyCode.F5); }
		else if (Input.GetKeyDown(KeyCode.F6))			{ ChangeKeybind(action, KeyCode.F6); }
		else if (Input.GetKeyDown(KeyCode.F7))			{ ChangeKeybind(action, KeyCode.F7); }
		else if (Input.GetKeyDown(KeyCode.F8))			{ ChangeKeybind(action, KeyCode.F8); }
		else if (Input.GetKeyDown(KeyCode.F9))			{ ChangeKeybind(action, KeyCode.F9); }
		else if (Input.GetKeyDown(KeyCode.F10))			{ ChangeKeybind(action, KeyCode.F10); }
		else if (Input.GetKeyDown(KeyCode.F11))			{ ChangeKeybind(action, KeyCode.F11); }
		else if (Input.GetKeyDown(KeyCode.F12))			{ ChangeKeybind(action, KeyCode.F12); }

		
		else if (Input.GetKeyDown(KeyCode.Escape)) { ChangeKeybind(action, KeyCode.Escape); }

		return KeyWasChanged;
	}

/*
    this must be initialised/called first inside keybinds initiator
    add the keys you want to save here with a initial key
*/
	public static void LoadKeybinds()
	{
		KeybindsList.Add (new Keybind("MoveUp", KeyCode.W.ToString()));
        KeybindsList.Add(new Keybind("MoveDown", KeyCode.S.ToString()));
        KeybindsList.Add(new Keybind("MoveLeft", KeyCode.A.ToString()));
        KeybindsList.Add(new Keybind("MoveRight", KeyCode.D.ToString()));
    }

    public static void SaveKeybinds()
	{
		foreach (Keybind k in KeybindsList)
		{
			k.Save();
		}
	}
}
