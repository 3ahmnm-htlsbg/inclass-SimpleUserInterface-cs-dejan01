using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleUserInterface : MonoBehaviour
{
    public InputField InputField_name;
    public Button Button_name;
    public Text Name_result;

    public Text Number_varA;
    public int counter;

    public void CopyText()
    {
        Name_result.text = InputField_name.text;
    }

    public void CountUp(){
        counter++;
        Number_varA.text = counter.ToString();
    }

}
