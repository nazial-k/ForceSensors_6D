using UnityEngine;
using UnityEngine.UI;

public class PositionUI : MonoBehaviour
{
    public Text positionText;

    void Update()
    {
        // Get the current position of the object
        Vector3 position = transform.position;

        // Update the text of the UI Text element
        positionText.text = "Force Origin: \n" + position.ToString();
    }
}