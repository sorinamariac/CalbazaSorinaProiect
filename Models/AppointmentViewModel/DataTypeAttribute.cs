using System;
using System.ComponentModel.DataAnnotations;

namespace CalbazaSorinaProiect.Models.AppointmentViewModel
{
    internal class DataTypeAttribute : Attribute
    {
        public DataTypeAttribute(DataType date)
        {
            Date = date;
        }

        public DataType Date { get; }
    }
}