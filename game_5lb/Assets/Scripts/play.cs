using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bt_play : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("game");
    }

    void OnMouseUp()
    {
    }
}
