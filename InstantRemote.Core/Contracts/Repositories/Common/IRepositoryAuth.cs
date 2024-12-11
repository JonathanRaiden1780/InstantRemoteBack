﻿using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Core.Contracts.Repositories.Common
{
    public interface IRepositoryAuth
    {
        PermisosResponseDto Login(SingInReqDto signIn);
        // RoleCode AutenticarUsuario(AuthenticationDto auth);
        // User GetById(int userId);
        // User GetUserByNickNamePassword(string nickname, string password);
        // int Registration(User user);
        // bool ValidateToken(TokenDto token, string seed);
        // string GetLogToken(TokenDto token);
        // void RegisterLogToken(TokenDto token);
        // string ActivationMail(string exid);
        // string ForgotPassword(EmailDto forgot);
        // string UpdatePassword(UpdatePasswordDto recuperar);
        // string ChangePassword(ChangePasswordDto cambio, string exid);

    }
}
