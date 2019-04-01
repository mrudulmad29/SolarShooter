using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsEnd : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}
