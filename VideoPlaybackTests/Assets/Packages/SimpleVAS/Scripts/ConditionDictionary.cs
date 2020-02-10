using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SimpleVAS
{
    public class ConditionDictionary : MonoBehaviour {

	    public List<string> conditions = new List<string>(); 
	    public Text conditionOrder;

	    public static string[] selectedOrder;

	    // Use this for initialization
	    void Start () {
		    //string[] items = conditionOrder.text.Split(' ');
	    }

	    public void OnNextButtonPressed () {

		    selectedOrder = conditionOrder.text.Split(' ');
            
		    for (int i = 0; i < selectedOrder.Length; i++) {
                if (selectedOrder [i] == "1") selectedOrder[i] = conditions[i];
			    if (selectedOrder [i] == "2") selectedOrder[i] = conditions[i];
				if (selectedOrder[i] == "3") selectedOrder[i] = conditions[i];
				if (selectedOrder[i] == "4") selectedOrder[i] = conditions[i];

			}

		}
    }

}