using System.Collections.Generic;
using System.Linq;
namespace SoraConf
{
    
    [System.Serializable]
    public enum ErrorCode
    {
        NOT_SET = 0,
        CLOSE_SUCCEEDED = 1,
        CLOSE_FAILED = 2,
        INTERNAL_ERROR = 3,
        INVALID_PARAMETER = 4,
        WEBSOCKET_HANDSHAKE_FAILED = 5,
        WEBSOCKET_ONCLOSE = 6,
        WEBSOCKET_ONERROR = 7,
        PEER_CONNECTION_STATE_FAILED = 8,
        ICE_FAILED = 9,
    }
    
    [System.Serializable]
    public class VideoFrameBuffer
    {
        [System.Serializable]
        public enum Type
        {
            kNative = 0,
            kI420 = 1,
            kI420A = 2,
            kI422 = 3,
            kI444 = 4,
            kI010 = 5,
            kI210 = 6,
            kI410 = 7,
            kNV12 = 8,
        }
        
        public long baseptr;
        public global::SoraConf.VideoFrameBuffer.Type type = new global::SoraConf.VideoFrameBuffer.Type();
        public int width;
        public int height;
        public int i420_stride_y;
        public int i420_stride_u;
        public int i420_stride_v;
        public long i420_data_y;
        public long i420_data_u;
        public long i420_data_v;
        public int nv12_stride_y;
        public int nv12_stride_uv;
        public long nv12_data_y;
        public long nv12_data_uv;
        public override bool Equals(object obj)
        {
            var v = obj as VideoFrameBuffer;
            if (v == null) return false;
            if (!this.baseptr.Equals(v.baseptr)) return false;
            if (!this.type.Equals(v.type)) return false;
            if (!this.width.Equals(v.width)) return false;
            if (!this.height.Equals(v.height)) return false;
            if (!this.i420_stride_y.Equals(v.i420_stride_y)) return false;
            if (!this.i420_stride_u.Equals(v.i420_stride_u)) return false;
            if (!this.i420_stride_v.Equals(v.i420_stride_v)) return false;
            if (!this.i420_data_y.Equals(v.i420_data_y)) return false;
            if (!this.i420_data_u.Equals(v.i420_data_u)) return false;
            if (!this.i420_data_v.Equals(v.i420_data_v)) return false;
            if (!this.nv12_stride_y.Equals(v.nv12_stride_y)) return false;
            if (!this.nv12_stride_uv.Equals(v.nv12_stride_uv)) return false;
            if (!this.nv12_data_y.Equals(v.nv12_data_y)) return false;
            if (!this.nv12_data_uv.Equals(v.nv12_data_uv)) return false;
            return true;
        }
        
        public override int GetHashCode()
        {
            int hashcode = 1430287;
            hashcode = hashcode * 7302013 ^ baseptr.GetHashCode();
            hashcode = hashcode * 7302013 ^ type.GetHashCode();
            hashcode = hashcode * 7302013 ^ width.GetHashCode();
            hashcode = hashcode * 7302013 ^ height.GetHashCode();
            hashcode = hashcode * 7302013 ^ i420_stride_y.GetHashCode();
            hashcode = hashcode * 7302013 ^ i420_stride_u.GetHashCode();
            hashcode = hashcode * 7302013 ^ i420_stride_v.GetHashCode();
            hashcode = hashcode * 7302013 ^ i420_data_y.GetHashCode();
            hashcode = hashcode * 7302013 ^ i420_data_u.GetHashCode();
            hashcode = hashcode * 7302013 ^ i420_data_v.GetHashCode();
            hashcode = hashcode * 7302013 ^ nv12_stride_y.GetHashCode();
            hashcode = hashcode * 7302013 ^ nv12_stride_uv.GetHashCode();
            hashcode = hashcode * 7302013 ^ nv12_data_y.GetHashCode();
            hashcode = hashcode * 7302013 ^ nv12_data_uv.GetHashCode();
            return hashcode;
        }
        
    }
    
    [System.Serializable]
    public class VideoFrame
    {
        public long baseptr;
        public int id;
        public long timestamp_us;
        public uint timestamp;
        public long ntp_time_ms;
        public int rotation;
        public global::SoraConf.VideoFrameBuffer video_frame_buffer = new global::SoraConf.VideoFrameBuffer();
        public override bool Equals(object obj)
        {
            var v = obj as VideoFrame;
            if (v == null) return false;
            if (!this.baseptr.Equals(v.baseptr)) return false;
            if (!this.id.Equals(v.id)) return false;
            if (!this.timestamp_us.Equals(v.timestamp_us)) return false;
            if (!this.timestamp.Equals(v.timestamp)) return false;
            if (!this.ntp_time_ms.Equals(v.ntp_time_ms)) return false;
            if (!this.rotation.Equals(v.rotation)) return false;
            if (!this.video_frame_buffer.Equals(v.video_frame_buffer)) return false;
            return true;
        }
        
        public override int GetHashCode()
        {
            int hashcode = 1430287;
            hashcode = hashcode * 7302013 ^ baseptr.GetHashCode();
            hashcode = hashcode * 7302013 ^ id.GetHashCode();
            hashcode = hashcode * 7302013 ^ timestamp_us.GetHashCode();
            hashcode = hashcode * 7302013 ^ timestamp.GetHashCode();
            hashcode = hashcode * 7302013 ^ ntp_time_ms.GetHashCode();
            hashcode = hashcode * 7302013 ^ rotation.GetHashCode();
            hashcode = hashcode * 7302013 ^ video_frame_buffer.GetHashCode();
            return hashcode;
        }
        
    }
    
}
