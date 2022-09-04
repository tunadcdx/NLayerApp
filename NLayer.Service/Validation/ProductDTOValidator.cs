using FluentValidation;
using NLayer.Core.DTOs;

namespace NLayer.Service.Validation
{
    public class ProductDTOValidator : AbstractValidator<ProductDTO>
    {
        public ProductDTOValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("İsim boş geçilemez.").NotEmpty().WithMessage("{PropertyName} is cannot be empty");
            RuleFor(x => x.Price).InclusiveBetween(1, int.MaxValue).WithMessage("Fiyat 0'dan büyük olmalı.");
            RuleFor(x => x.Stock).InclusiveBetween(1, int.MaxValue).WithMessage("Stok 0'dan büyük olmalı.");
            RuleFor(x => x.Image).NotNull().WithMessage("Resim boş geçilemez.").NotEmpty().WithMessage("{PropertyName} boş geçilemez.");
    


        }
    }
}
