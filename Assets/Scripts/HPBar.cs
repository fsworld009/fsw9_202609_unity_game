using UnityEngine;

public class HPBar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float barWitdh;
    private float hpRate;
    private RectTransform hpImageTransform;

    [SerializeField] private bool rotateWithCamera = true;

    void OnEnable()
    {
        hpImageTransform = transform.Find("CurrentHP").GetComponent<RectTransform>();
        barWitdh = hpImageTransform.rect.width;
        hpRate = 1;
        SetHpRate(1);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if (rotateWithCamera) { 
            //　カメラと同じ向きに設定
            transform.rotation = Camera.main.transform.rotation;
        }
    }

    public void SetHpRate(float rate)
    {
        hpRate = rate;
        hpImageTransform.sizeDelta = new Vector2(barWitdh * hpRate, hpImageTransform.rect.height);
    }
}
