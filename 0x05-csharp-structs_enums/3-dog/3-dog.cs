﻿using System;
public enum Rating
{
    Good,
    Great,
    Excellent
}

public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string nam, float ag, string owne, Rating ratin)
    {
        name = nam;
        age = ag;
        owner = owne;
        rating = ratin;
    }

    public override string ToString()
    {
        return $"Dog Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}";
    }
}
