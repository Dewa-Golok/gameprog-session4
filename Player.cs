using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator playerAnimator;
    public GameObject Video;
    public ChangeScene CS;

    void Start()
    {
        Video.SetActive(false);
    }
    public void playerAttack()
    {
        playerAnimator.SetTrigger("isAttack");
    }

    public void InvokeVideo()
    {
        Invoke("playVideo", 2.0f);
    }

    public void playVideo()
    {
        Video.SetActive(true);
    }

    public void CallChangeSceneAfterSecond()
    {
        StartCoroutine("WaitAndChange");
    }

    IEnumerable WaitAndChange ()
    {
        yield return new WaitForSeconds(3.0f);
        CS.ChangeMyScene("Menu");
    }

}
