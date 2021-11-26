using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TweenBehaviour : PlayableBehaviour
{
    public Transform startLocation;
    public Transform endLocation;

    public bool shouldTweenPosition;
    public bool shouldTweenRotation;

    public AnimationCurve curve;
}
