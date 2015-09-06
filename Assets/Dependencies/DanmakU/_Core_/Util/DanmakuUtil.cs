﻿// Copyright (c) 2015 James Liu
//	
// See the LISCENSE file for copying permission. 

using UnityEngine;

namespace Hourai.DanmakU {

    /// <summary>
    /// A set of utility functions that can be quite useful when using Hourai.DanmakU
    /// </summary>
    public static class DanmakuUtil {

        public static float AngleBetween2D(Vector2 v1, Vector2 v2) {
            return Mathf.Atan2(v2.y - v1.y, v2.x - v1.x) * Mathf.Rad2Deg;
        }

        public static Quaternion RotationBetween2D(Vector2 v1, Vector2 v2) {
            return Quaternion.Euler(0f, 0f, AngleBetween2D(v1, v2));
        }

    }

}