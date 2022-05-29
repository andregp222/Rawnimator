using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewAnimationData", menuName = "RawnimatorAnimationData")]
public class RawnimatorAnimationData : ScriptableObject
{
    public Sprite[] frames;

    public float frameSpeed;
}
