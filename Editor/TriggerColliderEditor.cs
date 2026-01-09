#if HAS_HEALTH_SYSTEM
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TriggerCollider))]
public class TriggerColliderEditor : Editor
{
    SerializedProperty onTriggerEnterCollider;
    SerializedProperty onTriggerStayCollider;
    SerializedProperty onTriggerExitCollider;

    SerializedProperty onTriggerEnterColliderInt;
    SerializedProperty onTriggerStayColliderInt;
    SerializedProperty onTriggerExitColliderInt;

    SerializedProperty onEnterType;
    SerializedProperty onStayType;
    SerializedProperty onExitType;

    SerializedProperty damageAmount;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        onTriggerEnterCollider = serializedObject.FindProperty("onTriggerEnterCollider");
        onTriggerStayCollider = serializedObject.FindProperty("onTriggerStayCollider");
        onTriggerExitCollider = serializedObject.FindProperty("onTriggerExitCollider");

        onTriggerEnterColliderInt = serializedObject.FindProperty("onTriggerEnterColliderInt");
        onTriggerStayColliderInt = serializedObject.FindProperty("onTriggerStayColliderInt");
        onTriggerExitColliderInt = serializedObject.FindProperty("onTriggerExitColliderInt");
        onEnterType = serializedObject.FindProperty("onEnterType");
        onStayType = serializedObject.FindProperty("onStayType");
        onExitType = serializedObject.FindProperty("onExitType");

        damageAmount  = serializedObject.FindProperty("damageAmount");
    }

    public override void OnInspectorGUI() 
    {
        serializedObject.Update();

        EditorGUILayout.LabelField("Events", EditorStyles.boldLabel);

        EditorGUILayout.Space();

        EditorGUILayout.PropertyField(onEnterType);
        switch (onEnterType.enumValueIndex)
        {
            case (0):
                EditorGUILayout.PropertyField(onTriggerEnterCollider, new GUIContent("OnTriggerEnter"));
                break;
            case (1):
                EditorGUILayout.PropertyField(onTriggerEnterColliderInt, new GUIContent("OnTriggerEnter"));
                break;
            case (2):
                EditorGUILayout.PropertyField(onTriggerEnterCollider, new GUIContent("OnTriggerEnter"));
                EditorGUILayout.PropertyField(onTriggerEnterColliderInt, new GUIContent("OnTriggerEnter"));
                break;
        }

        EditorGUILayout.Space();

        EditorGUILayout.PropertyField(onStayType);
        switch (onStayType.enumValueIndex)
        {
            case (0):
                EditorGUILayout.PropertyField(onTriggerStayCollider, new GUIContent("OnTriggerStay"));
                break;
            case (1):
                EditorGUILayout.PropertyField(onTriggerStayColliderInt, new GUIContent("OnTriggerStay"));
                break;
            case (2):
                EditorGUILayout.PropertyField(onTriggerStayCollider, new GUIContent("OnTriggerStay"));
                EditorGUILayout.PropertyField(onTriggerStayColliderInt, new GUIContent("OnTriggerStay"));
                break;
        }

        EditorGUILayout.Space();

        EditorGUILayout.PropertyField(onExitType);
        switch (onExitType.enumValueIndex) 
        {
            case (0):
                EditorGUILayout.PropertyField(onTriggerExitCollider, new GUIContent("OnTriggerExit"));
                break;
            case(1):
                EditorGUILayout.PropertyField(onTriggerExitColliderInt, new GUIContent("OnTriggerExit"));
                break;
            case(2):
                EditorGUILayout.PropertyField(onTriggerExitCollider, new GUIContent("OnTriggerExit"));
                EditorGUILayout.PropertyField(onTriggerExitColliderInt, new GUIContent("OnTriggerExit"));
                break;
        }

        EditorGUILayout.Space();

        EditorGUILayout.LabelField("Simple Health System", EditorStyles.boldLabel);
        EditorGUILayout.PropertyField(damageAmount);

        serializedObject.ApplyModifiedProperties();
    }
}
#endif
