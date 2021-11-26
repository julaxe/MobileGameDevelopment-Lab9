using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[System.Serializable]
public class TweenMixerBehaviour : PlayableBehaviour
{
    //public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    //{
    //    base.ProcessFrame(playable, info, playerData);

    //    // Iterate on all the playable's (mixer) inputs (ie each clip on the track)
    //    int inputCount = playable.GetInputCount();
    //    for (int i = 0; i < inputCount; i++)
    //    {
    //        // get the input connected to the mixer
    //        Playable input = playable.GetInput(i);

    //        // get the weight of the connection
    //        float inputWeight = playable.GetInputWeight(i);

    //        // get the clip's behaviour
    //        //TweenBehaviour tweenInput = GetTweenBehaviour(input);
    //    }

    //    // Apply the final position and rotation values in the track binding
    //    trackBinding.position = accumPosition + m_InitialPosition * (1.0f - totalPositionWeight);
    //    trackBinding.rotation = accumRotation.Blend(m_InitialRotation, 1.0f - totalRotationWeight);

    //}
}
