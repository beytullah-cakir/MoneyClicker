using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Clicker _clicker;
    [SerializeField]
    private int _textPopupPoolCount;
    [SerializeField]
    private TextPopup _textPopupPrefab;
    [SerializeField]
    private GameObject _textPopupParent;
    [SerializeField]
    private Pool _pool;
    [SerializeField]
    private EventHandler _eventHandler;
    [SerializeField]

    private AbstractBill _abstarctbill;

    private float _uiCheckMoneyTime;

    public int TextPopupPoolCount {  get; private set; }

    public static GameManager Instance { get; private set; } 

    public Clicker Clicker { get; private set; }

    public MoneyManager MoneyManager { get; private set; }

    public Formatter Formatter { get; private set; }

    public Pool Pool { get; private set; }

    public EventHandler EventHandler { get; private set; }

    public AbstractBill AbstractBill { get; private set; }

    public float UICheckMoneyTime { get { return _uiCheckMoneyTime; } }

    private void Awake()
    {
        Instance = this;

        MoneyManager = new MoneyManagerImpl(Formatter);
    }

    void Start()
    {
        Clicker = _clicker;
        TextPopupPoolCount = _textPopupPoolCount;
        Pool = _pool;
        EventHandler = _eventHandler;
        Formatter = new BasicFormatter();
        

        _pool.CreateNTimes(_textPopupPrefab, _textPopupParent.transform, _textPopupPoolCount);
    }

    void Update()
    {
        
    }

    public string GetMoney()
    {
        return null;
    }

    public NumberFormat GetNumberFormat()
    {
        return NumberFormat.NATURAL;
    }
}
