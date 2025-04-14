using UnityEngine; // Unity 엔진 네임스페이스 가져오기

/// <summary>
/// 게임 전체의 관리자 역할을 하는 클래스입니다.
/// </summary>
public class Manager : MonoBehaviour
{
    /// <summary>
    /// 게임 시작 시 자동으로 호출되는 메소드입니다.
    /// </summary>
    private void Awake()
    {
        SetLogManager();

        SetDataManager(); // 데이터 매니저 초기화

    }

    /// <summary>
    /// 데이터 매니저에 대한 정적 접근을 제공하는 프로퍼티입니다.
    /// 읽기는 어디서나 가능하지만 설정은 이 클래스 내부에서만 가능합니다.
    /// </summary>
    public static DataManager Data { get; private set; }

    /// <summary>
    /// 현재 GameObject의 자식 컴포넌트 중에서 DataManager를 찾아
    /// 정적 프로퍼티에 할당하는 메소드입니다.
    /// </summary>
    private void SetDataManager()
    {
        Data = transform.GetComponentInChildren<DataManager>();
        Data.Initialize();
    }

    public static LogManager Log { get; private set; }

    public void SetLogManager()
    {
        Log = transform.GetComponentInChildren<LogManager>();
        Log.Initialize();
    }
}