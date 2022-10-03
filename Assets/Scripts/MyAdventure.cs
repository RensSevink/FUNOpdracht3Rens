using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyAdventure : MonoBehaviour
{
    public Text textArea;

    public List<TextScriptableObject> textObjects;
    private TextScriptableObject currentTextObject;

    private int currentRoomID;
    private int lastRoomID;

    void Start()
    {
        currentRoomID = 0;
        currentTextObject = textObjects[currentRoomID];
    }

    void Update()
    {
        for(int i = 0; i < textObjects.Count; i++)
        {
            if(currentRoomID == textObjects[i].roomID)
            {
                currentTextObject = textObjects[i];
            }
        }
        textArea.text = currentTextObject.textData;

        switch (currentTextObject.roomID)
        {
            case 0:
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    lastRoomID = currentRoomID;
                    currentRoomID = 1;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    lastRoomID = currentRoomID;
                    currentRoomID = 2;
                }
                break;
            case 1:
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    lastRoomID = currentRoomID;
                    currentRoomID = 3;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    lastRoomID = currentRoomID;
                    currentRoomID = 4;
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    lastRoomID = currentRoomID;
                    currentRoomID = 5;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    lastRoomID = currentRoomID;
                    currentRoomID = 6;
                }
                break;
            case 3:
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    lastRoomID = currentRoomID;
                    currentRoomID = 7;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    lastRoomID = currentRoomID;
                    currentRoomID = 8;
                }
                break;
            case 4:
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    lastRoomID = currentRoomID;
                    currentRoomID = 9;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    lastRoomID = currentRoomID;
                    currentRoomID = 10;
                }
                break;
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            currentRoomID = lastRoomID;
        }
    }
}
