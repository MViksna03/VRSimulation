using System;
using System.Threading.Tasks.Sources;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PhysicsButton : MonoBehaviour
{
    [SerializeField] private float threshold = 0.1f;
    [SerializeField] private float deadZone = 0.025f;
    [SerializeField] private TextMeshProUGUI StartingText;
    [SerializeField] private TextMeshProUGUI GamingText;
    public string correctBoneName;
    public bool objectbool = true;
    private bool _isPressed;
    private Vector3 _startPos;
    private ConfigurableJoint _joint;
    public string[] bones = { "Cranium Bone", "Femur Bone", "LumbarVertebrae Bone" };

    Timerscript reset;
    
    public UnityEvent onPressed, onReleased;
    void Start()
    {
        _startPos = transform.localPosition;
        _joint = GetComponent<ConfigurableJoint>();
       
    }

    void Update()
    {
        if (!_isPressed && GetValue() + threshold >= 1)
            Pressed();
        if (_isPressed && GetValue() - threshold <= 0)
            Released();
        
    }
    
    
    private float GetValue()
    {
        var value = Vector3.Distance(_startPos, transform.localPosition) / _joint.linearLimit.limit;

        if (Math.Abs(value) < deadZone)
            value = 0;

        return Mathf.Clamp(value, -1f, 1f);
    }

    private void Pressed()
    {
        reset = FindObjectOfType<Timerscript>();
        float resetval = reset.currentTime;
        TextMeshProUGUI texttimer = reset.timertext;
        resetval = 0;
        texttimer.text = resetval.ToString();
        objectbool = false;
        _isPressed = true;
        onPressed.Invoke();
        Debug.Log("Pressed");
        int randomIndex = UnityEngine.Random.Range(0, bones.Length);
        correctBoneName = bones[randomIndex];
        GamingText.text = "Choose The correct bone:" + correctBoneName;
        StartingText.text = "";
    }

    private void Released()
    {
        objectbool = true;
        _isPressed = false;
        onReleased.Invoke();
        Debug.Log("Released");
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}
