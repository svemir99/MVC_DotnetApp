using System;
using System.ComponentModel.DataAnnotations;
namespace FirstMvcApp.Models
{
    public class DateRangeAttribute : ValidationAttribute
    {

        public string From { get; set; }

        public string To { get; set; }


        public override bool IsValid(object value)
       
        {
            if (value == null)
                return false;


            DateTime from = DateTime.Parse(From);

            DateTime to = DateTime.Parse(To);


                DateTime dateVaule = (DateTime)value;


            if (dateVaule > from && dateVaule <= to)

            {
                return true;
            }
            else
            {
                return false;


            }
        }
    }
}
