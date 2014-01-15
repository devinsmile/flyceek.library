﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindProperty.Lib.Cache.Component.ResultExaminer
{
    public class CollectionResultExaminer : IResultExaminer
    {
        public bool IsNullOrEmpty(object v)
        {
            return v == null || (v as ICollection).Count < 1;
        }
    }
}
