using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticle : MonoBehaviour
{
    public ParticleSystem ps;
    public ParticleSystem ps2;
    public ParticleSystem ps3;
    public ParticleSystem ps4;


    public void OnclickParticleToggle()
    {
        ps2.Stop();
        ps3.Stop();
        ps4.Stop();
        ps.Play();
    }
}
