using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer Gamer)
        {
            if (_userValidationService.Validate(Gamer)==true)
            {
                Console.WriteLine("Doğrulama Başarılı, Oyuncu Eklendi");
            }
            else
            {
                Console.WriteLine("Doğrulama Yapılamadığından, Kayıt Başarısız oldu");
            }
           
        }

        public void Delete(Gamer Gamer)
        {
            Console.WriteLine("Oyuncu Silindi");
        }

        public void Update(Gamer Gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi");
        }
    }
}
