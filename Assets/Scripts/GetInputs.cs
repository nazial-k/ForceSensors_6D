using UnityEngine;
using UnityEngine.UI;

public class GetInputs : MonoBehaviour
{

    public InputField minInput;
    public InputField maxInput;
    public Text mintxt;
    public Text maxtxt;

    void Start()
    {
        minInput.onEndEdit.AddListener(UpdateMin);
        maxInput.onEndEdit.AddListener(UpdateMax);
    }

    void Update()
    {
        mintxt.text = SensorReadings.minForce.ToString();
        maxtxt.text = SensorReadings.maxForce.ToString();
    }

    void UpdateMin(string minValue){
        if(float.TryParse(minValue, out float parsedVal)){
            SensorReadings.minForce = parsedVal;
            if(SensorReadings.minForce>SensorReadings.maxForce){ //ensure Min < Max
                SensorReadings.maxForce = SensorReadings.minForce+500.0f;
            }
        }
    }
    void UpdateMax(string maxValue){
        if(float.TryParse(maxValue, out float parsedVal)){
            SensorReadings.maxForce = parsedVal;
            if(SensorReadings.maxForce<SensorReadings.minForce){ //ensure Max > Min
                SensorReadings.minForce = SensorReadings.maxForce-500.0f;
            }
        }
    }
}
