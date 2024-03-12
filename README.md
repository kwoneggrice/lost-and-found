# 🖥 수지구 분실물 센터
- 용인시 수지구에서 발생한 분실물을 관리하는 프로그램

# 🔧 구현 기능
☑ 전체 분실물 조회 기능
- 등록된 모든 분실물을 조회할 수 있습니다.

☑ 특정 날짜 분실물 조회 기능
- 특정 날짜에 등록된 모든 분실물을 조회할 수 있습니다.

☑ 분실물 등록 기능
- `분실물 종류`, `분실 위치`, `습득자 이름`, `습득 시간`, `수령자 이름`을 저장할 수 있습니다.
  - `분실 위치`는 사용자가 입력할 수 없게 콤보 박스로 선택할 수 있습니다.

☑ 분실물 정보 수정 기능
- 분실물 목록에서 선택한 분실물 정보를 수정할 수 있습니다.
  - `분실물 종류`, `분실 위치`, `습득자 이름`, `습득 시간`, `수령자 이름`을 수정할 수 있습니다.

☑ 분실물 정보 삭제 기능
- 분실물 목록에서 선택한 분실물 정보를 삭제할 수 있습니다.

☑ 분실물 수령 기능
- `수령자 이름`을 입력하여 분실물 수령을 할 수 있습니다.
  - `수령 시간`은 분실물을 수령한 시점으로 자동 등록됩니다.

☑ 지역별 분실물 비율 원형차트 기능
- `지역별 분실물`의 비율로 원형차트로 보여줍니다.

☑ 분실물 종류 비율 원형차트 기능
- `분실물 종류`의 비율로 원형차트를 보여줍니다.

☑ 분실물 회수 비율 원형차트 기능
- `분실물 회수`의 비율로 원형차트를 보여줍니다.

☑ 원형차트 새로고침 기능
- 수정되거나 새로 입력된 분실물을 포함하여 새로운 원형차트를 보여줍니다.

# 📚 스택
- .NET 8.0
- WinForms
- SQL Server 2022
- Entity Framework Core(ORM)
- LINQ
- Dependency Injection

# 📦 패키지
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- WinForms.DataVisualization

# 🎞️ 동영상
https://github.com/kwoneggrice/lost-and-found/assets/73627446/547f361d-37c8-4a4c-ac6a-f79129bc5a5c

# 📖 유스케이스 다이어그램
![스크린샷 2024-03-13 000610](https://github.com/kwoneggrice/lost-and-found/assets/73627446/8bf300ca-1da0-4584-aa7b-93501915c5b8)

# 💾 ERD
![스크린샷 2024-03-12 235736](https://github.com/kwoneggrice/lost-and-found/assets/73627446/57873458-cf13-4575-9c95-d55edc8086b8)
