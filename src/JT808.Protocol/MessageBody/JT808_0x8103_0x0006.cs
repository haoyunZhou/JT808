﻿using JT808.Protocol.Attributes;
using JT808.Protocol.Formatters.MessageBodyFormatters;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// SMS 消息应答超时时间，单位为秒（s）
    /// 0x8103_0x0006
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8103_0x0006_Formatter))]
    public class JT808_0x8103_0x0006 : JT808_0x8103_BodyBase
    {
        public override uint ParamId { get; set; } = 0x0006;
        /// <summary>
        /// 数据 长度
        /// </summary>
        public override byte ParamLength { get; set; } = 4;
        /// <summary>
        /// SMS 消息应答超时时间，单位为秒（s）
        /// </summary>
        public uint ParamValue { get; set; }
    }
}
