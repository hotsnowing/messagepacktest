using System;
using System.Collections.Generic;
using UnityEngine;
using ZeroFormatter;
using ZeroFormatter.Formatters;
using ZeroFormatter.Internal;

[ZeroFormattable]
public abstract class ZeroFormattableContextBase {
    // Resource폴더에서 불러올지,
    // PlayerPrefs에 저장할지,
    // 기타 프로퍼티를 사용할 수 있도록 하기.

    public virtual void OnPreSerialized() {
    }
    public virtual void OnPostSerialized() {
    }

    public virtual void OnPreDeserialized() {
    }
    public virtual void OnPostDeserialized() {
    }
}

public abstract class ZeroFormatterBase<T> : ZeroFormatterBase<DefaultResolver,T> {
    public static int SerializePrimitive<T>(ref byte[] bytes, int offset, T value) {
        return Formatter<DefaultResolver, T>.Default.Serialize(ref bytes, offset, value);
    }
    
    public T DeserializePrimitive<T>(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
        T item = Formatter<DefaultResolver, T>.Default.Deserialize(ref bytes, offset, tracker, out byteSize);
        
        return item;
    }
}

public abstract class ZeroFormatterBase<TTypeResolver, T> : Formatter<TTypeResolver, T> where TTypeResolver : ITypeResolver, new() {
}

