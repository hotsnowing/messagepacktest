using System.Collections.Generic;
using System.Text;
using UnityEngine;
using ZeroFormatter;
using ZeroFormatter.Formatters;

public class ZeroFormatterConstant {
    public const int NULL = -1;
}

public class ZeroFormat {
    private static ZeroFormat instance = null;
    public static ZeroFormat Instance {
        get {
            if (ReferenceEquals(instance, null) == false) {
                return instance;
            }
            
            instance = new ZeroFormat();
            instance.Initialize();
            return instance;
        }
    }
    
    public static byte[] Serialize<T>(T obj) {
        return Instance.SerializeInternal(obj);
    }

    public static T Deserialize<T>(byte[] data) {
        return Instance.DeserializeInternal<T>(data);
    }
    
    private void Initialize() {
        Debug.Log("ZeroFormat.Register");
        RegisterFormatter();
    }

    void RegisterFormatter() {
        Formatter<DefaultResolver,InnerDataByZeroFormatter>.Register(new InnerDataByZeroFormatter.Formatter());

        Formatter<DefaultResolver,Dictionary<int,int>>.Register(new DictionaryFormatter<int,int>());
        Formatter<DefaultResolver,List<int>>.Register(new ListFormatter<int>());
        Formatter<DefaultResolver,List<List<int>>>.Register(new DoubleListFormatter<int>());
    }

    public byte[] SerializeInternal<T>(T obj) {
        return ZeroFormatterSerializer.Serialize(obj);
    }

    public T DeserializeInternal<T>(byte[] data) {
        return ZeroFormatterSerializer.Deserialize<T>(data);
    }
}