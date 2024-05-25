using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameBGMscript : MonoBehaviour
{
    public AudioSource BGMstop;

    public void gameBGMstop()
    {
        BGMstop.Stop();
    }

}
