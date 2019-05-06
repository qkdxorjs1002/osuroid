// By Novang

using UnityEngine;
using System.Collections;

public class Beat_Lner : MonoBehaviour {

    public BarSpectrum AudioSp;
    Animation anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
        if (AudioSp.beat == true)
        {
            anim.Play();
        }
    }
}
