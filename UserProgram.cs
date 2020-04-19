using System;

class UserProgram {
  private IUserRepository userRepository;

  public UserProgram(IUserRepository userRepository) {
    this.userRepository = userRepository;
  }

  public void CreateUser(string userId, string userName) {
    var user = new User(new UserId(userId), new UserName(userName));

    var userService = new UserService(userRepository);
    if (userService.Exists(user)) {
      throw new Exception($"{userName}は既に存在しています");
    }

    userRepository.Save(user);
  }

  
}