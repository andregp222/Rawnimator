using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rawnimator : MonoBehaviour
{
    RawnimatorAnimationData currentAnimation;
    RawnimatorAnimationData nextAnimation;

    SpriteRenderer spr;

    int frame;
    float timer;

    private void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        frame = 0;
    }

    private void Update()
    {
        if (currentAnimation != null)
        {
            StateUpdate();
            FrameUpdate(); 
        }
        else
        {
            currentAnimation = nextAnimation;
        }
    }

    void StateUpdate()
    {
        if (currentAnimation != nextAnimation)
        {
            currentAnimation = nextAnimation;
            frame = 0;
            timer = currentAnimation.frameSpeed;
        }
    }

    void FrameUpdate()
    {
        spr.sprite = currentAnimation.frames[frame];
        if (timer <= 0)
        {
            if (frame == currentAnimation.frames.Length - 1)
            {
                frame = 0;
                timer = currentAnimation.frameSpeed;
                return;
            }
            else
            {
                frame += 1;
                timer = currentAnimation.frameSpeed;
                return;
            }
        }
        timer -= Time.deltaTime;
    }

    public void PlayAnimation(RawnimatorAnimationData animation)
    {
        nextAnimation = animation;
    }

    public void Flip(bool flip)
    {
        spr.flipX = flip;
    }
}
