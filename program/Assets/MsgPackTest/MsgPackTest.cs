using System.Collections.Generic;
using MessagePack;
using MessagePack.Formatters;
using MessagePack.Resolvers;
using UnityEngine;

public class TestData
{
        public int value1;
        public string value2;
        public List<Wrapper> typeless = new List<Wrapper>();
}

public class Wrapper
{
        public int TestGetter { get; set; }
        [IgnoreMember]
        public int TestGetter2 { get; set; }

        private int innerGetterValue;
        public int TestGetter3
        {
                get { return innerGetterValue; }
                set { innerGetterValue = value; }
        }

        [MessagePackFormatter(typeof(TypelessFormatter))]
        public object innerData;
}

public class InnerDataBase
{
        public string baseValue;
}

public class InnerData1 : InnerDataBase
{
        public string inner1;
}

public class InnerData2 : InnerDataBase
{
        public int inner2;
}

//abstract일 경우:[Union(0, typeof(InnerData4))]
[MessagePackObject]
public class ContractDataBase
{
        [Key(0)]
        public string baseValue;
}

[MessagePackObject]
public class InnerData4 : ContractDataBase
{
        [Key(1)]
        public string inner1;
}

public class MsgPackTest
{
#if UNITY_EDITOR
        [UnityEditor.MenuItem("MessagePack/Test")]
        public static void Test()
        {
                TestData t = new TestData();
                t.value1 = 5;
                t.value2 = "blah";

                Wrapper wrapper = new Wrapper();
                wrapper.TestGetter = 3;
                wrapper.TestGetter2 = 33;
                wrapper.TestGetter3 = 333;
                
                InnerData1 innerData1 = new InnerData1 {inner1 = "this is inner data",baseValue = "first base value"};
                wrapper.innerData = innerData1;
                t.typeless.Add(wrapper);

                wrapper = new Wrapper();
                InnerData2 innerData2 = new InnerData2 {inner2 = 80, baseValue = "second base value"};
                wrapper.innerData = innerData2;
                t.typeless.Add(wrapper);

                var serialized = MessagePackSerializer.Serialize(t);
                var deserialized = MessagePackSerializer.Deserialize<TestData>(serialized);

                Debug.Log(deserialized.value1 + "," + deserialized.value2);

                if (deserialized.typeless == null)
                {
                        Debug.Log("typeless:null");
                }
                else
                {
                        Debug.Log("typeless:OK");
                        for (int i = 0; i < deserialized.typeless.Count; ++i)
                        {
                                var implemented = deserialized.typeless[i];

                        }
                }
        }

        [UnityEditor.MenuItem("MessagePack/Test2")]
        public static void Test2()
        {
                InnerData1 data1 = new InnerData1();
                data1.baseValue = "this is base";
                data1.inner1 = "blahblah blah";
                
                InnerData4 data4 = new InnerData4();
                data4.baseValue = "this is base";
                data4.inner1 = "blahblah blah";

                string byteFilePath = System.IO.Path.Combine(Application.dataPath, "MsgPackTest/testByte.bytes");
                string textFilePath = System.IO.Path.Combine(Application.dataPath, "MsgPackTest/testByte.txt");
                string contractByteFilePath = System.IO.Path.Combine(Application.dataPath, "MsgPackTest/contractTestByte.bytes");

                var bytes = MessagePackSerializer.Serialize(data1);
                if (System.IO.File.Exists(byteFilePath) == false)
                {
                        using (System.IO.File.Create(byteFilePath))
                        {
                        }
                }
                System.IO.File.WriteAllBytes(byteFilePath, bytes);

                var contractBytes = MessagePackSerializer.Serialize(data4);
                if (System.IO.File.Exists(contractByteFilePath) == false)
                {
                        using (System.IO.File.Create(contractByteFilePath))
                        {
                        }
                }
                System.IO.File.WriteAllBytes(contractByteFilePath, contractBytes);

                var json = MessagePackSerializer.SerializeToJson(bytes);
                if (System.IO.File.Exists(textFilePath) == false)
                {
                        using (System.IO.File.Create(textFilePath))
                        {
                        }
                }
                System.IO.File.WriteAllText(textFilePath, json);


        }
#endif
}

public class Startup
{
        static bool serializerRegistered = false;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void Initialize()
        {
                if (!serializerRegistered)
                {
                        StaticCompositeResolver.Instance.Register(
                                MessagePack.Resolvers.GeneratedResolver.Instance,
                                MessagePack.Resolvers.StandardResolver.Instance
                        );

                        var option = MessagePackSerializerOptions.Standard.WithResolver(StaticCompositeResolver.Instance);

                        option = option.WithResolver(ContractlessStandardResolver.Instance);

                        MessagePackSerializer.DefaultOptions = option;
                        serializerRegistered = true;
                }
        }

#if UNITY_EDITOR


        [UnityEditor.InitializeOnLoadMethod]
        static void EditorInitialize()
        {
                Initialize();
        }

#endif
}