using System;
using UnityEngine;

namespace Utils
{
    public static class JsonHelper
    {
        public static T[] FromJson<T>(string json)
        {
            Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
            return wrapper.Cards;
        }
        
        [Serializable]
        private class Wrapper<T>
        {
            public T[] Cards;
        }

        public static string FixJson(string value)
        {
            value = "{\"Cards\":" + value + "}";
            return value;
        }
    }
}