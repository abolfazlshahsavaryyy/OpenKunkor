﻿using namespace OpenKunkor.Domain.ValueObject.Common;
public sealed class ViewCount
{
    public int Value { get; private set; }

    private ViewCount(int value)
    {
        if (value < 0) throw new ArgumentException("View count cannot be negative.");
        Value = value;
    }

    public static ViewCount Of(int value) => new ViewCount(value);
    

    public void Increase(int amount)
    {
        this.Value += amount;
    }

    public override bool Equals(object? obj) =>
        obj is ViewCount other && Value == other.Value;

    public override int GetHashCode() => Value.GetHashCode();
}
