using System.Collections.Generic;
using System.Text;
using ZeroFormatter;
using ZeroFormatter.Formatters;
using ZeroFormatter.Internal;

public class ListFormatter<T> : ZeroFormatterBase<List<T>> {
    public override int? GetLength() {
        return null;
    }

    public override int Serialize(ref byte[] bytes, int offset, List<T> value) {
        int startOffset = offset;

        /*
        if (value == null) {
            BinaryUtil.WriteInt32(ref bytes, offset, ZeroFormatterConstant.NULL);
            return sizeof(int);
        }
        */
        if (value == null) {
            value = new List<T>();
        }

        BinaryUtil.WriteInt32(ref bytes, offset, value.Count);
        offset += sizeof(int);
        
        for (int i = 0; i < value.Count; ++i) {
            if (value[i] == null) {
                value[i] = default;
            }
            offset += SerializePrimitive(ref bytes, offset, value[i]);
        }
        
        return offset - startOffset;
    }

    public override List<T> Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {

        int startOffset = offset;
        int size;

        List<T> instance = new List<T>();

        var length = BinaryUtil.ReadInt32(ref bytes, offset);
        size = sizeof(int);
        offset += size;

        if (length == ZeroFormatterConstant.NULL) {
            byteSize = offset - startOffset;
            return null;
        }

        for (int i = 0; i < length; ++i) {
            var val = DeserializePrimitive<T>(ref bytes, offset, tracker, out size);
            offset += size;
            instance.Add(val);
        }

        byteSize = offset - startOffset;

        return instance;
    }
}

public class DoubleListFormatter<T> : ZeroFormatterBase<List<List<T>>> {
    public override int? GetLength() {
        return null;
    }

    public override int Serialize(ref byte[] bytes, int offset, List<List<T>> value) {
        int startOffset = offset;

        /*
        if (value == null) {
            BinaryUtil.WriteInt32(ref bytes, offset, ZeroFormatterConstant.NULL);
            return sizeof(int);
        }*/
        if (value == null) {
            value = new List<List<T>>();
        }

        BinaryUtil.WriteInt32(ref bytes, offset, value.Count);
        offset += sizeof(int);
        
        for (int i = 0; i < value.Count; ++i) {
            if (value[i] == null) {
                value[i] = new List<T>();
            }
            offset += SerializePrimitive(ref bytes, offset, value[i]);
        }
        
        return offset - startOffset;
    }

    public override List<List<T>> Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {

        int startOffset = offset;
        int size;

        List<List<T>> instance = new List<List<T>>();

        var length = BinaryUtil.ReadInt32(ref bytes, offset);
        size = sizeof(int);
        offset += size;

        if (length == ZeroFormatterConstant.NULL) {
            byteSize = offset - startOffset;
            return null;
        }

        for (int i = 0; i < length; ++i) {
            var val = DeserializePrimitive<List<T>>(ref bytes, offset, tracker, out size);
            offset += size;
            instance.Add(val);
        }

        byteSize = offset - startOffset;

        return instance;
    }
}