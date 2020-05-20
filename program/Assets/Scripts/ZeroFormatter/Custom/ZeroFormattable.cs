using ZeroFormatter;
using ZeroFormatter.Formatters;

// https://github.com/neuecc/ZeroFormatter

public abstract class ZeroFormattableBase {
    public virtual void OnPreSerialized() {
    }
    public virtual void OnPostSerialized() {
    }

    public virtual void OnPreDeserialized() {
    }
    public virtual void OnPostDeserialized() {
    }
}

[ZeroFormattable]
public class ZeroFormattableBase<T0> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    
    public class Formatter<T,T0> : ZeroFormatter.Formatters.Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;
        
            value.OnPreSerialized();

            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 0);

            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            
            value.OnPostSerialized();
        
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();

            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = ZeroFormatter.Formatters.Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    
    public class Formatter<T,T0,T1> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;
        
            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 1);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
        
            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }
            
            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            byteSize = offset - startOffset;
            return instance;
        }
    }
}



[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    
    public class Formatter<T,T0,T1,T2> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;
        
            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 2);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
        
            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();

            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            
            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    
    public class Formatter<T,T0,T1,T2,T3> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;
        
            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 3);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
        
            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3,T4> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    [Index(4)]
    public T4 item4 = default;
    
    public class Formatter<T,T0,T1,T2,T3,T4> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3,T4>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;
        
            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 4);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
            offset += Formatter<DefaultResolver, T4>.Default.Serialize(ref bytes, offset, value.item4);
        
            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 4) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item4 = Formatter<DefaultResolver, T4>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3,T4,T5> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    [Index(4)]
    public T4 item4 = default;
    [Index(5)]
    public T5 item5 = default;
    
    public class Formatter<T,T0,T1,T2,T3,T4,T5> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3,T4,T5>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;
        
            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 5);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
            offset += Formatter<DefaultResolver, T4>.Default.Serialize(ref bytes, offset, value.item4);
            offset += Formatter<DefaultResolver, T5>.Default.Serialize(ref bytes, offset, value.item5);
        
            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 4) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item4 = Formatter<DefaultResolver, T4>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 5) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item5 = Formatter<DefaultResolver, T5>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    [Index(4)]
    public T4 item4 = default;
    [Index(5)]
    public T5 item5 = default;
    [Index(6)]
    public T6 item6 = default;
    
    public class Formatter<T,T0,T1,T2,T3,T4,T5,T6> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;

            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 6);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
            offset += Formatter<DefaultResolver, T4>.Default.Serialize(ref bytes, offset, value.item4);
            offset += Formatter<DefaultResolver, T5>.Default.Serialize(ref bytes, offset, value.item5);
            offset += Formatter<DefaultResolver, T6>.Default.Serialize(ref bytes, offset, value.item6);
        
            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 4) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item4 = Formatter<DefaultResolver, T4>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 5) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item5 = Formatter<DefaultResolver, T5>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 6) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item6 = Formatter<DefaultResolver, T6>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    [Index(4)]
    public T4 item4 = default;
    [Index(5)]
    public T5 item5 = default;
    [Index(6)]
    public T6 item6 = default;
    [Index(7)]
    public T7 item7 = default;
    
    public class Formatter<T,T0,T1,T2,T3,T4,T5,T6,T7> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;

            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 7);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
            offset += Formatter<DefaultResolver, T4>.Default.Serialize(ref bytes, offset, value.item4);
            offset += Formatter<DefaultResolver, T5>.Default.Serialize(ref bytes, offset, value.item5);
            offset += Formatter<DefaultResolver, T6>.Default.Serialize(ref bytes, offset, value.item6);
            offset += Formatter<DefaultResolver, T7>.Default.Serialize(ref bytes, offset, value.item7);
        
            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 4) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item4 = Formatter<DefaultResolver, T4>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 5) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item5 = Formatter<DefaultResolver, T5>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 6) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item6 = Formatter<DefaultResolver, T6>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 7) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item7 = Formatter<DefaultResolver, T7>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    [Index(4)]
    public T4 item4 = default;
    [Index(5)]
    public T5 item5 = default;
    [Index(6)]
    public T6 item6 = default;
    [Index(7)]
    public T7 item7 = default;
    [Index(8)]
    public T8 item8 = default;
    
    public class Formatter<T,T0,T1,T2,T3,T4,T5,T6,T7,T8> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;

            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 8);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
            offset += Formatter<DefaultResolver, T4>.Default.Serialize(ref bytes, offset, value.item4);
            offset += Formatter<DefaultResolver, T5>.Default.Serialize(ref bytes, offset, value.item5);
            offset += Formatter<DefaultResolver, T6>.Default.Serialize(ref bytes, offset, value.item6);
            offset += Formatter<DefaultResolver, T7>.Default.Serialize(ref bytes, offset, value.item7);
            offset += Formatter<DefaultResolver, T8>.Default.Serialize(ref bytes, offset, value.item8);
        
            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 4) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item4 = Formatter<DefaultResolver, T4>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 5) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item5 = Formatter<DefaultResolver, T5>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 6) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item6 = Formatter<DefaultResolver, T6>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 7) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item7 = Formatter<DefaultResolver, T7>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 8) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item8 = Formatter<DefaultResolver, T8>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3,T4,T5
    ,T6,T7,T8,T9> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    [Index(4)]
    public T4 item4 = default;
    [Index(5)]
    public T5 item5 = default;
    [Index(6)]
    public T6 item6 = default;
    [Index(7)]
    public T7 item7 = default;
    [Index(8)]
    public T8 item8 = default;
    [Index(9)]
    public T9 item9 = default;
    
    public class Formatter<T,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;

            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 9);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
            offset += Formatter<DefaultResolver, T4>.Default.Serialize(ref bytes, offset, value.item4);
            offset += Formatter<DefaultResolver, T5>.Default.Serialize(ref bytes, offset, value.item5);
            offset += Formatter<DefaultResolver, T6>.Default.Serialize(ref bytes, offset, value.item6);
            offset += Formatter<DefaultResolver, T7>.Default.Serialize(ref bytes, offset, value.item7);
            offset += Formatter<DefaultResolver, T8>.Default.Serialize(ref bytes, offset, value.item8);
            offset += Formatter<DefaultResolver, T9>.Default.Serialize(ref bytes, offset, value.item9);
        
            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 4) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item4 = Formatter<DefaultResolver, T4>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 5) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item5 = Formatter<DefaultResolver, T5>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 6) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item6 = Formatter<DefaultResolver, T6>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 7) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item7 = Formatter<DefaultResolver, T7>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 8) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item8 = Formatter<DefaultResolver, T8>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 9) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item9 = Formatter<DefaultResolver, T9>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    [Index(4)]
    public T4 item4 = default;
    [Index(5)]
    public T5 item5 = default;
    [Index(6)]
    public T6 item6 = default;
    [Index(7)]
    public T7 item7 = default;
    [Index(8)]
    public T8 item8 = default;
    [Index(9)]
    public T9 item9 = default;
    [Index(10)]
    public T10 item10 = default;
    
    public class Formatter<T,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;

            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 10);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
            offset += Formatter<DefaultResolver, T4>.Default.Serialize(ref bytes, offset, value.item4);
            offset += Formatter<DefaultResolver, T5>.Default.Serialize(ref bytes, offset, value.item5);
            offset += Formatter<DefaultResolver, T6>.Default.Serialize(ref bytes, offset, value.item6);
            offset += Formatter<DefaultResolver, T7>.Default.Serialize(ref bytes, offset, value.item7);
            offset += Formatter<DefaultResolver, T8>.Default.Serialize(ref bytes, offset, value.item8);
            offset += Formatter<DefaultResolver, T9>.Default.Serialize(ref bytes, offset, value.item9);
            offset += Formatter<DefaultResolver, T10>.Default.Serialize(ref bytes, offset, value.item10);

            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 4) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item4 = Formatter<DefaultResolver, T4>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 5) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item5 = Formatter<DefaultResolver, T5>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 6) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item6 = Formatter<DefaultResolver, T6>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 7) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item7 = Formatter<DefaultResolver, T7>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 8) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item8 = Formatter<DefaultResolver, T8>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 9) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item9 = Formatter<DefaultResolver, T9>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 10) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item10 = Formatter<DefaultResolver, T10>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    [Index(4)]
    public T4 item4 = default;
    [Index(5)]
    public T5 item5 = default;
    [Index(6)]
    public T6 item6 = default;
    [Index(7)]
    public T7 item7 = default;
    [Index(8)]
    public T8 item8 = default;
    [Index(9)]
    public T9 item9 = default;
    [Index(10)]
    public T10 item10 = default;
    [Index(11)]
    public T11 item11 = default;
    
    public class Formatter<T,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;

            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 11);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
            offset += Formatter<DefaultResolver, T4>.Default.Serialize(ref bytes, offset, value.item4);
            offset += Formatter<DefaultResolver, T5>.Default.Serialize(ref bytes, offset, value.item5);
            offset += Formatter<DefaultResolver, T6>.Default.Serialize(ref bytes, offset, value.item6);
            offset += Formatter<DefaultResolver, T7>.Default.Serialize(ref bytes, offset, value.item7);
            offset += Formatter<DefaultResolver, T8>.Default.Serialize(ref bytes, offset, value.item8);
            offset += Formatter<DefaultResolver, T9>.Default.Serialize(ref bytes, offset, value.item9);
            offset += Formatter<DefaultResolver, T10>.Default.Serialize(ref bytes, offset, value.item10);
            offset += Formatter<DefaultResolver, T11>.Default.Serialize(ref bytes, offset, value.item11);
        
            value.OnPostDeserialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 4) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item4 = Formatter<DefaultResolver, T4>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 5) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item5 = Formatter<DefaultResolver, T5>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 6) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item6 = Formatter<DefaultResolver, T6>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 7) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item7 = Formatter<DefaultResolver, T7>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 8) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item8 = Formatter<DefaultResolver, T8>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 9) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item9 = Formatter<DefaultResolver, T9>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 10) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item10 = Formatter<DefaultResolver, T10>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 11) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item11 = Formatter<DefaultResolver, T11>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    [Index(4)]
    public T4 item4 = default;
    [Index(5)]
    public T5 item5 = default;
    [Index(6)]
    public T6 item6 = default;
    [Index(7)]
    public T7 item7 = default;
    [Index(8)]
    public T8 item8 = default;
    [Index(9)]
    public T9 item9 = default;
    [Index(10)]
    public T10 item10 = default;
    [Index(11)]
    public T11 item11 = default;
    [Index(12)]
    public T12 item12 = default;
    
    public class Formatter<T,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;

            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 12);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
            offset += Formatter<DefaultResolver, T4>.Default.Serialize(ref bytes, offset, value.item4);
            offset += Formatter<DefaultResolver, T5>.Default.Serialize(ref bytes, offset, value.item5);
            offset += Formatter<DefaultResolver, T6>.Default.Serialize(ref bytes, offset, value.item6);
            offset += Formatter<DefaultResolver, T7>.Default.Serialize(ref bytes, offset, value.item7);
            offset += Formatter<DefaultResolver, T8>.Default.Serialize(ref bytes, offset, value.item8);
            offset += Formatter<DefaultResolver, T9>.Default.Serialize(ref bytes, offset, value.item9);
            offset += Formatter<DefaultResolver, T10>.Default.Serialize(ref bytes, offset, value.item10);
            offset += Formatter<DefaultResolver, T11>.Default.Serialize(ref bytes, offset, value.item11);
            offset += Formatter<DefaultResolver, T12>.Default.Serialize(ref bytes, offset, value.item12);
        
            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 4) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item4 = Formatter<DefaultResolver, T4>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 5) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item5 = Formatter<DefaultResolver, T5>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 6) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item6 = Formatter<DefaultResolver, T6>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 7) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item7 = Formatter<DefaultResolver, T7>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 8) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item8 = Formatter<DefaultResolver, T8>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 9) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item9 = Formatter<DefaultResolver, T9>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 10) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item10 = Formatter<DefaultResolver, T10>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 11) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item11 = Formatter<DefaultResolver, T11>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 12) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item12 = Formatter<DefaultResolver, T12>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    [Index(4)]
    public T4 item4 = default;
    [Index(5)]
    public T5 item5 = default;
    [Index(6)]
    public T6 item6 = default;
    [Index(7)]
    public T7 item7 = default;
    [Index(8)]
    public T8 item8 = default;
    [Index(9)]
    public T9 item9 = default;
    [Index(10)]
    public T10 item10 = default;
    [Index(11)]
    public T11 item11 = default;
    [Index(12)]
    public T12 item12 = default;
    [Index(13)]
    public T13 item13 = default;
    
    public class Formatter<T,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;

            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 13);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
            offset += Formatter<DefaultResolver, T4>.Default.Serialize(ref bytes, offset, value.item4);
            offset += Formatter<DefaultResolver, T5>.Default.Serialize(ref bytes, offset, value.item5);
            offset += Formatter<DefaultResolver, T6>.Default.Serialize(ref bytes, offset, value.item6);
            offset += Formatter<DefaultResolver, T7>.Default.Serialize(ref bytes, offset, value.item7);
            offset += Formatter<DefaultResolver, T8>.Default.Serialize(ref bytes, offset, value.item8);
            offset += Formatter<DefaultResolver, T9>.Default.Serialize(ref bytes, offset, value.item9);
            offset += Formatter<DefaultResolver, T10>.Default.Serialize(ref bytes, offset, value.item10);
            offset += Formatter<DefaultResolver, T11>.Default.Serialize(ref bytes, offset, value.item11);
            offset += Formatter<DefaultResolver, T12>.Default.Serialize(ref bytes, offset, value.item12);
            offset += Formatter<DefaultResolver, T13>.Default.Serialize(ref bytes, offset, value.item13);
        
            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 4) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item4 = Formatter<DefaultResolver, T4>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 5) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item5 = Formatter<DefaultResolver, T5>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 6) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item6 = Formatter<DefaultResolver, T6>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 7) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item7 = Formatter<DefaultResolver, T7>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 8) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item8 = Formatter<DefaultResolver, T8>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 9) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item9 = Formatter<DefaultResolver, T9>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 10) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item10 = Formatter<DefaultResolver, T10>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 11) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item11 = Formatter<DefaultResolver, T11>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 12) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item12 = Formatter<DefaultResolver, T12>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 13) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item13 = Formatter<DefaultResolver, T13>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    [Index(4)]
    public T4 item4 = default;
    [Index(5)]
    public T5 item5 = default;
    [Index(6)]
    public T6 item6 = default;
    [Index(7)]
    public T7 item7 = default;
    [Index(8)]
    public T8 item8 = default;
    [Index(9)]
    public T9 item9 = default;
    [Index(10)]
    public T10 item10 = default;
    [Index(11)]
    public T11 item11 = default;
    [Index(12)]
    public T12 item12 = default;
    [Index(13)]
    public T13 item13 = default;
    [Index(14)]
    public T14 item14 = default;
    
    public class Formatter<T,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;
        
            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 14);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
            offset += Formatter<DefaultResolver, T4>.Default.Serialize(ref bytes, offset, value.item4);
            offset += Formatter<DefaultResolver, T5>.Default.Serialize(ref bytes, offset, value.item5);
            offset += Formatter<DefaultResolver, T6>.Default.Serialize(ref bytes, offset, value.item6);
            offset += Formatter<DefaultResolver, T7>.Default.Serialize(ref bytes, offset, value.item7);
            offset += Formatter<DefaultResolver, T8>.Default.Serialize(ref bytes, offset, value.item8);
            offset += Formatter<DefaultResolver, T9>.Default.Serialize(ref bytes, offset, value.item9);
            offset += Formatter<DefaultResolver, T10>.Default.Serialize(ref bytes, offset, value.item10);
            offset += Formatter<DefaultResolver, T11>.Default.Serialize(ref bytes, offset, value.item11);
            offset += Formatter<DefaultResolver, T12>.Default.Serialize(ref bytes, offset, value.item12);
            offset += Formatter<DefaultResolver, T13>.Default.Serialize(ref bytes, offset, value.item13);
            offset += Formatter<DefaultResolver, T14>.Default.Serialize(ref bytes, offset, value.item14);

            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 4) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item4 = Formatter<DefaultResolver, T4>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 5) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item5 = Formatter<DefaultResolver, T5>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 6) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item6 = Formatter<DefaultResolver, T6>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 7) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item7 = Formatter<DefaultResolver, T7>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 8) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item8 = Formatter<DefaultResolver, T8>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 9) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item9 = Formatter<DefaultResolver, T9>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 10) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item10 = Formatter<DefaultResolver, T10>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 11) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item11 = Formatter<DefaultResolver, T11>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 12) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item12 = Formatter<DefaultResolver, T12>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 13) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item13 = Formatter<DefaultResolver, T13>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 14) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item14 = Formatter<DefaultResolver, T14>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    [Index(4)]
    public T4 item4 = default;
    [Index(5)]
    public T5 item5 = default;
    [Index(6)]
    public T6 item6 = default;
    [Index(7)]
    public T7 item7 = default;
    [Index(8)]
    public T8 item8 = default;
    [Index(9)]
    public T9 item9 = default;
    [Index(10)]
    public T10 item10 = default;
    [Index(11)]
    public T11 item11 = default;
    [Index(12)]
    public T12 item12 = default;
    [Index(13)]
    public T13 item13 = default;
    [Index(14)]
    public T14 item14 = default;
    [Index(15)]
    public T15 item15 = default;
    
    public class Formatter<T,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;

            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 15);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
            offset += Formatter<DefaultResolver, T4>.Default.Serialize(ref bytes, offset, value.item4);
            offset += Formatter<DefaultResolver, T5>.Default.Serialize(ref bytes, offset, value.item5);
            offset += Formatter<DefaultResolver, T6>.Default.Serialize(ref bytes, offset, value.item6);
            offset += Formatter<DefaultResolver, T7>.Default.Serialize(ref bytes, offset, value.item7);
            offset += Formatter<DefaultResolver, T8>.Default.Serialize(ref bytes, offset, value.item8);
            offset += Formatter<DefaultResolver, T9>.Default.Serialize(ref bytes, offset, value.item9);
            offset += Formatter<DefaultResolver, T10>.Default.Serialize(ref bytes, offset, value.item10);
            offset += Formatter<DefaultResolver, T11>.Default.Serialize(ref bytes, offset, value.item11);
            offset += Formatter<DefaultResolver, T12>.Default.Serialize(ref bytes, offset, value.item12);
            offset += Formatter<DefaultResolver, T13>.Default.Serialize(ref bytes, offset, value.item13);
            offset += Formatter<DefaultResolver, T14>.Default.Serialize(ref bytes, offset, value.item14);
            offset += Formatter<DefaultResolver, T15>.Default.Serialize(ref bytes, offset, value.item15);

            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 4) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item4 = Formatter<DefaultResolver, T4>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 5) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item5 = Formatter<DefaultResolver, T5>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 6) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item6 = Formatter<DefaultResolver, T6>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 7) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item7 = Formatter<DefaultResolver, T7>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 8) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item8 = Formatter<DefaultResolver, T8>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 9) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item9 = Formatter<DefaultResolver, T9>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 10) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item10 = Formatter<DefaultResolver, T10>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 11) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item11 = Formatter<DefaultResolver, T11>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 12) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item12 = Formatter<DefaultResolver, T12>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 13) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item13 = Formatter<DefaultResolver, T13>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 14) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item14 = Formatter<DefaultResolver, T14>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 15) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item15 = Formatter<DefaultResolver, T15>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    [Index(4)]
    public T4 item4 = default;
    [Index(5)]
    public T5 item5 = default;
    [Index(6)]
    public T6 item6 = default;
    [Index(7)]
    public T7 item7 = default;
    [Index(8)]
    public T8 item8 = default;
    [Index(9)]
    public T9 item9 = default;
    [Index(10)]
    public T10 item10 = default;
    [Index(11)]
    public T11 item11 = default;
    [Index(12)]
    public T12 item12 = default;
    [Index(13)]
    public T13 item13 = default;
    [Index(14)]
    public T14 item14 = default;
    [Index(15)]
    public T15 item15 = default;
    [Index(16)]
    public T16 item16 = default;
    
    public class Formatter<T,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;
        
            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 16);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
            offset += Formatter<DefaultResolver, T4>.Default.Serialize(ref bytes, offset, value.item4);
            offset += Formatter<DefaultResolver, T5>.Default.Serialize(ref bytes, offset, value.item5);
            offset += Formatter<DefaultResolver, T6>.Default.Serialize(ref bytes, offset, value.item6);
            offset += Formatter<DefaultResolver, T7>.Default.Serialize(ref bytes, offset, value.item7);
            offset += Formatter<DefaultResolver, T8>.Default.Serialize(ref bytes, offset, value.item8);
            offset += Formatter<DefaultResolver, T9>.Default.Serialize(ref bytes, offset, value.item9);
            offset += Formatter<DefaultResolver, T10>.Default.Serialize(ref bytes, offset, value.item10);
            offset += Formatter<DefaultResolver, T11>.Default.Serialize(ref bytes, offset, value.item11);
            offset += Formatter<DefaultResolver, T12>.Default.Serialize(ref bytes, offset, value.item12);
            offset += Formatter<DefaultResolver, T13>.Default.Serialize(ref bytes, offset, value.item13);
            offset += Formatter<DefaultResolver, T14>.Default.Serialize(ref bytes, offset, value.item14);
            offset += Formatter<DefaultResolver, T15>.Default.Serialize(ref bytes, offset, value.item15);
            offset += Formatter<DefaultResolver, T16>.Default.Serialize(ref bytes, offset, value.item16);
        
            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 4) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item4 = Formatter<DefaultResolver, T4>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 5) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item5 = Formatter<DefaultResolver, T5>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 6) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item6 = Formatter<DefaultResolver, T6>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 7) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item7 = Formatter<DefaultResolver, T7>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 8) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item8 = Formatter<DefaultResolver, T8>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 9) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item9 = Formatter<DefaultResolver, T9>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 10) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item10 = Formatter<DefaultResolver, T10>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 11) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item11 = Formatter<DefaultResolver, T11>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 12) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item12 = Formatter<DefaultResolver, T12>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 13) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item13 = Formatter<DefaultResolver, T13>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 14) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item14 = Formatter<DefaultResolver, T14>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 15) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item15 = Formatter<DefaultResolver, T15>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 16) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item16 = Formatter<DefaultResolver, T16>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}


[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    [Index(4)]
    public T4 item4 = default;
    [Index(5)]
    public T5 item5 = default;
    [Index(6)]
    public T6 item6 = default;
    [Index(7)]
    public T7 item7 = default;
    [Index(8)]
    public T8 item8 = default;
    [Index(9)]
    public T9 item9 = default;
    [Index(10)]
    public T10 item10 = default;
    [Index(11)]
    public T11 item11 = default;
    [Index(12)]
    public T12 item12 = default;
    [Index(13)]
    public T13 item13 = default;
    [Index(14)]
    public T14 item14 = default;
    [Index(15)]
    public T15 item15 = default;
    [Index(16)]
    public T16 item16 = default;
    [Index(17)]
    public T17 item17 = default;
    
    public class Formatter<T,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;
        
            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 17);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
            offset += Formatter<DefaultResolver, T4>.Default.Serialize(ref bytes, offset, value.item4);
            offset += Formatter<DefaultResolver, T5>.Default.Serialize(ref bytes, offset, value.item5);
            offset += Formatter<DefaultResolver, T6>.Default.Serialize(ref bytes, offset, value.item6);
            offset += Formatter<DefaultResolver, T7>.Default.Serialize(ref bytes, offset, value.item7);
            offset += Formatter<DefaultResolver, T8>.Default.Serialize(ref bytes, offset, value.item8);
            offset += Formatter<DefaultResolver, T9>.Default.Serialize(ref bytes, offset, value.item9);
            offset += Formatter<DefaultResolver, T10>.Default.Serialize(ref bytes, offset, value.item10);
            offset += Formatter<DefaultResolver, T11>.Default.Serialize(ref bytes, offset, value.item11);
            offset += Formatter<DefaultResolver, T12>.Default.Serialize(ref bytes, offset, value.item12);
            offset += Formatter<DefaultResolver, T13>.Default.Serialize(ref bytes, offset, value.item13);
            offset += Formatter<DefaultResolver, T14>.Default.Serialize(ref bytes, offset, value.item14);
            offset += Formatter<DefaultResolver, T15>.Default.Serialize(ref bytes, offset, value.item15);
            offset += Formatter<DefaultResolver, T16>.Default.Serialize(ref bytes, offset, value.item16);
            offset += Formatter<DefaultResolver, T17>.Default.Serialize(ref bytes, offset, value.item17);
        
            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();
            
            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }


            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 4) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item4 = Formatter<DefaultResolver, T4>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 5) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item5 = Formatter<DefaultResolver, T5>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 6) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item6 = Formatter<DefaultResolver, T6>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 7) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item7 = Formatter<DefaultResolver, T7>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 8) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item8 = Formatter<DefaultResolver, T8>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 9) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item9 = Formatter<DefaultResolver, T9>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 10) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item10 = Formatter<DefaultResolver, T10>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 11) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item11 = Formatter<DefaultResolver, T11>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 12) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item12 = Formatter<DefaultResolver, T12>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 13) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item13 = Formatter<DefaultResolver, T13>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 14) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item14 = Formatter<DefaultResolver, T14>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 15) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item15 = Formatter<DefaultResolver, T15>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 16) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item16 = Formatter<DefaultResolver, T16>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 17) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item17 = Formatter<DefaultResolver, T17>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}

[ZeroFormattable]
public class ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18> : ZeroFormattableBase {

    [Index(0)]
    public T0 item0 = default;
    [Index(1)]
    public T1 item1 = default;
    [Index(2)]
    public T2 item2 = default;
    [Index(3)]
    public T3 item3 = default;
    [Index(4)]
    public T4 item4 = default;
    [Index(5)]
    public T5 item5 = default;
    [Index(6)]
    public T6 item6 = default;
    [Index(7)]
    public T7 item7 = default;
    [Index(8)]
    public T8 item8 = default;
    [Index(9)]
    public T9 item9 = default;
    [Index(10)]
    public T10 item10 = default;
    [Index(11)]
    public T11 item11 = default;
    [Index(12)]
    public T12 item12 = default;
    [Index(13)]
    public T13 item13 = default;
    [Index(14)]
    public T14 item14 = default;
    [Index(15)]
    public T15 item15 = default;
    [Index(16)]
    public T16 item16 = default;
    [Index(17)]
    public T17 item17 = default;
    [Index(18)]
    public T18 item18 = default;
    
    public class Formatter<T,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18> : Formatter<DefaultResolver, T> where T:ZeroFormattableBase<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>,new() {
        public override int? GetLength() {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, T value) {
            int startOffset = offset;
        
            value.OnPreSerialized();
            
            // Last Index For Version
            offset += ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Serialize(ref bytes, offset, 18);
            offset += Formatter<DefaultResolver, T0>.Default.Serialize(ref bytes, offset, value.item0);
            offset += Formatter<DefaultResolver, T1>.Default.Serialize(ref bytes, offset, value.item1);
            offset += Formatter<DefaultResolver, T2>.Default.Serialize(ref bytes, offset, value.item2);
            offset += Formatter<DefaultResolver, T3>.Default.Serialize(ref bytes, offset, value.item3);
            offset += Formatter<DefaultResolver, T4>.Default.Serialize(ref bytes, offset, value.item4);
            offset += Formatter<DefaultResolver, T5>.Default.Serialize(ref bytes, offset, value.item5);
            offset += Formatter<DefaultResolver, T6>.Default.Serialize(ref bytes, offset, value.item6);
            offset += Formatter<DefaultResolver, T7>.Default.Serialize(ref bytes, offset, value.item7);
            offset += Formatter<DefaultResolver, T8>.Default.Serialize(ref bytes, offset, value.item8);
            offset += Formatter<DefaultResolver, T9>.Default.Serialize(ref bytes, offset, value.item9);
            offset += Formatter<DefaultResolver, T10>.Default.Serialize(ref bytes, offset, value.item10);
            offset += Formatter<DefaultResolver, T11>.Default.Serialize(ref bytes, offset, value.item11);
            offset += Formatter<DefaultResolver, T12>.Default.Serialize(ref bytes, offset, value.item12);
            offset += Formatter<DefaultResolver, T13>.Default.Serialize(ref bytes, offset, value.item13);
            offset += Formatter<DefaultResolver, T14>.Default.Serialize(ref bytes, offset, value.item14);
            offset += Formatter<DefaultResolver, T15>.Default.Serialize(ref bytes, offset, value.item15);
            offset += Formatter<DefaultResolver, T16>.Default.Serialize(ref bytes, offset, value.item16);
            offset += Formatter<DefaultResolver, T17>.Default.Serialize(ref bytes, offset, value.item17);
            offset += Formatter<DefaultResolver, T18>.Default.Serialize(ref bytes, offset, value.item18);

            value.OnPostSerialized();
            
            return offset - startOffset;
        }

        public override T Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize) {
            int startOffset = offset;
            int size;

            T instance = new T();

            instance.OnPreDeserialized();

            // Last Index For Version
            int lastIndex = ZeroFormatter.Formatters.Formatter<DefaultResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.item0 = Formatter<DefaultResolver, T0>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 1) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item1 = Formatter<DefaultResolver, T1>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 2) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item2 = Formatter<DefaultResolver, T2>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 3) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item3 = Formatter<DefaultResolver, T3>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 4) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item4 = Formatter<DefaultResolver, T4>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 5) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }


            instance.item5 = Formatter<DefaultResolver, T5>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 6) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }


            instance.item6 = Formatter<DefaultResolver, T6>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            if (lastIndex < 7) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }


            instance.item7 = Formatter<DefaultResolver, T7>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 8) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item8 = Formatter<DefaultResolver, T8>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 9) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item9 = Formatter<DefaultResolver, T9>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 10) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item10 = Formatter<DefaultResolver, T10>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 11) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item11 = Formatter<DefaultResolver, T11>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 12) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item12 = Formatter<DefaultResolver, T12>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 13) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item13 = Formatter<DefaultResolver, T13>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 14) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item14 = Formatter<DefaultResolver, T14>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 15) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item15 = Formatter<DefaultResolver, T15>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 16) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item16 = Formatter<DefaultResolver, T16>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 17) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item17 = Formatter<DefaultResolver, T17>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            if (lastIndex < 18) {
                instance.OnPostDeserialized();
                byteSize = offset - startOffset;
                return instance;
            }

            instance.item18 = Formatter<DefaultResolver, T18>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            instance.OnPostDeserialized();
            
            byteSize = offset - startOffset;
            return instance;
        }
    }
}

