using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class camaraShake : MonoBehaviour
{
    public static camaraShake Instance { get; private set; }
    private CinemachineVirtualCamera CinemachineVirtualCamera;
    private float shaketetimer;
    private void Awake()
    {
        Instance = this;
        CinemachineVirtualCamera =  GetComponent<CinemachineVirtualCamera>();
    }
    public void Movimeintocamara(float intencidad,float tiempo)
    {
        CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin = CinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = intencidad;
        shaketetimer = tiempo;
    }
    private void Update()
    {
        if (shaketetimer > 0)
        {
            shaketetimer -= Time.deltaTime;
            if (shaketetimer <= 0f)
            {
                CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin = CinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
                cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 0f;
            }
        }
    }
}
