using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace project.Models
{
    public class Lab1Data
    {
	public Guid Id { get; set; } = Guid.Empty;
        public string Name { get; set; } // марка смартфона
        public double Price { get; set; } // цена
        public bool Sim { get; set; } // поддержка двух сим-карт
        public int Capacity { get; set; } // емкость аккумулятора
        public string OS { get; set; } // операционная система
   public BaseModelValidationResult Validate()
       {
          var validationResult = new BaseModelValidationResult();
           if (string.IsNullOrWhiteSpace(Name)) validationResult.Append($"Name cannot be empty");
           if (string.IsNullOrWhiteSpace(OS)) validationResult.Append($"Operating System cannot be empty");
           if (!(Sim == true || Sim == false)) validationResult.Append($"Sim {Sim} must be 1 or 0");
        if (!(Price > 0)) validationResult.Append($"Price {Price} must be higher than 0");
        if (!(Capacity > 0)) validationResult.Append($"Capacity {Capacity} must be higher than 0");
           return validationResult;
       }
       public override string ToString()
       {
           return $"Name: {Name}; Price: {Price}; Sim: {Sim}; Capacity: {Capacity}; OS:{OS}";
       }
   }
}