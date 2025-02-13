﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantRemote.Core.Helpers
{
    public static class Utils
    {
        public const string PasswordChangeTemplate = @" <!DOCTYPE html> <html lang='en'> <head> <meta charset='UTF-8'> <meta name='viewport' content='width=device-width, initial-scale=1.0'> <style> body { font-family: Arial, sans-serif; background-color: #f9f9f9; color: #333333; margin: 0; padding: 0; } .container { max-width: 600px; margin: 20px auto; background: #ffffff; padding: 20px; border-radius: 8px; box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1); } .logo { text-align: left; margin-bottom: 20px; } .divider { border: none; border-top: 2px solid #cccccc; margin: 20px 0; } .title { font-weight: bold; font-size: 18px; margin-bottom: 10px; } .content { font-size: 14px; line-height: 1.6; } .code { display: inline-block; font-weight: bold; font-size: 24px; color: #333333; background: #f2f2f2; padding: 10px 20px; border-radius: 5px; letter-spacing: 5px; margin: 10px 0; } .footer { margin-top: 20px; font-size: 12px; color: #777777; } </style> </head> <body> <div class='container'> <div class='logo'> <img src='https://i.ibb.co/dwDcc8bq/Group-11405-1.png' alt='Instant Remote Logo' width='60' style='height: auto;'> </div> <hr class='divider'> <div class='content'> <p class='title'>Tu código de seguridad de Instant Remote</p> <p>Hola, {userName}:</p> <p>Tu código de seguridad es:</p> <div class='code'>{nip}</div> <p>Para ayudarnos a confirmar tu identidad en Instant Remote, debemos verificar tu dirección de correo electrónico. Pega este código en tu navegador.</p> <p><strong>Solo lo podrás usar una vez.</strong></p> <p>Si tú no pediste ningún cambio a tu contraseña, solo ignora este mensaje.</p> <p>El enlace solo es válido dentro de los próximos 30 minutos.</p> <p>Gracias,<br>El equipo de seguridad de Instant Remote.</p> </div> </div> </body> </html>";
        public const string PasswordSendTemplate = @"  <!DOCTYPE html> <html lang='en'> <head> <meta charset='UTF-8'> <meta name='viewport' content='width=device-width, initial-scale=1.0'> <style> body { font-family: Arial, sans-serif; background-color: #f9f9f9; color: #333333; margin: 0; padding: 0; } .container { max-width: 600px; margin: 20px auto; background: #ffffff; padding: 20px; border-radius: 8px; box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1); } .logo { text-align: left; margin-bottom: 20px; } .divider { border: none; border-top: 2px solid #cccccc; margin: 20px 0; } .title { font-weight: bold; font-size: 18px; margin-bottom: 10px; } .content { font-size: 14px; line-height: 1.6; } .code { display: inline-block; font-weight: bold; font-size: 24px; color: #333333; background: #f2f2f2; padding: 10px 20px; border-radius: 5px; letter-spacing: 5px; margin: 10px 0; } .footer { margin-top: 20px; font-size: 12px; color: #777777; } </style> </head> <body> <div class='container'> <div class='logo'> <img src='https://i.ibb.co/dwDcc8bq/Group-11405-1.png' alt='Instant Remote Logo' width='60' style='height: auto;'> </div> <hr class='divider'> <div class='content'> <p class='title'>Se ha cambiado tu contraseña</p> <p>Hola, {userName}:</p> <p>Se ha cambiado tu contraseña recientemente.<br>Esta es tu nueva contraseña: </p> <div class='code'>{pass}</div> <p>Si tu no solicitaste ningún cambio a tu contraseña, favor de contactar al administrador.</p><p>Por seguridad el sistema solicita el cambio de tu contraseña cada 6 meses.</p><p>Gracias,<br>El equipo de seguridad de Instant Remote.</p> </div> </div> </body> </html>";
    }
    public static class DataTableExtensions
    {
        public static DataTable ToDataTable<T>(this List<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                table.Rows.Add(row);
            }

            return table;
        }
    }
}


