﻿namespace NeoServer.Game.Common.Results;

public readonly ref struct Result
{
    public Result(InvalidOperation error)
    {
        Error = error;
    }

    public InvalidOperation Error { get; }
    public bool Succeeded => Error == InvalidOperation.None;
    public bool Failed => !Succeeded;
    public static Result Success => new(InvalidOperation.None);
    public static Result NotPossible => new(InvalidOperation.NotPossible);

    public static Result Fail(InvalidOperation invalidOperation)
    {
        return new Result(invalidOperation);
    }
}

public readonly struct Result<T>
{
    public Result(T result, InvalidOperation error = InvalidOperation.None)
    {
        Value = result;
        Error = error;
    }

    public Result(InvalidOperation error)
    {
        Value = default;
        Error = error;
    }

    public Result ResultValue => new(Error);

    public T Value { get; }
    public InvalidOperation Error { get; }
    public bool Succeeded => Error is InvalidOperation.None;
    public bool Failed => Error is not InvalidOperation.None;

    public static Result<T> Success => new(InvalidOperation.None);
    
    public static Result<T> Ok(T value) => new(value);


    public static Result<T> NotPossible => new(InvalidOperation.NotPossible);

    public static Result<T> Fail(InvalidOperation invalidOperation)
    {
        return new Result<T>(invalidOperation);
    }
}