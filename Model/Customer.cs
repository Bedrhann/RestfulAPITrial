using Bedirhan_Hafta_2.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bedirhan_Hafta_2.Model
{

    //Yaratılacak tablomuzun adını ver değerlenirinin bilgilerinin burada attribute'ler sayesinde saglıyoruz.
    [Table("Müsteri")]//'ü' türkçe karakteri oldugu için hata verilecek.
    public class Customer
    {
        [Column("Id,int,zorunlu")]
        public int Id { get; set; }

        [Column("Name,string,zorunlu")]
        public string Name { get; set; }

        [Column("Surname,string,zorunlu")]
        public string Surname { get; set; }

        [Column("Adress,string,")]
        public string Adress { get; set; }

    }
}
