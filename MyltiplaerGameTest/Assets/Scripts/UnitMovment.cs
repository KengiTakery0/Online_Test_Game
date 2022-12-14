using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.AI;


public class UnitMovment : NetworkBehaviour
{
    [SerializeField] NavMeshAgent agent = null;
    Camera mainCamera;

    #region Server
    [Command]
    void CmdMove(Vector3 pos)
    {
        if (!NavMesh.SamplePosition(pos, out NavMeshHit hit, 1f, NavMesh.AllAreas)) return;
        agent.SetDestination(hit.position);
    }
    #endregion

    #region Client
    public override void OnStartAuthority()
    {
        mainCamera = Camera.main;
    }

    [ClientCallback]

    private void Update()
    {
        if (!hasAuthority) return;
        if (!Input.GetMouseButtonDown(0)) return;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (!Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity)) return;
        CmdMove(hit.point);
     }
    #endregion
}
