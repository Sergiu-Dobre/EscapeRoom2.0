

using UnityEngine;

using UnityEngine.SceneManagement;

using TMPro;

using UnityEngine.UI;

using System.Collections;

using System.Collections.Generic;

using System;



[CreateAssetMenu(fileName = "AI file", menuName = "AI Files Archive")]

public class NPC : ScriptableObject

{



    public string name;

    [TextArea(3, 15)]

    public string[] dialogue;

    [TextArea(3, 15)]

    public string[] playerDialogue;



}

