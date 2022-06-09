using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bedirhan_Hafta_2.Extensions;
using Bedirhan_Hafta_2.Validations;
using Bedirhan_Hafta_2.Model;
using Bedirhan_Hafta_2.Interfaces;
using Bedirhan_Hafta_2.Work;

namespace Bedirhan_Hafta_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// Query'den gelen Datetime nesnesini karşılayan ve "2 gün 3 saat 4 dakika önce" tarzında string olarak geri döndüren endpoint
        /// Datetime şu düzende gönderilmeli ==>  2022-05-26T12:55:47.973Z
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        [HttpGet("Extension")]
        public string CalculateTimes([FromQuery] DateTime dateTime)//  
        {
            return dateTime.Ago();
        }
        /// <summary>
        /// Customer Class'ından örnek bir veritabanı tablosu oluşturulsa, oluşacak özelliklerin cıktısını almak için yaptığımız endpoint
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        [HttpGet("Attribute")]
        public string CreateTable([FromQuery] int x)
        {
            Customer customer = new()
            {
                Id = x,
                Name = "aaaa",
                Surname = "bbbb",
                Adress = "cccc"
            };
            return CustomerValidation.TableValidation(customer);
        }
        [HttpGet("Solid")]
        public string deneme([FromServices] IAnimal animal)//  Dependency injection ile alacağımız nesneyi servis konteynırından çekerek bağlılığımızı kontrol altına alıyoruz.
        {

            return ((Parrot)animal).Fly();//Animal nesnesi ile çekilen referansı Parrot olarak cast edip Parrot'a has özellikleri kullanmayı sağlıyoruz.
        }
    }
}
