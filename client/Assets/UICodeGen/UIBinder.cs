﻿using System;
using UnityEngine;
using UnityEngine.UI;

public enum CodeGenObjectType
        {
            Type = CodeGenObjectType.Unknown;
            Debug.LogError(string.Format("UIBinder: Invalid object name to generated code, {0} ", gameObject.name));
        }
    {
        var c = name[0];
        return Char.IsLetter( c) || c == '_' ;        
    }
                if (trans.gameObject.GetComponent<UIBinder>() == null)
                {
                    trans.gameObject.AddComponent<UIBinder>();
                }

        if (go.GetComponent<Dropdown>() != null)
        {
            return CodeGenObjectType.GenAsDropdown;
        }