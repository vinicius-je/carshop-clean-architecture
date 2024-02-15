using CarShop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Domain.Entities
{
    public class Car
    {
        [Key]
        public int CarId {  get; set; }
        [Required(ErrorMessage = "Informe o link da imagem")]
        public string ImageLink { get; set; }
        [Required(ErrorMessage = "Informe o nome do veículo")]
        [MinLength(3, ErrorMessage = "O nome do veículo deve ter pelo menos 3 caracteres")]
        [MaxLength(120, ErrorMessage = "O nome do veículo deve ter no máximo 50 caracteres")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Informe o preço do veículo")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [EnumDataType(typeof(Category), ErrorMessage = "Selecione a categoria do veículo")]
        public Category Category { get; set; }
        [Required]
        [EnumDataType(typeof(Brand), ErrorMessage = "Selecione a marca do veículo")]
        public Brand Brand { get; set; }

        public Car(int carId, string imageLink, string name, decimal price, Category category, Brand brand)
        {
            CarId = carId;
            ImageLink = imageLink;
            Name = name;
            Price = price;
            Category = category;
            Brand = brand;
        }
    }
}
