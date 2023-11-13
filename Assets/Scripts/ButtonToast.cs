using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToast : MonoBehaviour
{
    public void OnSigninClick() 
    {
        SSTools.ShowMessage("Signing in", SSTools.Position.bottom, SSTools.Time.twoSecond);
    }

}
