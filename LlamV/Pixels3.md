# Pixels

## 構造

ジェネリックにしてるけど、いろいろ制約強くて  
結局T4べた書きしている件

そんなこんなで書き直す可能性大

| namespace | Class | Description |
|:---|:---|:---|
| Pixels | Pixel |
| Pixels | PixelMap |
| Pixels | PixelFactory |
| Pixels | PixelFormat |
| Pixels.Stream | PixelStream |
| Pixels.Math | PixelMathEx |
| Pixels.Math | PixelFilter |
| Pixels.Math | BMPColor |
| Pixels.Math | INEQUALITY |
| Pixels.Math | LineMath |

### Pixel

| Key | Description |
|:---|:---|
| this[x] |
| this[x,y] |
| this[string map] |
| Map(string map) |
| Clone() |
| AddMap | Mapを追加します（viewerでのtrim用)

### PixelStream


| Name | Option | Map | Clone | Description |
|:---|:---|:---|:---|:---|
| Read      | -       | 反映 | Create(w,h,d) | 切り出し |
| Write     |  | Full(T[]) | Create(w,h,d) |  |
| WriteText |  | Full(T[]) | Create(w,h,d) |  |


### PixelMath

** 四則演算 + キャスト **

| Name | Option | Map | Clone | Description |
|:---|:---|:---|:---|:---|
| (Cast)  | -      | reflect | Create(map,d) | |
| Add     | T      | reflect | Clone |  |
| AddSelf | T      | ↑       | Self  |  |
| Sub     | T      | reflect | Clone |  |
| SubSelf | T      | ↑       | Self  |  |
| Mul     | T      | reflect | Clone |  |
| Mul     | double | ↑       | Clone |  |
| MulSelf | T      | ↑       | Self  |  |
| MulSelf | double | ↑       | Self  |  |
| Div     | T      | reflect | Clone |  |
| Div     | double | ↑       | Clone |  |
| DivSelf | T      | ↑       | Self  |  |
| DivSelf | double | ↑       | Self  |  |
| ShiftLeft      | T | ↑     | Clone |  |
| ShiftLeftSelf  | T | ↑     | Self  |  |
| ShiftRight     | T | ↑     | Clone |  |
| ShiftRightSelf | T | ↑     | Self  |  |

** 統計命令 **

| Name | Option | Map | Clone | Description |
|:---|:---|:---|:---|:---|
| Count      | src, thr      | reflect | - |  |
| Count      | src1,src2,thr | ↑       | - | 差分のカウント |
| CountBayer | src, thr      | reflect | - |  |
| CountBayer | src1,src2,thr | ↑       | - |  |
| Average        |     | reflect | - |  |
| AverageBayer   |     | reflect | - |  |
| Deviation      |     | reflect | - |  |
| DeviationBayer |     | reflect | - |  |
| Signal         |     | reflect | - |  |
| SignalBayer    |     | reflect | - |  |
| AverageV       |     | reflect | - | V方向 Hラインプロファイル |
| AverageH       |     | reflect | - | H方向 Vラインプロファイル |

** LineMath **


### PixelFilter

Selfがついているものは破壊的変更

| Name | Option | Map | Clone | Description |
|:---|:---|:---|:---|:---|
| Cut          | -       | 反映 | Create(w,h,d) | 切り出し |
| Cut          | x,y,w,h | Full | Create(w,h,d) |  |
| Stagger      |  | reflect | 引数(mapあわさないと死にます) | 右正, 奇数行対象 |
| StaggerL     |  | ↑ | Clone | ↑ |
| StaggerR     |  | ↑ | Clone | ↑ |
| StaggerLSelf |  | ↑ | - | ↑ |
| StaggerRSelf |  | ↑ | - | ↑ |
| FilterAverageV     |  | ↑ | Clone | AverageV使用して引き伸ばし |
| FilterAverageH     |  | ↑ | Clone | AverageH使用して引き伸ばし |
| FilterAverageVSelf |  | ↑ | Self |  |
| FilterAverageHSelf |  | ↑ | Self |  |
| StaggerRSelf |  | ↑ | - | ↑ |
| FiletrMedian |  | ↑ | - | ↑ |
