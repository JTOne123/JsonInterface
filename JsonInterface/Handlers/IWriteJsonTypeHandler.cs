﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace JsonInterface.Handlers
{
    public interface IWriteJsonTypeHandler<T>
    {
        void SetPropertyValue(JObject jObject, string propertyName, T value);

    }
}