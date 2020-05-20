using System.Collections.Generic;
using ZeroFormatter;
using ZeroFormatter.Internal;

public class DictionaryFormatter<T,V> : ZeroFormatterBase<Dictionary<T,V>> {
    public override int? GetLength() {
        return null;
    }

    public override int Serialize(ref byte[] bytes, int offset, Dictionary<T,V> value) {
        int startOffset = offset;

        /*
        if (value == null) {
            BinaryUtil.WriteInt32(ref bytes, offset, ZeroFormatterConstant.NULL);
            return sizeof(int);
        }
        */
        if (value == null) {
            value = new Dictionary<T, V>();
        }

        BinaryUtil.WriteInt32(ref bytes, offset, value.Count);
        offset += sizeof(int);

        foreach (var item in value)
        {
            offset += SerializePrimitive(ref bytes, offset, item.Key == null ? default : item.Key);
            offset += SerializePrimitive(ref bytes, offset, item.Value == null ? default : item.Value);
        }
        
        return offset - startOffset;
    }

    public override Dictionary<T,V> Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {

        int startOffset = offset;
        int size;

        Dictionary<T,V> instance = new Dictionary<T, V>();

        var length = BinaryUtil.ReadInt32(ref bytes, offset);
        size = sizeof(int);
        offset += size;

        if (length == ZeroFormatterConstant.NULL) {
            byteSize = offset - startOffset;
            return null;
        }

        for (int i = 0; i < length; ++i) {
            var key = DeserializePrimitive<T>(ref bytes, offset, tracker, out size);
            offset += size;
            var value = DeserializePrimitive<V>(ref bytes, offset, tracker, out size);
            offset += size;
            instance.Add(key,value);
        }

        byteSize = offset - startOffset;

        return instance;
    }
}