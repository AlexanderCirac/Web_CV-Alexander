using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AlexanderCA.Tools
{
    public static class ToolsAlex
    {
        public static RectTransform GetRectTransform(this Transform t)
        {
            return t as RectTransform;
        }
    }
}
