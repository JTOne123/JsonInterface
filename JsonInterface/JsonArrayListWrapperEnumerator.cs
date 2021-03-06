﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace JsonInterface
{
    internal class JsonArrayListWrapperEnumerator<T> : IEnumerator<T>
    {
        private readonly IEnumerator<JToken> _baseEnumerator;
        private readonly JsonArrayListWrapper<T> _arrayListWrapper;

        public JsonArrayListWrapperEnumerator(JsonArrayListWrapper<T> arrayListWrapper, IEnumerator<JToken> enumerator)
        {
            _baseEnumerator = enumerator ?? throw new ArgumentNullException(nameof(enumerator));
            _arrayListWrapper = arrayListWrapper ?? throw new ArgumentNullException(nameof(arrayListWrapper));
        }

        public T Current => _arrayListWrapper.FromJToken(_baseEnumerator.Current);

        object IEnumerator.Current => _arrayListWrapper.FromJToken(_baseEnumerator.Current);

        public void Dispose() => _baseEnumerator.Dispose();

        public bool MoveNext() => _baseEnumerator.MoveNext();

        public void Reset() => _baseEnumerator.Reset();
    }

}
