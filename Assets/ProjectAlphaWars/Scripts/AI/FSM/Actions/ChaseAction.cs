﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Chase")]
public class ChaseAction : Action
{
    public override void Act(StateController stateController)
    {
        Chase(stateController);
    }

    private void Chase(StateController stateController)
    {
        stateController.navMeshAgent.destination = stateController.chaseTarget.position;
        stateController.navMeshAgent.stoppingDistance = 10;
        stateController.navMeshAgent.isStopped = false;
        stateController.navMeshAgent.angularSpeed = 200;
    }
}
