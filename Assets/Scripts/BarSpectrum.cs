// By Novang

using UnityEngine;
using System.Collections;

public class BarSpectrum : MonoBehaviour
{
    public float[] spectrum = new float[32], avg = new float[64];
    public float temp;
    public bool beat = false;
    AudioSource _AS;
    public GameObject[] _BS;

    // Use this for initialization
    void Start()
    {
        _AS = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //beat = false;
        _AS.GetSpectrumData(spectrum, 0, FFTWindow.BlackmanHarris);

        for (int i = 0, k = 0; i < 32; i++, k += 2) {
            temp = 0;
            for (int j = 0; j <= 1; j++)
            {
                temp += spectrum[k + j];
            }
            avg[i] = temp / 2;
            _BS[i].transform.localScale = new Vector3(1f, avg[i] * 100f, 1f);
        }
    }
}
