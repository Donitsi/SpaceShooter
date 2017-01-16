using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorDestroyWhenFinished : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Animator a = gameObject.GetComponent<Animator>();
        AnimatorClipInfo[] clips = a.GetCurrentAnimatorClipInfo(0);

        Destroy(gameObject, clips[0].clip.length);
	}
}
