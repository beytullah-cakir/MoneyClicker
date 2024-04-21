using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using System;

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
    private OnMouseClickListener _onMouseClickListener;
    [SerializeField]
    private BillManager _billmanager;
    [SerializeField]
    private UIManager _u�manager;
    [SerializeField]
    private FarmManager _farmmanager;
    [SerializeField]
    private ButtonManager _buttonmanager;

    private float _uiCheckMoneyTime;

    public int TextPopupPoolCount { get; private set; }

    public static GameManager Instance { get; private set; }

    public Clicker Clicker { get; private set; }

    public MoneyManager MoneyManager { get; private set; }

    public Formatter Formatter { get; private set; }

    public Pool Pool { get; private set; }

    public EventHandler EventHandler { get; private set; }

    public BillManager BillManager { get; private set; }

    

    public float UICheckMoneyTime { get { return _uiCheckMoneyTime; } }

    public OnMouseClickListener OnMouseClickListener { get; private set; }

    public UIManager UIManager { get; private set; }

    public FarmManager FarmManager { get; private set; }

    public ButtonManager ButtonManager {  get; private set; }
 
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
        ButtonManager = _buttonmanager;
        OnMouseClickListener = _onMouseClickListener;
        BillManager = _billmanager;
        UIManager = _u�manager;
        FarmManager= _farmmanager;
        

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
