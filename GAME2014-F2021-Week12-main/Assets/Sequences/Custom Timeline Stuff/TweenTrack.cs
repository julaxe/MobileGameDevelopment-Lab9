using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[TrackBindingType(typeof(Transform))]
[TrackClipType(typeof(TweenClip))]
public class TweenTrack : TrackAsset
{
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
        return ScriptPlayable<TweenMixerBehaviour>.Create(graph, inputCount);
    }
}
