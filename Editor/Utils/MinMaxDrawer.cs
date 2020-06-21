using UnityEngine;
using UnityEditor;

namespace lisandroct.Core.Utils {
    [CustomPropertyDrawer(typeof(MinMaxAttribute))]
    public class MinMaxDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            MinMaxAttribute minMax = attribute as MinMaxAttribute;
            if(property.propertyType == SerializedPropertyType.Vector2 || property.propertyType == SerializedPropertyType.Vector2Int) {
                float valueWidth = 40;

                var minRect = new Rect(position.x, position.y, valueWidth, position.height);
                var sliderRect = new Rect(minRect.xMax + 5, position.y, position.width - valueWidth * 2 - 10, position.height);
                var maxRect = new Rect(sliderRect.xMax + 5, position.y, valueWidth, position.height);

                if(property.propertyType == SerializedPropertyType.Vector2) {
                    float min = property.vector2Value.x;
                    float max = property.vector2Value.y;

                    min = EditorGUI.FloatField(minRect, min);
                    EditorGUI.MinMaxSlider(sliderRect, ref min, ref max, minMax.MinLimit, minMax.MaxLimit);
                    max = EditorGUI.FloatField(maxRect, max);

                    min = Mathf.Clamp(min, minMax.MinLimit, Mathf.Min(minMax.MinTopLimit, max));
                    max = Mathf.Clamp(max, Mathf.Max(minMax.MaxBottomLimit, min), minMax.MaxLimit);

                    property.vector2Value = new Vector2(min, max);
                } else {
                    float min = property.vector2IntValue.x;
                    float max = property.vector2IntValue.y;

                    min = EditorGUI.IntField(minRect, (int) min);
                    EditorGUI.MinMaxSlider(sliderRect, ref min, ref max, minMax.MinLimit, minMax.MaxLimit);
                    max = EditorGUI.IntField(maxRect, (int) max);

                    min = Mathf.Clamp(min, minMax.MinLimit, Mathf.Min(minMax.MinTopLimit, max));
                    max = Mathf.Clamp(max, Mathf.Max(minMax.MaxBottomLimit, min), minMax.MaxLimit);

                    property.vector2IntValue = new Vector2Int((int)min, (int)max);
                }
            } else {
                EditorGUI.LabelField(position, "Use MinMax with Vector2 or Vector2Int.");
            }

            EditorGUI.EndProperty();
        }
    }
}