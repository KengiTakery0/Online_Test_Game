using Mirror;
using Mirror.Examples.Basic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class MainMenu : NetworkBehaviour
{
    [SerializeField] GameObject mainPage;

    public void OnHost()
    {
        mainPage.SetActive(false);

        NetworkManager.singleton.StartHost();
    }
}
