#region Using Tags

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

#endregion

/// <summary>
/// BigPapa is the manager of all managers. ABV: bp
/// </summary>
public class BigPapa : MonoBehaviour
{

    //bp singleton
    public static BigPapa x;

    #region Variables
    
    #region Serialised

    /// <summary>
    /// The serialised string array of managers to add to BigP
    /// </summary>
    [SerializeField] private string[] sA_managersToAdd;

    #endregion

    #region Private

    /// <summary>
    /// The list of all the managers attached to bp
    /// </summary>
    Dictionary<string, ManagerBase> s_mbD_managers = new Dictionary<string, ManagerBase>();

    #endregion

    #endregion

    #region Functions

    #region Unity Standards

    private void Awake()
    {
        if (x == null) x = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        Init();
    }

    #endregion

    #region Private Voids

    /// <summary>
    /// Initialise BigPapa
    /// </summary>
    private void Init()
    {
        AddManagers();
        InitialiseAll();
    }

    /// <summary>
    /// Initialise all classess that BigPapa stores
    /// </summary>
    private void InitialiseAll()
    {
        InitialiseManagers();
        InitialiseMisc();
    }

    /// <summary>
    /// Initialises BigPapas manager hoes
    /// </summary>
    private void InitialiseManagers()
    {

        foreach (ManagerBase m in s_mbD_managers.Values)
            m.Init();

    }

    /// <summary>
    /// Initialises the non manager classes
    /// </summary>
    private void InitialiseMisc()
    {

    }

    /// <summary>
    /// Adds all managers listed in sA_managersToAdd
    /// </summary>
    private void AddManagers()
    {
        foreach (string m in sA_managersToAdd)
            AddManager(m);
    }

    /// <summary>
    /// Adds the manager of type T to BigPapa
    /// </summary>
    /// <param name="T">
    /// The manager type to add
    /// </param>
    private void AddManager(string T)
    {
        gameObject.AddComponent(Type.GetType(T));
        s_mbD_managers.Add(T, (ManagerBase)GetComponent(T));
    }

    #endregion

    #region Private Returns


    #endregion

    #region Public Voids


    #endregion

    #region Public Returns

    /// <summary>
    /// Gets a manager from bp
    /// </summary>
    /// <param name="_s_manToGet">
    /// the name of the manager to get
    /// </param>
    /// <returns>
    /// a manager
    /// </returns>
    public ManagerBase GetManager(string _s_manToGet)
    {
        return s_mbD_managers[_s_manToGet];
    }

    #endregion

    #endregion

}