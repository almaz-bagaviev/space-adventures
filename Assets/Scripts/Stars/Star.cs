using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Stars
{
    public class Star : MonoBehaviour
    {
        public void Initial(int obj, Text text, string key)
        {
            text = gameObject.GetComponent<Text>();
            obj = PlayerPrefs.GetInt(key, obj);
        }

        public void Shop(int obj, Text textObj)
        {
            textObj.text = obj.ToString();
        }
    }
}