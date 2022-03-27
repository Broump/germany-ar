using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Net;
using System.IO;
public class changeText : MonoBehaviour
{

    private string jsonURL;

    public TMP_Text textDisplay;

    void Start()
    {
        writeText();
        
    }

    public void writeText()
    {
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://germany-ar-api.herokuapp.com/federal-states");
      HttpWebResponse response = (HttpWebResponse)request.GetResponse();
      StreamReader reader =  new StreamReader(response.GetResponseStream());
      string json = reader.ReadToEnd();
      StateClass stateClass = JsonUtility.FromJson<StateClass>(json);

      foreach (StateList x in stateClass.states)
        {
            if (x.name == transform.parent.parent.name)
            {
                textDisplay.text = "Name: " + x.name + "\nFläche: " + x.flaeche + "\nEinwohner: " + x.einwohner + "\nMinisterpräsident:in: " + x.ministerpraesident;
            }
        }
    }
}
