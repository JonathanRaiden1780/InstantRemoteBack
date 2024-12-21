﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantRemote.Core.Helpers
{
    public static class Utils
    {
        public const string PasswordChangeTemplate = @" <!DOCTYPE html> <html lang='en'> <head> <meta charset='UTF-8'> <meta name='viewport' content='width=device-width, initial-scale=1.0'> <style> body { font-family: Arial, sans-serif; background-color: #f9f9f9; color: #333333; margin: 0; padding: 0; } .container { max-width: 600px; margin: 20px auto; background: #ffffff; padding: 20px; border-radius: 8px; box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1); } .logo { text-align: left; margin-bottom: 20px; } .divider { border: none; border-top: 2px solid #cccccc; margin: 20px 0; } .title { font-weight: bold; font-size: 18px; margin-bottom: 10px; } .content { font-size: 14px; line-height: 1.6; } .code { display: inline-block; font-weight: bold; font-size: 24px; color: #333333; background: #f2f2f2; padding: 10px 20px; border-radius: 5px; letter-spacing: 5px; margin: 10px 0; } .footer { margin-top: 20px; font-size: 12px; color: #777777; } </style> </head> <body> <div class='container'> <div class='logo'> <img src='https://i.ibb.co/q7xKb13/Group-11405.png' alt='Instant Remote Logo' width='60' style='height: auto;'> </div> <hr class='divider'> <div class='content'> <p class='title'>Tu código de seguridad de Instant Remote</p> <p>Hola, {userName}:</p> <p>Tu código de seguridad es:</p> <div class='code'>{nip}</div> <p>Para ayudarnos a confirmar tu identidad en Instant Remote, debemos verificar tu dirección de correo electrónico. Pega este código en tu navegador.</p> <p><strong>Solo lo podrás usar una vez.</strong></p> <p>Si tú no pediste ningún cambio a tu contraseña, solo ignora este mensaje.</p> <p>El enlace solo es válido dentro de los próximos 30 minutos.</p> <p>Gracias,<br>El equipo de seguridad de Instant Remote.</p> </div> </div> </body> </html>";
    }
}
