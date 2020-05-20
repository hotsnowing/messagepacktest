# mpc
./mpc/osx/mpcode -i program/Assembly-CSharp.csproj -o program/Assets/MsgPackTest/Generated.cs

# ProjectSetting
API Compatibility Level : .NET 4.x
Typeless API를 사용하기 위함. Typeless API를 사용할 필요 없다면 

# 추가 처리한 부분
TypelessFormatter.cs
AsymmetricKeyHashTable.cs
를 디파인(UNITY_2018_3_OR_NEWER)을 주석처리함.
https://github.com/neuecc/MessagePack-CSharp/issues/559

# 용량 비교
json >  contractless(어트리뷰트 사용하지 않고 ContractlessStandardResolver를 사용) > contract (어트리뷰트 사용)