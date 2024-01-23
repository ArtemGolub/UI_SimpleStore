using UnityEngine;
using UnityEngine.UI;

public class CloseStore : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;
    [SerializeField] private Button _btnClose;

    private void Start()
    {
        _btnClose.onClick.AddListener(Close);
    }

    void Close()
    {
        _canvas.enabled = false;
    }
}
