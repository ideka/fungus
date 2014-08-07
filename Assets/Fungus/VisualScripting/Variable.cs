﻿using UnityEngine;
using System;
using System.Collections;

namespace Fungus.Script
{
	[Serializable]
	public class VariableData
	{
	}

	[Serializable]
	public class BooleanData : VariableData
	{
		public bool value;
	}
	
	[Serializable]
	public class IntegerData : VariableData
	{
		public int value;
	}

	[Serializable]
	public class FloatData : VariableData
	{
		public float value;
	}

	[Serializable]
	public class StringData : VariableData
	{
		public string value;
	}
}