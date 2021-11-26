using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[System.Serializable]
public class TweenClip : PlayableAsset
{
    public ExposedReference<Transform> startLocation;
    public ExposedReference<Transform> endLocation;

    public bool shouldTweenPosition = true;
    public bool shouldTweenRotation = true;

    public AnimationCurve curve;


    // Factory method that generates a playable based on this asset
    public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
    {
        // create a new TweenBehaviour
        ScriptPlayable<TweenBehaviour> playable = ScriptPlayable<TweenBehaviour>.Create(graph);
        TweenBehaviour tween = playable.GetBehaviour();

        // set the behaviour's data
        tween.startLocation = startLocation.Resolve(graph.GetResolver());
        tween.endLocation = endLocation.Resolve(graph.GetResolver());
        tween.curve = curve;
        tween.shouldTweenPosition = shouldTweenPosition;
        tween.shouldTweenRotation = shouldTweenRotation;

        return playable;
    }
}
