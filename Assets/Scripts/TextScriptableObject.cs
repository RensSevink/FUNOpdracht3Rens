using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TextData", menuName = "TextData/Text")]
public class TextScriptableObject : ScriptableObject
{
    public int roomID;

    [TextArea(15, 20)]
    public string textData;
    
}
