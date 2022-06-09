using Bedirhan_Hafta_2.Attributes;
using Bedirhan_Hafta_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bedirhan_Hafta_2.Validations
{
    static public class CustomerValidation
    {

        //Tablomuzu oluştururken attributlerde istenmiş gerekli ön koşulların kontrolünü yapıyoruz.
        static public string TableValidation(Customer customer)
        {
            Type TableType = typeof(Customer);
            var TablAttr = customer.GetType().GetCustomAttribute<TableAttribute>();
            //var TablAttr = TableType.GetCustomAttribute<TableAttribute>();//Tablomuzun yaratıldığı class'ın üstündeki attribute'ü cekiyoruz.
            string result = "Tablo Adı : ";
            if (!Regex.IsMatch(TablAttr.TableName, "^[a-zA-Z0-9]*$"))//tablonun isminde sadece ingilizce alfabe olmasını kontrol ediyoruz.
            {
                return "Tablo adı sadece ingiliz alfabesinden oluşmalıdır.";
            }
            result = result + TablAttr.TableName + " --- Kolonlar:";
            PropertyInfo[] PropertyInfos = TableType.GetProperties();
            List<ColumnAttribute> ColumnAttr = new List<ColumnAttribute>();
            foreach (PropertyInfo propertyInfos in PropertyInfos)//Class'daki field'ları Listeye ekliyoruz.
            {
                ColumnAttr.Add(propertyInfos.GetCustomAttribute<ColumnAttribute>());
            }
            List<string> features = new();
            foreach (var c in ColumnAttr)
            {
                string[] liste = c.Features.Split(',');
                if (liste[2] == "") liste[2] = "Zorunlu Değil";
                result = result + "Name: " + liste[0] + " | " + "Type: " + liste[1] + " | {" + liste[2] + "} // ";
            }
            return result;
        }


    }
}
