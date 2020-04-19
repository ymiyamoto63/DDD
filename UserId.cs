using System;

public class UserId {
  public UserId(string value) {
    if (value == null)
      throw new ArgumentNullException(nameof(value));

    Value = value;
  }

  public string Value {get;}

  public override string ToString() {
    return Value;
  }
}