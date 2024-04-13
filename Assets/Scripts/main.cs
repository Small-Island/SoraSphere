using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Runtime.InteropServices;

public class main : MonoBehaviour
{
    public enum SampleType
    {
        MultiSendrecv,
        MultiRecvonly,
        MultiSendonly,
        Sendonly,
        Recvonly
    }

    public Material sphereMaterial;
    private uint trackedID;

    Sora sora;
    // bool started;
    public Sora.Role sendrecvSendonlyRecvOnly;
   
    // 以下共通
    public string signalingUrl = "";
    public string channelId = "";
    public bool video = true;
    public new bool audio = true;
    public Sora.VideoCodecType videoCodecType = Sora.VideoCodecType.H264;
    public int videoBitRate = 0;

    // Start is called before the first frame update
    void Start()
    {
        DisposeSora();
        this.sora = new Sora();
        sora.OnAddTrack = (trackId, connectionId) =>
        {
            this.trackedID = trackId;
        };
        sora.OnDisconnect = (code, message) =>
        {
            DisposeSora();
        };
        var config = new Sora.Config() {
            SignalingUrl = this.signalingUrl,
            ChannelId = channelId,
            Role = this.sendrecvSendonlyRecvOnly,
            Multistream = true,
            Insecure = true,
            VideoCodecType = this.videoCodecType,
            Video = this.video,
            Audio = this.audio,
            VideoBitRate = this.videoBitRate
        };
        this.sora.Connect(config);
    }

    // Update is called once per frame
    void Update()
    {
        if (sora == null)
        {
            return;
        }

        sora.DispatchEvents();

        // DispatchEvents で OnDisconnect → DisposeSora と呼ばれて sora が null になることがある
        if (sora == null)
        {
            return;
        }

        if (trackedID != 0) {
            Texture sphereTexture2D = new Texture2D(3840, 2160, TextureFormat.RGBA32, false);
            sora.RenderTrackToTexture(this.trackedID, sphereTexture2D);
            this.sphereMaterial.mainTexture = sphereTexture2D;
        }
    }

    void DisconnectSora()
    {
        if (sora == null)
        {
            return;
        }
        sora.Disconnect();
    }

    void DisposeSora()
    {
        if (sora == null)
        {
            return;
        }
        sora.Dispose();
        sora = null;
    }

    void OnApplicationQuit()
    {
        DisposeSora();
    }
}