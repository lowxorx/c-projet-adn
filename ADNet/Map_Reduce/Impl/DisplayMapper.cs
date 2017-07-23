﻿using NodeNet.Map_Reduce;
using System;
using System.Collections.Generic;

namespace ADNet.Map_Reduce.Impl
{
    public class DisplayMapper : IMapper<String, String>
    {
        public List<string> map(string input)
        {
            List<String> mappedList = new List<string>();
            foreach(char c in input)
            {
                mappedList.Add(c.ToString());
            }
            return mappedList;
        }
    }
}