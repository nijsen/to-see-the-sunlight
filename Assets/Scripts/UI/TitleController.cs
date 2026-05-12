using UnityEngine;
using TMPro; // Important: Include the TMP namespace

/*
 * TitleController
 * ---------
 * The class file is utilized for the text and font of the title text.
 */

public class TitleController : MonoBehaviour
{
    public TextMeshProUGUI titleText;

    void Start()
    {
        titleText.text = "To See the Sunlight";
        titleText.fontSize = 75;
    }
}
