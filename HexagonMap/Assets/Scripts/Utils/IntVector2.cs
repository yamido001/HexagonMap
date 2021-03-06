﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct IntVector2{

	public static IntVector2 Zero = new IntVector2(0, 0);

	public int x;
	public int y;

	public IntVector2(int x, int y)
	{
		this.x = x;
		this.y = y;
	}

	public int SqrMagnitude()
	{
		return x * x + y * y;
	}

	public static bool operator == (IntVector2 lhs, IntVector2 rhs)
	{
		return lhs.x == rhs.x && lhs.y == rhs.y;
	}

	public static bool operator != (IntVector2 lhs, IntVector2 rhs)
	{
		return lhs.x != rhs.x || lhs.y != rhs.y;
	}

	public override bool Equals (object obj)
	{
		if (!(obj is IntVector2))
			return 	false;
		IntVector2 other = (IntVector2)obj;
		return this == other;
	}

	public static IntVector2 operator / (IntVector2 lhs, IntVector2 rhs)
	{
		IntVector2 ret = lhs;
		ret.x = lhs.x / rhs.x;
		ret.y = lhs.y / rhs.y;
		return ret;
	}

	public static IntVector2 operator * (IntVector2 lhs, IntVector2 rhs)
	{
		IntVector2 ret = lhs;
		ret.x *= rhs.x;
		ret.y *= rhs.y;
		return ret;
	}

	public static IntVector2 operator - (IntVector2 lhs, IntVector2 rhs)
	{
		IntVector2 ret = lhs;
		ret.x -= rhs.x;
		ret.y -= rhs.y;
		return ret;
	}

	public override int GetHashCode ()
	{
		return (x << 16) | y;
	}

	public override string ToString ()
	{
		return string.Format ("[{0:D}, {1:D}]", x, y);
	}
}
