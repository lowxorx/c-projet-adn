﻿using System;

namespace NodeNet.Data
{
    [Serializable]
    public class DataInput
    {
        public MessageType MsgType;
        public String Method { get; set; }
        public Object Data { get; set; }
    }
}
