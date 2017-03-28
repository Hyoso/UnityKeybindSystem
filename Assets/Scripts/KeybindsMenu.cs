using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// keybinds menu example
public class KeybindsMenu : MonoBehaviour
{
    string pollForNewKey = "";

    KeyCode LeftButtonKeycode;
    KeyCode RightButtonKeycode;
    KeyCode UpButtonKeycode;
    KeyCode DownButtonKeycode;

    [SerializeField]
    Text leftButtonDisplayText;
    [SerializeField]
    Text rightButtonDisplayText;
    [SerializeField]
    Text upButtonDisplayText;
    [SerializeField]
    Text downButtonDisplayText;

    void Start ()
    {
        Keybinds.LoadKeybinds();
        RefreshKeys();
    }
	
	void Update ()
    {
	    if (pollForNewKey != "")
        {
            if (Keybinds.PollForNewKeybind(pollForNewKey))
            {
                pollForNewKey = "";

                RefreshKeys();
            }
        }
	}

    void RefreshKeys()
    {
        // get keybind string parameter must match the keybinds specified inside keybinds.cs load function
        UpButtonKeycode = Keybinds.GetKeybind("MoveUp");
        DownButtonKeycode = Keybinds.GetKeybind("MoveDown");
        LeftButtonKeycode = Keybinds.GetKeybind("MoveLeft");
        RightButtonKeycode = Keybinds.GetKeybind("MoveRight");

        leftButtonDisplayText.text = LeftButtonKeycode.ToString();
        rightButtonDisplayText.text = RightButtonKeycode.ToString();
        upButtonDisplayText.text = UpButtonKeycode.ToString();
        downButtonDisplayText.text = DownButtonKeycode.ToString();
    }

    // input keybindtype must match keybinds specified inside keybinds.cs load function
    public void PollForNewKeybind(string keybindType)
    {
        Debug.Log("called new keybind for: " + keybindType);
        pollForNewKey = keybindType;
    }
}
