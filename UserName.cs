using System;

public class UserName{
   public UserName(string value) {
    if (value == null)
      throw new ArgumentNullException(nameof(value));
    if (value.Length < 3)
      throw new ArgumentException("ユーザー名は3文字以上です", nameof(value));

    Value = value;
  }

  public string Value {get;}

  public override string ToString() {
    return Value;
  }

}