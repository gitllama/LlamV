# Pixels

## �\��

�W�F�l���b�N�ɂ��Ă邯�ǁA���낢�됧�񋭂���  
����T4�ׂ��������Ă��錏

����Ȃ���Ȃŏ��������\����

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
| AddMap | Map��ǉ����܂��iviewer�ł�trim�p)

### PixelStream


| Name | Option | Map | Clone | Description |
|:---|:---|:---|:---|:---|
| Read      | -       | ���f | Create(w,h,d) | �؂�o�� |
| Write     |  | Full(T[]) | Create(w,h,d) |  |
| WriteText |  | Full(T[]) | Create(w,h,d) |  |


### PixelMath

** �l�����Z + �L���X�g **

| Name | Option | Map | Clone | Description |
|:---|:---|:---|:---|:---|
| (Cast)  | -      | reflect | Create(map,d) | |
| Add     | T      | reflect | Clone |  |
| AddSelf | T      | ��       | Self  |  |
| Sub     | T      | reflect | Clone |  |
| SubSelf | T      | ��       | Self  |  |
| Mul     | T      | reflect | Clone |  |
| Mul     | double | ��       | Clone |  |
| MulSelf | T      | ��       | Self  |  |
| MulSelf | double | ��       | Self  |  |
| Div     | T      | reflect | Clone |  |
| Div     | double | ��       | Clone |  |
| DivSelf | T      | ��       | Self  |  |
| DivSelf | double | ��       | Self  |  |
| ShiftLeft      | T | ��     | Clone |  |
| ShiftLeftSelf  | T | ��     | Self  |  |
| ShiftRight     | T | ��     | Clone |  |
| ShiftRightSelf | T | ��     | Self  |  |

** ���v���� **

| Name | Option | Map | Clone | Description |
|:---|:---|:---|:---|:---|
| Count      | src, thr      | reflect | - |  |
| Count      | src1,src2,thr | ��       | - | �����̃J�E���g |
| CountBayer | src, thr      | reflect | - |  |
| CountBayer | src1,src2,thr | ��       | - |  |
| Average        |     | reflect | - |  |
| AverageBayer   |     | reflect | - |  |
| Deviation      |     | reflect | - |  |
| DeviationBayer |     | reflect | - |  |
| Signal         |     | reflect | - |  |
| SignalBayer    |     | reflect | - |  |
| AverageV       |     | reflect | - | V���� H���C���v���t�@�C�� |
| AverageH       |     | reflect | - | H���� V���C���v���t�@�C�� |

** LineMath **


### PixelFilter

Self�����Ă�����͔̂j��I�ύX

| Name | Option | Map | Clone | Description |
|:---|:---|:---|:---|:---|
| Cut          | -       | ���f | Create(w,h,d) | �؂�o�� |
| Cut          | x,y,w,h | Full | Create(w,h,d) |  |
| Stagger      |  | reflect | ����(map���킳�Ȃ��Ǝ��ɂ܂�) | �E��, ��s�Ώ� |
| StaggerL     |  | �� | Clone | �� |
| StaggerR     |  | �� | Clone | �� |
| StaggerLSelf |  | �� | - | �� |
| StaggerRSelf |  | �� | - | �� |
| FilterAverageV     |  | �� | Clone | AverageV�g�p���Ĉ����L�΂� |
| FilterAverageH     |  | �� | Clone | AverageH�g�p���Ĉ����L�΂� |
| FilterAverageVSelf |  | �� | Self |  |
| FilterAverageHSelf |  | �� | Self |  |
| StaggerRSelf |  | �� | - | �� |
| FiletrMedian |  | �� | - | �� |
