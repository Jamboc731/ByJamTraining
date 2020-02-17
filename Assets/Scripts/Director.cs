using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Director : MonoBehaviour
{
    // Variables
    #region Serialized

    [SerializeField] private string[] sA_managersToAdd;

    #endregion

    #region private

    Dictionary<string, ManagerBase> D_managers = new Dictionary<string, ManagerBase>();
    
    #endregion
    public void Init()
    {

    }

    public ManagerBase GetManager()
    {
        return D_managers[sA_managersToAdd[0]];
    }

    public ManagerBase GetManager(string _s_key)
    {
        return D_managers[_s_key];
    }

    public string GetAvailableKey()
    {
        foreach (string a in D_managers.Keys)
            if (D_managers[a] == null)
                return a;
        return "";
    }

    private void AddManagers()
    {
        foreach (string m in sA_managersToAdd)
            AddManager(m);
    }

    private void AddManager(string T)
    {
        gameObject.AddComponent(Type.GetType(T));
        D_managers.Add(T, (ManagerBase)GetComponent(T));
    }
}
