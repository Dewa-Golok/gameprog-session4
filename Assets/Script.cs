using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script : MonoBehaviour
{
    public void ChangeMyScene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }
}
