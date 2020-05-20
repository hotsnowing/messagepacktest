# MessagePack
- 버전 : v2.1.115
- 깃헙 : https://github.com/neuecc/MessagePack-CSharp/

# mpc
```
program/mpc -i program/Assembly-CSharp.csproj -o program/Assets/MsgPackTest/Generated.cs
```
- 실행안되면 파일 권한 설정 필요.
- typelessAPI로 contract 어트리뷰트 붙이지 않는다면 코드 제너레이팅을 하지 않아도 됨.

# ProjectSetting
API Compatibility Level : .NET 4.x
Typeless API를 사용하기 위함. Typeless API를 사용할 필요 없다면 2.0으로 유지해도 괜찮음.

# 추가 처리한 부분

- TypelessFormatter.cs
AsymmetricKeyHashTable.cs
를 디파인(UNITY_2018_3_OR_NEWER)을 주석처리함.
https://github.com/neuecc/MessagePack-CSharp/issues/559

- TypelessFormatter의 생성자를 public으로 변경.

- MsgPackTest.cs에 있는 Startup 클래스는 깃헙 README에 있는 클래스와 같은 내용에
```
option = option.WithResolver(ContractlessStandardResolver.Instance);
```
한 줄을 추가하였음.(contractless 타입을 사용하기 위함. 사용할 필요 없다면 빼도 됨)

# 용량 비교
json >  contractless(어트리뷰트 사용하지 않고 ContractlessStandardResolver를 사용) > contract (어트리뷰트 사용)

- MsgPackTest.cs에 용량별 비교하는 코드와 Typeless 테스트하는 코드가 있음.
- 유니티메뉴에 MessagePack/Test, Test2로 진행.