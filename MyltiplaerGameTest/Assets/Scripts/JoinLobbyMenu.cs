using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Mirror;

public class JoinLobbyMenu : MonoBehaviour
{
    [SerializeField] GameObject JoinPanel;
    [SerializeField] TMP_InputField addresField;
    public void OnJoin()
    {
        string adress = addresField.text;
        NetworkManager.singleton.networkAddress= adress;
        NetworkManager.singleton.StartClient();

        JoinPanel.SetActive(false);
    }
    private void HandleClientConnected()
    {
        JoinPanel.SetActive(true);
    }

}
