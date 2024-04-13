using System.Collections.Generic;
using System.Linq;
namespace SoraConf.Internal
{
    
    [System.Serializable]
    public class DataChannel
    {
        [System.Serializable]
        public enum OrderedCase
        {
            NOT_SET = 0,
            kOrdered = 4,
        }
        public OrderedCase _ordered_case;
        public void ClearOrderedCase()
        {
            _ordered_case = OrderedCase.NOT_SET;
            ordered = default(bool);
        }
        [System.Serializable]
        public enum MaxPacketLifeTimeCase
        {
            NOT_SET = 0,
            kMaxPacketLifeTime = 6,
        }
        public MaxPacketLifeTimeCase _max_packet_life_time_case;
        public void ClearMaxPacketLifeTimeCase()
        {
            _max_packet_life_time_case = MaxPacketLifeTimeCase.NOT_SET;
            max_packet_life_time = default(int);
        }
        [System.Serializable]
        public enum MaxRetransmitsCase
        {
            NOT_SET = 0,
            kMaxRetransmits = 8,
        }
        public MaxRetransmitsCase _max_retransmits_case;
        public void ClearMaxRetransmitsCase()
        {
            _max_retransmits_case = MaxRetransmitsCase.NOT_SET;
            max_retransmits = default(int);
        }
        [System.Serializable]
        public enum ProtocolCase
        {
            NOT_SET = 0,
            kProtocol = 10,
        }
        public ProtocolCase _protocol_case;
        public void ClearProtocolCase()
        {
            _protocol_case = ProtocolCase.NOT_SET;
            protocol = "";
        }
        [System.Serializable]
        public enum CompressCase
        {
            NOT_SET = 0,
            kCompress = 12,
        }
        public CompressCase _compress_case;
        public void ClearCompressCase()
        {
            _compress_case = CompressCase.NOT_SET;
            compress = default(bool);
        }
        public string label = "";
        public string direction = "";
        public bool ordered;
        public void SetOrdered(bool ordered)
        {
            ClearOrderedCase();
            _ordered_case = OrderedCase.kOrdered;
            this.ordered = ordered;
        }
        public bool HasOrdered()
        {
            return _ordered_case == OrderedCase.kOrdered;
        }
        public void ClearOrdered()
        {
            if (_ordered_case == OrderedCase.kOrdered)
            {
                ClearOrderedCase();
            }
        }
        public int max_packet_life_time;
        public void SetMaxPacketLifeTime(int max_packet_life_time)
        {
            ClearMaxPacketLifeTimeCase();
            _max_packet_life_time_case = MaxPacketLifeTimeCase.kMaxPacketLifeTime;
            this.max_packet_life_time = max_packet_life_time;
        }
        public bool HasMaxPacketLifeTime()
        {
            return _max_packet_life_time_case == MaxPacketLifeTimeCase.kMaxPacketLifeTime;
        }
        public void ClearMaxPacketLifeTime()
        {
            if (_max_packet_life_time_case == MaxPacketLifeTimeCase.kMaxPacketLifeTime)
            {
                ClearMaxPacketLifeTimeCase();
            }
        }
        public int max_retransmits;
        public void SetMaxRetransmits(int max_retransmits)
        {
            ClearMaxRetransmitsCase();
            _max_retransmits_case = MaxRetransmitsCase.kMaxRetransmits;
            this.max_retransmits = max_retransmits;
        }
        public bool HasMaxRetransmits()
        {
            return _max_retransmits_case == MaxRetransmitsCase.kMaxRetransmits;
        }
        public void ClearMaxRetransmits()
        {
            if (_max_retransmits_case == MaxRetransmitsCase.kMaxRetransmits)
            {
                ClearMaxRetransmitsCase();
            }
        }
        public string protocol = "";
        public void SetProtocol(string protocol)
        {
            ClearProtocolCase();
            _protocol_case = ProtocolCase.kProtocol;
            this.protocol = protocol;
        }
        public bool HasProtocol()
        {
            return _protocol_case == ProtocolCase.kProtocol;
        }
        public void ClearProtocol()
        {
            if (_protocol_case == ProtocolCase.kProtocol)
            {
                ClearProtocolCase();
            }
        }
        public bool compress;
        public void SetCompress(bool compress)
        {
            ClearCompressCase();
            _compress_case = CompressCase.kCompress;
            this.compress = compress;
        }
        public bool HasCompress()
        {
            return _compress_case == CompressCase.kCompress;
        }
        public void ClearCompress()
        {
            if (_compress_case == CompressCase.kCompress)
            {
                ClearCompressCase();
            }
        }
        public override bool Equals(object obj)
        {
            var v = obj as DataChannel;
            if (v == null) return false;
            if (!this.label.Equals(v.label)) return false;
            if (!this.direction.Equals(v.direction)) return false;
            if (!this._ordered_case.Equals(v._ordered_case)) return false;
            if (this._ordered_case == OrderedCase.kOrdered && !this.ordered.Equals(v.ordered)) return false;
            if (!this._max_packet_life_time_case.Equals(v._max_packet_life_time_case)) return false;
            if (this._max_packet_life_time_case == MaxPacketLifeTimeCase.kMaxPacketLifeTime && !this.max_packet_life_time.Equals(v.max_packet_life_time)) return false;
            if (!this._max_retransmits_case.Equals(v._max_retransmits_case)) return false;
            if (this._max_retransmits_case == MaxRetransmitsCase.kMaxRetransmits && !this.max_retransmits.Equals(v.max_retransmits)) return false;
            if (!this._protocol_case.Equals(v._protocol_case)) return false;
            if (this._protocol_case == ProtocolCase.kProtocol && !this.protocol.Equals(v.protocol)) return false;
            if (!this._compress_case.Equals(v._compress_case)) return false;
            if (this._compress_case == CompressCase.kCompress && !this.compress.Equals(v.compress)) return false;
            return true;
        }
        
        public override int GetHashCode()
        {
            int hashcode = 1430287;
            hashcode = hashcode * 7302013 ^ label.GetHashCode();
            hashcode = hashcode * 7302013 ^ direction.GetHashCode();
            hashcode = hashcode * 7302013 ^ _ordered_case.GetHashCode();
            if (_ordered_case == OrderedCase.kOrdered) hashcode = hashcode * 7302013 ^ ordered.GetHashCode();
            hashcode = hashcode * 7302013 ^ _max_packet_life_time_case.GetHashCode();
            if (_max_packet_life_time_case == MaxPacketLifeTimeCase.kMaxPacketLifeTime) hashcode = hashcode * 7302013 ^ max_packet_life_time.GetHashCode();
            hashcode = hashcode * 7302013 ^ _max_retransmits_case.GetHashCode();
            if (_max_retransmits_case == MaxRetransmitsCase.kMaxRetransmits) hashcode = hashcode * 7302013 ^ max_retransmits.GetHashCode();
            hashcode = hashcode * 7302013 ^ _protocol_case.GetHashCode();
            if (_protocol_case == ProtocolCase.kProtocol) hashcode = hashcode * 7302013 ^ protocol.GetHashCode();
            hashcode = hashcode * 7302013 ^ _compress_case.GetHashCode();
            if (_compress_case == CompressCase.kCompress) hashcode = hashcode * 7302013 ^ compress.GetHashCode();
            return hashcode;
        }
        
    }
    
    [System.Serializable]
    public class ForwardingFilter
    {
        [System.Serializable]
        public class Rule
        {
            public string field = "";
            public string op = "";
            public List<string> values = new List<string>();
            public override bool Equals(object obj)
            {
                var v = obj as Rule;
                if (v == null) return false;
                if (!this.field.Equals(v.field)) return false;
                if (!this.op.Equals(v.op)) return false;
                if (!this.values.SequenceEqual(v.values)) return false;
                return true;
            }
            
            public override int GetHashCode()
            {
                int hashcode = 1430287;
                hashcode = hashcode * 7302013 ^ field.GetHashCode();
                hashcode = hashcode * 7302013 ^ op.GetHashCode();
                foreach (var v in this.values) hashcode = hashcode * 7302013 ^ v.GetHashCode();
                return hashcode;
            }
            
        }
        
        [System.Serializable]
        public class Rules
        {
            public List<global::SoraConf.Internal.ForwardingFilter.Rule> rules = new List<global::SoraConf.Internal.ForwardingFilter.Rule>();
            public override bool Equals(object obj)
            {
                var v = obj as Rules;
                if (v == null) return false;
                if (!this.rules.SequenceEqual(v.rules)) return false;
                return true;
            }
            
            public override int GetHashCode()
            {
                int hashcode = 1430287;
                foreach (var v in this.rules) hashcode = hashcode * 7302013 ^ v.GetHashCode();
                return hashcode;
            }
            
        }
        
        [System.Serializable]
        public enum ActionCase
        {
            NOT_SET = 0,
            kAction = 2,
        }
        public ActionCase _action_case;
        public void ClearActionCase()
        {
            _action_case = ActionCase.NOT_SET;
            action = "";
        }
        [System.Serializable]
        public enum VersionCase
        {
            NOT_SET = 0,
            kVersion = 5,
        }
        public VersionCase _version_case;
        public void ClearVersionCase()
        {
            _version_case = VersionCase.NOT_SET;
            version = "";
        }
        [System.Serializable]
        public enum MetadataCase
        {
            NOT_SET = 0,
            kMetadata = 7,
        }
        public MetadataCase _metadata_case;
        public void ClearMetadataCase()
        {
            _metadata_case = MetadataCase.NOT_SET;
            metadata = "";
        }
        public string action = "";
        public void SetAction(string action)
        {
            ClearActionCase();
            _action_case = ActionCase.kAction;
            this.action = action;
        }
        public bool HasAction()
        {
            return _action_case == ActionCase.kAction;
        }
        public void ClearAction()
        {
            if (_action_case == ActionCase.kAction)
            {
                ClearActionCase();
            }
        }
        public List<global::SoraConf.Internal.ForwardingFilter.Rules> rules = new List<global::SoraConf.Internal.ForwardingFilter.Rules>();
        public string version = "";
        public void SetVersion(string version)
        {
            ClearVersionCase();
            _version_case = VersionCase.kVersion;
            this.version = version;
        }
        public bool HasVersion()
        {
            return _version_case == VersionCase.kVersion;
        }
        public void ClearVersion()
        {
            if (_version_case == VersionCase.kVersion)
            {
                ClearVersionCase();
            }
        }
        public string metadata = "";
        public void SetMetadata(string metadata)
        {
            ClearMetadataCase();
            _metadata_case = MetadataCase.kMetadata;
            this.metadata = metadata;
        }
        public bool HasMetadata()
        {
            return _metadata_case == MetadataCase.kMetadata;
        }
        public void ClearMetadata()
        {
            if (_metadata_case == MetadataCase.kMetadata)
            {
                ClearMetadataCase();
            }
        }
        public override bool Equals(object obj)
        {
            var v = obj as ForwardingFilter;
            if (v == null) return false;
            if (!this.rules.SequenceEqual(v.rules)) return false;
            if (!this._action_case.Equals(v._action_case)) return false;
            if (this._action_case == ActionCase.kAction && !this.action.Equals(v.action)) return false;
            if (!this._version_case.Equals(v._version_case)) return false;
            if (this._version_case == VersionCase.kVersion && !this.version.Equals(v.version)) return false;
            if (!this._metadata_case.Equals(v._metadata_case)) return false;
            if (this._metadata_case == MetadataCase.kMetadata && !this.metadata.Equals(v.metadata)) return false;
            return true;
        }
        
        public override int GetHashCode()
        {
            int hashcode = 1430287;
            foreach (var v in this.rules) hashcode = hashcode * 7302013 ^ v.GetHashCode();
            hashcode = hashcode * 7302013 ^ _action_case.GetHashCode();
            if (_action_case == ActionCase.kAction) hashcode = hashcode * 7302013 ^ action.GetHashCode();
            hashcode = hashcode * 7302013 ^ _version_case.GetHashCode();
            if (_version_case == VersionCase.kVersion) hashcode = hashcode * 7302013 ^ version.GetHashCode();
            hashcode = hashcode * 7302013 ^ _metadata_case.GetHashCode();
            if (_metadata_case == MetadataCase.kMetadata) hashcode = hashcode * 7302013 ^ metadata.GetHashCode();
            return hashcode;
        }
        
    }
    
    [System.Serializable]
    public class CameraConfig
    {
        public int capturer_type;
        public long unity_camera_texture;
        public string video_capturer_device = "";
        public int video_width;
        public int video_height;
        public int video_fps;
        public override bool Equals(object obj)
        {
            var v = obj as CameraConfig;
            if (v == null) return false;
            if (!this.capturer_type.Equals(v.capturer_type)) return false;
            if (!this.unity_camera_texture.Equals(v.unity_camera_texture)) return false;
            if (!this.video_capturer_device.Equals(v.video_capturer_device)) return false;
            if (!this.video_width.Equals(v.video_width)) return false;
            if (!this.video_height.Equals(v.video_height)) return false;
            if (!this.video_fps.Equals(v.video_fps)) return false;
            return true;
        }
        
        public override int GetHashCode()
        {
            int hashcode = 1430287;
            hashcode = hashcode * 7302013 ^ capturer_type.GetHashCode();
            hashcode = hashcode * 7302013 ^ unity_camera_texture.GetHashCode();
            hashcode = hashcode * 7302013 ^ video_capturer_device.GetHashCode();
            hashcode = hashcode * 7302013 ^ video_width.GetHashCode();
            hashcode = hashcode * 7302013 ^ video_height.GetHashCode();
            hashcode = hashcode * 7302013 ^ video_fps.GetHashCode();
            return hashcode;
        }
        
    }
    
    [System.Serializable]
    public class ConnectConfig
    {
        [System.Serializable]
        public enum MultistreamCase
        {
            NOT_SET = 0,
            kMultistream = 8,
        }
        public MultistreamCase _multistream_case;
        public void ClearMultistreamCase()
        {
            _multistream_case = MultistreamCase.NOT_SET;
            multistream = default(bool);
        }
        [System.Serializable]
        public enum SpotlightCase
        {
            NOT_SET = 0,
            kSpotlight = 10,
        }
        public SpotlightCase _spotlight_case;
        public void ClearSpotlightCase()
        {
            _spotlight_case = SpotlightCase.NOT_SET;
            spotlight = default(bool);
        }
        [System.Serializable]
        public enum SimulcastCase
        {
            NOT_SET = 0,
            kSimulcast = 15,
        }
        public SimulcastCase _simulcast_case;
        public void ClearSimulcastCase()
        {
            _simulcast_case = SimulcastCase.NOT_SET;
            simulcast = default(bool);
        }
        [System.Serializable]
        public enum DataChannelSignalingCase
        {
            NOT_SET = 0,
            kDataChannelSignaling = 36,
        }
        public DataChannelSignalingCase _data_channel_signaling_case;
        public void ClearDataChannelSignalingCase()
        {
            _data_channel_signaling_case = DataChannelSignalingCase.NOT_SET;
            data_channel_signaling = default(bool);
        }
        [System.Serializable]
        public enum IgnoreDisconnectWebsocketCase
        {
            NOT_SET = 0,
            kIgnoreDisconnectWebsocket = 39,
        }
        public IgnoreDisconnectWebsocketCase _ignore_disconnect_websocket_case;
        public void ClearIgnoreDisconnectWebsocketCase()
        {
            _ignore_disconnect_websocket_case = IgnoreDisconnectWebsocketCase.NOT_SET;
            ignore_disconnect_websocket = default(bool);
        }
        [System.Serializable]
        public enum ForwardingFilterCase
        {
            NOT_SET = 0,
            kForwardingFilter = 51,
        }
        public ForwardingFilterCase _forwarding_filter_case;
        public void ClearForwardingFilterCase()
        {
            _forwarding_filter_case = ForwardingFilterCase.NOT_SET;
            forwarding_filter = new global::SoraConf.Internal.ForwardingFilter();
        }
        [System.Serializable]
        public enum UseHardwareEncoderCase
        {
            NOT_SET = 0,
            kUseHardwareEncoder = 53,
        }
        public UseHardwareEncoderCase _use_hardware_encoder_case;
        public void ClearUseHardwareEncoderCase()
        {
            _use_hardware_encoder_case = UseHardwareEncoderCase.NOT_SET;
            use_hardware_encoder = default(bool);
        }
        public string unity_version = "";
        public List<string> signaling_url = new List<string>();
        public string channel_id = "";
        public string client_id = "";
        public string metadata = "";
        public string role = "";
        public bool multistream;
        public void SetMultistream(bool multistream)
        {
            ClearMultistreamCase();
            _multistream_case = MultistreamCase.kMultistream;
            this.multistream = multistream;
        }
        public bool HasMultistream()
        {
            return _multistream_case == MultistreamCase.kMultistream;
        }
        public void ClearMultistream()
        {
            if (_multistream_case == MultistreamCase.kMultistream)
            {
                ClearMultistreamCase();
            }
        }
        public bool spotlight;
        public void SetSpotlight(bool spotlight)
        {
            ClearSpotlightCase();
            _spotlight_case = SpotlightCase.kSpotlight;
            this.spotlight = spotlight;
        }
        public bool HasSpotlight()
        {
            return _spotlight_case == SpotlightCase.kSpotlight;
        }
        public void ClearSpotlight()
        {
            if (_spotlight_case == SpotlightCase.kSpotlight)
            {
                ClearSpotlightCase();
            }
        }
        public int spotlight_number;
        public string spotlight_focus_rid = "";
        public string spotlight_unfocus_rid = "";
        public bool simulcast;
        public void SetSimulcast(bool simulcast)
        {
            ClearSimulcastCase();
            _simulcast_case = SimulcastCase.kSimulcast;
            this.simulcast = simulcast;
        }
        public bool HasSimulcast()
        {
            return _simulcast_case == SimulcastCase.kSimulcast;
        }
        public void ClearSimulcast()
        {
            if (_simulcast_case == SimulcastCase.kSimulcast)
            {
                ClearSimulcastCase();
            }
        }
        public string simulcast_rid = "";
        public bool no_video_device;
        public bool no_audio_device;
        public global::SoraConf.Internal.CameraConfig camera_config = new global::SoraConf.Internal.CameraConfig();
        public bool video;
        public bool audio;
        public string video_codec_type = "";
        public string video_vp9_params = "";
        public string video_av1_params = "";
        public string video_h264_params = "";
        public int video_bit_rate;
        public bool unity_audio_input;
        public bool unity_audio_output;
        public string audio_recording_device = "";
        public string audio_playout_device = "";
        public string audio_codec_type = "";
        public int audio_bit_rate;
        public bool data_channel_signaling;
        public void SetDataChannelSignaling(bool data_channel_signaling)
        {
            ClearDataChannelSignalingCase();
            _data_channel_signaling_case = DataChannelSignalingCase.kDataChannelSignaling;
            this.data_channel_signaling = data_channel_signaling;
        }
        public bool HasDataChannelSignaling()
        {
            return _data_channel_signaling_case == DataChannelSignalingCase.kDataChannelSignaling;
        }
        public void ClearDataChannelSignaling()
        {
            if (_data_channel_signaling_case == DataChannelSignalingCase.kDataChannelSignaling)
            {
                ClearDataChannelSignalingCase();
            }
        }
        public int data_channel_signaling_timeout;
        public bool ignore_disconnect_websocket;
        public void SetIgnoreDisconnectWebsocket(bool ignore_disconnect_websocket)
        {
            ClearIgnoreDisconnectWebsocketCase();
            _ignore_disconnect_websocket_case = IgnoreDisconnectWebsocketCase.kIgnoreDisconnectWebsocket;
            this.ignore_disconnect_websocket = ignore_disconnect_websocket;
        }
        public bool HasIgnoreDisconnectWebsocket()
        {
            return _ignore_disconnect_websocket_case == IgnoreDisconnectWebsocketCase.kIgnoreDisconnectWebsocket;
        }
        public void ClearIgnoreDisconnectWebsocket()
        {
            if (_ignore_disconnect_websocket_case == IgnoreDisconnectWebsocketCase.kIgnoreDisconnectWebsocket)
            {
                ClearIgnoreDisconnectWebsocketCase();
            }
        }
        public int disconnect_wait_timeout;
        public List<global::SoraConf.Internal.DataChannel> data_channels = new List<global::SoraConf.Internal.DataChannel>();
        public bool insecure;
        public string bundle_id = "";
        public string proxy_url = "";
        public string proxy_username = "";
        public string proxy_password = "";
        public string proxy_agent = "";
        public string audio_streaming_language_code = "";
        public string signaling_notify_metadata = "";
        public global::SoraConf.Internal.ForwardingFilter forwarding_filter = new global::SoraConf.Internal.ForwardingFilter();
        public void SetForwardingFilter(global::SoraConf.Internal.ForwardingFilter forwarding_filter)
        {
            ClearForwardingFilterCase();
            _forwarding_filter_case = ForwardingFilterCase.kForwardingFilter;
            this.forwarding_filter = forwarding_filter;
        }
        public bool HasForwardingFilter()
        {
            return _forwarding_filter_case == ForwardingFilterCase.kForwardingFilter;
        }
        public void ClearForwardingFilter()
        {
            if (_forwarding_filter_case == ForwardingFilterCase.kForwardingFilter)
            {
                ClearForwardingFilterCase();
            }
        }
        public bool use_hardware_encoder;
        public void SetUseHardwareEncoder(bool use_hardware_encoder)
        {
            ClearUseHardwareEncoderCase();
            _use_hardware_encoder_case = UseHardwareEncoderCase.kUseHardwareEncoder;
            this.use_hardware_encoder = use_hardware_encoder;
        }
        public bool HasUseHardwareEncoder()
        {
            return _use_hardware_encoder_case == UseHardwareEncoderCase.kUseHardwareEncoder;
        }
        public void ClearUseHardwareEncoder()
        {
            if (_use_hardware_encoder_case == UseHardwareEncoderCase.kUseHardwareEncoder)
            {
                ClearUseHardwareEncoderCase();
            }
        }
        public override bool Equals(object obj)
        {
            var v = obj as ConnectConfig;
            if (v == null) return false;
            if (!this.unity_version.Equals(v.unity_version)) return false;
            if (!this.signaling_url.SequenceEqual(v.signaling_url)) return false;
            if (!this.channel_id.Equals(v.channel_id)) return false;
            if (!this.client_id.Equals(v.client_id)) return false;
            if (!this.metadata.Equals(v.metadata)) return false;
            if (!this.role.Equals(v.role)) return false;
            if (!this.spotlight_number.Equals(v.spotlight_number)) return false;
            if (!this.spotlight_focus_rid.Equals(v.spotlight_focus_rid)) return false;
            if (!this.spotlight_unfocus_rid.Equals(v.spotlight_unfocus_rid)) return false;
            if (!this.simulcast_rid.Equals(v.simulcast_rid)) return false;
            if (!this.no_video_device.Equals(v.no_video_device)) return false;
            if (!this.no_audio_device.Equals(v.no_audio_device)) return false;
            if (!this.camera_config.Equals(v.camera_config)) return false;
            if (!this.video.Equals(v.video)) return false;
            if (!this.audio.Equals(v.audio)) return false;
            if (!this.video_codec_type.Equals(v.video_codec_type)) return false;
            if (!this.video_vp9_params.Equals(v.video_vp9_params)) return false;
            if (!this.video_av1_params.Equals(v.video_av1_params)) return false;
            if (!this.video_h264_params.Equals(v.video_h264_params)) return false;
            if (!this.video_bit_rate.Equals(v.video_bit_rate)) return false;
            if (!this.unity_audio_input.Equals(v.unity_audio_input)) return false;
            if (!this.unity_audio_output.Equals(v.unity_audio_output)) return false;
            if (!this.audio_recording_device.Equals(v.audio_recording_device)) return false;
            if (!this.audio_playout_device.Equals(v.audio_playout_device)) return false;
            if (!this.audio_codec_type.Equals(v.audio_codec_type)) return false;
            if (!this.audio_bit_rate.Equals(v.audio_bit_rate)) return false;
            if (!this.data_channel_signaling_timeout.Equals(v.data_channel_signaling_timeout)) return false;
            if (!this.disconnect_wait_timeout.Equals(v.disconnect_wait_timeout)) return false;
            if (!this.data_channels.SequenceEqual(v.data_channels)) return false;
            if (!this.insecure.Equals(v.insecure)) return false;
            if (!this.bundle_id.Equals(v.bundle_id)) return false;
            if (!this.proxy_url.Equals(v.proxy_url)) return false;
            if (!this.proxy_username.Equals(v.proxy_username)) return false;
            if (!this.proxy_password.Equals(v.proxy_password)) return false;
            if (!this.proxy_agent.Equals(v.proxy_agent)) return false;
            if (!this.audio_streaming_language_code.Equals(v.audio_streaming_language_code)) return false;
            if (!this.signaling_notify_metadata.Equals(v.signaling_notify_metadata)) return false;
            if (!this._multistream_case.Equals(v._multistream_case)) return false;
            if (this._multistream_case == MultistreamCase.kMultistream && !this.multistream.Equals(v.multistream)) return false;
            if (!this._spotlight_case.Equals(v._spotlight_case)) return false;
            if (this._spotlight_case == SpotlightCase.kSpotlight && !this.spotlight.Equals(v.spotlight)) return false;
            if (!this._simulcast_case.Equals(v._simulcast_case)) return false;
            if (this._simulcast_case == SimulcastCase.kSimulcast && !this.simulcast.Equals(v.simulcast)) return false;
            if (!this._data_channel_signaling_case.Equals(v._data_channel_signaling_case)) return false;
            if (this._data_channel_signaling_case == DataChannelSignalingCase.kDataChannelSignaling && !this.data_channel_signaling.Equals(v.data_channel_signaling)) return false;
            if (!this._ignore_disconnect_websocket_case.Equals(v._ignore_disconnect_websocket_case)) return false;
            if (this._ignore_disconnect_websocket_case == IgnoreDisconnectWebsocketCase.kIgnoreDisconnectWebsocket && !this.ignore_disconnect_websocket.Equals(v.ignore_disconnect_websocket)) return false;
            if (!this._forwarding_filter_case.Equals(v._forwarding_filter_case)) return false;
            if (this._forwarding_filter_case == ForwardingFilterCase.kForwardingFilter && !this.forwarding_filter.Equals(v.forwarding_filter)) return false;
            if (!this._use_hardware_encoder_case.Equals(v._use_hardware_encoder_case)) return false;
            if (this._use_hardware_encoder_case == UseHardwareEncoderCase.kUseHardwareEncoder && !this.use_hardware_encoder.Equals(v.use_hardware_encoder)) return false;
            return true;
        }
        
        public override int GetHashCode()
        {
            int hashcode = 1430287;
            hashcode = hashcode * 7302013 ^ unity_version.GetHashCode();
            foreach (var v in this.signaling_url) hashcode = hashcode * 7302013 ^ v.GetHashCode();
            hashcode = hashcode * 7302013 ^ channel_id.GetHashCode();
            hashcode = hashcode * 7302013 ^ client_id.GetHashCode();
            hashcode = hashcode * 7302013 ^ metadata.GetHashCode();
            hashcode = hashcode * 7302013 ^ role.GetHashCode();
            hashcode = hashcode * 7302013 ^ spotlight_number.GetHashCode();
            hashcode = hashcode * 7302013 ^ spotlight_focus_rid.GetHashCode();
            hashcode = hashcode * 7302013 ^ spotlight_unfocus_rid.GetHashCode();
            hashcode = hashcode * 7302013 ^ simulcast_rid.GetHashCode();
            hashcode = hashcode * 7302013 ^ no_video_device.GetHashCode();
            hashcode = hashcode * 7302013 ^ no_audio_device.GetHashCode();
            hashcode = hashcode * 7302013 ^ camera_config.GetHashCode();
            hashcode = hashcode * 7302013 ^ video.GetHashCode();
            hashcode = hashcode * 7302013 ^ audio.GetHashCode();
            hashcode = hashcode * 7302013 ^ video_codec_type.GetHashCode();
            hashcode = hashcode * 7302013 ^ video_vp9_params.GetHashCode();
            hashcode = hashcode * 7302013 ^ video_av1_params.GetHashCode();
            hashcode = hashcode * 7302013 ^ video_h264_params.GetHashCode();
            hashcode = hashcode * 7302013 ^ video_bit_rate.GetHashCode();
            hashcode = hashcode * 7302013 ^ unity_audio_input.GetHashCode();
            hashcode = hashcode * 7302013 ^ unity_audio_output.GetHashCode();
            hashcode = hashcode * 7302013 ^ audio_recording_device.GetHashCode();
            hashcode = hashcode * 7302013 ^ audio_playout_device.GetHashCode();
            hashcode = hashcode * 7302013 ^ audio_codec_type.GetHashCode();
            hashcode = hashcode * 7302013 ^ audio_bit_rate.GetHashCode();
            hashcode = hashcode * 7302013 ^ data_channel_signaling_timeout.GetHashCode();
            hashcode = hashcode * 7302013 ^ disconnect_wait_timeout.GetHashCode();
            foreach (var v in this.data_channels) hashcode = hashcode * 7302013 ^ v.GetHashCode();
            hashcode = hashcode * 7302013 ^ insecure.GetHashCode();
            hashcode = hashcode * 7302013 ^ bundle_id.GetHashCode();
            hashcode = hashcode * 7302013 ^ proxy_url.GetHashCode();
            hashcode = hashcode * 7302013 ^ proxy_username.GetHashCode();
            hashcode = hashcode * 7302013 ^ proxy_password.GetHashCode();
            hashcode = hashcode * 7302013 ^ proxy_agent.GetHashCode();
            hashcode = hashcode * 7302013 ^ audio_streaming_language_code.GetHashCode();
            hashcode = hashcode * 7302013 ^ signaling_notify_metadata.GetHashCode();
            hashcode = hashcode * 7302013 ^ _multistream_case.GetHashCode();
            if (_multistream_case == MultistreamCase.kMultistream) hashcode = hashcode * 7302013 ^ multistream.GetHashCode();
            hashcode = hashcode * 7302013 ^ _spotlight_case.GetHashCode();
            if (_spotlight_case == SpotlightCase.kSpotlight) hashcode = hashcode * 7302013 ^ spotlight.GetHashCode();
            hashcode = hashcode * 7302013 ^ _simulcast_case.GetHashCode();
            if (_simulcast_case == SimulcastCase.kSimulcast) hashcode = hashcode * 7302013 ^ simulcast.GetHashCode();
            hashcode = hashcode * 7302013 ^ _data_channel_signaling_case.GetHashCode();
            if (_data_channel_signaling_case == DataChannelSignalingCase.kDataChannelSignaling) hashcode = hashcode * 7302013 ^ data_channel_signaling.GetHashCode();
            hashcode = hashcode * 7302013 ^ _ignore_disconnect_websocket_case.GetHashCode();
            if (_ignore_disconnect_websocket_case == IgnoreDisconnectWebsocketCase.kIgnoreDisconnectWebsocket) hashcode = hashcode * 7302013 ^ ignore_disconnect_websocket.GetHashCode();
            hashcode = hashcode * 7302013 ^ _forwarding_filter_case.GetHashCode();
            if (_forwarding_filter_case == ForwardingFilterCase.kForwardingFilter) hashcode = hashcode * 7302013 ^ forwarding_filter.GetHashCode();
            hashcode = hashcode * 7302013 ^ _use_hardware_encoder_case.GetHashCode();
            if (_use_hardware_encoder_case == UseHardwareEncoderCase.kUseHardwareEncoder) hashcode = hashcode * 7302013 ^ use_hardware_encoder.GetHashCode();
            return hashcode;
        }
        
    }
    
}
