// By Novang

using UnityEngine;
using System.Collections;

public class basic_function : MonoBehaviour {

    public void start() {
        
    }

    public void exit_event () {
        Application.Quit();
    }

    public void cng_scene(string target_scene) {
        Application.LoadLevel(target_scene);
    }

    public void hide_object() {
        
    }
}
