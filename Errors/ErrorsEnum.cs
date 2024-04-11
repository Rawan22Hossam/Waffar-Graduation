namespace Waffar.Errors
{
    public enum ErrorsEnum
    {
       Success = 0,
        Error = 1,
        InvalidUsernameOrPassword = 2,
        UserAllReadyRegistered = 3,
        UserRoleDoesnotExist = 4,
        UserRoleAlreadyExist = 5,
        ApiKeyFoeChatGptIsMissing = 6,
        ChatGptServiceIsUnavailable = 7,
        AnswerIsNull = 8,
        NoMatchingQuestion = 9
    }
}
