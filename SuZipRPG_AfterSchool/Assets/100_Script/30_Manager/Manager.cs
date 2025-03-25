using UnityEngine; // Unity ���� ���ӽ����̽� ��������

/// <summary>
/// ���� ��ü�� ������ ������ �ϴ� Ŭ�����Դϴ�.
/// </summary>
public class Manager : MonoBehaviour
{
    /// <summary>
    /// ���� ���� �� �ڵ����� ȣ��Ǵ� �޼ҵ��Դϴ�.
    /// </summary>
    private void Awake()
    {
        SetDataManager(); // ������ �Ŵ��� �ʱ�ȭ
    }

    /// <summary>
    /// ������ �Ŵ����� ���� ���� ������ �����ϴ� ������Ƽ�Դϴ�.
    /// �б�� ��𼭳� ���������� ������ �� Ŭ���� ���ο����� �����մϴ�.
    /// </summary>
    public static DataManager Data { get; private set; }

    /// <summary>
    /// ���� GameObject�� �ڽ� ������Ʈ �߿��� DataManager�� ã��
    /// ���� ������Ƽ�� �Ҵ��ϴ� �޼ҵ��Դϴ�.
    /// </summary>
    private void SetDataManager()
    {
        Data = transform.GetComponentInChildren<DataManager>();
        Data.Initialize();
    }
}